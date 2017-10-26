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
        }
        public void Populate(Member member, int index)
        {
            rowIndex = index;
            currentMember = member;
            txtFirstname.Text = member.Firstname;
            txtLastname.Text = member.Lastname;
            cbBelt.Text = member.Belt.ToString();
            cbGender.Text = member.Gender.ToString();
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
            DataColumn c6 = new DataColumn("InBank");
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
                row["Type"] = pay.Type;
                row["Name"] = pay.Name;
                row["Debt"] = pay.Debt;
                row["ReceptionDate"] = pay.ReceptionDate;
                row["InBank"] = pay.depotBank;
                row["BankDate"] = pay.DepotDate;
                Payments.Rows.Add(row);
            }
            payGrid.DataSource = Payments;
            payGrid.Columns[0].Visible = false;
            payGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            payGrid.RowHeadersVisible = false;
            payGrid.AllowUserToAddRows = false;
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
            currentMember.Gender = (Member.genderEnum)Enum.Parse(typeof(Member.genderEnum), cbGender.Text, true);
            if (currentMember.ID == 0)
            {
                AcademyMgr.InsertMember(currentMember);
            }
            else
            {
                AcademyMgr.UpdateMember(currentMember);
            }
            mainform.FillMembersGrid(rowIndex);
            this.Close();
        }

        
    }
}
