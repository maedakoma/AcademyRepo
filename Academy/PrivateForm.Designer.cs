namespace Academy
{
    partial class PrivateForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.lblBooked = new System.Windows.Forms.Label();
            this.txtBooked = new System.Windows.Forms.TextBox();
            this.lblDone = new System.Windows.Forms.Label();
            this.txtDone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
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
            this.btnOK.Location = new System.Drawing.Point(17, 137);
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
            // lblBooked
            // 
            this.lblBooked.AutoSize = true;
            this.lblBooked.Location = new System.Drawing.Point(12, 69);
            this.lblBooked.Name = "lblBooked";
            this.lblBooked.Size = new System.Drawing.Size(44, 13);
            this.lblBooked.TabIndex = 19;
            this.lblBooked.Text = "Booked";
            // 
            // txtBooked
            // 
            this.txtBooked.Location = new System.Drawing.Point(70, 66);
            this.txtBooked.Name = "txtBooked";
            this.txtBooked.Size = new System.Drawing.Size(121, 20);
            this.txtBooked.TabIndex = 20;
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Location = new System.Drawing.Point(14, 100);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(33, 13);
            this.lblDone.TabIndex = 22;
            this.lblDone.Text = "Done";
            // 
            // txtDone
            // 
            this.txtDone.Location = new System.Drawing.Point(70, 93);
            this.txtDone.Name = "txtDone";
            this.txtDone.Size = new System.Drawing.Size(121, 20);
            this.txtDone.TabIndex = 23;
            // 
            // PrivateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 184);
            this.Controls.Add(this.txtDone);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.txtBooked);
            this.Controls.Add(this.lblBooked);
            this.Controls.Add(this.date);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "PrivateForm";
            this.Text = "PrivateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemberForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastname;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label lblBooked;
        private System.Windows.Forms.TextBox txtBooked;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.TextBox txtDone;
    }
}