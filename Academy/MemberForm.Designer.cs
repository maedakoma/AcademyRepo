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
            this.txtBelt = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblPayments = new System.Windows.Forms.Label();
            this.payGrid = new System.Windows.Forms.DataGridView();
            this.btnAddPayment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.payGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(70, 6);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
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
            this.lblLastname.Location = new System.Drawing.Point(12, 48);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(53, 13);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "Lastname";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(70, 45);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 2;
            // 
            // lblBelt
            // 
            this.lblBelt.AutoSize = true;
            this.lblBelt.Location = new System.Drawing.Point(12, 82);
            this.lblBelt.Name = "lblBelt";
            this.lblBelt.Size = new System.Drawing.Size(25, 13);
            this.lblBelt.TabIndex = 5;
            this.lblBelt.Text = "Belt";
            // 
            // txtBelt
            // 
            this.txtBelt.Location = new System.Drawing.Point(70, 79);
            this.txtBelt.Name = "txtBelt";
            this.txtBelt.Size = new System.Drawing.Size(100, 20);
            this.txtBelt.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(15, 257);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Location = new System.Drawing.Point(12, 115);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(53, 13);
            this.lblPayments.TabIndex = 9;
            this.lblPayments.Text = "Payments";
            // 
            // payGrid
            // 
            this.payGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payGrid.Location = new System.Drawing.Point(15, 131);
            this.payGrid.Name = "payGrid";
            this.payGrid.Size = new System.Drawing.Size(352, 120);
            this.payGrid.TabIndex = 10;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(292, 257);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(75, 23);
            this.btnAddPayment.TabIndex = 11;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 299);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.payGrid);
            this.Controls.Add(this.lblPayments);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblBelt);
            this.Controls.Add(this.txtBelt);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.txtFirstname);
            this.Name = "MemberForm";
            this.Text = "MemberForm";
            ((System.ComponentModel.ISupportInitialize)(this.payGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblBelt;
        private System.Windows.Forms.TextBox txtBelt;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.DataGridView payGrid;
        private System.Windows.Forms.Button btnAddPayment;
    }
}