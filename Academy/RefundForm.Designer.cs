namespace Academy
{
    partial class RefundForm
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
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(70, 6);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(121, 20);
            this.txtLabel.TabIndex = 0;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(12, 9);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(33, 13);
            this.lblLabel.TabIndex = 1;
            this.lblLabel.Text = "Label";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(12, 35);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(43, 13);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(70, 35);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(15, 108);
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
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(12, 69);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 19;
            this.lblComment.Text = "Comment";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(70, 66);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(420, 20);
            this.txtComment.TabIndex = 20;
            // 
            // RefundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 146);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.date);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.txtLabel);
            this.Name = "RefundForm";
            this.Text = "RefundForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemberForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Label lblLastname;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
    }
}