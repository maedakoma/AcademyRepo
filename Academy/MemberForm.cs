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
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }
        public void Populate(Member member)
        {
            txtFirstname.Text = member.Firstname;
            txtLastname.Text = member.Lastname;
            txtBelt.Text = member.Belt;
            foreach (Payment pay in member.Payments)
            {
                lstPayments.Items.Add(pay.Amount);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
