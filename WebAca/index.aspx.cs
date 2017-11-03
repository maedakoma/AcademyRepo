using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AcademyMgr;


namespace WebAca
{
    public partial class WebMainForm : System.Web.UI.Page
    {
        List<AcademyMgr.Member> members;
        AcademyMgr.AcademyMgr manager;
        protected void Page_Load(object sender, EventArgs e)
        {
            AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            manager.Open();
            List<Refund> refunds = manager.getRefunds();
            int TotalRefund = 0;
            foreach (Refund refund in refunds)
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
            DataColumn c3 = new DataColumn("enddate");
            c3.DataType = typeof(DateTime);
            DataColumn c4 = new DataColumn("belt");
            DataColumn c5 = new DataColumn("gender");
            DataColumn c6 = new DataColumn("child");
            c6.DataType = typeof(bool);
            DataColumn c7 = new DataColumn("alert");
            c7.DataType = typeof(bool);
            DataColumn c8 = new DataColumn("amount");
            DataColumn c9 = new DataColumn("debt");
            DataColumn c10 = new DataColumn("comment");


            //Add the Created Columns to the Datatable
            People.Columns.Add(c0);
            People.Columns.Add(c1);
            People.Columns.Add(c2);
            People.Columns.Add(c3);
            People.Columns.Add(c4);
            People.Columns.Add(c5);
            People.Columns.Add(c6);
            People.Columns.Add(c7);
            People.Columns.Add(c8);
            People.Columns.Add(c9);
            People.Columns.Add(c10);

            foreach (Member mem in members)
            {
                DataRow row = People.NewRow();
                row["ID"] = mem.ID;
                row["lastname"] = mem.Lastname;
                row["firstname"] = mem.Firstname;
                row["enddate"] = mem.Enddate;
                row["belt"] = mem.Belt;
                row["gender"] = mem.Gender;
                row["child"] = mem.Child;
                row["alert"] = mem.Alert;
                int amount = 0;
                int debt = 0;
                foreach (Payment pay in mem.Payments)
                {
                    amount = amount + pay.Amount;
                    debt = debt + pay.Debt;
                }
                row["amount"] = amount;
                row["debt"] = debt;
                row["comment"] = mem.Comment;
                People.Rows.Add(row);
            }
            mainGrid.DataSource = People;
            mainGrid.DataBind();
            //mainGrid.Columns[0].Visible = false;
            //mainGrid.Columns[5].Visible = false;
            //mainGrid.Columns[6].Visible = false;
            //mainGrid.Columns[7].Visible = false;
            //mainGrid.RowHeadersVisible = false;
            //mainGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //mainGrid.AllowUserToAddRows = false;
            //mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //mainGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //mainGrid.ReadOnly = true;
            //if (rowIndex != 0)
            //{
            //    mainGrid.CurrentCell = mainGrid.Rows[rowIndex].Cells[1];
            //    mainGrid.Rows[rowIndex].Selected = true;
            //}
        }
    }
}