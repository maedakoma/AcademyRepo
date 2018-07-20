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
                cbType.SelectedItem = "Check";
                cbBank.SelectedIndex = 0;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            currentPayment.Amount = Convert.ToDecimal(txtAmount.Text);
            currentPayment.Debt = Convert.ToDecimal(Convert.ToDouble(txtDebt.Text));
            currentPayment.Name = txtName.Text;
            currentPayment.Type = (Payment.typeEnum)Enum.Parse(typeof(Payment.typeEnum), cbType.Text, true);
            currentPayment.ReceptionDate = dateTimePickerReception.Value;
            currentPayment.Bank = (Payment.bankEnum)Enum.Parse(typeof(Payment.bankEnum), cbBank.Text, true);
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
                if (int.TryParse(txtAmount.Text, out result) && cbType.SelectedItem.ToString() != "Cash" )
                {
                    txtDebt.Text = (AcademyMgr.AcademyMgr.CoefDebt * result).ToString();
                }
                else
                {
                    txtDebt.Text = "0";
                }
            }
        }

        private void cbBank_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTimePickerBank.Value = DateTime.Now;
        }
    }
}
