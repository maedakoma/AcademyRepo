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
            //On remplit la combo des eleves:
            List<Member> members = AcademyMgr.getMembers();
            cbMember.Items.AddRange(members.ToArray());
            cbMember.DisplayMember = "Fullname";
        }
        public void Populate(Private privateLesson, int index)
        {
            this.Text = privateLesson.member.Lastname;
            rowIndex = index;
            currentPrivate = privateLesson;
            cbMember.SelectedIndex = cbMember.FindStringExact(privateLesson.member.Fullname);
            txtBooked.Text = privateLesson.BookedLessons.ToString();
            txtDescription.Text = privateLesson.Description;
            txtDone.Text = privateLesson.DoneLessons.ToString();
            if (privateLesson.Date != DateTime.MinValue)
            {
                date.Value = privateLesson.Date;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            currentPrivate.member = (Member)cbMember.SelectedItem;
            currentPrivate.BookedLessons = Convert.ToInt32(txtBooked.Text);
            currentPrivate.DoneLessons = Convert.ToInt32(txtDone.Text);
            currentPrivate.Description = txtDescription.Text;
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
