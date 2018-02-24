namespace Academy
{
    partial class SeminarForm
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
            this.lblWebMembers = new System.Windows.Forms.Label();
            this.txtWebMembers = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.lblTheme = new System.Windows.Forms.Label();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.lblLocalMembers = new System.Windows.Forms.Label();
            this.txtLocalMembers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWebMembers
            // 
            this.lblWebMembers.AutoSize = true;
            this.lblWebMembers.Location = new System.Drawing.Point(12, 35);
            this.lblWebMembers.Name = "lblWebMembers";
            this.lblWebMembers.Size = new System.Drawing.Size(73, 13);
            this.lblWebMembers.TabIndex = 3;
            this.lblWebMembers.Text = "WebMembers";
            // 
            // txtWebMembers
            // 
            this.txtWebMembers.Location = new System.Drawing.Point(91, 35);
            this.txtWebMembers.Name = "txtWebMembers";
            this.txtWebMembers.Size = new System.Drawing.Size(121, 20);
            this.txtWebMembers.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(15, 200);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(239, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(287, 6);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 18;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(12, 9);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(40, 13);
            this.lblTheme.TabIndex = 19;
            this.lblTheme.Text = "Theme";
            // 
            // txtTheme
            // 
            this.txtTheme.Location = new System.Drawing.Point(91, 6);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.Size = new System.Drawing.Size(121, 20);
            this.txtTheme.TabIndex = 20;
            // 
            // lblLocalMembers
            // 
            this.lblLocalMembers.AutoSize = true;
            this.lblLocalMembers.Location = new System.Drawing.Point(12, 67);
            this.lblLocalMembers.Name = "lblLocalMembers";
            this.lblLocalMembers.Size = new System.Drawing.Size(76, 13);
            this.lblLocalMembers.TabIndex = 22;
            this.lblLocalMembers.Text = "LocalMembers";
            // 
            // txtLocalMembers
            // 
            this.txtLocalMembers.Location = new System.Drawing.Point(93, 67);
            this.txtLocalMembers.Name = "txtLocalMembers";
            this.txtLocalMembers.Size = new System.Drawing.Size(121, 20);
            this.txtLocalMembers.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(93, 105);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Debt";
            // 
            // txtDebt
            // 
            this.txtDebt.Location = new System.Drawing.Point(287, 105);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.Size = new System.Drawing.Size(121, 20);
            this.txtDebt.TabIndex = 25;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(93, 155);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(394, 20);
            this.txtComment.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Comment";
            // 
            // SeminarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 240);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDebt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblLocalMembers);
            this.Controls.Add(this.txtLocalMembers);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.date);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblWebMembers);
            this.Controls.Add(this.txtWebMembers);
            this.Name = "SeminarForm";
            this.Text = "SeminarForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeminarForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWebMembers;
        public System.Windows.Forms.TextBox txtWebMembers;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.TextBox txtTheme;
        private System.Windows.Forms.Label lblLocalMembers;
        public System.Windows.Forms.TextBox txtLocalMembers;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label3;
    }
}