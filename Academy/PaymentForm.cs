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
            parentMember = member;
            parentForm = form;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Amount = Convert.ToInt32(txtAmount.Text);
            pay.Debt = Convert.ToInt32(txtDebt.Text);
            pay.Name = txtName.Text;
            pay.Type = txtType.Text;
            parentMember.Payments.Add(pay);
            parentForm.Populate(parentMember);
            this.Close();
        }

        private void txtAmount_TextValidated(object sender, EventArgs e)
        {
            txtDebt.Text = (0.6 * Convert.ToInt32(txtAmount.Text)).ToString();
        }
    }
}
