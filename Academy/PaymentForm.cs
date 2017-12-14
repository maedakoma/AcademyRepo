using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AcademyMgr;


namespace Academy
{
    public partial class PaymentForm : Form
    {
        Member parentMember;
        MemberForm parentForm;
        Payment currentPayment;
        public PaymentForm(MemberForm form, Member member, Payment payment = null)
        {
            InitializeComponent();
            parentMember = member;
            parentForm = form;
            if (payment != null)
            {
                currentPayment = payment;
                txtName.Text = payment.Name;
                txtAmount.Text = payment.Amount.ToString();
                txtDebt.Text = payment.Debt.ToString();
                cbType.Text = payment.Type.ToString();
                cbBank.Text = payment.Bank.ToString();
                if (payment.ReceptionDate != DateTime.MinValue)
                {
                    dateTimePickerReception.Value = payment.ReceptionDate;
                }
                if (payment.DepotDate != DateTime.MinValue)
                {
                    DateTimePickerBank.Value = payment.DepotDate;
                }
            }
            else
            {
                currentPayment = new Payment();
                txtName.Text = form.txtFirstname.Text + " " + form.txtLastname.Text;
                cbType.SelectedIndex = 0;
                cbBank.SelectedIndex = 0;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            currentPayment.Amount = Convert.ToInt32(txtAmount.Text);
            currentPayment.Debt = Convert.ToInt32(Convert.ToDouble(txtDebt.Text));
            currentPayment.Name = txtName.Text;
            currentPayment.Type = cbType.Text;
            currentPayment.ReceptionDate = dateTimePickerReception.Value;
            currentPayment.Bank = (Payment.bankEnum)Enum.Parse(typeof(Payment.bankEnum), cbBank.Text, true);  ;
            currentPayment.DepotDate = DateTimePickerBank.Value;
            if (currentPayment.ID == 0)
            {
                parentMember.Payments.Add(currentPayment);
            }
            parentForm.PopulatePayments(parentMember);
            this.Close();
        }

        private void txtAmount_TextValidated(object sender, EventArgs e)
        {
            int result;
            if (currentPayment.ID == 0)
            {
                if (int.TryParse(txtAmount.Text, out result) && cbType.SelectedIndex != 1)
                {
                    txtDebt.Text = (0.6 * result).ToString();
                }
                else
                {
                    txtDebt.Text = "0";
                }
            }
        }
    }
}
