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
        bool bCreateMode = true;
        AcademyMgr.AcademyMgr AcademyMgr;
        MainForm mainform;
        Member currentMember;
        public MemberForm(MainForm parentForm, AcademyMgr.AcademyMgr manager, bool createMode)
        {
            AcademyMgr = manager;
            bCreateMode = createMode;
            if (createMode)
            {
                currentMember = new Member();
            }
            mainform = parentForm;
            InitializeComponent();
        }
        public void Populate(Member member)
        {
            currentMember = member;
            bCreateMode = false;
            txtFirstname.Text = member.Firstname;
            txtLastname.Text = member.Lastname;
            txtBelt.Text = member.Belt;

            //Create a New DataTable to store the Data
            DataTable Payments = new DataTable("Payments");
            //Create the Columns in the DataTable
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("Amount");
            DataColumn c2 = new DataColumn("Type");
            DataColumn c3 = new DataColumn("Name");
            DataColumn c4 = new DataColumn("Debt");

            //Add the Created Columns to the Datatable
            Payments.Columns.Add(c0);
            Payments.Columns.Add(c1);
            Payments.Columns.Add(c2);
            Payments.Columns.Add(c3);
            Payments.Columns.Add(c4);

            foreach (Payment pay in member.Payments)
            {
                DataRow row = Payments.NewRow();
                row["ID"] = pay.ID;
                row["Amount"] = pay.Amount;
                row["Type"] = pay.Type;
                row["Name"] = pay.Name;
                row["Debt"] = pay.Debt;
                Payments.Rows.Add(row);
            }
            payGrid.DataSource = Payments;
            payGrid.Columns[0].Visible = false;
            payGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            payGrid.RowHeadersVisible = false;

        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            PaymentForm payform = new PaymentForm(this, currentMember);
            payform.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //int currentPaymentID = Convert.ToInt32(payGrid.SelectedRows[0].Cells[0].Value);
            //Payment pay = currentMember.Payments.Where(x => x.ID == currentPaymentID).ToList<Payment>()[0];
            //currentMember.Payments.Remove(pay);
            payGrid.Rows.Remove(payGrid.SelectedRows[0]);
            //Populate(currentMember);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (bCreateMode)
            {
                //Nous sommes en mode création, on va créer un nouveau member
                Member newMember = new Member();
                newMember.Firstname = txtFirstname.Text;
                newMember.Lastname = txtLastname.Text;
                newMember.Belt = txtBelt.Text;
                //Gestion des paiements:


                AcademyMgr.InsertMember(newMember);
                mainform.FillGrid();
            }
            this.Close();
        }

        
    }
}
