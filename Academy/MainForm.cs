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
        public MainForm()
        {
            InitializeComponent();
            MainForm_Load();
        }

        private void MainForm_Load()
        {
            // TODO: This line of code loads data into the 'academyDataSet.members' table. You can move, or remove it, as needed.
            AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            List<AcademyMgr.Member> members =  manager.getMembers();
            FillGrid(members);
        }
            
        private void FillGrid(List<AcademyMgr.Member> members)
        {
            //Create a New DataTable to store the Data
            DataTable People = new DataTable("People");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("lastname");
            DataColumn c1 = new DataColumn("firstname");
            DataColumn c2 = new DataColumn("belt");
            DataColumn c3 = new DataColumn("gender");
            DataColumn c4 = new DataColumn("amount");


            //Add the Created Columns to the Datatable
            People.Columns.Add(c0);
            People.Columns.Add(c1);
            People.Columns.Add(c2);
            People.Columns.Add(c3);
            People.Columns.Add(c4);
            
            foreach (Member mem in members)
            {
                DataRow row = People.NewRow();
                row["lastname"] = mem.Lastname;
                row["firstname"] = mem.Firstname;
                row["belt"] = mem.Belt;
                row["gender"] = mem.Gender;
                int amount = 0;
                foreach(Payment pay in mem.Payments)
                {
                    amount = amount  + pay.Amount;
                }
                row["amount"] = amount;
                People.Rows.Add(row);
            }
            mainGrid.DataSource = People;
            lblMembers.Text = People.Rows.Count.ToString() + " members";
        }
    }
}
