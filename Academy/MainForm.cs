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
            FillGrid();
        }
            
        public void FillGrid()
        {
            AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            manager.Open();
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
            lblMembers.Text = People.Rows.Count.ToString() + " members";
        }

        private void mainGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MemberForm mf = new MemberForm(this, manager, false);
            mf.Show();
            int currentMemberID = Convert.ToInt32(mainGrid.Rows[e.RowIndex].Cells[0].Value);
            Member member = members.Where(x => x.ID == currentMemberID).ToList<Member>()[0];
            mf.Populate(member);

        }

        private void bntNewMember_Click(object sender, EventArgs e)
        {
            MemberForm mf = new MemberForm(this, manager, true);
            mf.Show();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            int currentMemberID = Convert.ToInt32(mainGrid.SelectedRows[0].Cells[0].Value);
            manager.DeleteMember(currentMemberID);
            FillGrid();
        }
    }
}
