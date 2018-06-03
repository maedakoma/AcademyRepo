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
    public partial class SeminarForm : Form
    {
        AcademyMgr.AcademyMgr AcademyMgr;
        MainForm mainform;
        Seminar currentSeminar;
        int rowIndex;
        public SeminarForm(MainForm parentForm, AcademyMgr.AcademyMgr manager)
        {
            InitializeComponent();
            AcademyMgr = manager;
            currentSeminar = new Seminar();
            mainform = parentForm;
        }
        public void Populate(Seminar seminar, int index)
        {
            this.Text = seminar.Theme;
            rowIndex = index;
            currentSeminar = seminar;
            txtTheme.Text = seminar.Theme;
            txtWebMembers.Text = seminar.WebMembers.ToString();
            txtLocalMembers.Text = seminar.LocalMembers.ToString();
            txtAmount.Text = seminar.Amount.ToString();
            txtDebt.Text = seminar.Debt.ToString();
            txtComment.Text = seminar.Comment.ToString();
            if (seminar.Date != DateTime.MinValue)
            {
                date.Value = seminar.Date;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            currentSeminar.Theme = txtTheme.Text;
            currentSeminar.WebMembers = Convert.ToInt32(txtWebMembers.Text);
            currentSeminar.LocalMembers = Convert.ToInt32(txtLocalMembers.Text);
            currentSeminar.Amount = Convert.ToDecimal(txtAmount.Text);
            currentSeminar.Debt = Convert.ToDecimal(txtDebt.Text);
            currentSeminar.Comment = txtComment.Text;
            currentSeminar.Date = date.Value;
            if (currentSeminar.ID == 0)
            {
                AcademyMgr.InsertSeminar(currentSeminar);
            }
            else
            {
                AcademyMgr.UpdateSeminar(currentSeminar);
            }
            this.Close();
        }

        private void SeminarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.FillSeminarsGrid(rowIndex);
        }

    }
}
