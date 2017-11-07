﻿using System;
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
    public partial class PrivateForm : Form
    {
        AcademyMgr.AcademyMgr AcademyMgr;
        MainForm mainform;
        Private currentPrivate;
        int rowIndex;
        public PrivateForm(MainForm parentForm, AcademyMgr.AcademyMgr manager)
        {
            InitializeComponent();
            AcademyMgr = manager;
            currentPrivate = new Private();
            mainform = parentForm;
        }
        public void Populate(Private privateLesson, int index)
        {
            this.Text = privateLesson.Name;
            rowIndex = index;
            currentPrivate = privateLesson;
            txtName.Text = privateLesson.Name;
            txtAmount.Text = privateLesson.Amount.ToString();
            txtBooked.Text = privateLesson.BookedLessons.ToString();
            txtDone.Text = privateLesson.DoneLessons.ToString();
            if (privateLesson.Date != DateTime.MinValue)
            {
                date.Value = privateLesson.Date;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            currentPrivate.Name = txtName.Text;
            currentPrivate.Amount = Convert.ToInt32(txtAmount.Text);
            currentPrivate.BookedLessons = Convert.ToInt32(txtBooked.Text);
            currentPrivate.DoneLessons = Convert.ToInt32(txtDone.Text);
            currentPrivate.Date = date.Value;
            if (currentPrivate.ID == 0)
            {
                AcademyMgr.InsertPrivate(currentPrivate);
            }
            else
            {
                AcademyMgr.UpdatePrivate(currentPrivate);
            }
            this.Close();
        }

        private void MemberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.FillPrivatesGrid(rowIndex);
        }
    }
}
