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
            this.lblPaidDebt = new System.Windows.Forms.Label();
            this.lblStillDebt = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.tabRefunds = new System.Windows.Forms.TabPage();
            this.tabSeminars = new System.Windows.Forms.TabPage();
            this.gridRefunds = new System.Windows.Forms.DataGridView();
            this.gridSeminars = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabMembers.SuspendLayout();
            this.tabRefunds.SuspendLayout();
            this.tabSeminars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRefunds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeminars)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Location = new System.Drawing.Point(119, 6);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.Size = new System.Drawing.Size(820, 612);
            this.mainGrid.TabIndex = 0;
            this.mainGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mainGrid_CellMouseDoubleClick);
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Location = new System.Drawing.Point(9, 99);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(60, 13);
            this.lblMembers.TabIndex = 1;
            this.lblMembers.Text = "lblMembers";
            // 
            // bntNewMember
            // 
            this.bntNewMember.Location = new System.Drawing.Point(6, 6);
            this.bntNewMember.Name = "bntNewMember";
            this.bntNewMember.Size = new System.Drawing.Size(107, 23);
            this.bntNewMember.TabIndex = 2;
            this.bntNewMember.Text = "Add new member";
            this.bntNewMember.UseVisualStyleBackColor = true;
            this.bntNewMember.Click += new System.EventHandler(this.bntNewMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(6, 37);
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
            this.lblTotal.Location = new System.Drawing.Point(9, 127);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "lblTotalAmout";
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.Location = new System.Drawing.Point(9, 140);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(64, 13);
            this.lblTotalDebt.TabIndex = 5;
            this.lblTotalDebt.Text = "lblTotalDebt";
            // 
            // lblBenef
            // 
            this.lblBenef.AutoSize = true;
            this.lblBenef.Location = new System.Drawing.Point(9, 153);
            this.lblBenef.Name = "lblBenef";
            this.lblBenef.Size = new System.Drawing.Size(45, 13);
            this.lblBenef.TabIndex = 6;
            this.lblBenef.Text = "lblBenef";
            // 
            // lblPaidDebt
            // 
            this.lblPaidDebt.AutoSize = true;
            this.lblPaidDebt.Location = new System.Drawing.Point(9, 166);
            this.lblPaidDebt.Name = "lblPaidDebt";
            this.lblPaidDebt.Size = new System.Drawing.Size(61, 13);
            this.lblPaidDebt.TabIndex = 7;
            this.lblPaidDebt.Text = "lblPaidDebt";
            // 
            // lblStillDebt
            // 
            this.lblStillDebt.AutoSize = true;
            this.lblStillDebt.Location = new System.Drawing.Point(9, 179);
            this.lblStillDebt.Name = "lblStillDebt";
            this.lblStillDebt.Size = new System.Drawing.Size(56, 13);
            this.lblStillDebt.TabIndex = 8;
            this.lblStillDebt.Text = "lblStillDebt";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMembers);
            this.tabControl1.Controls.Add(this.tabRefunds);
            this.tabControl1.Controls.Add(this.tabSeminars);
            this.tabControl1.Location = new System.Drawing.Point(150, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(953, 650);
            this.tabControl1.TabIndex = 9;
            // 
            // tabMembers
            // 
            this.tabMembers.Controls.Add(this.mainGrid);
            this.tabMembers.Controls.Add(this.bntNewMember);
            this.tabMembers.Controls.Add(this.btnDeleteMember);
            this.tabMembers.Location = new System.Drawing.Point(4, 22);
            this.tabMembers.Name = "tabMembers";
            this.tabMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabMembers.Size = new System.Drawing.Size(945, 624);
            this.tabMembers.TabIndex = 0;
            this.tabMembers.Text = "Members";
            this.tabMembers.UseVisualStyleBackColor = true;
            // 
            // tabRefunds
            // 
            this.tabRefunds.Controls.Add(this.gridRefunds);
            this.tabRefunds.Location = new System.Drawing.Point(4, 22);
            this.tabRefunds.Name = "tabRefunds";
            this.tabRefunds.Padding = new System.Windows.Forms.Padding(3);
            this.tabRefunds.Size = new System.Drawing.Size(945, 624);
            this.tabRefunds.TabIndex = 1;
            this.tabRefunds.Text = "Refunds";
            this.tabRefunds.UseVisualStyleBackColor = true;
            // 
            // tabSeminars
            // 
            this.tabSeminars.Controls.Add(this.gridSeminars);
            this.tabSeminars.Location = new System.Drawing.Point(4, 22);
            this.tabSeminars.Name = "tabSeminars";
            this.tabSeminars.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeminars.Size = new System.Drawing.Size(945, 624);
            this.tabSeminars.TabIndex = 2;
            this.tabSeminars.Text = "Seminars";
            this.tabSeminars.UseVisualStyleBackColor = true;
            // 
            // gridRefunds
            // 
            this.gridRefunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRefunds.Location = new System.Drawing.Point(134, 31);
            this.gridRefunds.Name = "gridRefunds";
            this.gridRefunds.Size = new System.Drawing.Size(762, 497);
            this.gridRefunds.TabIndex = 0;
            // 
            // gridSeminars
            // 
            this.gridSeminars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSeminars.Location = new System.Drawing.Point(159, 48);
            this.gridSeminars.Name = "gridSeminars";
            this.gridSeminars.Size = new System.Drawing.Size(769, 482);
            this.gridSeminars.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1615, 752);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblStillDebt);
            this.Controls.Add(this.lblPaidDebt);
            this.Controls.Add(this.lblBenef);
            this.Controls.Add(this.lblTotalDebt);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMembers);
            this.Name = "MainForm";
            this.Text = "Academy Cercle";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMembers.ResumeLayout(false);
            this.tabRefunds.ResumeLayout(false);
            this.tabSeminars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRefunds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeminars)).EndInit();
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
        private System.Windows.Forms.Label lblPaidDebt;
        private System.Windows.Forms.Label lblStillDebt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMembers;
        private System.Windows.Forms.TabPage tabRefunds;
        private System.Windows.Forms.TabPage tabSeminars;
        private System.Windows.Forms.DataGridView gridRefunds;
        private System.Windows.Forms.DataGridView gridSeminars;
    }
}

