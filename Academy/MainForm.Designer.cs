namespace Academy
{
    partial class MainForm
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
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.lblMembers = new System.Windows.Forms.Label();
            this.bntNewMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            this.lblBenef = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Location = new System.Drawing.Point(149, 30);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.Size = new System.Drawing.Size(606, 448);
            this.mainGrid.TabIndex = 0;
            this.mainGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mainGrid_CellMouseDoubleClick);
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Location = new System.Drawing.Point(146, 495);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(60, 13);
            this.lblMembers.TabIndex = 1;
            this.lblMembers.Text = "lblMembers";
            // 
            // bntNewMember
            // 
            this.bntNewMember.Location = new System.Drawing.Point(12, 30);
            this.bntNewMember.Name = "bntNewMember";
            this.bntNewMember.Size = new System.Drawing.Size(107, 23);
            this.bntNewMember.TabIndex = 2;
            this.bntNewMember.Text = "Add new member";
            this.bntNewMember.UseVisualStyleBackColor = true;
            this.bntNewMember.Click += new System.EventHandler(this.bntNewMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(12, 59);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteMember.TabIndex = 3;
            this.btnDeleteMember.Text = "Delete member";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(146, 523);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "lblTotalAmout";
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.Location = new System.Drawing.Point(146, 536);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(64, 13);
            this.lblTotalDebt.TabIndex = 5;
            this.lblTotalDebt.Text = "lblTotalDebt";
            // 
            // lblBenef
            // 
            this.lblBenef.AutoSize = true;
            this.lblBenef.Location = new System.Drawing.Point(146, 549);
            this.lblBenef.Name = "lblBenef";
            this.lblBenef.Size = new System.Drawing.Size(45, 13);
            this.lblBenef.TabIndex = 6;
            this.lblBenef.Text = "lblBenef";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(783, 590);
            this.Controls.Add(this.lblBenef);
            this.Controls.Add(this.lblTotalDebt);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.bntNewMember);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.mainGrid);
            this.Name = "MainForm";
            this.Text = "Academy Cercle";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainGrid;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Button bntNewMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalDebt;
        private System.Windows.Forms.Label lblBenef;
    }
}

