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
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Location = new System.Drawing.Point(361, 30);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.Size = new System.Drawing.Size(571, 448);
            this.mainGrid.TabIndex = 0;
            this.mainGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mainGrid_CellMouseDoubleClick);
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Location = new System.Drawing.Point(358, 498);
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
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(944, 567);
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
    }
}

