namespace Academy
{
    partial class MemberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblBelt = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblPayments = new System.Windows.Forms.Label();
            this.payGrid = new System.Windows.Forms.DataGridView();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbBelt = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.chkChild = new System.Windows.Forms.CheckBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.chkAlert = new System.Windows.Forms.CheckBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.chkFullYear = new System.Windows.Forms.CheckBox();
            this.chkInternal = new System.Windows.Forms.CheckBox();
            this.chkCompetitor = new System.Windows.Forms.CheckBox();
            this.chkCoach = new System.Windows.Forms.CheckBox();
            this.chkPrelev = new System.Windows.Forms.CheckBox();
            this.txtPrelevAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.payGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(70, 6);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(121, 20);
            this.txtFirstname.TabIndex = 0;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(12, 9);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(52, 13);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Firstname";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(12, 35);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(53, 13);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "Lastname";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(70, 35);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(121, 20);
            this.txtLastname.TabIndex = 2;
            // 
            // lblBelt
            // 
            this.lblBelt.AutoSize = true;
            this.lblBelt.Location = new System.Drawing.Point(12, 66);
            this.lblBelt.Name = "lblBelt";
            this.lblBelt.Size = new System.Drawing.Size(25, 13);
            this.lblBelt.TabIndex = 5;
            this.lblBelt.Text = "Belt";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(16, 346);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Location = new System.Drawing.Point(12, 130);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(53, 13);
            this.lblPayments.TabIndex = 9;
            this.lblPayments.Text = "Payments";
            // 
            // payGrid
            // 
            this.payGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payGrid.Location = new System.Drawing.Point(15, 146);
            this.payGrid.Name = "payGrid";
            this.payGrid.Size = new System.Drawing.Size(680, 184);
            this.payGrid.TabIndex = 10;
            this.payGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.payGrid_CellMouseDoubleClick);
            this.payGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.payGrid_DataBindingComplete);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(97, 346);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(75, 23);
            this.btnAddPayment.TabIndex = 11;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(620, 645);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbBelt
            // 
            this.cbBelt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBelt.FormattingEnabled = true;
            this.cbBelt.Items.AddRange(new object[] {
            "White",
            "Blue",
            "Purple",
            "Brown",
            "Black"});
            this.cbBelt.Location = new System.Drawing.Point(70, 66);
            this.cbBelt.Name = "cbBelt";
            this.cbBelt.Size = new System.Drawing.Size(121, 21);
            this.cbBelt.TabIndex = 13;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbGender.Location = new System.Drawing.Point(70, 93);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 21);
            this.cbGender.TabIndex = 15;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 93);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // chkChild
            // 
            this.chkChild.AutoSize = true;
            this.chkChild.Location = new System.Drawing.Point(207, 97);
            this.chkChild.Name = "chkChild";
            this.chkChild.Size = new System.Drawing.Size(49, 17);
            this.chkChild.TabIndex = 16;
            this.chkChild.Text = "Child";
            this.chkChild.UseVisualStyleBackColor = true;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(355, 13);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(49, 13);
            this.lblEndDate.TabIndex = 17;
            this.lblEndDate.Text = "EndDate";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(407, 9);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 18;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(12, 416);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 19;
            this.lblComment.Text = "Comment";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(70, 409);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(538, 20);
            this.txtComment.TabIndex = 20;
            // 
            // chkAlert
            // 
            this.chkAlert.AutoSize = true;
            this.chkAlert.Location = new System.Drawing.Point(17, 386);
            this.chkAlert.Name = "chkAlert";
            this.chkAlert.Size = new System.Drawing.Size(61, 17);
            this.chkAlert.TabIndex = 21;
            this.chkAlert.Text = "ALERT";
            this.chkAlert.UseVisualStyleBackColor = true;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(16, 443);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(24, 13);
            this.lblJob.TabIndex = 22;
            this.lblJob.Text = "Job";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(70, 440);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(538, 20);
            this.txtJob.TabIndex = 23;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(278, 97);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(47, 17);
            this.chkActive.TabIndex = 24;
            this.chkActive.Text = "Actif";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(14, 486);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 25;
            this.lblMail.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(70, 479);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(538, 20);
            this.txtMail.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Facebook";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Address";
            // 
            // txtFacebook
            // 
            this.txtFacebook.Location = new System.Drawing.Point(69, 578);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(538, 20);
            this.txtFacebook.TabIndex = 30;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(69, 547);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(538, 20);
            this.txtAddress.TabIndex = 31;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(69, 511);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(538, 20);
            this.txtPhone.TabIndex = 32;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(613, 578);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(42, 20);
            this.btnGo.TabIndex = 33;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // chkFullYear
            // 
            this.chkFullYear.AutoSize = true;
            this.chkFullYear.Location = new System.Drawing.Point(130, 386);
            this.chkFullYear.Name = "chkFullYear";
            this.chkFullYear.Size = new System.Drawing.Size(64, 17);
            this.chkFullYear.TabIndex = 34;
            this.chkFullYear.Text = "FullYear";
            this.chkFullYear.UseVisualStyleBackColor = true;
            // 
            // chkInternal
            // 
            this.chkInternal.AutoSize = true;
            this.chkInternal.Location = new System.Drawing.Point(346, 97);
            this.chkInternal.Name = "chkInternal";
            this.chkInternal.Size = new System.Drawing.Size(61, 17);
            this.chkInternal.TabIndex = 35;
            this.chkInternal.Text = "Internal";
            this.chkInternal.UseVisualStyleBackColor = true;
            // 
            // chkCompetitor
            // 
            this.chkCompetitor.AutoSize = true;
            this.chkCompetitor.Location = new System.Drawing.Point(407, 97);
            this.chkCompetitor.Name = "chkCompetitor";
            this.chkCompetitor.Size = new System.Drawing.Size(76, 17);
            this.chkCompetitor.TabIndex = 36;
            this.chkCompetitor.Text = "Competitor";
            this.chkCompetitor.UseVisualStyleBackColor = true;
            // 
            // chkCoach
            // 
            this.chkCoach.AutoSize = true;
            this.chkCoach.Location = new System.Drawing.Point(489, 97);
            this.chkCoach.Name = "chkCoach";
            this.chkCoach.Size = new System.Drawing.Size(57, 17);
            this.chkCoach.TabIndex = 37;
            this.chkCoach.Text = "Coach";
            this.chkCoach.UseVisualStyleBackColor = true;
            // 
            // chkPrelev
            // 
            this.chkPrelev.AutoSize = true;
            this.chkPrelev.Location = new System.Drawing.Point(550, 97);
            this.chkPrelev.Name = "chkPrelev";
            this.chkPrelev.Size = new System.Drawing.Size(62, 17);
            this.chkPrelev.TabIndex = 38;
            this.chkPrelev.Text = "Prelev :";
            this.chkPrelev.UseVisualStyleBackColor = true;
            // 
            // txtPrelevAmount
            // 
            this.txtPrelevAmount.Location = new System.Drawing.Point(612, 95);
            this.txtPrelevAmount.Name = "txtPrelevAmount";
            this.txtPrelevAmount.Size = new System.Drawing.Size(39, 20);
            this.txtPrelevAmount.TabIndex = 39;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 680);
            this.Controls.Add(this.txtPrelevAmount);
            this.Controls.Add(this.chkPrelev);
            this.Controls.Add(this.chkCoach);
            this.Controls.Add(this.chkCompetitor);
            this.Controls.Add(this.chkInternal);
            this.Controls.Add(this.chkFullYear);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFacebook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.chkAlert);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.chkChild);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cbBelt);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.payGrid);
            this.Controls.Add(this.lblPayments);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblBelt);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.txtFirstname);
            this.Name = "MemberForm";
            this.Text = "MemberForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemberForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.payGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        public System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblBelt;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.DataGridView payGrid;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbBelt;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.CheckBox chkChild;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.CheckBox chkAlert;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.CheckBox chkFullYear;
        private System.Windows.Forms.CheckBox chkInternal;
        private System.Windows.Forms.CheckBox chkCompetitor;
        private System.Windows.Forms.CheckBox chkCoach;
        private System.Windows.Forms.CheckBox chkPrelev;
        private System.Windows.Forms.TextBox txtPrelevAmount;
    }
}