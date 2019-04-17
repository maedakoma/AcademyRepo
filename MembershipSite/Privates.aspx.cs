using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcademyMgr;
using System.Data;
using System.Web.Security;

namespace MembershipSite
{
    public partial class _Privates : System.Web.UI.Page
    {
        List<AcademyMgr.Private> privates;
        AcademyMgr.AcademyMgr manager;

        protected void Page_Load(object sender, EventArgs e)
        {
            manager = new AcademyMgr.AcademyMgr();
            manager.Initialize();
            if (!Page.IsPostBack)
            {
                List<Member> members = manager.getMembers();
                ddMembers.DataSource = members;
                ddMembers.DataTextField = "Lastname";
                ddMembers.DataValueField = "ID";
                ddMembers.DataBind();
            }
            // Populate the GridView.
            BindGridView();
        }

        private void BindGridView()
        {
            privates = manager.getPrivates();
            //Create a New DataTable to store the Data
            DataTable Privates = new DataTable("Privates");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("name");
            DataColumn c2 = new DataColumn("date");
            c2.DataType = typeof(DateTime);
            DataColumn c3 = new DataColumn("booked");
            DataColumn c4 = new DataColumn("done");
            DataColumn c5 = new DataColumn("description");


            //Add the Created Columns to the Datatable
            Privates.Columns.Add(c0);
            Privates.Columns.Add(c1);
            Privates.Columns.Add(c2);
            Privates.Columns.Add(c3);
            Privates.Columns.Add(c4);
            Privates.Columns.Add(c5);

            foreach (Private prv in privates)
            {
                DataRow row = Privates.NewRow();
                row["ID"] = prv.ID;
                row["name"] = prv.member.Lastname;
                row["date"] = prv.Date;
                row["booked"] = prv.BookedLessons;
                row["done"] = prv.DoneLessons;
                row["description"] = prv.Description;
                Privates.Rows.Add(row);
            }
            GridPrivates.DataSource = Privates;
            GridPrivates.DataBind();

        }
        protected void gridPrivates_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[2].Visible = false;
            //e.Row.Cells[7].Visible = false;
            //e.Row.Cells[8].Visible = false;
            //e.Row.Cells[9].Visible = false;
            //e.Row.Cells[13].Visible = false;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[6].Text == e.Row.Cells[7].Text)
                {
                    e.Row.BackColor = System.Drawing.Color.LightGreen;
                }
                //if (e.Row.Cells[9].Text == "True")
                //{
                //    e.Row.BackColor = System.Drawing.Color.Orange;
                //}
                // Make sure the current GridViewRow is either 
                // in the normal state or an alternate row.
                if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
                {
                    // Add client-side confirmation when deleting.
                    ((LinkButton)e.Row.Cells[1].Controls[0]).Attributes["onclick"] = "if(!confirm('Are you certain you want to delete this private ?')) return false;";
                }
            }
        }
        protected void RowEditing(object sender, GridViewEditEventArgs e)
        {
            int currentPrivateID = Convert.ToInt32(GridPrivates.Rows[e.NewEditIndex].Cells[2].Text);
            Application["currentPrivateID"] = currentPrivateID;
            Private prv = privates.Where(x => x.ID == currentPrivateID).ToList<Private>()[0];
            pnlPrivate.Visible = true;
            PopulatePrivatePanel(prv);
        }

        private void PopulatePrivatePanel(Private prv)
        {
            ddMembers.SelectedValue = prv.member.ID.ToString();
            txtBooked.Text = prv.BookedLessons.ToString();
            txtDone.Text = prv.DoneLessons.ToString();
            txtDescription.Text = prv.Description.ToString();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            pnlPrivate.Visible = false;
            GridPrivates.EditIndex = -1;
            BindGridView();
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            int currentPrivateID = Convert.ToInt32(Application["currentPrivateID"]);
            Private prv = new Private();
            if (currentPrivateID != 0)
            {
                prv = privates.Where(x => x.ID == currentPrivateID).ToList<Private>()[0];
            }
            Member member = new Member();
            member.ID = Convert.ToInt32(ddMembers.SelectedValue);
            prv.member = member;
            prv.BookedLessons = Convert.ToInt32(txtBooked.Text);
            prv.DoneLessons = Convert.ToInt32(txtDone.Text);
            prv.Description = txtDescription.Text;
            prv.Date = DateTime.Now;
            if (currentPrivateID != 0)
            {
                manager.UpdatePrivate(prv);
            }
            else
            {
                manager.InsertPrivate(prv);
            }
            pnlPrivate.Visible = false;
            // Populate the GridView.
            GridPrivates.EditIndex = -1;
            BindGridView();
        }
        protected void btnAddPrivate_Click(object sender, EventArgs e)
        {
            Application["currentPrivateID"] = 0;
            ddMembers.SelectedIndex = 0;
            txtBooked.Text = "";
            txtDone.Text = "";
            txtDescription.Text = "";
            pnlPrivate.Visible = true;
        }
        // GridView.RowDeleting Event
        protected void RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int currentPrivateID = Convert.ToInt32(GridPrivates.Rows[e.RowIndex].Cells[2].Text);
            manager.DeletePrivate(currentPrivateID);
            // Populate the GridView.
            BindGridView();
        }

        protected void Signout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Logon.aspx");
        }
    }
}
