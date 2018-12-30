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
    public partial class MemberForm : Form
    {
        AcademyMgr.AcademyMgr AcademyMgr;
        MainForm mainform;
        Member currentMember;
        int rowIndex;
        public MemberForm(MainForm parentForm, AcademyMgr.AcademyMgr manager)
        {
            InitializeComponent();
            AcademyMgr = manager;
            currentMember = new Member();
            mainform = parentForm;
            cbBelt.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
            chkActive.Checked = true;
            dateEnd.Value = DateTime.Now.AddYears(1);
            List<Plan> plansAbo = AcademyMgr.getPlans(Plan.typeEnum.Abonnement);
            cbPlanAbo.Items.Add("");
            cbPlanAbo.Items.AddRange(plansAbo.ToArray());
            cbPlanAbo.DisplayMember = "Label";
            List<Plan> plansPrivate = AcademyMgr.getPlans(Plan.typeEnum.Private);
            cbPlanPrivate.Items.Add("");
            cbPlanPrivate.Items.AddRange(plansPrivate.ToArray());
            cbPlanPrivate.DisplayMember = "Label";
        }
        public void Populate(Member member, int index)
        {
            this.Text = member.Firstname + " " + member.Lastname;
            rowIndex = index;
            currentMember = member;
            txtFirstname.Text = member.Firstname;
            txtLastname.Text = member.Lastname;
            cbBelt.Text = member.Belt.ToString();
            txtStripe.Text = member.Stripe.ToString();
            cbGender.Text = member.Gender.ToString();
            chkChild.Checked = member.Child;
            chkAlert.Checked = member.Alert;
            chkFullYear.Checked = member.FullYear;
            chkCompetitor.Checked = member.Competitor;
            if (member.AboPlan != null)
            {
                cbPlanAbo.SelectedIndex = cbPlanAbo.FindStringExact(member.AboPlan.Label);
            }
            if (member.PrivatePlan != null)
            {
                cbPlanPrivate.SelectedIndex = cbPlanPrivate.FindStringExact(member.PrivatePlan.Label);
            }
            chkCoach.Checked = member.Coach;
            chkActive.Checked = member.Active;
            txtComment.Text = member.Comment;
            txtJob.Text = member.Job;
            txtMail.Text = member.Mail;
            txtPhone.Text = member.Phone;
            txtAddress.Text = member.Address;
            txtFacebook.Text = member.Facebook;
            if (member.Enddate != DateTime.MinValue)
            {
                dateEnd.Value = member.Enddate;
            }
            PopulatePayments(member);
        }
        public void PopulatePayments(Member member)
        {
            //Create a New DataTable to store the Data
            DataTable Payments = new DataTable("Payments");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("Amount");
            DataColumn c2 = new DataColumn("Type");
            DataColumn c3 = new DataColumn("Name");
            DataColumn c4 = new DataColumn("Debt");
            DataColumn c5 = new DataColumn("ReceptionDate");
            DataColumn c6 = new DataColumn("Bank");
            DataColumn c7 = new DataColumn("BankDate");

            //Add the Created Columns to the Datatable
            Payments.Columns.Add(c0);
            Payments.Columns.Add(c1);
            Payments.Columns.Add(c2);
            Payments.Columns.Add(c3);
            Payments.Columns.Add(c4);
            Payments.Columns.Add(c5);
            Payments.Columns.Add(c6);
            Payments.Columns.Add(c7);

            foreach (Payment pay in member.Payments)
            {
                DataRow row = Payments.NewRow();
                row["ID"] = pay.ID;
                row["Amount"] = pay.Amount;
                row["Type"] = pay.Type.ToString();
                row["Name"] = pay.Name;
                row["Debt"] = pay.Debt;
                row["ReceptionDate"] = pay.ReceptionDate;
                row["Bank"] = pay.Bank.ToString();
                row["BankDate"] = pay.DepotDate;
                Payments.Rows.Add(row);
            }
            payGrid.DataSource = Payments;
            payGrid.Columns[0].Visible = false;
            payGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            payGrid.RowHeadersVisible = false;
            payGrid.AllowUserToAddRows = false;
            payGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            payGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            payGrid.ReadOnly = true;
        }

        private void payGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int currentPaymentD = Convert.ToInt32(payGrid.Rows[e.RowIndex].Cells[0].Value);
            Payment payment = currentMember.Payments.Where(x => x.ID == currentPaymentD).ToList<Payment>()[0];
            PaymentForm pf = new PaymentForm(this, currentMember, payment);
            pf.Show();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            PaymentForm payform = new PaymentForm(this, currentMember);
            payform.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int currentPaymentID = Convert.ToInt32(payGrid.SelectedRows[0].Cells[0].Value);
            if (currentPaymentID != 0)
            {
                Payment pay = currentMember.Payments.Where(x => x.ID == currentPaymentID).ToList<Payment>()[0];
                currentMember.Payments.Remove(pay);
                PopulatePayments(currentMember);
            }
            else
            {
                payGrid.Rows.Remove(payGrid.SelectedRows[0]);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            currentMember.Firstname = txtFirstname.Text;
            currentMember.Lastname = txtLastname.Text;
            currentMember.Belt = (Member.beltEnum)Enum.Parse(typeof(Member.beltEnum), cbBelt.Text, true);
            currentMember.Stripe = Convert.ToByte(txtStripe.Text);
            currentMember.Gender = (Member.genderEnum)Enum.Parse(typeof(Member.genderEnum), cbGender.Text, true);
            currentMember.Child = chkChild.Checked;
            currentMember.Active = chkActive.Checked;
            currentMember.Alert = chkAlert.Checked;
            currentMember.FullYear = chkFullYear.Checked;
            currentMember.Competitor = chkCompetitor.Checked;
            currentMember.Coach = chkCoach.Checked;
            if (cbPlanAbo.SelectedItem == null || cbPlanAbo.SelectedItem.ToString() == string.Empty)
            {
                currentMember.AboPlan = null;
            }
            else
            {
                currentMember.AboPlan = (Plan)cbPlanAbo.SelectedItem;
            }
            if (cbPlanPrivate.SelectedItem == null ||  cbPlanPrivate.SelectedItem.ToString() == string.Empty)
            {
                currentMember.PrivatePlan = null;
            }
            else
            {
                currentMember.PrivatePlan = (Plan)cbPlanPrivate.SelectedItem;
            }
            currentMember.Comment = txtComment.Text;
            currentMember.Job = txtJob.Text;
            currentMember.Mail = txtMail.Text;
            currentMember.Phone = txtPhone.Text;
            currentMember.Address = txtAddress.Text;
            currentMember.Facebook = txtFacebook.Text;
            currentMember.Enddate = dateEnd.Value;
            if (currentMember.ID == 0)
            {
                AcademyMgr.InsertMember(currentMember);
            }
            else
            {
                AcademyMgr.UpdateMember(currentMember);
            }
            this.Close();
        }

        private void MemberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.FillMembersGrid(rowIndex);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtFacebook.Text);
        }

        private void payGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in payGrid.Rows)
            {
                string sBank = Convert.ToString(row.Cells[6].Value);
                string sType = Convert.ToString(row.Cells[2].Value);
                if (sType != "Check" || sBank != "None")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

    }
}
