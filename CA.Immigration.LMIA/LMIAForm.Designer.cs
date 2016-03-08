namespace CA.Immigration.LMIA
{
    partial class LMIAForm
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
            if(disposing && (components != null))
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabBase = new System.Windows.Forms.TabControl();
            this.tabAdvisor = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabApplication = new System.Windows.Forms.TabPage();
            this.tbcADandMedia = new System.Windows.Forms.TabControl();
            this.tbAD = new System.Windows.Forms.TabPage();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.stsEmployer = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsEmployee = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsAppId = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpSelectEmployer = new System.Windows.Forms.GroupBox();
            this.dgvEmployer = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblEmployer = new System.Windows.Forms.Label();
            this.chkEducation = new System.Windows.Forms.CheckedListBox();
            this.chkBenefit = new System.Windows.Forms.CheckedListBox();
            this.txtEmploymentTerm = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbESDCMainDuties = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ESDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtESDCMainduties = new System.Windows.Forms.TextBox();
            this.tbMainDuties = new System.Windows.Forms.TabPage();
            this.txtMainDuties = new System.Windows.Forms.TextBox();
            this.tbESDCQualification = new System.Windows.Forms.TabPage();
            this.txtESDCQualification = new System.Windows.Forms.TextBox();
            this.tbQualification = new System.Windows.Forms.TabPage();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.tbCompanyBrief = new System.Windows.Forms.TabPage();
            this.txtCompanyBrief = new System.Windows.Forms.TextBox();
            this.tbPositionSummary = new System.Windows.Forms.TabPage();
            this.txtPositionSummary = new System.Windows.Forms.TextBox();
            this.tbMedia = new System.Windows.Forms.TabPage();
            this.btnGoForPosting = new System.Windows.Forms.Button();
            this.dgvMedia = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbADPreview = new System.Windows.Forms.TabPage();
            this.txtJobAdPreview = new System.Windows.Forms.TextBox();
            this.lmFactors1 = new CA.Immigration.LMIA.LMFactors();
            this.indicators1 = new CA.Immigration.LMIA.Indicators();
            this.financial1 = new CA.Immigration.LMIA.financial();
            this.jobPosition1 = new CA.Immigration.LMIA.JobPosition();
            this.UCAppStream = new CA.Immigration.LMIA.ApplicationSteam();
            this.ucAddress1 = new CA.Immigration.LMIA.UCAddress();
            this.tabBase.SuspendLayout();
            this.tabAdvisor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabApplication.SuspendLayout();
            this.tbcADandMedia.SuspendLayout();
            this.tbAD.SuspendLayout();
            this.stsStatus.SuspendLayout();
            this.grpSelectEmployer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployer)).BeginInit();
            this.tbESDCMainDuties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbMainDuties.SuspendLayout();
            this.tbESDCQualification.SuspendLayout();
            this.tbQualification.SuspendLayout();
            this.tbCompanyBrief.SuspendLayout();
            this.tbPositionSummary.SuspendLayout();
            this.tbMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).BeginInit();
            this.tbADPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBase
            // 
            this.tabBase.Controls.Add(this.tabAdvisor);
            this.tabBase.Controls.Add(this.tabApplication);
            this.tabBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBase.Location = new System.Drawing.Point(0, 0);
            this.tabBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabBase.Name = "tabBase";
            this.tabBase.SelectedIndex = 0;
            this.tabBase.Size = new System.Drawing.Size(1498, 1221);
            this.tabBase.TabIndex = 0;
            // 
            // tabAdvisor
            // 
            this.tabAdvisor.CausesValidation = false;
            this.tabAdvisor.Controls.Add(this.groupBox1);
            this.tabAdvisor.Controls.Add(this.lmFactors1);
            this.tabAdvisor.Controls.Add(this.indicators1);
            this.tabAdvisor.Controls.Add(this.financial1);
            this.tabAdvisor.Controls.Add(this.jobPosition1);
            this.tabAdvisor.Controls.Add(this.UCAppStream);
            this.tabAdvisor.Location = new System.Drawing.Point(4, 29);
            this.tabAdvisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAdvisor.Name = "tabAdvisor";
            this.tabAdvisor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAdvisor.Size = new System.Drawing.Size(1490, 1188);
            this.tabAdvisor.TabIndex = 0;
            this.tabAdvisor.Text = "Advisor";
            this.tabAdvisor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(549, 531);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(918, 545);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reasonable Employment Need";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "The impact of the current situation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "The situation the employer is currely facing";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(0, 334);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(916, 209);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(918, 184);
            this.textBox1.TabIndex = 0;
            // 
            // tabApplication
            // 
            this.tabApplication.Controls.Add(this.tbcADandMedia);
            this.tabApplication.Location = new System.Drawing.Point(4, 29);
            this.tabApplication.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabApplication.Name = "tabApplication";
            this.tabApplication.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabApplication.Size = new System.Drawing.Size(1490, 1104);
            this.tabApplication.TabIndex = 1;
            this.tabApplication.Text = "Application";
            this.tabApplication.UseVisualStyleBackColor = true;
            // 
            // tbcADandMedia
            // 
            this.tbcADandMedia.Controls.Add(this.tbAD);
            this.tbcADandMedia.Controls.Add(this.tbESDCMainDuties);
            this.tbcADandMedia.Controls.Add(this.tbMainDuties);
            this.tbcADandMedia.Controls.Add(this.tbESDCQualification);
            this.tbcADandMedia.Controls.Add(this.tbQualification);
            this.tbcADandMedia.Controls.Add(this.tbCompanyBrief);
            this.tbcADandMedia.Controls.Add(this.tbPositionSummary);
            this.tbcADandMedia.Controls.Add(this.tbMedia);
            this.tbcADandMedia.Controls.Add(this.tbADPreview);
            this.tbcADandMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcADandMedia.Location = new System.Drawing.Point(4, 5);
            this.tbcADandMedia.Name = "tbcADandMedia";
            this.tbcADandMedia.SelectedIndex = 0;
            this.tbcADandMedia.Size = new System.Drawing.Size(1482, 1094);
            this.tbcADandMedia.TabIndex = 5;
            // 
            // tbAD
            // 
            this.tbAD.BackColor = System.Drawing.Color.White;
            this.tbAD.Controls.Add(this.ucAddress1);
            this.tbAD.Controls.Add(this.stsStatus);
            this.tbAD.Controls.Add(this.grpSelectEmployer);
            this.tbAD.Controls.Add(this.chkEducation);
            this.tbAD.Controls.Add(this.chkBenefit);
            this.tbAD.Controls.Add(this.txtEmploymentTerm);
            this.tbAD.Controls.Add(this.label14);
            this.tbAD.Controls.Add(this.label13);
            this.tbAD.Controls.Add(this.label3);
            this.tbAD.Controls.Add(this.textBox6);
            this.tbAD.Controls.Add(this.label16);
            this.tbAD.Location = new System.Drawing.Point(4, 29);
            this.tbAD.Name = "tbAD";
            this.tbAD.Padding = new System.Windows.Forms.Padding(3);
            this.tbAD.Size = new System.Drawing.Size(1474, 1061);
            this.tbAD.TabIndex = 0;
            this.tbAD.Text = "Job AD";
            // 
            // stsStatus
            // 
            this.stsStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsEmployer,
            this.stsEmployee,
            this.stsAppId});
            this.stsStatus.Location = new System.Drawing.Point(3, 1036);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.stsStatus.Size = new System.Drawing.Size(1468, 22);
            this.stsStatus.TabIndex = 6;
            this.stsStatus.Text = "Status";
            // 
            // stsEmployer
            // 
            this.stsEmployer.Name = "stsEmployer";
            this.stsEmployer.Size = new System.Drawing.Size(0, 17);
            // 
            // stsEmployee
            // 
            this.stsEmployee.Name = "stsEmployee";
            this.stsEmployee.Size = new System.Drawing.Size(0, 17);
            // 
            // stsAppId
            // 
            this.stsAppId.Name = "stsAppId";
            this.stsAppId.Size = new System.Drawing.Size(0, 17);
            // 
            // grpSelectEmployer
            // 
            this.grpSelectEmployer.Controls.Add(this.dgvEmployer);
            this.grpSelectEmployer.Controls.Add(this.textBox7);
            this.grpSelectEmployer.Controls.Add(this.lblEmployer);
            this.grpSelectEmployer.Location = new System.Drawing.Point(394, 375);
            this.grpSelectEmployer.Name = "grpSelectEmployer";
            this.grpSelectEmployer.Size = new System.Drawing.Size(936, 445);
            this.grpSelectEmployer.TabIndex = 4;
            this.grpSelectEmployer.TabStop = false;
            this.grpSelectEmployer.Text = "Select Employer from Database";
            // 
            // dgvEmployer
            // 
            this.dgvEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployer.Location = new System.Drawing.Point(6, 78);
            this.dgvEmployer.Name = "dgvEmployer";
            this.dgvEmployer.RowTemplate.Height = 28;
            this.dgvEmployer.Size = new System.Drawing.Size(924, 360);
            this.dgvEmployer.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(160, 35);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(230, 26);
            this.textBox7.TabIndex = 3;
            // 
            // lblEmployer
            // 
            this.lblEmployer.AutoSize = true;
            this.lblEmployer.Location = new System.Drawing.Point(14, 35);
            this.lblEmployer.Name = "lblEmployer";
            this.lblEmployer.Size = new System.Drawing.Size(121, 20);
            this.lblEmployer.TabIndex = 2;
            this.lblEmployer.Text = "Employer Name";
            // 
            // chkEducation
            // 
            this.chkEducation.CheckOnClick = true;
            this.chkEducation.FormattingEnabled = true;
            this.chkEducation.Items.AddRange(new object[] {
            "Doctorate/PhD",
            "Doctor of Medicine",
            "Master\'s Degree",
            "Bachelor\'s Degree",
            "College level diploma/certificate",
            "Apprenticeship diploma/certificate",
            "Trade diploma/certificate",
            "Secondary school",
            "Vocational school diploma/certificate",
            "No formal education requirement"});
            this.chkEducation.Location = new System.Drawing.Point(28, 586);
            this.chkEducation.Name = "chkEducation";
            this.chkEducation.Size = new System.Drawing.Size(296, 235);
            this.chkEducation.TabIndex = 3;
            // 
            // chkBenefit
            // 
            this.chkBenefit.CheckOnClick = true;
            this.chkBenefit.FormattingEnabled = true;
            this.chkBenefit.Items.AddRange(new object[] {
            "Disability insurance",
            "Dental insurance",
            "Pension",
            "Extended medical insurance"});
            this.chkBenefit.Location = new System.Drawing.Point(28, 411);
            this.chkBenefit.Name = "chkBenefit";
            this.chkBenefit.Size = new System.Drawing.Size(296, 88);
            this.chkBenefit.TabIndex = 3;
            // 
            // txtEmploymentTerm
            // 
            this.txtEmploymentTerm.Location = new System.Drawing.Point(590, 37);
            this.txtEmploymentTerm.Name = "txtEmploymentTerm";
            this.txtEmploymentTerm.Size = new System.Drawing.Size(230, 26);
            this.txtEmploymentTerm.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 545);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Education Requirement";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 369);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Benefit Package";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employment Term";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(171, 38);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(230, 26);
            this.textBox6.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Operating Name";
            // 
            // tbESDCMainDuties
            // 
            this.tbESDCMainDuties.Controls.Add(this.dataGridView1);
            this.tbESDCMainDuties.Controls.Add(this.txtESDCMainduties);
            this.tbESDCMainDuties.Location = new System.Drawing.Point(4, 29);
            this.tbESDCMainDuties.Name = "tbESDCMainDuties";
            this.tbESDCMainDuties.Padding = new System.Windows.Forms.Padding(3);
            this.tbESDCMainDuties.Size = new System.Drawing.Size(1474, 1061);
            this.tbESDCMainDuties.TabIndex = 1;
            this.tbESDCMainDuties.Text = "ESDC MainDuties";
            this.tbESDCMainDuties.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ESDC,
            this.JobDescription});
            this.dataGridView1.Location = new System.Drawing.Point(3, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1455, 526);
            this.dataGridView1.TabIndex = 2;
            // 
            // ESDC
            // 
            this.ESDC.HeaderText = "ESDC NOC Main Duties";
            this.ESDC.Name = "ESDC";
            this.ESDC.Width = 400;
            // 
            // JobDescription
            // 
            this.JobDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JobDescription.DefaultCellStyle = dataGridViewCellStyle1;
            this.JobDescription.HeaderText = "Position\'s job description";
            this.JobDescription.MinimumWidth = 100;
            this.JobDescription.Name = "JobDescription";
            // 
            // txtESDCMainduties
            // 
            this.txtESDCMainduties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtESDCMainduties.Location = new System.Drawing.Point(3, 3);
            this.txtESDCMainduties.Multiline = true;
            this.txtESDCMainduties.Name = "txtESDCMainduties";
            this.txtESDCMainduties.Size = new System.Drawing.Size(1468, 1055);
            this.txtESDCMainduties.TabIndex = 0;
            // 
            // tbMainDuties
            // 
            this.tbMainDuties.Controls.Add(this.txtMainDuties);
            this.tbMainDuties.Location = new System.Drawing.Point(4, 29);
            this.tbMainDuties.Name = "tbMainDuties";
            this.tbMainDuties.Padding = new System.Windows.Forms.Padding(3);
            this.tbMainDuties.Size = new System.Drawing.Size(1474, 1061);
            this.tbMainDuties.TabIndex = 2;
            this.tbMainDuties.Text = "Main Duties";
            this.tbMainDuties.UseVisualStyleBackColor = true;
            // 
            // txtMainDuties
            // 
            this.txtMainDuties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMainDuties.Location = new System.Drawing.Point(3, 3);
            this.txtMainDuties.Multiline = true;
            this.txtMainDuties.Name = "txtMainDuties";
            this.txtMainDuties.Size = new System.Drawing.Size(1468, 1055);
            this.txtMainDuties.TabIndex = 0;
            // 
            // tbESDCQualification
            // 
            this.tbESDCQualification.Controls.Add(this.txtESDCQualification);
            this.tbESDCQualification.Location = new System.Drawing.Point(4, 29);
            this.tbESDCQualification.Name = "tbESDCQualification";
            this.tbESDCQualification.Size = new System.Drawing.Size(1474, 1061);
            this.tbESDCQualification.TabIndex = 3;
            this.tbESDCQualification.Text = "ESDC Qualification";
            this.tbESDCQualification.UseVisualStyleBackColor = true;
            // 
            // txtESDCQualification
            // 
            this.txtESDCQualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtESDCQualification.Location = new System.Drawing.Point(0, 0);
            this.txtESDCQualification.Multiline = true;
            this.txtESDCQualification.Name = "txtESDCQualification";
            this.txtESDCQualification.Size = new System.Drawing.Size(1474, 1061);
            this.txtESDCQualification.TabIndex = 0;
            // 
            // tbQualification
            // 
            this.tbQualification.Controls.Add(this.txtQualification);
            this.tbQualification.Location = new System.Drawing.Point(4, 29);
            this.tbQualification.Name = "tbQualification";
            this.tbQualification.Size = new System.Drawing.Size(1474, 1061);
            this.tbQualification.TabIndex = 4;
            this.tbQualification.Text = "Qualification";
            this.tbQualification.UseVisualStyleBackColor = true;
            // 
            // txtQualification
            // 
            this.txtQualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQualification.Location = new System.Drawing.Point(0, 0);
            this.txtQualification.Multiline = true;
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(1474, 1061);
            this.txtQualification.TabIndex = 0;
            // 
            // tbCompanyBrief
            // 
            this.tbCompanyBrief.Controls.Add(this.txtCompanyBrief);
            this.tbCompanyBrief.Location = new System.Drawing.Point(4, 29);
            this.tbCompanyBrief.Name = "tbCompanyBrief";
            this.tbCompanyBrief.Size = new System.Drawing.Size(1474, 1061);
            this.tbCompanyBrief.TabIndex = 6;
            this.tbCompanyBrief.Text = "Company brief";
            this.tbCompanyBrief.UseVisualStyleBackColor = true;
            // 
            // txtCompanyBrief
            // 
            this.txtCompanyBrief.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCompanyBrief.Location = new System.Drawing.Point(0, 0);
            this.txtCompanyBrief.Multiline = true;
            this.txtCompanyBrief.Name = "txtCompanyBrief";
            this.txtCompanyBrief.Size = new System.Drawing.Size(1474, 1061);
            this.txtCompanyBrief.TabIndex = 0;
            // 
            // tbPositionSummary
            // 
            this.tbPositionSummary.Controls.Add(this.txtPositionSummary);
            this.tbPositionSummary.Location = new System.Drawing.Point(4, 29);
            this.tbPositionSummary.Name = "tbPositionSummary";
            this.tbPositionSummary.Size = new System.Drawing.Size(1474, 1061);
            this.tbPositionSummary.TabIndex = 7;
            this.tbPositionSummary.Text = "Position Summary";
            this.tbPositionSummary.UseVisualStyleBackColor = true;
            // 
            // txtPositionSummary
            // 
            this.txtPositionSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPositionSummary.Location = new System.Drawing.Point(0, 0);
            this.txtPositionSummary.Multiline = true;
            this.txtPositionSummary.Name = "txtPositionSummary";
            this.txtPositionSummary.Size = new System.Drawing.Size(1474, 1061);
            this.txtPositionSummary.TabIndex = 0;
            // 
            // tbMedia
            // 
            this.tbMedia.Controls.Add(this.btnGoForPosting);
            this.tbMedia.Controls.Add(this.dgvMedia);
            this.tbMedia.Controls.Add(this.label18);
            this.tbMedia.Controls.Add(this.label17);
            this.tbMedia.Controls.Add(this.label19);
            this.tbMedia.Controls.Add(this.label20);
            this.tbMedia.Location = new System.Drawing.Point(4, 29);
            this.tbMedia.Name = "tbMedia";
            this.tbMedia.Size = new System.Drawing.Size(1474, 1061);
            this.tbMedia.TabIndex = 5;
            this.tbMedia.Text = "Media Selection";
            this.tbMedia.UseVisualStyleBackColor = true;
            // 
            // btnGoForPosting
            // 
            this.btnGoForPosting.Location = new System.Drawing.Point(1244, 622);
            this.btnGoForPosting.Name = "btnGoForPosting";
            this.btnGoForPosting.Size = new System.Drawing.Size(171, 38);
            this.btnGoForPosting.TabIndex = 3;
            this.btnGoForPosting.Text = "Go Posting";
            this.btnGoForPosting.UseVisualStyleBackColor = true;
            // 
            // dgvMedia
            // 
            this.dgvMedia.AllowUserToOrderColumns = true;
            this.dgvMedia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedia.Location = new System.Drawing.Point(3, 3);
            this.dgvMedia.Name = "dgvMedia";
            this.dgvMedia.RowTemplate.Height = 28;
            this.dgvMedia.Size = new System.Drawing.Size(1464, 598);
            this.dgvMedia.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(747, 703);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "Official Media";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(514, 703);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Official Media";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(262, 703);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "Official Media";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(32, 703);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 20);
            this.label20.TabIndex = 1;
            this.label20.Text = "Official Media";
            // 
            // tbADPreview
            // 
            this.tbADPreview.Controls.Add(this.txtJobAdPreview);
            this.tbADPreview.Location = new System.Drawing.Point(4, 29);
            this.tbADPreview.Name = "tbADPreview";
            this.tbADPreview.Size = new System.Drawing.Size(1474, 1061);
            this.tbADPreview.TabIndex = 8;
            this.tbADPreview.Text = "Job AD Preview";
            this.tbADPreview.UseVisualStyleBackColor = true;
            // 
            // txtJobAdPreview
            // 
            this.txtJobAdPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJobAdPreview.Location = new System.Drawing.Point(0, 0);
            this.txtJobAdPreview.Multiline = true;
            this.txtJobAdPreview.Name = "txtJobAdPreview";
            this.txtJobAdPreview.Size = new System.Drawing.Size(1474, 1061);
            this.txtJobAdPreview.TabIndex = 0;
            // 
            // lmFactors1
            // 
            this.lmFactors1.Location = new System.Drawing.Point(27, 531);
            this.lmFactors1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lmFactors1.Name = "lmFactors1";
            this.lmFactors1.Size = new System.Drawing.Size(500, 546);
            this.lmFactors1.TabIndex = 5;
            // 
            // indicators1
            // 
            this.indicators1.Location = new System.Drawing.Point(1107, 126);
            this.indicators1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.indicators1.Name = "indicators1";
            this.indicators1.Size = new System.Drawing.Size(362, 400);
            this.indicators1.TabIndex = 4;
            // 
            // financial1
            // 
            this.financial1.Location = new System.Drawing.Point(18, 338);
            this.financial1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.financial1.Name = "financial1";
            this.financial1.Size = new System.Drawing.Size(1080, 188);
            this.financial1.TabIndex = 2;
            // 
            // jobPosition1
            // 
            this.jobPosition1.Location = new System.Drawing.Point(16, 125);
            this.jobPosition1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.jobPosition1.Name = "jobPosition1";
            this.jobPosition1.Size = new System.Drawing.Size(1082, 194);
            this.jobPosition1.TabIndex = 1;
            // 
            // UCAppStream
            // 
            this.UCAppStream.Location = new System.Drawing.Point(14, 11);
            this.UCAppStream.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.UCAppStream.Name = "UCAppStream";
            this.UCAppStream.Size = new System.Drawing.Size(1455, 106);
            this.UCAppStream.TabIndex = 0;
            // 
            // ucAddress1
            // 
            this.ucAddress1.AutoSize = true;
            this.ucAddress1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucAddress1.Location = new System.Drawing.Point(8, 91);
            this.ucAddress1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ucAddress1.Name = "ucAddress1";
            this.ucAddress1.Size = new System.Drawing.Size(1321, 212);
            this.ucAddress1.TabIndex = 7;
            // 
            // LMIAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 1221);
            this.Controls.Add(this.tabBase);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LMIAForm";
            this.Text = "LMIAForm";
            this.Load += new System.EventHandler(this.LMIAForm_Load);
            this.tabBase.ResumeLayout(false);
            this.tabAdvisor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabApplication.ResumeLayout(false);
            this.tbcADandMedia.ResumeLayout(false);
            this.tbAD.ResumeLayout(false);
            this.tbAD.PerformLayout();
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.grpSelectEmployer.ResumeLayout(false);
            this.grpSelectEmployer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployer)).EndInit();
            this.tbESDCMainDuties.ResumeLayout(false);
            this.tbESDCMainDuties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbMainDuties.ResumeLayout(false);
            this.tbMainDuties.PerformLayout();
            this.tbESDCQualification.ResumeLayout(false);
            this.tbESDCQualification.PerformLayout();
            this.tbQualification.ResumeLayout(false);
            this.tbQualification.PerformLayout();
            this.tbCompanyBrief.ResumeLayout(false);
            this.tbCompanyBrief.PerformLayout();
            this.tbPositionSummary.ResumeLayout(false);
            this.tbPositionSummary.PerformLayout();
            this.tbMedia.ResumeLayout(false);
            this.tbMedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).EndInit();
            this.tbADPreview.ResumeLayout(false);
            this.tbADPreview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBase;
        private System.Windows.Forms.TabPage tabAdvisor;
        private financial financial1;
        private JobPosition jobPosition1;
        private ApplicationSteam UCAppStream;
        private System.Windows.Forms.TabPage tabApplication;
        private Indicators indicators1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private LMFactors lmFactors1;
        private System.Windows.Forms.TabControl tbcADandMedia;
        private System.Windows.Forms.TabPage tbAD;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel stsEmployer;
        private System.Windows.Forms.ToolStripStatusLabel stsEmployee;
        private System.Windows.Forms.ToolStripStatusLabel stsAppId;
        private System.Windows.Forms.GroupBox grpSelectEmployer;
        private System.Windows.Forms.DataGridView dgvEmployer;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblEmployer;
        private System.Windows.Forms.CheckedListBox chkEducation;
        private System.Windows.Forms.CheckedListBox chkBenefit;
        private System.Windows.Forms.TextBox txtEmploymentTerm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tbESDCMainDuties;
        private System.Windows.Forms.TextBox txtESDCMainduties;
        private System.Windows.Forms.TabPage tbMainDuties;
        private System.Windows.Forms.TextBox txtMainDuties;
        private System.Windows.Forms.TabPage tbESDCQualification;
        private System.Windows.Forms.TextBox txtESDCQualification;
        private System.Windows.Forms.TabPage tbQualification;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.TabPage tbCompanyBrief;
        private System.Windows.Forms.TextBox txtCompanyBrief;
        private System.Windows.Forms.TabPage tbPositionSummary;
        private System.Windows.Forms.TextBox txtPositionSummary;
        private System.Windows.Forms.TabPage tbMedia;
        private System.Windows.Forms.Button btnGoForPosting;
        private System.Windows.Forms.DataGridView dgvMedia;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tbADPreview;
        private System.Windows.Forms.TextBox txtJobAdPreview;
        private UCAddress ucAddress1;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESDC;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}