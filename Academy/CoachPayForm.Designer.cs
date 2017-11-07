namespace Academy
{
    partial class CoachPayForm
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dateTimePickerReception = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtLessons = new System.Windows.Forms.TextBox();
            this.lblLessons = new System.Windows.Forms.Label();
            this.txtLessonPrice = new System.Windows.Forms.TextBox();
            this.lblLessonPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(21, 142);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(100, 139);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // dateTimePickerReception
            // 
            this.dateTimePickerReception.Location = new System.Drawing.Point(99, 190);
            this.dateTimePickerReception.Name = "dateTimePickerReception";
            this.dateTimePickerReception.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReception.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 196);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 20);
            this.txtName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(99, 48);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(122, 20);
            this.txtMonth.TabIndex = 9;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(21, 51);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 8;
            this.lblMonth.Text = "Month";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(24, 240);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtLessons
            // 
            this.txtLessons.Location = new System.Drawing.Point(100, 77);
            this.txtLessons.Name = "txtLessons";
            this.txtLessons.Size = new System.Drawing.Size(121, 20);
            this.txtLessons.TabIndex = 12;
            // 
            // lblLessons
            // 
            this.lblLessons.AutoSize = true;
            this.lblLessons.Location = new System.Drawing.Point(21, 80);
            this.lblLessons.Name = "lblLessons";
            this.lblLessons.Size = new System.Drawing.Size(73, 13);
            this.lblLessons.TabIndex = 11;
            this.lblLessons.Text = "Given lessons";
            // 
            // txtLessonPrice
            // 
            this.txtLessonPrice.Location = new System.Drawing.Point(100, 108);
            this.txtLessonPrice.Name = "txtLessonPrice";
            this.txtLessonPrice.Size = new System.Drawing.Size(121, 20);
            this.txtLessonPrice.TabIndex = 14;
            // 
            // lblLessonPrice
            // 
            this.lblLessonPrice.AutoSize = true;
            this.lblLessonPrice.Location = new System.Drawing.Point(21, 111);
            this.lblLessonPrice.Name = "lblLessonPrice";
            this.lblLessonPrice.Size = new System.Drawing.Size(65, 13);
            this.lblLessonPrice.TabIndex = 13;
            this.lblLessonPrice.Text = "LessonPrice";
            // 
            // CoachPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 275);
            this.Controls.Add(this.txtLessonPrice);
            this.Controls.Add(this.lblLessonPrice);
            this.Controls.Add(this.txtLessons);
            this.Controls.Add(this.lblLessons);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePickerReception);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "CoachPayForm";
            this.Text = "PaymentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CoachPayForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerReception;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtLessons;
        private System.Windows.Forms.Label lblLessons;
        private System.Windows.Forms.TextBox txtLessonPrice;
        private System.Windows.Forms.Label lblLessonPrice;
    }
}