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
    public partial class CoachPayForm : Form
    {
        AcademyMgr.AcademyMgr AcademyMgr;
        MainForm mainform;
        CoachPay currentCoachPayment;
        int rowIndex;
        public CoachPayForm(MainForm parentForm, AcademyMgr.AcademyMgr manager)
        {
            InitializeComponent();
            AcademyMgr = manager;
            mainform = parentForm;
            currentCoachPayment = new CoachPay();
            //On remplit la combo des coachs:
            List<Member> coachs = AcademyMgr.getMembers(true);
            cbCoachs.Items.AddRange(coachs.ToArray());
            cbCoachs.DisplayMember = "Lastname";
        }

        public void Populate(CoachPay pay, int index)
        {
            rowIndex = index;
            currentCoachPayment = pay;
            cbCoachs.SelectedIndex = cbCoachs.FindStringExact(pay.Coach.Lastname);
            txtMonth.Text = pay.Month;
            txtLessons.Text = pay.Lessons.ToString();
            txtLessonPrice.Text = pay.Pay.ToString();
            txtAmount.Text = pay.Amount.ToString();
            if (pay.Date != DateTime.MinValue)
            {
                dateTimePickerReception.Value = pay.Date;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            currentCoachPayment.Coach = (Member)cbCoachs.SelectedItem;
            currentCoachPayment.Month = txtMonth.Text;
            currentCoachPayment.Lessons = Convert.ToInt32(txtLessons.Text);
            currentCoachPayment.Pay = Convert.ToInt32(txtLessonPrice.Text);
            currentCoachPayment.Amount = Convert.ToInt32(txtAmount.Text);
            currentCoachPayment.Date = dateTimePickerReception.Value;
            if (currentCoachPayment.ID == 0)
            {
                AcademyMgr.InsertCoachPayment(currentCoachPayment);
            }
            else
            {
                AcademyMgr.UpdateCoachPayment(currentCoachPayment);
            }
            this.Close();
        }

        private void CoachPayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.FillCoachPayGrid(rowIndex);
        }
    }
}
