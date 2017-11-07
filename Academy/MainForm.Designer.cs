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
            this.txtMembersCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Location = new System.Drawing.Point(116, 6);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.Size = new System.Drawing.Size(1163, 690);
            this.mainGrid.TabIndex = 0;
            this.mainGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mainGrid_CellMouseDoubleClick);
            this.mainGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.mainGrid_DataBindingComplete);
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Location = new System.Drawing.Point(6, 27);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(117, 13);
            this.lblMembers.TabIndex = 1;
            this.lblMembers.Text = "Nombre d\'élèves actifs:";
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
            this.lblTotal.Location = new System.Drawing.Point(6, 52);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(111, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Montant des licences:";
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.Location = new System.Drawing.Point(6, 77);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(98, 13);
            this.lblTotalDebt.TabIndex = 5;
            this.lblTotalDebt.Text = "Dette des licences:";
            // 
            // lblBenef
            // 
            this.lblBenef.AutoSize = true;
            this.lblBenef.Location = new System.Drawing.Point(6, 102);
            this.lblBenef.Name = "lblBenef";
            this.lblBenef.Size = new System.Drawing.Size(132, 13);
            this.lblBenef.TabIndex = 6;
            this.lblBenef.Text = "Benefice net des licences:";
            // 
            // lblPaidDebt
            // 
            this.lblPaidDebt.AutoSize = true;
            this.lblPaidDebt.Location = new System.Drawing.Point(6, 254);
            this.lblPaidDebt.Name = "lblPaidDebt";
            this.lblPaidDebt.Size = new System.Drawing.Size(91, 13);
            this.lblPaidDebt.TabIndex = 7;
            this.lblPaidDebt.Text = "Dette déja payée:";
            // 
            // lblStillDebt
            // 
            this.lblStillDebt.AutoSize = true;
            this.lblStillDebt.Location = new System.Drawing.Point(6, 280);
            this.lblStillDebt.Name = "lblStillDebt";
            this.lblStillDebt.Size = new System.Drawing.Size(77, 13);
            this.lblStillDebt.TabIndex = 8;
            this.lblStillDebt.Text = "Dette restante:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMembers);
            this.tabControl1.Controls.Add(this.tabRefunds);
            this.tabControl1.Controls.Add(this.tabSeminars);
            this.tabControl1.Controls.Add(this.tabPrivates);
            this.tabControl1.Controls.Add(this.tabCoachPay);
            this.tabControl1.Controls.Add(this.tabResume);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1293, 728);
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
            this.tabMembers.Size = new System.Drawing.Size(1285, 702);
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
            this.tabRefunds.Size = new System.Drawing.Size(1285, 702);
            this.tabRefunds.TabIndex = 1;
            this.tabRefunds.Text = "Refunds";
            this.tabRefunds.UseVisualStyleBackColor = true;
            // 
            // gridRefunds
            // 
            this.gridRefunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRefunds.Location = new System.Drawing.Point(118, 6);
            this.gridRefunds.Name = "gridRefunds";
            this.gridRefunds.Size = new System.Drawing.Size(1161, 690);
            this.gridRefunds.TabIndex = 0;
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
            // 
            // gridSeminars
            // 
            this.gridSeminars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSeminars.Location = new System.Drawing.Point(118, 6);
            this.gridSeminars.Name = "gridSeminars";
            this.gridSeminars.Size = new System.Drawing.Size(1171, 690);
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
            this.gridPrivates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrivates.Location = new System.Drawing.Point(119, 6);
            this.gridPrivates.Name = "gridPrivates";
            this.gridPrivates.Size = new System.Drawing.Size(1160, 690);
            this.gridPrivates.TabIndex = 0;
            this.gridPrivates.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPrivates_CellMouseDoubleClick);
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
            this.tabResume.Controls.Add(this.txtMembersCount);
            this.tabResume.Controls.Add(this.label8);
            this.tabResume.Controls.Add(this.label7);
            this.tabResume.Controls.Add(this.label6);
            this.tabResume.Controls.Add(this.label5);
            this.tabResume.Controls.Add(this.label4);
            this.tabResume.Controls.Add(this.label3);
            this.tabResume.Controls.Add(this.label2);
            this.tabResume.Controls.Add(this.label1);
            this.tabResume.Controls.Add(this.lblMembers);
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
            this.tabResume.Text = "Resume";
            this.tabResume.UseVisualStyleBackColor = true;
            // 
            // txtPrevOfficialMonth
            // 
            this.txtPrevOfficialMonth.Location = new System.Drawing.Point(1139, 246);
            this.txtPrevOfficialMonth.Name = "txtPrevOfficialMonth";
            this.txtPrevOfficialMonth.Size = new System.Drawing.Size(100, 20);
            this.txtPrevOfficialMonth.TabIndex = 36;
            // 
            // txtPrevBlackMonth
            // 
            this.txtPrevBlackMonth.Location = new System.Drawing.Point(1139, 220);
            this.txtPrevBlackMonth.Name = "txtPrevBlackMonth";
            this.txtPrevBlackMonth.Size = new System.Drawing.Size(100, 20);
            this.txtPrevBlackMonth.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(969, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mensuel prévu déclaré:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(969, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Mensuel prevu au black:";
            // 
            // txtTotalDebt
            // 
            this.txtTotalDebt.Location = new System.Drawing.Point(176, 220);
            this.txtTotalDebt.Name = "txtTotalDebt";
            this.txtTotalDebt.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDebt.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Dette totale:";
            // 
            // txtOfficialMonth
            // 
            this.txtOfficialMonth.Location = new System.Drawing.Point(816, 246);
            this.txtOfficialMonth.Name = "txtOfficialMonth";
            this.txtOfficialMonth.Size = new System.Drawing.Size(100, 20);
            this.txtOfficialMonth.TabIndex = 30;
            // 
            // txtBlackMonth
            // 
            this.txtBlackMonth.Location = new System.Drawing.Point(816, 220);
            this.txtBlackMonth.Name = "txtBlackMonth";
            this.txtBlackMonth.Size = new System.Drawing.Size(100, 20);
            this.txtBlackMonth.TabIndex = 29;
            // 
            // txtTotalBenef
            // 
            this.txtTotalBenef.Location = new System.Drawing.Point(493, 220);
            this.txtTotalBenef.Name = "txtTotalBenef";
            this.txtTotalBenef.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBenef.TabIndex = 28;
            // 
            // txtDebt
            // 
            this.txtDebt.Location = new System.Drawing.Point(176, 273);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.Size = new System.Drawing.Size(100, 20);
            this.txtDebt.TabIndex = 27;
            // 
            // txtPaidDebt
            // 
            this.txtPaidDebt.Location = new System.Drawing.Point(176, 247);
            this.txtPaidDebt.Name = "txtPaidDebt";
            this.txtPaidDebt.Size = new System.Drawing.Size(100, 20);
            this.txtPaidDebt.TabIndex = 26;
            // 
            // txtTeacherPays
            // 
            this.txtTeacherPays.Location = new System.Drawing.Point(1139, 20);
            this.txtTeacherPays.Name = "txtTeacherPays";
            this.txtTeacherPays.Size = new System.Drawing.Size(100, 20);
            this.txtTeacherPays.TabIndex = 25;
            // 
            // txtSeminarBenef
            // 
            this.txtSeminarBenef.Location = new System.Drawing.Point(816, 71);
            this.txtSeminarBenef.Name = "txtSeminarBenef";
            this.txtSeminarBenef.Size = new System.Drawing.Size(100, 20);
            this.txtSeminarBenef.TabIndex = 24;
            // 
            // txtSeminarDebt
            // 
            this.txtSeminarDebt.Location = new System.Drawing.Point(816, 45);
            this.txtSeminarDebt.Name = "txtSeminarDebt";
            this.txtSeminarDebt.Size = new System.Drawing.Size(100, 20);
            this.txtSeminarDebt.TabIndex = 23;
            // 
            // txtSeminar
            // 
            this.txtSeminar.Location = new System.Drawing.Point(816, 20);
            this.txtSeminar.Name = "txtSeminar";
            this.txtSeminar.Size = new System.Drawing.Size(100, 20);
            this.txtSeminar.TabIndex = 22;
            // 
            // txtPrivates
            // 
            this.txtPrivates.Location = new System.Drawing.Point(493, 20);
            this.txtPrivates.Name = "txtPrivates";
            this.txtPrivates.Size = new System.Drawing.Size(100, 20);
            this.txtPrivates.TabIndex = 21;
            // 
            // txtLicencesBenef
            // 
            this.txtLicencesBenef.Location = new System.Drawing.Point(176, 95);
            this.txtLicencesBenef.Name = "txtLicencesBenef";
            this.txtLicencesBenef.Size = new System.Drawing.Size(100, 20);
            this.txtLicencesBenef.TabIndex = 20;
            // 
            // txtLicencesDebt
            // 
            this.txtLicencesDebt.Location = new System.Drawing.Point(176, 70);
            this.txtLicencesDebt.Name = "txtLicencesDebt";
            this.txtLicencesDebt.Size = new System.Drawing.Size(100, 20);
            this.txtLicencesDebt.TabIndex = 19;
            // 
            // txtLicencesAmount
            // 
            this.txtLicencesAmount.Location = new System.Drawing.Point(176, 45);
            this.txtLicencesAmount.Name = "txtLicencesAmount";
            this.txtLicencesAmount.Size = new System.Drawing.Size(100, 20);
            this.txtLicencesAmount.TabIndex = 18;
            // 
            // txtMembersCount
            // 
            this.txtMembersCount.Location = new System.Drawing.Point(176, 20);
            this.txtMembersCount.Name = "txtMembersCount";
            this.txtMembersCount.Size = new System.Drawing.Size(100, 20);
            this.txtMembersCount.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(646, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mensuel déclaré:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(646, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mensuel au black:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bénéfice total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(969, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Salaire des profs déja payés:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Montant des cours particuliers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Benefice net des stages:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dette des stages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Montant des stages:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1340, 752);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Academy Cercle";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMembers.ResumeLayout(false);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtMembersCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
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
    }
}

