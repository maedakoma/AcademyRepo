namespace Academy
{
    partial class PaymentForm
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
            this.lblType = new System.Windows.Forms.Label();
            this.dateTimePickerReception = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.lblDebt = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblPutDate = new System.Windows.Forms.Label();
            this.DateTimePickerBank = new System.Windows.Forms.DateTimePicker();
            this.cbBank = new System.Windows.Forms.ComboBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(20, 52);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(73, 49);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Validated += new System.EventHandler(this.txtAmount_TextValidated);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 19);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // dateTimePickerReception
            // 
            this.dateTimePickerReception.Location = new System.Drawing.Point(73, 115);
            this.dateTimePickerReception.Name = "dateTimePickerReception";
            this.dateTimePickerReception.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReception.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 121);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 152);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 20);
            this.txtName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 155);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // txtDebt
            // 
            this.txtDebt.Location = new System.Drawing.Point(73, 80);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.Size = new System.Drawing.Size(122, 20);
            this.txtDebt.TabIndex = 9;
            // 
            // lblDebt
            // 
            this.lblDebt.AutoSize = true;
            this.lblDebt.Location = new System.Drawing.Point(21, 83);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(30, 13);
            this.lblDebt.TabIndex = 8;
            this.lblDebt.Text = "Debt";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(24, 277);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Transfert"});
            this.cbType.Location = new System.Drawing.Point(73, 16);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 11;
            // 
            // lblPutDate
            // 
            this.lblPutDate.AutoSize = true;
            this.lblPutDate.Location = new System.Drawing.Point(21, 191);
            this.lblPutDate.Name = "lblPutDate";
            this.lblPutDate.Size = new System.Drawing.Size(46, 13);
            this.lblPutDate.TabIndex = 14;
            this.lblPutDate.Text = "PutDate";
            // 
            // DateTimePickerBank
            // 
            this.DateTimePickerBank.Location = new System.Drawing.Point(73, 185);
            this.DateTimePickerBank.Name = "DateTimePickerBank";
            this.DateTimePickerBank.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerBank.TabIndex = 13;
            // 
            // cbBank
            // 
            this.cbBank.FormattingEnabled = true;
            this.cbBank.Items.AddRange(new object[] {
            "None",
            "Academy",
            "Perso"});
            this.cbBank.Location = new System.Drawing.Point(73, 223);
            this.cbBank.Name = "cbBank";
            this.cbBank.Size = new System.Drawing.Size(121, 21);
            this.cbBank.TabIndex = 15;
            this.cbBank.SelectedValueChanged += new System.EventHandler(this.cbBank_SelectedValueChanged);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(24, 226);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(32, 13);
            this.lblBank.TabIndex = 16;
            this.lblBank.Text = "Bank";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 324);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.cbBank);
            this.Controls.Add(this.lblPutDate);
            this.Controls.Add(this.DateTimePickerBank);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDebt);
            this.Controls.Add(this.lblDebt);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePickerReception);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DateTimePicker dateTimePickerReception;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblPutDate;
        private System.Windows.Forms.DateTimePicker DateTimePickerBank;
        private System.Windows.Forms.ComboBox cbBank;
        private System.Windows.Forms.Label lblBank;
    }
}