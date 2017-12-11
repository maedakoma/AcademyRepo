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
            this.btnAddRefund = new System.Windows.Forms.Button();
            this.btnDelRefund = new System.Windows.Forms.Button();
            this.gridRefunds = new System.Windows.Forms.DataGridView();
            this.tabSeminars = new System.Windows.Forms.TabPage();
            this.gridSeminars = new System.Windows.Forms.DataGridView();
            this.tabPrivates = new System.Windows.Forms.TabPage();
            this.btnAddPrivate = new System.Windows.Forms.Button();
            this.gridPrivates = new System.Windows.Forms.DataGridView();
            this.tabCoachPay = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridCoachPay = new System.Windows.Forms.DataGridView();
            this.tabResume = new System.Windows.Forms.TabPage();
            this.txtPrevOfficialMonth = new System.Windows.Forms.TextBox();
            this.txtPrevBlackMonth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalDebt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOfficialMonth = new System.Windows.Forms.TextBox();
            this.txtBlackMonth = new System.Windows.Forms.TextBox();
            this.txtTotalBenef = new System.Windows.Forms.TextBox();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.txtPaidDebt = new System.Windows.Forms.TextBox();
            this.txtTeacherPays = new System.Windows.Forms.TextBox();
            this.txtSeminarBenef = new System.Windows.Forms.TextBox();
            this.txtSeminarDebt = new System.Windows.Forms.TextBox();
            this.txtSeminar = new System.Windows.Forms.TextBox();
            this.txtPrivates = new System.Windows.Forms.TextBox();
            this.txtLicencesBenef = new System.Windows.Forms.TextBox();
            this.txtLicencesDebt = new System.Windows.Forms.TextBox();
            this.txtLicencesAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrivates = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkInactive = new System.Windows.Forms.CheckBox();
            this.tabMembersResume = new System.Windows.Forms.TabPage();
            this.txtMembersCount = new System.Windows.Forms.TextBox();
            this.lblMembers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabMembers.SuspendLayout();
            this.tabRefunds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRefunds)).BeginInit();
            this.tabSeminars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeminars)).BeginInit();
            this.tabPrivates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrivates)).BeginInit();
            this.tabCoachPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCoachPay)).BeginInit();
            this.tabResume.SuspendLayout();
            this.tabMembersResume.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Location = new System.Drawing.Point(116, 6);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.Size = new System.Drawing.Size(1163, 680);
            this.mainGrid.TabIndex = 0;
            this.mainGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mainGrid_CellMouseDoubleClick);
            this.mainGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.mainGrid_DataBindingComplete);
            // 
            // bntNewMember
            // 
            this.bntNewMember.Location = new System.Drawing.Point(3, 6);
            this.bntNewMember.Name = "bntNewMember";
            this.bntNewMember.Size = new System.Drawing.Size(107, 23);
            this.bntNewMember.TabIndex = 2;
            this.bntNewMember.Text = "Add new member";
            this.bntNewMember.UseVisualStyleBackColor = true;
            this.bntNewMember.Click += new System.EventHandler(this.bntNewMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(3, 35);
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
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(193, 24);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Montant des licences:";
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebt.Location = new System.Drawing.Point(6, 52);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(169, 24);
            this.lblTotalDebt.TabIndex = 5;
            this.lblTotalDebt.Text = "Dette des licences:";
            // 
            // lblBenef
            // 
            this.lblBenef.AutoSize = true;
            this.lblBenef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenef.Location = new System.Drawing.Point(6, 77);
            this.lblBenef.Name = "lblBenef";
            this.lblBenef.Size = new System.Drawing.Size(231, 24);
            this.lblBenef.TabIndex = 6;
            this.lblBenef.Text = "Benefice net des licences:";
            // 
            // lblPaidDebt
            // 
            this.lblPaidDebt.AutoSize = true;
            this.lblPaidDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidDebt.Location = new System.Drawing.Point(7, 406);
            this.lblPaidDebt.Name = "lblPaidDebt";
            this.lblPaidDebt.Size = new System.Drawing.Size(156, 24);
            this.lblPaidDebt.TabIndex = 7;
            this.lblPaidDebt.Text = "Dette déja payée:";
            // 
            // lblStillDebt
            // 
            this.lblStillDebt.AutoSize = true;
            this.lblStillDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStillDebt.Location = new System.Drawing.Point(7, 432);
            this.lblStillDebt.Name = "lblStillDebt";
            this.lblStillDebt.Size = new System.Drawing.Size(129, 24);
            this.lblStillDebt.TabIndex = 8;
            this.lblStillDebt.Text = "Dette restante:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabMembers);
            this.tabControl1.Controls.Add(this.tabRefunds);
            this.tabControl1.Controls.Add(this.tabSeminars);
            this.tabControl1.Controls.Add(this.tabPrivates);
            this.tabControl1.Controls.Add(this.tabCoachPay);
            this.tabControl1.Controls.Add(this.tabResume);
            this.tabControl1.Controls.Add(this.tabMembersResume);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(75, 28);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1293, 728);
            this.tabControl1.TabIndex = 9;
            // 
            // tabMembers
            // 
            this.tabMembers.Controls.Add(this.chkInactive);
            this.tabMembers.Controls.Add(this.mainGrid);
            this.tabMembers.Controls.Add(this.bntNewMember);
            this.tabMembers.Controls.Add(this.btnDeleteMember);
            this.tabMembers.Location = new System.Drawing.Point(4, 32);
            this.tabMembers.Name = "tabMembers";
            this.tabMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabMembers.Size = new System.Drawing.Size(1285, 692);
            this.tabMembers.TabIndex = 0;
            this.tabMembers.Text = "Members";
            this.tabMembers.UseVisualStyleBackColor = true;
            this.tabMembers.Enter += new System.EventHandler(this.tabMembers_Enter);
            // 
            // tabRefunds
            // 
            this.tabRefunds.Controls.Add(this.btnAddRefund);
            this.tabRefunds.Controls.Add(this.btnDelRefund);
            this.tabRefunds.Controls.Add(this.gridRefunds);
            this.tabRefunds.Location = new System.Drawing.Point(4, 22);
            this.tabRefunds.Name = "tabRefunds";
            this.tabRefunds.Padding = new System.Windows.Forms.Padding(3);
            this.tabRefunds.Size = new System.Drawing.Size(1285, 702);
            this.tabRefunds.TabIndex = 1;
            this.tabRefunds.Text = "Refunds";
            this.tabRefunds.UseVisualStyleBackColor = true;
            this.tabRefunds.Enter += new System.EventHandler(this.tabRefunds_Enter);
            // 
            // btnAddRefund
            // 
            this.btnAddRefund.Location = new System.Drawing.Point(5, 6);
            this.btnAddRefund.Name = "btnAddRefund";
            this.btnAddRefund.Size = new System.Drawing.Size(107, 23);
            this.btnAddRefund.TabIndex = 4;
            this.btnAddRefund.Text = "Add new refund";
            this.btnAddRefund.UseVisualStyleBackColor = true;
            this.btnAddRefund.Click += new System.EventHandler(this.btnAddRefund_Click);
            // 
            // btnDelRefund
            // 
            this.btnDelRefund.Location = new System.Drawing.Point(5, 35);
            this.btnDelRefund.Name = "btnDelRefund";
            this.btnDelRefund.Size = new System.Drawing.Size(107, 23);
            this.btnDelRefund.TabIndex = 5;
            this.btnDelRefund.Text = "Delete refund";
            this.btnDelRefund.UseVisualStyleBackColor = true;
            this.btnDelRefund.Click += new System.EventHandler(this.btnDelRefund_Click);
            // 
            // gridRefunds
            // 
            this.gridRefunds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRefunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRefunds.Location = new System.Drawing.Point(118, 6);
            this.gridRefunds.Name = "gridRefunds";
            this.gridRefunds.Size = new System.Drawing.Size(1161, 690);
            this.gridRefunds.TabIndex = 0;
            this.gridRefunds.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridRefunds_CellMouseDoubleClick);
            // 
            // tabSeminars
            // 
            this.tabSeminars.Controls.Add(this.gridSeminars);
            this.tabSeminars.Location = new System.Drawing.Point(4, 22);
            this.tabSeminars.Name = "tabSeminars";
            this.tabSeminars.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeminars.Size = new System.Drawing.Size(1285, 702);
            this.tabSeminars.TabIndex = 2;
            this.tabSeminars.Text = "Seminars";
            this.tabSeminars.UseVisualStyleBackColor = true;
            this.tabSeminars.Enter += new System.EventHandler(this.tabSeminars_Enter);
            // 
            // gridSeminars
            // 
            this.gridSeminars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSeminars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSeminars.Location = new System.Drawing.Point(117, 6);
            this.gridSeminars.Name = "gridSeminars";
            this.gridSeminars.Size = new System.Drawing.Size(1162, 690);
            this.gridSeminars.TabIndex = 0;
            // 
            // tabPrivates
            // 
            this.tabPrivates.Controls.Add(this.btnAddPrivate);
            this.tabPrivates.Controls.Add(this.gridPrivates);
            this.tabPrivates.Location = new System.Drawing.Point(4, 22);
            this.tabPrivates.Name = "tabPrivates";
            this.tabPrivates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrivates.Size = new System.Drawing.Size(1285, 702);
            this.tabPrivates.TabIndex = 3;
            this.tabPrivates.Text = "Privates";
            this.tabPrivates.UseVisualStyleBackColor = true;
            this.tabPrivates.Enter += new System.EventHandler(this.tabPrivates_Enter);
            // 
            // btnAddPrivate
            // 
            this.btnAddPrivate.Location = new System.Drawing.Point(7, 16);
            this.btnAddPrivate.Name = "btnAddPrivate";
            this.btnAddPrivate.Size = new System.Drawing.Size(106, 23);
            this.btnAddPrivate.TabIndex = 1;
            this.btnAddPrivate.Text = "Add private";
            this.btnAddPrivate.UseVisualStyleBackColor = true;
            this.btnAddPrivate.Click += new System.EventHandler(this.btnAddPrivate_Click);
            // 
            // gridPrivates
            // 
            this.gridPrivates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPrivates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrivates.Location = new System.Drawing.Point(119, 6);
            this.gridPrivates.Name = "gridPrivates";
            this.gridPrivates.Size = new System.Drawing.Size(1160, 690);
            this.gridPrivates.TabIndex = 0;
            this.gridPrivates.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPrivates_CellMouseDoubleClick);
            this.gridPrivates.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.privateGrid_DataBindingComplete);
            // 
            // tabCoachPay
            // 
            this.tabCoachPay.Controls.Add(this.btnAdd);
            this.tabCoachPay.Controls.Add(this.gridCoachPay);
            this.tabCoachPay.Location = new System.Drawing.Point(4, 22);
            this.tabCoachPay.Name = "tabCoachPay";
            this.tabCoachPay.Padding = new System.Windows.Forms.Padding(3);
            this.tabCoachPay.Size = new System.Drawing.Size(1285, 702);
            this.tabCoachPay.TabIndex = 5;
            this.tabCoachPay.Text = "Coach Pay";
            this.tabCoachPay.UseVisualStyleBackColor = true;
            this.tabCoachPay.Enter += new System.EventHandler(this.tabCoachPay_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add new Payment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddCoachPayment_Click);
            // 
            // gridCoachPay
            // 
            this.gridCoachPay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCoachPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCoachPay.Location = new System.Drawing.Point(119, 6);
            this.gridCoachPay.Name = "gridCoachPay";
            this.gridCoachPay.Size = new System.Drawing.Size(1160, 690);
            this.gridCoachPay.TabIndex = 0;
            this.gridCoachPay.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCoachPay_CellMouseDoubleClick);
            // 
            // tabResume
            // 
            this.tabResume.Controls.Add(this.txtPrevOfficialMonth);
            this.tabResume.Controls.Add(this.txtPrevBlackMonth);
            this.tabResume.Controls.Add(this.label10);
            this.tabResume.Controls.Add(this.label11);
            this.tabResume.Controls.Add(this.txtTotalDebt);
            this.tabResume.Controls.Add(this.label9);
            this.tabResume.Controls.Add(this.txtOfficialMonth);
            this.tabResume.Controls.Add(this.txtBlackMonth);
            this.tabResume.Controls.Add(this.txtTotalBenef);
            this.tabResume.Controls.Add(this.txtDebt);
            this.tabResume.Controls.Add(this.txtPaidDebt);
            this.tabResume.Controls.Add(this.txtTeacherPays);
            this.tabResume.Controls.Add(this.txtSeminarBenef);
            this.tabResume.Controls.Add(this.txtSeminarDebt);
            this.tabResume.Controls.Add(this.txtSeminar);
            this.tabResume.Controls.Add(this.txtPrivates);
            this.tabResume.Controls.Add(this.txtLicencesBenef);
            this.tabResume.Controls.Add(this.txtLicencesDebt);
            this.tabResume.Controls.Add(this.txtLicencesAmount);
            this.tabResume.Controls.Add(this.label8);
            this.tabResume.Controls.Add(this.label7);
            this.tabResume.Controls.Add(this.label6);
            this.tabResume.Controls.Add(this.label5);
            this.tabResume.Controls.Add(this.lblPrivates);
            this.tabResume.Controls.Add(this.label3);
            this.tabResume.Controls.Add(this.label2);
            this.tabResume.Controls.Add(this.label1);
            this.tabResume.Controls.Add(this.lblStillDebt);
            this.tabResume.Controls.Add(this.lblTotal);
            this.tabResume.Controls.Add(this.lblPaidDebt);
            this.tabResume.Controls.Add(this.lblTotalDebt);
            this.tabResume.Controls.Add(this.lblBenef);
            this.tabResume.Location = new System.Drawing.Point(4, 22);
            this.tabResume.Name = "tabResume";
            this.tabResume.Padding = new System.Windows.Forms.Padding(3);
            this.tabResume.Size = new System.Drawing.Size(1285, 702);
            this.tabResume.TabIndex = 4;
            this.tabResume.Text = "Financial resume";
            this.tabResume.UseVisualStyleBackColor = true;
            this.tabResume.Enter += new System.EventHandler(this.tabResume_Enter);
            // 
            // txtPrevOfficialMonth
            // 
            this.txtPrevOfficialMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrevOfficialMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevOfficialMonth.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPrevOfficialMonth.Location = new System.Drawing.Point(550, 543);
            this.txtPrevOfficialMonth.Name = "txtPrevOfficialMonth";
            this.txtPrevOfficialMonth.Size = new System.Drawing.Size(100, 22);
            this.txtPrevOfficialMonth.TabIndex = 36;
            // 
            // txtPrevBlackMonth
            // 
            this.txtPrevBlackMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrevBlackMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevBlackMonth.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPrevBlackMonth.Location = new System.Drawing.Point(550, 517);
            this.txtPrevBlackMonth.Name = "txtPrevBlackMonth";
            this.txtPrevBlackMonth.Size = new System.Drawing.Size(100, 22);
            this.txtPrevBlackMonth.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(328, 546);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 24);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mensuel prévu déclaré:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(328, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 24);
            this.label11.TabIndex = 33;
            this.label11.Text = "Mensuel prevu au black:";
            // 
            // txtTotalDebt
            // 
            this.txtTotalDebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDebt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotalDebt.Location = new System.Drawing.Point(177, 372);
            this.txtTotalDebt.Name = "txtTotalDebt";
            this.txtTotalDebt.Size = new System.Drawing.Size(100, 22);
            this.txtTotalDebt.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Dette totale:";
            // 
            // txtOfficialMonth
            // 
            this.txtOfficialMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOfficialMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfficialMonth.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtOfficialMonth.Location = new System.Drawing.Point(182, 543);
            this.txtOfficialMonth.Name = "txtOfficialMonth";
            this.txtOfficialMonth.Size = new System.Drawing.Size(100, 22);
            this.txtOfficialMonth.TabIndex = 30;
            // 
            // txtBlackMonth
            // 
            this.txtBlackMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBlackMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlackMonth.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBlackMonth.Location = new System.Drawing.Point(182, 517);
            this.txtBlackMonth.Name = "txtBlackMonth";
            this.txtBlackMonth.Size = new System.Drawing.Size(100, 22);
            this.txtBlackMonth.TabIndex = 29;
            // 
            // txtTotalBenef
            // 
            this.txtTotalBenef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalBenef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBenef.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotalBenef.Location = new System.Drawing.Point(179, 476);
            this.txtTotalBenef.Name = "txtTotalBenef";
            this.txtTotalBenef.Size = new System.Drawing.Size(100, 22);
            this.txtTotalBenef.TabIndex = 28;
            // 
            // txtDebt
            // 
            this.txtDebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDebt.Location = new System.Drawing.Point(177, 425);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.Size = new System.Drawing.Size(100, 22);
            this.txtDebt.TabIndex = 27;
            // 
            // txtPaidDebt
            // 
            this.txtPaidDebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaidDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidDebt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPaidDebt.Location = new System.Drawing.Point(177, 399);
            this.txtPaidDebt.Name = "txtPaidDebt";
            this.txtPaidDebt.Size = new System.Drawing.Size(100, 22);
            this.txtPaidDebt.TabIndex = 26;
            // 
            // txtTeacherPays
            // 
            this.txtTeacherPays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeacherPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherPays.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTeacherPays.Location = new System.Drawing.Point(273, 301);
            this.txtTeacherPays.Name = "txtTeacherPays";
            this.txtTeacherPays.Size = new System.Drawing.Size(100, 22);
            this.txtTeacherPays.TabIndex = 25;
            // 
            // txtSeminarBenef
            // 
            this.txtSeminarBenef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeminarBenef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeminarBenef.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSeminarBenef.Location = new System.Drawing.Point(236, 249);
            this.txtSeminarBenef.Name = "txtSeminarBenef";
            this.txtSeminarBenef.Size = new System.Drawing.Size(100, 22);
            this.txtSeminarBenef.TabIndex = 24;
            // 
            // txtSeminarDebt
            // 
            this.txtSeminarDebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeminarDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeminarDebt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSeminarDebt.Location = new System.Drawing.Point(236, 223);
            this.txtSeminarDebt.Name = "txtSeminarDebt";
            this.txtSeminarDebt.Size = new System.Drawing.Size(100, 22);
            this.txtSeminarDebt.TabIndex = 23;
            // 
            // txtSeminar
            // 
            this.txtSeminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeminar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSeminar.Location = new System.Drawing.Point(236, 198);
            this.txtSeminar.Name = "txtSeminar";
            this.txtSeminar.Size = new System.Drawing.Size(100, 22);
            this.txtSeminar.TabIndex = 22;
            // 
            // txtPrivates
            // 
            this.txtPrivates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrivates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivates.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPrivates.Location = new System.Drawing.Point(282, 138);
            this.txtPrivates.Name = "txtPrivates";
            this.txtPrivates.Size = new System.Drawing.Size(100, 22);
            this.txtPrivates.TabIndex = 21;
            // 
            // txtLicencesBenef
            // 
            this.txtLicencesBenef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicencesBenef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicencesBenef.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtLicencesBenef.Location = new System.Drawing.Point(236, 77);
            this.txtLicencesBenef.Name = "txtLicencesBenef";
            this.txtLicencesBenef.Size = new System.Drawing.Size(100, 22);
            this.txtLicencesBenef.TabIndex = 20;
            // 
            // txtLicencesDebt
            // 
            this.txtLicencesDebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicencesDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicencesDebt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtLicencesDebt.Location = new System.Drawing.Point(236, 52);
            this.txtLicencesDebt.Name = "txtLicencesDebt";
            this.txtLicencesDebt.Size = new System.Drawing.Size(100, 22);
            this.txtLicencesDebt.TabIndex = 19;
            // 
            // txtLicencesAmount
            // 
            this.txtLicencesAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicencesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicencesAmount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtLicencesAmount.Location = new System.Drawing.Point(236, 27);
            this.txtLicencesAmount.Name = "txtLicencesAmount";
            this.txtLicencesAmount.Size = new System.Drawing.Size(100, 22);
            this.txtLicencesAmount.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mensuel déclaré:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mensuel au black:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bénéfice total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Salaire des profs déja payés:";
            // 
            // lblPrivates
            // 
            this.lblPrivates.AutoSize = true;
            this.lblPrivates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivates.Location = new System.Drawing.Point(6, 141);
            this.lblPrivates.Name = "lblPrivates";
            this.lblPrivates.Size = new System.Drawing.Size(265, 24);
            this.lblPrivates.TabIndex = 12;
            this.lblPrivates.Text = "Montant des cours particuliers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Benefice net des stages:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dette des stages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Montant des stages:";
            // 
            // chkInactive
            // 
            this.chkInactive.AutoSize = true;
            this.chkInactive.Location = new System.Drawing.Point(7, 65);
            this.chkInactive.Name = "chkInactive";
            this.chkInactive.Size = new System.Drawing.Size(94, 17);
            this.chkInactive.TabIndex = 4;
            this.chkInactive.Text = "Show Inactive";
            this.chkInactive.UseVisualStyleBackColor = true;
            this.chkInactive.CheckedChanged += new System.EventHandler(this.chkInactive_CheckedChanged);
            // 
            // tabMembersResume
            // 
            this.tabMembersResume.Controls.Add(this.txtMembersCount);
            this.tabMembersResume.Controls.Add(this.lblMembers);
            this.tabMembersResume.Location = new System.Drawing.Point(4, 22);
            this.tabMembersResume.Name = "tabMembersResume";
            this.tabMembersResume.Padding = new System.Windows.Forms.Padding(3);
            this.tabMembersResume.Size = new System.Drawing.Size(1285, 702);
            this.tabMembersResume.TabIndex = 6;
            this.tabMembersResume.Text = "Members Resume";
            this.tabMembersResume.UseVisualStyleBackColor = true;
            this.tabMembersResume.Enter += new System.EventHandler(this.tabMembersResume_Enter);
            // 
            // txtMembersCount
            // 
            this.txtMembersCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMembersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMembersCount.Location = new System.Drawing.Point(235, 27);
            this.txtMembersCount.Name = "txtMembersCount";
            this.txtMembersCount.Size = new System.Drawing.Size(100, 22);
            this.txtMembersCount.TabIndex = 19;
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembers.Location = new System.Drawing.Point(15, 27);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(205, 24);
            this.lblMembers.TabIndex = 18;
            this.lblMembers.Text = "Nombre d\'élèves actifs:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1340, 752);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Academy Cercle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMembers.ResumeLayout(false);
            this.tabMembers.PerformLayout();
            this.tabRefunds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRefunds)).EndInit();
            this.tabSeminars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSeminars)).EndInit();
            this.tabPrivates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrivates)).EndInit();
            this.tabCoachPay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCoachPay)).EndInit();
            this.tabResume.ResumeLayout(false);
            this.tabResume.PerformLayout();
            this.tabMembersResume.ResumeLayout(false);
            this.tabMembersResume.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mainGrid;
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
        private System.Windows.Forms.TabPage tabPrivates;
        private System.Windows.Forms.DataGridView gridPrivates;
        private System.Windows.Forms.TabPage tabResume;
        private System.Windows.Forms.TextBox txtOfficialMonth;
        private System.Windows.Forms.TextBox txtBlackMonth;
        private System.Windows.Forms.TextBox txtTotalBenef;
        private System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.TextBox txtPaidDebt;
        private System.Windows.Forms.TextBox txtTeacherPays;
        private System.Windows.Forms.TextBox txtSeminarBenef;
        private System.Windows.Forms.TextBox txtSeminarDebt;
        private System.Windows.Forms.TextBox txtSeminar;
        private System.Windows.Forms.TextBox txtPrivates;
        private System.Windows.Forms.TextBox txtLicencesBenef;
        private System.Windows.Forms.TextBox txtLicencesDebt;
        private System.Windows.Forms.TextBox txtLicencesAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrivates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalDebt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabCoachPay;
        private System.Windows.Forms.DataGridView gridCoachPay;
        private System.Windows.Forms.TextBox txtPrevOfficialMonth;
        private System.Windows.Forms.TextBox txtPrevBlackMonth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddPrivate;
        private System.Windows.Forms.Button btnAddRefund;
        private System.Windows.Forms.Button btnDelRefund;
        private System.Windows.Forms.CheckBox chkInactive;
        private System.Windows.Forms.TabPage tabMembersResume;
        private System.Windows.Forms.TextBox txtMembersCount;
        private System.Windows.Forms.Label lblMembers;
    }
}

