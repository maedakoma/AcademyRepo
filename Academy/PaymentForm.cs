using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademyMgr;


namespace Academy
{
    public partial class PaymentForm : Form
    {
        Member parentMember;
        MemberForm parentForm;
        public PaymentForm(MemberForm form, Member member)
        {
            InitializeComponent();
            parentMember = member;
            parentForm = form;
            txtName.Text = form.txtFirstname.Text + " " + form.txtLastname.Text;
            cbType.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Amount = Convert.ToInt32(txtAmount.Text);
            pay.Debt = Convert.ToInt32(Convert.ToDouble(txtDebt.Text));
            pay.Name = txtName.Text;
            pay.Type = cbType.Text;
            parentMember.Payments.Add(pay);
            parentForm.PopulatePayments(parentMember);
            this.Close();
        }

        private void txtAmount_TextValidated(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(txtAmount.Text, out result) && cbType.SelectedIndex!= 1)
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
