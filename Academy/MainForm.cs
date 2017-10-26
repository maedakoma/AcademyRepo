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
    public partial class MainForm : Form
    {
        List<AcademyMgr.Member> members;
        AcademyMgr.AcademyMgr manager;
        public MainForm()
        {
            InitializeComponent();
            MainForm_Load();
        }

        private void MainForm_Load()
        {
            manager = new AcademyMgr.AcademyMgr();
            manager.Open();
            FillMembersGrid();
            FillSeminarsGrid();
            FillRefundsGrid();
        }
            
        public void FillMembersGrid(int rowIndex = 0)
        {
            AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            manager.Open();
            List<Refund> refunds = manager.getRefunds();
            int TotalRefund = 0;
            foreach(Refund refund in refunds)
            {
                TotalRefund = TotalRefund + refund.Amount;
            }
            
            members = manager.getMembers();
            //Create a New DataTable to store the Data
            DataTable People = new DataTable("People");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("lastname");
            DataColumn c2 = new DataColumn("firstname");
            DataColumn c3 = new DataColumn("belt");
            DataColumn c4 = new DataColumn("gender");
            DataColumn c5 = new DataColumn("amount");
            DataColumn c6 = new DataColumn("debt");


            //Add the Created Columns to the Datatable
            People.Columns.Add(c0);
            People.Columns.Add(c1);
            People.Columns.Add(c2);
            People.Columns.Add(c3);
            People.Columns.Add(c4);
            People.Columns.Add(c5);
            People.Columns.Add(c6);

            foreach (Member mem in members)
            {
                DataRow row = People.NewRow();
                row["ID"] = mem.ID;
                row["lastname"] = mem.Lastname;
                row["firstname"] = mem.Firstname;
                row["belt"] = mem.Belt;
                row["gender"] = mem.Gender;
                int amount = 0;
                int debt = 0;
                foreach (Payment pay in mem.Payments)
                {
                    amount = amount  + pay.Amount;
                    debt = debt + pay.Debt;
                }
                row["amount"] = amount;
                row["debt"] = debt;
                People.Rows.Add(row);
            }
            mainGrid.DataSource = People;
            mainGrid.Columns[0].Visible = false;
            mainGrid.RowHeadersVisible = false;
            mainGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainGrid.AllowUserToAddRows = false;
            mainGrid.ReadOnly = true;
            if (rowIndex != 0)
            {
                mainGrid.CurrentCell = mainGrid.Rows[rowIndex].Cells[1];
                mainGrid.Rows[rowIndex].Selected = true;
            }
            lblMembers.Text = People.Rows.Count.ToString() + " members";
            int totalAmount = mainGrid.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[5].Value));
            lblTotal.Text = "Licences: " + totalAmount.ToString() + " E";
            int totalDebt = mainGrid.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[6].Value));
            lblTotalDebt.Text = "Dettes: " + totalDebt.ToString() + " E";
            int total = totalAmount - totalDebt;
            lblBenef.Text = "Benefices Licences: " + total.ToString() + " E";
            lblPaidDebt.Text = "Dette payée: " + TotalRefund.ToString() + " E";
            lblStillDebt.Text = "Dette restante: " + (totalDebt - TotalRefund).ToString() + " E";
        }

        public void FillSeminarsGrid(int rowIndex = 0)
        {
            AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            manager.Open();
            List<Seminar> seminars = manager.getSeminars();
            //Create a New DataTable to store the Data
            DataTable Seminar = new DataTable("Seminar");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("theme");
            DataColumn c2 = new DataColumn("date");
            DataColumn c3 = new DataColumn("webmembers");
            DataColumn c4 = new DataColumn("localmembers");
            DataColumn c5 = new DataColumn("amount");
            DataColumn c6 = new DataColumn("debt");
            DataColumn c7 = new DataColumn("comment");


            //Add the Created Columns to the Datatable
            Seminar.Columns.Add(c0);
            Seminar.Columns.Add(c1);
            Seminar.Columns.Add(c2);
            Seminar.Columns.Add(c3);
            Seminar.Columns.Add(c4);
            Seminar.Columns.Add(c5);
            Seminar.Columns.Add(c6);
            Seminar.Columns.Add(c7);

            foreach (Seminar seminar in seminars)
            {
                DataRow row = Seminar.NewRow();
                row["ID"] = seminar.ID;
                row["theme"] = seminar.Theme;
                row["date"] = seminar.Date;
                row["webmembers"] = seminar.WebMembers;
                row["localmembers"] = seminar.LocalMembers;
                row["amount"] = seminar.Amount;
                row["debt"] = seminar.Debt;
                row["comment"] = seminar.Comment;
                Seminar.Rows.Add(row);
            }
            gridSeminars.DataSource = Seminar;
            gridSeminars.Columns[0].Visible = false;
            gridSeminars.RowHeadersVisible = false;
            gridSeminars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSeminars.AllowUserToAddRows = false;
            gridSeminars.ReadOnly = true;
            if (rowIndex != 0)
            {
                gridSeminars.CurrentCell = gridSeminars.Rows[rowIndex].Cells[1];
                gridSeminars.Rows[rowIndex].Selected = true;
            }
        }

        public void FillRefundsGrid(int rowIndex = 0)
        {
            AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            manager.Open();
            List<Refund> refunds = manager.getRefunds();
            //Create a New DataTable to store the Data
            DataTable Refund = new DataTable("Refund");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("label");
            DataColumn c2 = new DataColumn("amount");
            DataColumn c3 = new DataColumn("date");
            DataColumn c4 = new DataColumn("comment");


            //Add the Created Columns to the Datatable
            Refund.Columns.Add(c0);
            Refund.Columns.Add(c1);
            Refund.Columns.Add(c2);
            Refund.Columns.Add(c3);
            Refund.Columns.Add(c4);
            

            foreach (Refund refund in refunds)
            {
                DataRow row = Refund.NewRow();
                row["ID"] = refund.ID;
                row["label"] = refund.Label;
                row["amount"] = refund.Amount;
                row["date"] = refund.Date;
                row["comment"] = refund.Comment;
                Refund.Rows.Add(row);
            }
            gridRefunds.DataSource = Refund;
            gridRefunds.Columns[0].Visible = false;
            gridRefunds.RowHeadersVisible = false;
            gridRefunds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRefunds.AllowUserToAddRows = false;
            gridRefunds.ReadOnly = true;
            if (rowIndex != 0)
            {
                gridRefunds.CurrentCell = gridRefunds.Rows[rowIndex].Cells[1];
                gridRefunds.Rows[rowIndex].Selected = true;
            }
        }

        private void mainGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MemberForm mf = new MemberForm(this, manager);
                mf.Show();
                int currentMemberID = Convert.ToInt32(mainGrid.Rows[e.RowIndex].Cells[0].Value);
                Member member = members.Where(x => x.ID == currentMemberID).ToList<Member>()[0];
                mf.Populate(member, e.RowIndex);
            }
        }

        private void bntNewMember_Click(object sender, EventArgs e)
        {
            MemberForm mf = new MemberForm(this, manager);
            mf.Show();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            int currentMemberID = Convert.ToInt32(mainGrid.SelectedRows[0].Cells[0].Value);
            manager.DeleteMember(currentMemberID);
            FillMembersGrid();
        }
    }
}
