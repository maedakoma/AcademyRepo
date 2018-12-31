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
    public partial class _Default : System.Web.UI.Page
    {
        List<AcademyMgr.Member> members;
        AcademyMgr.AcademyMgr manager;

        protected void Page_Load(object sender, EventArgs e)
        {
            manager = new AcademyMgr.AcademyMgr();
            manager.Initialize();
            //ddBelt.Items.Clear();
            if (!IsPostBack)
            {
                ddBelt.Items.Add("White");
                ddBelt.Items.Add("Blue");
                ddBelt.Items.Add("Purple");
                ddBelt.Items.Add("Brown");
                ddBelt.Items.Add("Black");

                List<Plan> plans = manager.getPlans(Plan.typeEnum.Abonnement);
                ddAbo.Items.Add("");
                foreach (Plan p in plans)
                {
                    ListItem i = new ListItem(p.Label, p.ID.ToString());
                    ddAbo.Items.Add(i);
                }

                List<Plan> privates = manager.getPlans(Plan.typeEnum.Private);
                ddPrivates.Items.Add("");
                foreach (Plan p in privates)
                {
                    ListItem i = new ListItem(p.Label, p.ID.ToString());
                    ddPrivates.Items.Add(i);
                }
            }
            // Populate the GridView.
            BindGridView();
        }
        private void BindGridView()
        {
            members = manager.getMembers(null);
            //Create a New DataTable to store the Data
            DataTable People = new DataTable("People");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("lastname");
            DataColumn c2 = new DataColumn("firstname");
            DataColumn c3 = new DataColumn("enddate");
            c3.DataType = typeof(DateTime);
            DataColumn c4 = new DataColumn("belt");
            DataColumn c5 = new DataColumn("stripe");
            DataColumn c6 = new DataColumn("gender");
            DataColumn c7 = new DataColumn("child");
            c7.DataType = typeof(bool);
            DataColumn c8 = new DataColumn("alert");
            //c7.DataType = typeof(bool);
            DataColumn c9 = new DataColumn("amount");
            DataColumn c10 = new DataColumn("debt");
            DataColumn c11 = new DataColumn("comment");
            DataColumn c12 = new DataColumn("fullyear");
            DataColumn c13 = new DataColumn("phone");
            DataColumn c14 = new DataColumn("mail");



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
            People.Columns.Add(c11);
            People.Columns.Add(c12);
            People.Columns.Add(c13);
            People.Columns.Add(c14);


            foreach (Member mem in members)
            {
                if (mem.Active)
                {
                    DataRow row = People.NewRow();
                    row["ID"] = mem.ID;
                    row["lastname"] = mem.Lastname;
                    row["firstname"] = mem.Firstname;
                    row["enddate"] = mem.Enddate;
                    row["belt"] = mem.Belt;
                    row["stripe"] = mem.Stripe;
                    row["gender"] = mem.Gender;
                    row["child"] = mem.Child;
                    row["alert"] = mem.Alert;
                    decimal amount = 0;
                    decimal debt = 0;
                    foreach (Payment pay in mem.Payments)
                    {
                        amount = amount + pay.Amount;
                        debt = debt + pay.Debt;
                    }
                    row["amount"] = amount;
                    row["debt"] = debt;
                    row["comment"] = mem.Comment;
                    row["fullyear"] = mem.FullYear;
                    row["phone"] = mem.Phone;
                    row["mail"] = mem.Mail;
                    People.Rows.Add(row);
                }
            }
            mainGrid.DataSource = People;
            mainGrid.DataBind();
            
        }
        protected void mainGrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[5].Visible = false;
            e.Row.Cells[8].Visible = false;
            e.Row.Cells[9].Visible = false;
            e.Row.Cells[10].Visible = false;
            e.Row.Cells[14].Visible = false;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                bool bAlert = e.Row.Cells[10].Text == "True";
                bool bFullyear = e.Row.Cells[14].Text == "True";
                if (!bFullyear)
                {
                    e.Row.BackColor = System.Drawing.Color.Gray;
                    e.Row.ForeColor = System.Drawing.Color.White;
                }
                if (bAlert)
                {
                    e.Row.BackColor = System.Drawing.Color.BlueViolet;
                    e.Row.ForeColor = System.Drawing.Color.White;
                }
                if (e.Row.Cells[5].Text != string.Empty)
                {
                    DateTime endDate = Convert.ToDateTime(e.Row.Cells[5].Text);
                    if (endDate != DateTime.MinValue)
                    {
                        int daydiff = (int)(DateTime.Now - endDate).TotalDays;
                        if (daydiff > 10)
                        {
                            if (daydiff < 30)
                            {
                                e.Row.BackColor = System.Drawing.Color.Orange;
                                e.Row.ForeColor = System.Drawing.Color.White;
                            }
                            else if (daydiff < 50)
                            {
                                e.Row.BackColor = System.Drawing.Color.Red;
                                e.Row.ForeColor = System.Drawing.Color.White;
                            }
                            else
                            {
                                e.Row.BackColor = System.Drawing.Color.Black;
                                e.Row.ForeColor = System.Drawing.Color.White;
                            }
                        }
                    }
                }
                // Make sure the current GridViewRow is either 
                // in the normal state or an alternate row.
                if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
                {
                    // Add client-side confirmation when deleting.
                    ((LinkButton)e.Row.Cells[1].Controls[0]).Attributes["onclick"] = "if(!confirm('Are you certain you want to delete this person ?')) return false;";
                }
            }
        }

        // GridView.RowDeleting Event
        protected void RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int currentMemberID = Convert.ToInt32(mainGrid.Rows[e.RowIndex].Cells[2].Text);
            manager.DeleteMember(currentMemberID);
            // Populate the GridView.
            BindGridView();
        }

        protected void Signout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Logon.aspx");
        }

        protected void RowEditing(object sender, GridViewEditEventArgs e)
        {
            int currentMemberID = Convert.ToInt32(mainGrid.Rows[e.NewEditIndex].Cells[2].Text);
            Application["currentMemberID"] = currentMemberID;
            Member member = members.Where(x => x.ID == currentMemberID).ToList<Member>()[0];
            pnlMember.Visible = true;
            PopulateMemberPanel(member);
        }

        private void PopulateMemberPanel(Member member)
        {
            tbFirstname.Text = member.Firstname;
            tbLastname.Text = member.Lastname;
            ddBelt.SelectedValue = member.Belt.ToString();
            if (member.AboPlan != null)
            {
                ddAbo.SelectedValue = member.AboPlan.ID.ToString();
            }
            else
            {
                ddAbo.SelectedValue = "";
            }
            if (member.PrivatePlan != null)
            {
                ddPrivates.SelectedValue = member.PrivatePlan.ID.ToString();
            }
            else
            {
                ddPrivates.SelectedValue = "";
            }
            chkChild.Checked = member.Child;
            chkActive.Checked = member.Active;
            chkCompetitor.Checked = member.Competitor;
            chkCoach.Checked = member.Coach;
            chkAlert.Checked = member.Alert;
            chkFullyear.Checked = member.FullYear;
            tbComment.Text = member.Comment;
            tbStripe.Text = member.Stripe.ToString();
            tbJob.Text = member.Job;
            tbMail.Text = member.Mail;
            tbAdress.Text = member.Address;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            pnlMember.Visible = false;
            mainGrid.EditIndex = -1;
            BindGridView();
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            int currentMemberID = Convert.ToInt32(Application["currentMemberID"]);
            Member member = new Member();
            if (currentMemberID != 0)
            {
                member = members.Where(x => x.ID == currentMemberID).ToList<Member>()[0];
            }
            member.Firstname = tbFirstname.Text;
            member.Lastname = tbLastname.Text;
            member.Belt = (Member.beltEnum)Enum.Parse(typeof(Member.beltEnum), ddBelt.SelectedValue.ToString(), true);
            if (ddAbo.SelectedValue != "")
            {
                Plan abo = new Plan();
                abo.ID = Convert.ToInt32(ddAbo.SelectedValue);
                member.AboPlan = abo;
            }
            if (ddPrivates.SelectedValue != "")
            {
                Plan priv = new Plan();
                priv.ID = Convert.ToInt32(ddPrivates.SelectedValue);
                member.PrivatePlan = priv;
            }
            member.Child = chkChild.Checked;
            member.Active = chkActive.Checked;
            member.Competitor = chkCompetitor.Checked;
            member.Coach = chkCoach.Checked;
            member.Alert = chkAlert.Checked;
            member.FullYear = chkFullyear.Checked;
            member.Comment = tbComment.Text;
            member.Stripe = Convert.ToByte(tbStripe.Text);
            member.Job = tbJob.Text;
            member.Mail = tbMail.Text;
            member.Address = tbAdress.Text;

            if (currentMemberID != 0)
            { 
                manager.UpdateMember(member);
            }
            else
            {
                manager.InsertMember(member);
            }
            pnlMember.Visible = false;
            // Populate the GridView.
            mainGrid.EditIndex = -1;
            BindGridView();
        }

        protected void btnAddMember_Click(object sender, EventArgs e)
        {
            Application["currentMemberID"] = 0;
            tbFirstname.Text = "";
            tbLastname.Text = "";
            ddBelt.SelectedIndex = 0;
            tbStripe.Text = "0";
            ddAbo.SelectedIndex = 0;
            ddPrivates.SelectedIndex = 0;
            chkActive.Checked = true;
            chkAlert.Checked = false;
            tbComment.Text = "";
            tbJob.Text = "";
            tbMail.Text = "";
            tbAdress.Text = "";
            pnlMember.Visible = true;
        }
    }
}
