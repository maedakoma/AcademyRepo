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
    public partial class MainForm : Form
    {
        List<Member> members;
        List<Private> privates;
        List<CoachPay> pays;
        AcademyMgr.AcademyMgr manager;
        public MainForm()
        {
            InitializeComponent();
            manager = new AcademyMgr.AcademyMgr();
            manager.Open();
            this.Text = "Academy Cercle - " + manager.connectionString;
            MainForm_Load();
        }

        private void MainForm_Load()
        {
            FillResume();
            FillMembersGrid();
            FillSeminarsGrid();
            FillRefundsGrid();
            FillPrivatesGrid();
            FillCoachPayGrid();

            //TODO
            //Bug: Quand on modifie les paiements et ferme la fenetre, c'est encore en mémoire....
            // Faire des chiffres previsionels
            // Comment enregistrer des reports et lesquels?
            // faire une version web
            // faire un script de svg SQL
            // Mettre dans la grille une colonne paiement avec ($$$ ou 2 / 5 posés par ex)
            // Gerer les ouvertures fermetures de connection
            // Faire de payment.type une énumération??
        }

        public void FillResume()
        {
            txtMembersCount.Text = manager.getActiveMembersCount().ToString();
            int nLicencesAmount = manager.getLicencesAmount();
            txtLicencesAmount.Text = nLicencesAmount.ToString();
            int nLicencesDebt = manager.getLicencesDebt();
            txtLicencesDebt.Text = nLicencesDebt.ToString();
            txtLicencesBenef.Text = (nLicencesAmount - nLicencesDebt).ToString();
            int nPrivatesAmount = manager.getPrivatesAmount();
            txtPrivates.Text = nPrivatesAmount.ToString();
            int nSeminarsAmount = manager.getSeminarsAmount();
            txtSeminar.Text = nSeminarsAmount.ToString();
            int nSeminarsDebt = manager.getSeminarsDebt();
            txtSeminarDebt.Text = nSeminarsDebt.ToString();
            txtSeminarBenef.Text = (nSeminarsAmount - nSeminarsDebt).ToString();
            int nCoachsPaysAmount = manager.getCoachsPaysAmount();
            txtTeacherPays.Text = nCoachsPaysAmount.ToString();
            txtTotalDebt.Text = (nSeminarsDebt + nLicencesDebt).ToString();
            txtPaidDebt.Text = manager.getPaidDebt().ToString();
            txtDebt.Text = (nSeminarsDebt + nLicencesDebt - manager.getPaidDebt()).ToString();
            int nTotalBenef = nLicencesAmount - nLicencesDebt + nPrivatesAmount + nSeminarsAmount - nSeminarsDebt - nCoachsPaysAmount;
            txtTotalBenef.Text = nTotalBenef.ToString();
            //calcul d'un mensuel hypothétique:
            DateTime beginDate = new DateTime(2017,5,1);
            int nMonth = Math.Abs((beginDate.Month - DateTime.Now.Month) + 12 * (beginDate.Year - DateTime.Now.Year));
            txtBlackMonth.Text = (nTotalBenef / nMonth).ToString();
            txtOfficialMonth.Text = ((nTotalBenef * 75) / (nMonth * 100)).ToString();
            txtPrevBlackMonth.Text = (nTotalBenef / 12).ToString();
            txtPrevOfficialMonth.Text = ((nTotalBenef * 75) / (12 * 100)).ToString();
        }

        public void FillMembersGrid(int rowIndex = 0)
        {
            members = manager.getMembers();
            //Create a New DataTable to store the Data
            DataTable People = new DataTable("People");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("lastname");
            DataColumn c2 = new DataColumn("firstname");
            DataColumn c3 = new DataColumn("enddate");
            DataColumn c4 = new DataColumn("belt");
            DataColumn c5 = new DataColumn("gender");
            DataColumn c6 = new DataColumn("child");
            c6.DataType = typeof(bool);
            DataColumn c7 = new DataColumn("alert");
            c7.DataType = typeof(bool);
            DataColumn c8 = new DataColumn("amount");
            DataColumn c9 = new DataColumn("debt");
            DataColumn c10 = new DataColumn("comment");
            DataColumn c11 = new DataColumn("membershipOK");


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

            foreach (Member mem in members)
            {
                if (mem.Active)
                {
                    DataRow row = People.NewRow();
                    row["ID"] = mem.ID;
                    row["lastname"] = mem.Lastname;
                    row["firstname"] = mem.Firstname;
                    row["enddate"] = mem.Enddate.ToString("MMMM yy");
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
                    row["membershipOK"] = mem.MembershipOK;
                    People.Rows.Add(row);
                }
            }
            mainGrid.DataSource = People;
            mainGrid.Columns[0].Visible = false;
            mainGrid.Columns[5].Visible = false;
            mainGrid.Columns[6].Visible = false;
            mainGrid.Columns[7].Visible = false;
            mainGrid.Columns[11].Visible = false;
            mainGrid.RowHeadersVisible = false;
            mainGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainGrid.AllowUserToAddRows = false;
            mainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mainGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            mainGrid.ReadOnly = true;
            if (rowIndex != 0)
            {
                mainGrid.CurrentCell = mainGrid.Rows[rowIndex].Cells[1];
                mainGrid.Rows[rowIndex].Selected = true;
            }
            
        }
        public void FillSeminarsGrid(int rowIndex = 0)
        {
            //AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            //manager.Open();
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
            gridSeminars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridSeminars.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridSeminars.ReadOnly = true;
            if (rowIndex != 0)
            {
                gridSeminars.CurrentCell = gridSeminars.Rows[rowIndex].Cells[1];
                gridSeminars.Rows[rowIndex].Selected = true;
            }
        }
        public void FillPrivatesGrid(int rowIndex = 0)
        {
            //AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            //manager.Open();
            privates = manager.getPrivates();
            //Create a New DataTable to store the Data
            DataTable Private = new DataTable("Private");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("name");
            DataColumn c2 = new DataColumn("amount");
            DataColumn c3 = new DataColumn("date");
            DataColumn c4 = new DataColumn("bookedLessons");
            DataColumn c5 = new DataColumn("doneLessons");


            //Add the Created Columns to the Datatable
            Private.Columns.Add(c0);
            Private.Columns.Add(c1);
            Private.Columns.Add(c2);
            Private.Columns.Add(c3);
            Private.Columns.Add(c4);
            Private.Columns.Add(c5);

            foreach (Private priv in privates)
            {
                DataRow row = Private.NewRow();
                row["ID"] = priv.ID;
                row["name"] = priv.Name;
                row["amount"] = priv.Amount;
                row["date"] = priv.Date;
                row["bookedLessons"] = priv.BookedLessons;
                row["doneLessons"] = priv.DoneLessons;
                Private.Rows.Add(row);
            }
            gridPrivates.DataSource = Private;
            gridPrivates.Columns[0].Visible = false;
            gridPrivates.RowHeadersVisible = false;
            gridPrivates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPrivates.AllowUserToAddRows = false;
            gridPrivates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridPrivates.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridPrivates.ReadOnly = true;
            if (rowIndex != 0)
            {
                gridPrivates.CurrentCell = gridPrivates.Rows[rowIndex].Cells[1];
                gridPrivates.Rows[rowIndex].Selected = true;
            }
        }
        public void FillRefundsGrid(int rowIndex = 0)
        {
            //AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            //manager.Open();
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
            gridRefunds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridRefunds.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridRefunds.ReadOnly = true;
            if (rowIndex != 0)
            {
                gridRefunds.CurrentCell = gridRefunds.Rows[rowIndex].Cells[1];
                gridRefunds.Rows[rowIndex].Selected = true;
            }
        }
        public void FillCoachPayGrid(int rowIndex = 0)
        {
            //AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            //manager.Open();
            pays = manager.getCoachPays();
            //Create a New DataTable to store the Data
            DataTable Coachpay = new DataTable("Coachpay");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("Month");
            DataColumn c2 = new DataColumn("Coach");
            DataColumn c3 = new DataColumn("Lessons");
            DataColumn c4 = new DataColumn("Pay");
            DataColumn c5 = new DataColumn("Amount");
            DataColumn c6 = new DataColumn("Date");
            DataColumn c7 = new DataColumn("comment");


            //Add the Created Columns to the Datatable
            Coachpay.Columns.Add(c0);
            Coachpay.Columns.Add(c1);
            Coachpay.Columns.Add(c2);
            Coachpay.Columns.Add(c3);
            Coachpay.Columns.Add(c4);
            Coachpay.Columns.Add(c5);
            Coachpay.Columns.Add(c6);
            Coachpay.Columns.Add(c7);

            foreach (CoachPay pay in pays)
            {
                DataRow row = Coachpay.NewRow();
                row["ID"] = pay.ID;
                row["Month"] = pay.Month;
                row["Coach"] = pay.Coach;
                row["Lessons"] = pay.Lessons;
                row["Pay"] = pay.Pay;
                row["Amount"] = pay.Amount;
                row["date"] = pay.Date;
                row["comment"] = pay.Comment;
                Coachpay.Rows.Add(row);
            }
            gridCoachPay.DataSource = Coachpay;
            gridCoachPay.Columns[0].Visible = false;
            gridCoachPay.RowHeadersVisible = false;
            gridCoachPay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCoachPay.AllowUserToAddRows = false;
            gridCoachPay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCoachPay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridCoachPay.ReadOnly = true;
            if (rowIndex != 0)
            {
                gridCoachPay.CurrentCell = gridCoachPay.Rows[rowIndex].Cells[1];
                gridCoachPay.Rows[rowIndex].Selected = true;
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
        private void gridPrivates_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                PrivateForm pf = new PrivateForm(this, manager);
                pf.Show();
                int currentPrivateID = Convert.ToInt32(gridPrivates.Rows[e.RowIndex].Cells[0].Value);
                Private priv = privates.Where(x => x.ID == currentPrivateID).ToList<Private>()[0];
                pf.Populate(priv, e.RowIndex);
            }
        }
        private void gridCoachPay_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CoachPayForm cpf = new CoachPayForm(this, manager);
                cpf.Show();
                int currentCoachPayID = Convert.ToInt32(gridCoachPay.Rows[e.RowIndex].Cells[0].Value);
                CoachPay pay = pays.Where(x => x.ID == currentCoachPayID).ToList<CoachPay>()[0];
                cpf.Populate(pay, e.RowIndex);
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

        private void mainGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in mainGrid.Rows)
            {
                bool bMembershipOK = Convert.ToBoolean(row.Cells[11].Value);
                if (!bMembershipOK)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                bool bAlert = Convert.ToBoolean(row.Cells[7].Value);
                if (bAlert)
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void btnAddCoachPayment_Click(object sender, EventArgs e)
        {
            CoachPayForm cpf = new CoachPayForm(this, manager);
            cpf.Show();
        }

        private void btnAddPrivate_Click(object sender, EventArgs e)
        {
            PrivateForm pf = new PrivateForm(this, manager);
            pf.Show();
        }
    }
}
