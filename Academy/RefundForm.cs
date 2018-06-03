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
    public partial class RefundForm : Form
    {
        AcademyMgr.AcademyMgr AcademyMgr;
        MainForm mainform;
        Refund currentRefund;
        int rowIndex;
        public RefundForm(MainForm parentForm, AcademyMgr.AcademyMgr manager)
        {
            InitializeComponent();
            AcademyMgr = manager;
            currentRefund = new Refund();
            mainform = parentForm;
        }
        public void Populate(Refund refund, int index)
        {
            //this.Text = refund.Name;
            rowIndex = index;
            currentRefund = refund;
            txtLabel.Text = refund.Label;
            txtAmount.Text = refund.Amount.ToString();
            txtComment.Text = refund.Comment;
            if (refund.Date != DateTime.MinValue)
            {
                date.Value = refund.Date;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            currentRefund.Label = txtLabel.Text;
            currentRefund.Amount = Convert.ToDecimal(txtAmount.Text);
            currentRefund.Comment = txtComment.Text;
            currentRefund.Date = date.Value;
            if (currentRefund.ID == 0)
            {
                AcademyMgr.InsertRefund(currentRefund);
            }
            else
            {
                AcademyMgr.UpdateRefund(currentRefund);
            }
            this.Close();
        }

        private void MemberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.FillRefundsGrid(rowIndex);
        }
    }
}
