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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLMIAEmployer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLMIAEmployee = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLMIARCIC = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLMIAProgram = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLMIAStream = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLMIAApplication = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabApplication = new System.Windows.Forms.TabPage();
            this.tabLMIAApplication = new System.Windows.Forms.TabControl();
            this.tabAD = new System.Windows.Forms.TabPage();
            this.txtOtherBenefit = new System.Windows.Forms.TextBox();
            this.lblOtherBenefit = new System.Windows.Forms.Label();
            this.cmbLMIAEduReq = new System.Windows.Forms.ComboBox();
            this.txtJobAdContactInfo = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.grpWorkLocation = new System.Windows.Forms.GroupBox();
            this.canadaProvincesJobAd = new CA.Immigration.Data.CanadaProvinces();
            this.label34 = new System.Windows.Forms.Label();
            this.txtJobAdPostCode = new System.Windows.Forms.TextBox();
            this.cmbWorkLocation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtJobAdUnit = new System.Windows.Forms.TextBox();
            this.txtJobAdCity = new System.Windows.Forms.TextBox();
            this.txtJobAdStreetNo = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtJobAdStreetName = new System.Windows.Forms.TextBox();
            this.btnJobAdPreview = new System.Windows.Forms.Button();
            this.btnJobAdClear = new System.Windows.Forms.Button();
            this.btnJobAdSave = new System.Windows.Forms.Button();
            this.grpJobAd = new System.Windows.Forms.GroupBox();
            this.txtJobAdPreview = new System.Windows.Forms.TextBox();
            this.chkJobAdBenefit = new System.Windows.Forms.CheckedListBox();
            this.txtEmploymentTerm = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMainDuties = new System.Windows.Forms.TabPage();
            this.btnNocSave = new System.Windows.Forms.Button();
            this.grpPositionMainDuties = new System.Windows.Forms.GroupBox();
            this.txtPositionMainDuties = new System.Windows.Forms.TextBox();
            this.grpESDCMainDuties = new System.Windows.Forms.GroupBox();
            this.txtNOCMainDuties = new System.Windows.Forms.TextBox();
            this.tabQualifications = new System.Windows.Forms.TabPage();
            this.grpPositionQualification = new System.Windows.Forms.GroupBox();
            this.grpSkill = new System.Windows.Forms.GroupBox();
            this.txtPositionSkillReq = new System.Windows.Forms.TextBox();
            this.grpLanguage = new System.Windows.Forms.GroupBox();
            this.txtPositionLanguage = new System.Windows.Forms.TextBox();
            this.grpOthers = new System.Windows.Forms.GroupBox();
            this.txtPositionOthers = new System.Windows.Forms.TextBox();
            this.grpWorkExp = new System.Windows.Forms.GroupBox();
            this.txtPositionWorkExp = new System.Windows.Forms.TextBox();
            this.grpESDCQualification = new System.Windows.Forms.GroupBox();
            this.txtESDCQualification = new System.Windows.Forms.TextBox();
            this.dbOpsQualification = new CA.Immigration.LMIA.DBOps();
            this.tabMedia = new System.Windows.Forms.TabPage();
            this.btnJobPostDelete = new System.Windows.Forms.Button();
            this.btnJobPostSave = new System.Windows.Forms.Button();
            this.dgvJobPost = new System.Windows.Forms.DataGridView();
            this.btnMediaSave = new System.Windows.Forms.Button();
            this.btnGoForPosting = new System.Windows.Forms.Button();
            this.dgvMedia = new System.Windows.Forms.DataGridView();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblSpecific = new System.Windows.Forms.Label();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.lblOfficial = new System.Windows.Forms.Label();
            this.tabJobOffer = new System.Windows.Forms.TabPage();
            this.dtpJobOfferStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnJobOfferClear = new System.Windows.Forms.Button();
            this.btnJobOfferSave = new System.Windows.Forms.Button();
            this.btnJobOfferWhentoOffer = new System.Windows.Forms.Button();
            this.txtJobOfferWhentoOffer = new System.Windows.Forms.TextBox();
            this.lblJobOfferWhentoOffer = new System.Windows.Forms.Label();
            this.btnJobOfferHowtoDetermine = new System.Windows.Forms.Button();
            this.txtJobOfferHowtoDetermine = new System.Windows.Forms.TextBox();
            this.lblJobOfferHowtoQualify = new System.Windows.Forms.Label();
            this.btnJobOfferHowDidYouFind = new System.Windows.Forms.Button();
            this.lblJobOfferHowDidYouFind = new System.Windows.Forms.Label();
            this.txtJobOfferHowDidYouFind = new System.Windows.Forms.TextBox();
            this.btnJobOfferWhoFillInTheJob = new System.Windows.Forms.Button();
            this.lblJobOfferWhoCurrentInThePosition = new System.Windows.Forms.Label();
            this.txtJobOfferWhoFillInThisJob = new System.Windows.Forms.TextBox();
            this.lblJobOfferProvideAssistant = new System.Windows.Forms.Label();
            this.txtJobOfferProvideAssistant = new System.Windows.Forms.TextBox();
            this.chkJobOfferProvideRentNA = new System.Windows.Forms.CheckBox();
            this.cmbJobOfferProvideRent = new System.Windows.Forms.ComboBox();
            this.lblJobOfferAccomodationDescription = new System.Windows.Forms.Label();
            this.lblJobOfferProvideRent = new System.Windows.Forms.Label();
            this.txtJobOfferAccomadationDescription = new System.Windows.Forms.TextBox();
            this.txtJobOfferProvideRent = new System.Windows.Forms.TextBox();
            this.chkJobOfferProvideAccomadation = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.txtJobOfferTrainCanadian = new System.Windows.Forms.TextBox();
            this.chkJobOfferTrainCanadian = new System.Windows.Forms.CheckBox();
            this.btnJobOfferRationale = new System.Windows.Forms.Button();
            this.txtJobOfferOfferRationale = new System.Windows.Forms.TextBox();
            this.lblJobOfferOfferRational = new System.Windows.Forms.Label();
            this.btnJobOfferBenefitDetails = new System.Windows.Forms.Button();
            this.txtJobOfferBenefitBrief = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.lblJobOfferJobCreation = new System.Windows.Forms.Label();
            this.lblJobOfferSkillTransfer = new System.Windows.Forms.Label();
            this.lblFillingLabourShortage = new System.Windows.Forms.Label();
            this.lblJobOfferPotentialBenifit = new System.Windows.Forms.Label();
            this.lblJobOfferRecruitCanadian = new System.Windows.Forms.Label();
            this.txtJobOfferRecruitCanadian = new System.Windows.Forms.TextBox();
            this.chkJobOfferRecruitCanadian = new System.Windows.Forms.CheckBox();
            this.lblJobOfferUnionConsulted = new System.Windows.Forms.Label();
            this.txtJobOfferUnionExpOrOpinion = new System.Windows.Forms.TextBox();
            this.chkJobOfferUnionConsulted = new System.Windows.Forms.CheckBox();
            this.chkJobOfferIsUnion = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtJobOfferUnionName = new System.Windows.Forms.TextBox();
            this.cmbJobOfferDWM = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtJobOfferHowlongLicense = new System.Windows.Forms.TextBox();
            this.chkJobOfferLicenseReady = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtJobOfferLicenseAuthority = new System.Windows.Forms.TextBox();
            this.chkJobOfferLicenseNeeded = new System.Windows.Forms.CheckBox();
            this.txtJobOfferOtherBenifits = new System.Windows.Forms.TextBox();
            this.lblJobOfferOtherBenifits = new System.Windows.Forms.Label();
            this.chkJobOfferFullDuration = new System.Windows.Forms.CheckBox();
            this.chkJobOfferSeasonal = new System.Windows.Forms.CheckBox();
            this.txtJobOfferRemuneraton = new System.Windows.Forms.TextBox();
            this.txtJobOfferVacationDays = new System.Windows.Forms.TextBox();
            this.txtJobOfferRemuneration = new System.Windows.Forms.TextBox();
            this.rdbJobOfferRemuneration = new System.Windows.Forms.RadioButton();
            this.rdbJobOfferVacationDays = new System.Windows.Forms.RadioButton();
            this.grpLMIALanguage = new System.Windows.Forms.GroupBox();
            this.chkLMIAOtherLanguage = new System.Windows.Forms.CheckBox();
            this.chkLMIAWritingEnglisAndFrench = new System.Windows.Forms.CheckBox();
            this.chkLMIAWritingEnglisOrFrench = new System.Windows.Forms.CheckBox();
            this.chkLMIAOralEnglisAndFrench = new System.Windows.Forms.CheckBox();
            this.chkLMIAWritingFrench = new System.Windows.Forms.CheckBox();
            this.chkLMIAOralEnglisOrFrench = new System.Windows.Forms.CheckBox();
            this.chkLMIAWritingEnglish = new System.Windows.Forms.CheckBox();
            this.chkLMIAOralFrench = new System.Windows.Forms.CheckBox();
            this.txtLMIAOtherLanguage = new System.Windows.Forms.TextBox();
            this.chkLIMAWriting = new System.Windows.Forms.CheckBox();
            this.chkLMIAoralEnglish = new System.Windows.Forms.CheckBox();
            this.chkLIMAOralEnglish = new System.Windows.Forms.CheckBox();
            this.chkLanguageRequired = new System.Windows.Forms.CheckBox();
            this.cmbDurationUnit = new System.Windows.Forms.ComboBox();
            this.txtJobOfferExpectedDuration = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtJobOfferDurationRationale = new System.Windows.Forms.TextBox();
            this.lblJobOfferDurationRationale = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtJobOfferNumberofTFW = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tabAdvisor = new System.Windows.Forms.TabPage();
            this.tbcSubAdvisor = new System.Windows.Forms.TabControl();
            this.tabAnalysis = new System.Windows.Forms.TabPage();
            this.grpApplicationStream = new System.Windows.Forms.GroupBox();
            this.cmbLMIAProgram = new System.Windows.Forms.ComboBox();
            this.txtAnotherEmployer = new System.Windows.Forms.TextBox();
            this.cmbStream = new System.Windows.Forms.ComboBox();
            this.ckbOtherEmployer = new System.Windows.Forms.CheckBox();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.lblAnotherEmployer = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.grpLabourMarketFactors = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.ckbLmFactor = new System.Windows.Forms.CheckedListBox();
            this.txtOccupationProfile = new System.Windows.Forms.TextBox();
            this.btnOccupationProfile = new System.Windows.Forms.Button();
            this.txtCOPSRating = new System.Windows.Forms.TextBox();
            this.btnCOPSRate = new System.Windows.Forms.Button();
            this.txtUnemployRate = new System.Windows.Forms.TextBox();
            this.btnUmemploymentRate = new System.Windows.Forms.Button();
            this.grpIndicator = new System.Windows.Forms.GroupBox();
            this.dgvQualificationIndicator = new System.Windows.Forms.DataGridView();
            this.CheckPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobPositionAdvisor = new CA.Immigration.LMIA.JobPosition();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSituationImpact = new System.Windows.Forms.TextBox();
            this.txtEmployerSituation = new System.Windows.Forms.TextBox();
            this.financialAdvisor = new CA.Immigration.LMIA.financial();
            this.btnAnalysisClear = new System.Windows.Forms.Button();
            this.btnAnalysisDelete = new System.Windows.Forms.Button();
            this.btnAnalysisUpdate = new System.Windows.Forms.Button();
            this.btnAnalysisInsert = new System.Windows.Forms.Button();
            this.tabBusinessDetails = new System.Windows.Forms.TabPage();
            this.btnUpdateBD = new System.Windows.Forms.Button();
            this.btnDeleteBD = new System.Windows.Forms.Button();
            this.btnBDClear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBizDetailQ10 = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.chkBizDetailQ10Explain = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.grpLayOff = new System.Windows.Forms.GroupBox();
            this.chkBizDetailQ9 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtLayoffCanadians = new System.Windows.Forms.TextBox();
            this.txtTFWs = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.chkBizDetailQ9Explain = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.grpLMIARecord = new System.Windows.Forms.GroupBox();
            this.DTPQ8 = new System.Windows.Forms.DateTimePicker();
            this.chkLMIAMisRep = new System.Windows.Forms.CheckBox();
            this.chkLMIACompliance1415 = new System.Windows.Forms.CheckBox();
            this.chkBizDetailQ8 = new System.Windows.Forms.CheckBox();
            this.chkLMIA1415 = new System.Windows.Forms.CheckBox();
            this.chkLMIACompliance1213 = new System.Windows.Forms.CheckBox();
            this.chkLMIA1213 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLMIASFN = new System.Windows.Forms.TextBox();
            this.txtLMIAPublicPolicy = new System.Windows.Forms.TextBox();
            this.grpEmployeeStructure = new System.Windows.Forms.GroupBox();
            this.txtBizDetailQ5 = new System.Windows.Forms.TextBox();
            this.txtBizDetailQ4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBizDetailQ3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBizDetailQ2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBizDetailQ1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabBase = new System.Windows.Forms.TabControl();
            this.statusStrip1.SuspendLayout();
            this.tabApplication.SuspendLayout();
            this.tabLMIAApplication.SuspendLayout();
            this.tabAD.SuspendLayout();
            this.grpWorkLocation.SuspendLayout();
            this.grpJobAd.SuspendLayout();
            this.tabMainDuties.SuspendLayout();
            this.grpPositionMainDuties.SuspendLayout();
            this.grpESDCMainDuties.SuspendLayout();
            this.tabQualifications.SuspendLayout();
            this.grpPositionQualification.SuspendLayout();
            this.grpSkill.SuspendLayout();
            this.grpLanguage.SuspendLayout();
            this.grpOthers.SuspendLayout();
            this.grpWorkExp.SuspendLayout();
            this.grpESDCQualification.SuspendLayout();
            this.tabMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).BeginInit();
            this.tabJobOffer.SuspendLayout();
            this.grpLMIALanguage.SuspendLayout();
            this.tabAdvisor.SuspendLayout();
            this.tbcSubAdvisor.SuspendLayout();
            this.tabAnalysis.SuspendLayout();
            this.grpApplicationStream.SuspendLayout();
            this.grpLabourMarketFactors.SuspendLayout();
            this.grpIndicator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualificationIndicator)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabBusinessDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpLayOff.SuspendLayout();
            this.grpLMIARecord.SuspendLayout();
            this.grpEmployeeStructure.SuspendLayout();
            this.tabBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLMIAEmployer,
            this.tssLMIAEmployee,
            this.tssLMIARCIC,
            this.tssLMIAProgram,
            this.tssLMIAStream,
            this.tssLMIAApplication});
            this.statusStrip1.Location = new System.Drawing.Point(0, 662);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(999, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssLMIAEmployer
            // 
            this.tssLMIAEmployer.Name = "tssLMIAEmployer";
            this.tssLMIAEmployer.Size = new System.Drawing.Size(65, 17);
            this.tssLMIAEmployer.Text = "Employer()";
            // 
            // tssLMIAEmployee
            // 
            this.tssLMIAEmployee.Name = "tssLMIAEmployee";
            this.tssLMIAEmployee.Size = new System.Drawing.Size(67, 17);
            this.tssLMIAEmployee.Text = "Employee()";
            // 
            // tssLMIARCIC
            // 
            this.tssLMIARCIC.Name = "tssLMIARCIC";
            this.tssLMIARCIC.Size = new System.Drawing.Size(41, 17);
            this.tssLMIARCIC.Text = "RCIC()";
            // 
            // tssLMIAProgram
            // 
            this.tssLMIAProgram.Name = "tssLMIAProgram";
            this.tssLMIAProgram.Size = new System.Drawing.Size(61, 17);
            this.tssLMIAProgram.Text = "Program()";
            // 
            // tssLMIAStream
            // 
            this.tssLMIAStream.Name = "tssLMIAStream";
            this.tssLMIAStream.Size = new System.Drawing.Size(52, 17);
            this.tssLMIAStream.Text = "Stream()";
            // 
            // tssLMIAApplication
            // 
            this.tssLMIAApplication.Name = "tssLMIAApplication";
            this.tssLMIAApplication.Size = new System.Drawing.Size(76, 17);
            this.tssLMIAApplication.Text = "Application()";
            // 
            // tabApplication
            // 
            this.tabApplication.Controls.Add(this.tabLMIAApplication);
            this.tabApplication.Location = new System.Drawing.Point(4, 22);
            this.tabApplication.Name = "tabApplication";
            this.tabApplication.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabApplication.Size = new System.Drawing.Size(991, 658);
            this.tabApplication.TabIndex = 1;
            this.tabApplication.Text = "Application";
            this.tabApplication.UseVisualStyleBackColor = true;
            // 
            // tabLMIAApplication
            // 
            this.tabLMIAApplication.Controls.Add(this.tabAD);
            this.tabLMIAApplication.Controls.Add(this.tabMainDuties);
            this.tabLMIAApplication.Controls.Add(this.tabQualifications);
            this.tabLMIAApplication.Controls.Add(this.tabMedia);
            this.tabLMIAApplication.Controls.Add(this.tabJobOffer);
            this.tabLMIAApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLMIAApplication.Location = new System.Drawing.Point(3, 3);
            this.tabLMIAApplication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabLMIAApplication.Name = "tabLMIAApplication";
            this.tabLMIAApplication.SelectedIndex = 0;
            this.tabLMIAApplication.Size = new System.Drawing.Size(985, 652);
            this.tabLMIAApplication.TabIndex = 5;
            // 
            // tabAD
            // 
            this.tabAD.AutoScroll = true;
            this.tabAD.BackColor = System.Drawing.Color.White;
            this.tabAD.Controls.Add(this.txtOtherBenefit);
            this.tabAD.Controls.Add(this.lblOtherBenefit);
            this.tabAD.Controls.Add(this.cmbLMIAEduReq);
            this.tabAD.Controls.Add(this.txtJobAdContactInfo);
            this.tabAD.Controls.Add(this.label35);
            this.tabAD.Controls.Add(this.grpWorkLocation);
            this.tabAD.Controls.Add(this.btnJobAdPreview);
            this.tabAD.Controls.Add(this.btnJobAdClear);
            this.tabAD.Controls.Add(this.btnJobAdSave);
            this.tabAD.Controls.Add(this.grpJobAd);
            this.tabAD.Controls.Add(this.chkJobAdBenefit);
            this.tabAD.Controls.Add(this.txtEmploymentTerm);
            this.tabAD.Controls.Add(this.label14);
            this.tabAD.Controls.Add(this.label13);
            this.tabAD.Controls.Add(this.label3);
            this.tabAD.Location = new System.Drawing.Point(4, 22);
            this.tabAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAD.Name = "tabAD";
            this.tabAD.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAD.Size = new System.Drawing.Size(977, 626);
            this.tabAD.TabIndex = 0;
            this.tabAD.Text = "Job AD";
            // 
            // txtOtherBenefit
            // 
            this.txtOtherBenefit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtOtherBenefit.Location = new System.Drawing.Point(4, 420);
            this.txtOtherBenefit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOtherBenefit.Multiline = true;
            this.txtOtherBenefit.Name = "txtOtherBenefit";
            this.txtOtherBenefit.Size = new System.Drawing.Size(209, 59);
            this.txtOtherBenefit.TabIndex = 39;
            // 
            // lblOtherBenefit
            // 
            this.lblOtherBenefit.AutoSize = true;
            this.lblOtherBenefit.Location = new System.Drawing.Point(3, 396);
            this.lblOtherBenefit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOtherBenefit.Name = "lblOtherBenefit";
            this.lblOtherBenefit.Size = new System.Drawing.Size(69, 13);
            this.lblOtherBenefit.TabIndex = 38;
            this.lblOtherBenefit.Text = "Other Benefit";
            // 
            // cmbLMIAEduReq
            // 
            this.cmbLMIAEduReq.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbLMIAEduReq.FormattingEnabled = true;
            this.cmbLMIAEduReq.Location = new System.Drawing.Point(7, 511);
            this.cmbLMIAEduReq.Name = "cmbLMIAEduReq";
            this.cmbLMIAEduReq.Size = new System.Drawing.Size(197, 21);
            this.cmbLMIAEduReq.TabIndex = 37;
            this.cmbLMIAEduReq.SelectionChangeCommitted += new System.EventHandler(this.cmbLMIAEduReq_SelectionChangeCommitted);
            // 
            // txtJobAdContactInfo
            // 
            this.txtJobAdContactInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobAdContactInfo.Location = new System.Drawing.Point(5, 565);
            this.txtJobAdContactInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJobAdContactInfo.Multiline = true;
            this.txtJobAdContactInfo.Name = "txtJobAdContactInfo";
            this.txtJobAdContactInfo.Size = new System.Drawing.Size(209, 129);
            this.txtJobAdContactInfo.TabIndex = 11;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(4, 541);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(99, 13);
            this.label35.TabIndex = 10;
            this.label35.Text = "Contact Information";
            // 
            // grpWorkLocation
            // 
            this.grpWorkLocation.Controls.Add(this.canadaProvincesJobAd);
            this.grpWorkLocation.Controls.Add(this.label34);
            this.grpWorkLocation.Controls.Add(this.txtJobAdPostCode);
            this.grpWorkLocation.Controls.Add(this.cmbWorkLocation);
            this.grpWorkLocation.Controls.Add(this.label5);
            this.grpWorkLocation.Controls.Add(this.label32);
            this.grpWorkLocation.Controls.Add(this.label4);
            this.grpWorkLocation.Controls.Add(this.label16);
            this.grpWorkLocation.Controls.Add(this.txtJobAdUnit);
            this.grpWorkLocation.Controls.Add(this.txtJobAdCity);
            this.grpWorkLocation.Controls.Add(this.txtJobAdStreetNo);
            this.grpWorkLocation.Controls.Add(this.label31);
            this.grpWorkLocation.Controls.Add(this.txtJobAdStreetName);
            this.grpWorkLocation.Location = new System.Drawing.Point(5, 5);
            this.grpWorkLocation.Name = "grpWorkLocation";
            this.grpWorkLocation.Size = new System.Drawing.Size(219, 246);
            this.grpWorkLocation.TabIndex = 1;
            this.grpWorkLocation.TabStop = false;
            this.grpWorkLocation.Text = "Work Location";
            // 
            // canadaProvincesJobAd
            // 
            this.canadaProvincesJobAd.Location = new System.Drawing.Point(6, 136);
            this.canadaProvincesJobAd.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.canadaProvincesJobAd.Name = "canadaProvincesJobAd";
            this.canadaProvincesJobAd.Size = new System.Drawing.Size(105, 31);
            this.canadaProvincesJobAd.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(7, 174);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(56, 13);
            this.label34.TabIndex = 36;
            this.label34.Text = "Post Code";
            // 
            // txtJobAdPostCode
            // 
            this.txtJobAdPostCode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobAdPostCode.Location = new System.Drawing.Point(75, 171);
            this.txtJobAdPostCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJobAdPostCode.Name = "txtJobAdPostCode";
            this.txtJobAdPostCode.Size = new System.Drawing.Size(120, 20);
            this.txtJobAdPostCode.TabIndex = 35;
            // 
            // cmbWorkLocation
            // 
            this.cmbWorkLocation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbWorkLocation.FormattingEnabled = true;
            this.cmbWorkLocation.Items.AddRange(new object[] {
            "Business Adress",
            "Mail Address"});
            this.cmbWorkLocation.Location = new System.Drawing.Point(60, 219);
            this.cmbWorkLocation.Name = "cmbWorkLocation";
            this.cmbWorkLocation.Size = new System.Drawing.Size(133, 21);
            this.cmbWorkLocation.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Same as";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(5, 27);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(47, 13);
            this.label32.TabIndex = 30;
            this.label32.Text = "Apt/Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Street Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 117);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "City";
            // 
            // txtJobAdUnit
            // 
            this.txtJobAdUnit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobAdUnit.Location = new System.Drawing.Point(60, 24);
            this.txtJobAdUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJobAdUnit.Name = "txtJobAdUnit";
            this.txtJobAdUnit.Size = new System.Drawing.Size(135, 20);
            this.txtJobAdUnit.TabIndex = 26;
            // 
            // txtJobAdCity
            // 
            this.txtJobAdCity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobAdCity.Location = new System.Drawing.Point(60, 114);
            this.txtJobAdCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJobAdCity.Name = "txtJobAdCity";
            this.txtJobAdCity.Size = new System.Drawing.Size(133, 20);
            this.txtJobAdCity.TabIndex = 24;
            // 
            // txtJobAdStreetNo
            // 
            this.txtJobAdStreetNo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobAdStreetNo.Location = new System.Drawing.Point(61, 53);
            this.txtJobAdStreetNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJobAdStreetNo.Name = "txtJobAdStreetNo";
            this.txtJobAdStreetNo.Size = new System.Drawing.Size(132, 20);
            this.txtJobAdStreetNo.TabIndex = 25;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 56);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(52, 13);
            this.label31.TabIndex = 29;
            this.label31.Text = "Street No";
            // 
            // txtJobAdStreetName
            // 
            this.txtJobAdStreetName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobAdStreetName.Location = new System.Drawing.Point(75, 83);
            this.txtJobAdStreetName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJobAdStreetName.Name = "txtJobAdStreetName";
            this.txtJobAdStreetName.Size = new System.Drawing.Size(118, 20);
            this.txtJobAdStreetName.TabIndex = 22;
            // 
            // btnJobAdPreview
            // 
            this.btnJobAdPreview.Location = new System.Drawing.Point(148, 697);
            this.btnJobAdPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJobAdPreview.Name = "btnJobAdPreview";
            this.btnJobAdPreview.Size = new System.Drawing.Size(63, 23);
            this.btnJobAdPreview.TabIndex = 9;
            this.btnJobAdPreview.Text = "Preview";
            this.btnJobAdPreview.UseVisualStyleBackColor = true;
            this.btnJobAdPreview.Click += new System.EventHandler(this.btnJobAdPreview_Click);
            // 
            // btnJobAdClear
            // 
            this.btnJobAdClear.Location = new System.Drawing.Point(80, 697);
            this.btnJobAdClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJobAdClear.Name = "btnJobAdClear";
            this.btnJobAdClear.Size = new System.Drawing.Size(51, 23);
            this.btnJobAdClear.TabIndex = 9;
            this.btnJobAdClear.Text = "Clear";
            this.btnJobAdClear.UseVisualStyleBackColor = true;
            this.btnJobAdClear.Click += new System.EventHandler(this.btnJobAdClear_Click);
            // 
            // btnJobAdSave
            // 
            this.btnJobAdSave.Location = new System.Drawing.Point(9, 697);
            this.btnJobAdSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJobAdSave.Name = "btnJobAdSave";
            this.btnJobAdSave.Size = new System.Drawing.Size(51, 23);
            this.btnJobAdSave.TabIndex = 9;
            this.btnJobAdSave.Text = "Save";
            this.btnJobAdSave.UseVisualStyleBackColor = true;
            this.btnJobAdSave.Click += new System.EventHandler(this.btnJobAdSave_Click);
            // 
            // grpJobAd
            // 
            this.grpJobAd.Controls.Add(this.txtJobAdPreview);
            this.grpJobAd.Location = new System.Drawing.Point(229, 4);
            this.grpJobAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpJobAd.Name = "grpJobAd";
            this.grpJobAd.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpJobAd.Size = new System.Drawing.Size(730, 716);
            this.grpJobAd.TabIndex = 8;
            this.grpJobAd.TabStop = false;
            this.grpJobAd.Text = "Job  Advertisement Preview";
            // 
            // txtJobAdPreview
            // 
            this.txtJobAdPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJobAdPreview.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobAdPreview.Location = new System.Drawing.Point(2, 15);
            this.txtJobAdPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJobAdPreview.Multiline = true;
            this.txtJobAdPreview.Name = "txtJobAdPreview";
            this.txtJobAdPreview.Size = new System.Drawing.Size(726, 699);
            this.txtJobAdPreview.TabIndex = 0;
            // 
            // chkJobAdBenefit
            // 
            this.chkJobAdBenefit.CheckOnClick = true;
            this.chkJobAdBenefit.FormattingEnabled = true;
            this.chkJobAdBenefit.Location = new System.Drawing.Point(3, 302);
            this.chkJobAdBenefit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkJobAdBenefit.Name = "chkJobAdBenefit";
            this.chkJobAdBenefit.Size = new System.Drawing.Size(199, 64);
            this.chkJobAdBenefit.TabIndex = 3;
            // 
            // txtEmploymentTerm
            // 
            this.txtEmploymentTerm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmploymentTerm.Location = new System.Drawing.Point(109, 256);
            this.txtEmploymentTerm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmploymentTerm.Name = "txtEmploymentTerm";
            this.txtEmploymentTerm.Size = new System.Drawing.Size(103, 20);
            this.txtEmploymentTerm.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 495);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Education Requirement";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 289);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Benefit Package";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employment Term";
            // 
            // tabMainDuties
            // 
            this.tabMainDuties.AutoScroll = true;
            this.tabMainDuties.Controls.Add(this.btnNocSave);
            this.tabMainDuties.Controls.Add(this.grpPositionMainDuties);
            this.tabMainDuties.Controls.Add(this.grpESDCMainDuties);
            this.tabMainDuties.Location = new System.Drawing.Point(4, 22);
            this.tabMainDuties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMainDuties.Name = "tabMainDuties";
            this.tabMainDuties.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMainDuties.Size = new System.Drawing.Size(980, 748);
            this.tabMainDuties.TabIndex = 3;
            this.tabMainDuties.Text = "Main Duties";
            this.tabMainDuties.UseVisualStyleBackColor = true;
            // 
            // btnNocSave
            // 
            this.btnNocSave.Location = new System.Drawing.Point(15, 648);
            this.btnNocSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNocSave.Name = "btnNocSave";
            this.btnNocSave.Size = new System.Drawing.Size(75, 25);
            this.btnNocSave.TabIndex = 8;
            this.btnNocSave.Text = "Save";
            this.btnNocSave.UseVisualStyleBackColor = true;
            this.btnNocSave.Click += new System.EventHandler(this.btnNocSave_Click);
            // 
            // grpPositionMainDuties
            // 
            this.grpPositionMainDuties.Controls.Add(this.txtPositionMainDuties);
            this.grpPositionMainDuties.Location = new System.Drawing.Point(436, 12);
            this.grpPositionMainDuties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPositionMainDuties.Name = "grpPositionMainDuties";
            this.grpPositionMainDuties.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPositionMainDuties.Size = new System.Drawing.Size(523, 664);
            this.grpPositionMainDuties.TabIndex = 7;
            this.grpPositionMainDuties.TabStop = false;
            this.grpPositionMainDuties.Text = "Position Main Duties";
            // 
            // txtPositionMainDuties
            // 
            this.txtPositionMainDuties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPositionMainDuties.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPositionMainDuties.Location = new System.Drawing.Point(2, 15);
            this.txtPositionMainDuties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPositionMainDuties.Multiline = true;
            this.txtPositionMainDuties.Name = "txtPositionMainDuties";
            this.txtPositionMainDuties.Size = new System.Drawing.Size(519, 647);
            this.txtPositionMainDuties.TabIndex = 0;
            // 
            // grpESDCMainDuties
            // 
            this.grpESDCMainDuties.Controls.Add(this.txtNOCMainDuties);
            this.grpESDCMainDuties.Location = new System.Drawing.Point(11, 12);
            this.grpESDCMainDuties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpESDCMainDuties.Name = "grpESDCMainDuties";
            this.grpESDCMainDuties.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpESDCMainDuties.Size = new System.Drawing.Size(387, 625);
            this.grpESDCMainDuties.TabIndex = 6;
            this.grpESDCMainDuties.TabStop = false;
            this.grpESDCMainDuties.Text = "ESDC Suggestion";
            // 
            // txtNOCMainDuties
            // 
            this.txtNOCMainDuties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNOCMainDuties.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNOCMainDuties.Location = new System.Drawing.Point(2, 15);
            this.txtNOCMainDuties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNOCMainDuties.Multiline = true;
            this.txtNOCMainDuties.Name = "txtNOCMainDuties";
            this.txtNOCMainDuties.Size = new System.Drawing.Size(383, 608);
            this.txtNOCMainDuties.TabIndex = 0;
            // 
            // tabQualifications
            // 
            this.tabQualifications.AutoScroll = true;
            this.tabQualifications.Controls.Add(this.grpPositionQualification);
            this.tabQualifications.Controls.Add(this.grpESDCQualification);
            this.tabQualifications.Controls.Add(this.dbOpsQualification);
            this.tabQualifications.Location = new System.Drawing.Point(4, 22);
            this.tabQualifications.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabQualifications.Name = "tabQualifications";
            this.tabQualifications.Size = new System.Drawing.Size(980, 748);
            this.tabQualifications.TabIndex = 3;
            this.tabQualifications.Text = "Qualifications";
            this.tabQualifications.UseVisualStyleBackColor = true;
            // 
            // grpPositionQualification
            // 
            this.grpPositionQualification.Controls.Add(this.grpSkill);
            this.grpPositionQualification.Controls.Add(this.grpLanguage);
            this.grpPositionQualification.Controls.Add(this.grpOthers);
            this.grpPositionQualification.Controls.Add(this.grpWorkExp);
            this.grpPositionQualification.Location = new System.Drawing.Point(441, 16);
            this.grpPositionQualification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPositionQualification.Name = "grpPositionQualification";
            this.grpPositionQualification.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPositionQualification.Size = new System.Drawing.Size(523, 625);
            this.grpPositionQualification.TabIndex = 4;
            this.grpPositionQualification.TabStop = false;
            this.grpPositionQualification.Text = "Position Qualification";
            // 
            // grpSkill
            // 
            this.grpSkill.Controls.Add(this.txtPositionSkillReq);
            this.grpSkill.Location = new System.Drawing.Point(11, 175);
            this.grpSkill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSkill.Name = "grpSkill";
            this.grpSkill.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSkill.Size = new System.Drawing.Size(501, 135);
            this.grpSkill.TabIndex = 1;
            this.grpSkill.TabStop = false;
            this.grpSkill.Text = "Skill Requirement";
            // 
            // txtPositionSkillReq
            // 
            this.txtPositionSkillReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPositionSkillReq.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPositionSkillReq.Location = new System.Drawing.Point(2, 15);
            this.txtPositionSkillReq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPositionSkillReq.Multiline = true;
            this.txtPositionSkillReq.Name = "txtPositionSkillReq";
            this.txtPositionSkillReq.Size = new System.Drawing.Size(497, 118);
            this.txtPositionSkillReq.TabIndex = 1;
            // 
            // grpLanguage
            // 
            this.grpLanguage.Controls.Add(this.txtPositionLanguage);
            this.grpLanguage.Location = new System.Drawing.Point(11, 333);
            this.grpLanguage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLanguage.Name = "grpLanguage";
            this.grpLanguage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLanguage.Size = new System.Drawing.Size(501, 135);
            this.grpLanguage.TabIndex = 1;
            this.grpLanguage.TabStop = false;
            this.grpLanguage.Text = "Language Requirement";
            // 
            // txtPositionLanguage
            // 
            this.txtPositionLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPositionLanguage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPositionLanguage.Location = new System.Drawing.Point(2, 15);
            this.txtPositionLanguage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPositionLanguage.Multiline = true;
            this.txtPositionLanguage.Name = "txtPositionLanguage";
            this.txtPositionLanguage.Size = new System.Drawing.Size(497, 118);
            this.txtPositionLanguage.TabIndex = 2;
            // 
            // grpOthers
            // 
            this.grpOthers.Controls.Add(this.txtPositionOthers);
            this.grpOthers.Location = new System.Drawing.Point(11, 481);
            this.grpOthers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOthers.Name = "grpOthers";
            this.grpOthers.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOthers.Size = new System.Drawing.Size(501, 135);
            this.grpOthers.TabIndex = 1;
            this.grpOthers.TabStop = false;
            this.grpOthers.Text = "Others";
            // 
            // txtPositionOthers
            // 
            this.txtPositionOthers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPositionOthers.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPositionOthers.Location = new System.Drawing.Point(2, 15);
            this.txtPositionOthers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPositionOthers.Multiline = true;
            this.txtPositionOthers.Name = "txtPositionOthers";
            this.txtPositionOthers.Size = new System.Drawing.Size(497, 118);
            this.txtPositionOthers.TabIndex = 3;
            // 
            // grpWorkExp
            // 
            this.grpWorkExp.Controls.Add(this.txtPositionWorkExp);
            this.grpWorkExp.Location = new System.Drawing.Point(11, 26);
            this.grpWorkExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpWorkExp.Name = "grpWorkExp";
            this.grpWorkExp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpWorkExp.Size = new System.Drawing.Size(501, 135);
            this.grpWorkExp.TabIndex = 0;
            this.grpWorkExp.TabStop = false;
            this.grpWorkExp.Text = "Work Experience";
            // 
            // txtPositionWorkExp
            // 
            this.txtPositionWorkExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPositionWorkExp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPositionWorkExp.Location = new System.Drawing.Point(2, 15);
            this.txtPositionWorkExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPositionWorkExp.Multiline = true;
            this.txtPositionWorkExp.Name = "txtPositionWorkExp";
            this.txtPositionWorkExp.Size = new System.Drawing.Size(497, 118);
            this.txtPositionWorkExp.TabIndex = 0;
            // 
            // grpESDCQualification
            // 
            this.grpESDCQualification.Controls.Add(this.txtESDCQualification);
            this.grpESDCQualification.Location = new System.Drawing.Point(15, 16);
            this.grpESDCQualification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpESDCQualification.Name = "grpESDCQualification";
            this.grpESDCQualification.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpESDCQualification.Size = new System.Drawing.Size(387, 490);
            this.grpESDCQualification.TabIndex = 3;
            this.grpESDCQualification.TabStop = false;
            this.grpESDCQualification.Text = "ESDC Suggestion";
            // 
            // txtESDCQualification
            // 
            this.txtESDCQualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtESDCQualification.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtESDCQualification.Location = new System.Drawing.Point(2, 15);
            this.txtESDCQualification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtESDCQualification.Multiline = true;
            this.txtESDCQualification.Name = "txtESDCQualification";
            this.txtESDCQualification.Size = new System.Drawing.Size(383, 473);
            this.txtESDCQualification.TabIndex = 0;
            // 
            // dbOpsQualification
            // 
            this.dbOpsQualification.Location = new System.Drawing.Point(13, 524);
            this.dbOpsQualification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbOpsQualification.Name = "dbOpsQualification";
            this.dbOpsQualification.Size = new System.Drawing.Size(389, 30);
            this.dbOpsQualification.TabIndex = 2;
            // 
            // tabMedia
            // 
            this.tabMedia.AutoScroll = true;
            this.tabMedia.Controls.Add(this.btnJobPostDelete);
            this.tabMedia.Controls.Add(this.btnJobPostSave);
            this.tabMedia.Controls.Add(this.dgvJobPost);
            this.tabMedia.Controls.Add(this.btnMediaSave);
            this.tabMedia.Controls.Add(this.btnGoForPosting);
            this.tabMedia.Controls.Add(this.dgvMedia);
            this.tabMedia.Controls.Add(this.lblOther);
            this.tabMedia.Controls.Add(this.lblSpecific);
            this.tabMedia.Controls.Add(this.lblGeneral);
            this.tabMedia.Controls.Add(this.lblOfficial);
            this.tabMedia.Location = new System.Drawing.Point(4, 22);
            this.tabMedia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMedia.Name = "tabMedia";
            this.tabMedia.Size = new System.Drawing.Size(977, 626);
            this.tabMedia.TabIndex = 5;
            this.tabMedia.Text = "Media Selection";
            this.tabMedia.UseVisualStyleBackColor = true;
            // 
            // btnJobPostDelete
            // 
            this.btnJobPostDelete.Location = new System.Drawing.Point(834, 591);
            this.btnJobPostDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJobPostDelete.Name = "btnJobPostDelete";
            this.btnJobPostDelete.Size = new System.Drawing.Size(114, 25);
            this.btnJobPostDelete.TabIndex = 5;
            this.btnJobPostDelete.Text = "Delete";
            this.btnJobPostDelete.UseVisualStyleBackColor = true;
            this.btnJobPostDelete.Click += new System.EventHandler(this.btnJobPostDelete_Click);
            // 
            // btnJobPostSave
            // 
            this.btnJobPostSave.Location = new System.Drawing.Point(696, 591);
            this.btnJobPostSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJobPostSave.Name = "btnJobPostSave";
            this.btnJobPostSave.Size = new System.Drawing.Size(114, 25);
            this.btnJobPostSave.TabIndex = 5;
            this.btnJobPostSave.Text = "Save";
            this.btnJobPostSave.UseVisualStyleBackColor = true;
            this.btnJobPostSave.Click += new System.EventHandler(this.btnJobPostSave_Click);
            // 
            // dgvJobPost
            // 
            this.dgvJobPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobPost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvJobPost.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobPost.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJobPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobPost.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvJobPost.Location = new System.Drawing.Point(2, 365);
            this.dgvJobPost.Name = "dgvJobPost";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobPost.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJobPost.RowHeadersVisible = false;
            this.dgvJobPost.Size = new System.Drawing.Size(1560, 190);
            this.dgvJobPost.TabIndex = 4;
            this.dgvJobPost.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobPost_CellEndEdit);
            // 
            // btnMediaSave
            // 
            this.btnMediaSave.Location = new System.Drawing.Point(9, 335);
            this.btnMediaSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMediaSave.Name = "btnMediaSave";
            this.btnMediaSave.Size = new System.Drawing.Size(67, 25);
            this.btnMediaSave.TabIndex = 3;
            this.btnMediaSave.Text = "Save";
            this.btnMediaSave.UseVisualStyleBackColor = true;
            // 
            // btnGoForPosting
            // 
            this.btnGoForPosting.Location = new System.Drawing.Point(119, 336);
            this.btnGoForPosting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoForPosting.Name = "btnGoForPosting";
            this.btnGoForPosting.Size = new System.Drawing.Size(114, 25);
            this.btnGoForPosting.TabIndex = 3;
            this.btnGoForPosting.Text = "Go Posting";
            this.btnGoForPosting.UseVisualStyleBackColor = true;
            this.btnGoForPosting.Click += new System.EventHandler(this.btnGoForPosting_Click);
            // 
            // dgvMedia
            // 
            this.dgvMedia.AllowUserToOrderColumns = true;
            this.dgvMedia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedia.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvMedia.Location = new System.Drawing.Point(2, 2);
            this.dgvMedia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMedia.Name = "dgvMedia";
            this.dgvMedia.RowHeadersVisible = false;
            this.dgvMedia.RowTemplate.Height = 28;
            this.dgvMedia.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedia.Size = new System.Drawing.Size(1562, 321);
            this.dgvMedia.TabIndex = 2;
            this.dgvMedia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedia_CellClick);
            this.dgvMedia.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedia_CellEndEdit);
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(714, 342);
            this.lblOther.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(65, 13);
            this.lblOther.TabIndex = 1;
            this.lblOther.Text = "Other Media";
            // 
            // lblSpecific
            // 
            this.lblSpecific.AutoSize = true;
            this.lblSpecific.Location = new System.Drawing.Point(559, 342);
            this.lblSpecific.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecific.Name = "lblSpecific";
            this.lblSpecific.Size = new System.Drawing.Size(117, 13);
            this.lblSpecific.TabIndex = 1;
            this.lblSpecific.Text = "Specific Industry Media";
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Location = new System.Drawing.Point(391, 342);
            this.lblGeneral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(113, 13);
            this.lblGeneral.TabIndex = 1;
            this.lblGeneral.Text = "General Recruit Media";
            // 
            // lblOfficial
            // 
            this.lblOfficial.AutoSize = true;
            this.lblOfficial.Location = new System.Drawing.Point(237, 342);
            this.lblOfficial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOfficial.Name = "lblOfficial";
            this.lblOfficial.Size = new System.Drawing.Size(71, 13);
            this.lblOfficial.TabIndex = 1;
            this.lblOfficial.Text = "Official Media";
            // 
            // tabJobOffer
            // 
            this.tabJobOffer.AutoScroll = true;
            this.tabJobOffer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabJobOffer.Controls.Add(this.dtpJobOfferStartDate);
            this.tabJobOffer.Controls.Add(this.btnJobOfferClear);
            this.tabJobOffer.Controls.Add(this.btnJobOfferSave);
            this.tabJobOffer.Controls.Add(this.btnJobOfferWhentoOffer);
            this.tabJobOffer.Controls.Add(this.txtJobOfferWhentoOffer);
            this.tabJobOffer.Controls.Add(this.lblJobOfferWhentoOffer);
            this.tabJobOffer.Controls.Add(this.btnJobOfferHowtoDetermine);
            this.tabJobOffer.Controls.Add(this.txtJobOfferHowtoDetermine);
            this.tabJobOffer.Controls.Add(this.lblJobOfferHowtoQualify);
            this.tabJobOffer.Controls.Add(this.btnJobOfferHowDidYouFind);
            this.tabJobOffer.Controls.Add(this.lblJobOfferHowDidYouFind);
            this.tabJobOffer.Controls.Add(this.txtJobOfferHowDidYouFind);
            this.tabJobOffer.Controls.Add(this.btnJobOfferWhoFillInTheJob);
            this.tabJobOffer.Controls.Add(this.lblJobOfferWhoCurrentInThePosition);
            this.tabJobOffer.Controls.Add(this.txtJobOfferWhoFillInThisJob);
            this.tabJobOffer.Controls.Add(this.lblJobOfferProvideAssistant);
            this.tabJobOffer.Controls.Add(this.txtJobOfferProvideAssistant);
            this.tabJobOffer.Controls.Add(this.chkJobOfferProvideRentNA);
            this.tabJobOffer.Controls.Add(this.cmbJobOfferProvideRent);
            this.tabJobOffer.Controls.Add(this.lblJobOfferAccomodationDescription);
            this.tabJobOffer.Controls.Add(this.lblJobOfferProvideRent);
            this.tabJobOffer.Controls.Add(this.txtJobOfferAccomadationDescription);
            this.tabJobOffer.Controls.Add(this.txtJobOfferProvideRent);
            this.tabJobOffer.Controls.Add(this.chkJobOfferProvideAccomadation);
            this.tabJobOffer.Controls.Add(this.button5);
            this.tabJobOffer.Controls.Add(this.label30);
            this.tabJobOffer.Controls.Add(this.txtJobOfferTrainCanadian);
            this.tabJobOffer.Controls.Add(this.chkJobOfferTrainCanadian);
            this.tabJobOffer.Controls.Add(this.btnJobOfferRationale);
            this.tabJobOffer.Controls.Add(this.txtJobOfferOfferRationale);
            this.tabJobOffer.Controls.Add(this.lblJobOfferOfferRational);
            this.tabJobOffer.Controls.Add(this.btnJobOfferBenefitDetails);
            this.tabJobOffer.Controls.Add(this.txtJobOfferBenefitBrief);
            this.tabJobOffer.Controls.Add(this.label33);
            this.tabJobOffer.Controls.Add(this.lblJobOfferJobCreation);
            this.tabJobOffer.Controls.Add(this.lblJobOfferSkillTransfer);
            this.tabJobOffer.Controls.Add(this.lblFillingLabourShortage);
            this.tabJobOffer.Controls.Add(this.lblJobOfferPotentialBenifit);
            this.tabJobOffer.Controls.Add(this.lblJobOfferRecruitCanadian);
            this.tabJobOffer.Controls.Add(this.txtJobOfferRecruitCanadian);
            this.tabJobOffer.Controls.Add(this.chkJobOfferRecruitCanadian);
            this.tabJobOffer.Controls.Add(this.lblJobOfferUnionConsulted);
            this.tabJobOffer.Controls.Add(this.txtJobOfferUnionExpOrOpinion);
            this.tabJobOffer.Controls.Add(this.chkJobOfferUnionConsulted);
            this.tabJobOffer.Controls.Add(this.chkJobOfferIsUnion);
            this.tabJobOffer.Controls.Add(this.label29);
            this.tabJobOffer.Controls.Add(this.txtJobOfferUnionName);
            this.tabJobOffer.Controls.Add(this.cmbJobOfferDWM);
            this.tabJobOffer.Controls.Add(this.label28);
            this.tabJobOffer.Controls.Add(this.txtJobOfferHowlongLicense);
            this.tabJobOffer.Controls.Add(this.chkJobOfferLicenseReady);
            this.tabJobOffer.Controls.Add(this.label27);
            this.tabJobOffer.Controls.Add(this.txtJobOfferLicenseAuthority);
            this.tabJobOffer.Controls.Add(this.chkJobOfferLicenseNeeded);
            this.tabJobOffer.Controls.Add(this.txtJobOfferOtherBenifits);
            this.tabJobOffer.Controls.Add(this.lblJobOfferOtherBenifits);
            this.tabJobOffer.Controls.Add(this.chkJobOfferFullDuration);
            this.tabJobOffer.Controls.Add(this.chkJobOfferSeasonal);
            this.tabJobOffer.Controls.Add(this.txtJobOfferRemuneraton);
            this.tabJobOffer.Controls.Add(this.txtJobOfferVacationDays);
            this.tabJobOffer.Controls.Add(this.txtJobOfferRemuneration);
            this.tabJobOffer.Controls.Add(this.rdbJobOfferRemuneration);
            this.tabJobOffer.Controls.Add(this.rdbJobOfferVacationDays);
            this.tabJobOffer.Controls.Add(this.grpLMIALanguage);
            this.tabJobOffer.Controls.Add(this.cmbDurationUnit);
            this.tabJobOffer.Controls.Add(this.txtJobOfferExpectedDuration);
            this.tabJobOffer.Controls.Add(this.label24);
            this.tabJobOffer.Controls.Add(this.txtJobOfferDurationRationale);
            this.tabJobOffer.Controls.Add(this.lblJobOfferDurationRationale);
            this.tabJobOffer.Controls.Add(this.label25);
            this.tabJobOffer.Controls.Add(this.txtJobOfferNumberofTFW);
            this.tabJobOffer.Controls.Add(this.label21);
            this.tabJobOffer.Location = new System.Drawing.Point(4, 22);
            this.tabJobOffer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabJobOffer.Name = "tabJobOffer";
            this.tabJobOffer.Size = new System.Drawing.Size(980, 748);
            this.tabJobOffer.TabIndex = 8;
            this.tabJobOffer.Text = "Job Offer";
            this.tabJobOffer.UseVisualStyleBackColor = true;
            // 
            // dtpJobOfferStartDate
            // 
            this.dtpJobOfferStartDate.CalendarForeColor = System.Drawing.SystemColors.HotTrack;
            this.dtpJobOfferStartDate.Location = new System.Drawing.Point(849, 6);
            this.dtpJobOfferStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpJobOfferStartDate.Name = "dtpJobOfferStartDate";
            this.dtpJobOfferStartDate.Size = new System.Drawing.Size(119, 20);
            this.dtpJobOfferStartDate.TabIndex = 62;
            // 
            // btnJobOfferClear
            // 
            this.btnJobOfferClear.Location = new System.Drawing.Point(755, 676);
            this.btnJobOfferClear.Name = "btnJobOfferClear";
            this.btnJobOfferClear.Size = new System.Drawing.Size(75, 23);
            this.btnJobOfferClear.TabIndex = 61;
            this.btnJobOfferClear.Text = "Clear";
            this.btnJobOfferClear.UseVisualStyleBackColor = true;
            this.btnJobOfferClear.Click += new System.EventHandler(this.btnJobOfferClear_Click);
            // 
            // btnJobOfferSave
            // 
            this.btnJobOfferSave.Location = new System.Drawing.Point(657, 676);
            this.btnJobOfferSave.Name = "btnJobOfferSave";
            this.btnJobOfferSave.Size = new System.Drawing.Size(75, 23);
            this.btnJobOfferSave.TabIndex = 61;
            this.btnJobOfferSave.Text = "Save";
            this.btnJobOfferSave.UseVisualStyleBackColor = true;
            this.btnJobOfferSave.Click += new System.EventHandler(this.btnJobOfferSave_Click);
            // 
            // btnJobOfferWhentoOffer
            // 
            this.btnJobOfferWhentoOffer.Location = new System.Drawing.Point(885, 634);
            this.btnJobOfferWhentoOffer.Name = "btnJobOfferWhentoOffer";
            this.btnJobOfferWhentoOffer.Size = new System.Drawing.Size(75, 23);
            this.btnJobOfferWhentoOffer.TabIndex = 60;
            this.btnJobOfferWhentoOffer.Text = "Details";
            this.btnJobOfferWhentoOffer.UseVisualStyleBackColor = true;
            this.btnJobOfferWhentoOffer.Click += new System.EventHandler(this.btnJobOfferWhentoOffer_Click);
            // 
            // txtJobOfferWhentoOffer
            // 
            this.txtJobOfferWhentoOffer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferWhentoOffer.Location = new System.Drawing.Point(350, 634);
            this.txtJobOfferWhentoOffer.Multiline = true;
            this.txtJobOfferWhentoOffer.Name = "txtJobOfferWhentoOffer";
            this.txtJobOfferWhentoOffer.Size = new System.Drawing.Size(447, 20);
            this.txtJobOfferWhentoOffer.TabIndex = 59;
            // 
            // lblJobOfferWhentoOffer
            // 
            this.lblJobOfferWhentoOffer.AutoSize = true;
            this.lblJobOfferWhentoOffer.Location = new System.Drawing.Point(13, 637);
            this.lblJobOfferWhentoOffer.Name = "lblJobOfferWhentoOffer";
            this.lblJobOfferWhentoOffer.Size = new System.Drawing.Size(282, 13);
            this.lblJobOfferWhentoOffer.TabIndex = 58;
            this.lblJobOfferWhentoOffer.Text = "How and when did you offer this job to the foreign worker?";
            // 
            // btnJobOfferHowtoDetermine
            // 
            this.btnJobOfferHowtoDetermine.Location = new System.Drawing.Point(885, 604);
            this.btnJobOfferHowtoDetermine.Name = "btnJobOfferHowtoDetermine";
            this.btnJobOfferHowtoDetermine.Size = new System.Drawing.Size(75, 23);
            this.btnJobOfferHowtoDetermine.TabIndex = 57;
            this.btnJobOfferHowtoDetermine.Text = "Details";
            this.btnJobOfferHowtoDetermine.UseVisualStyleBackColor = true;
            this.btnJobOfferHowtoDetermine.Click += new System.EventHandler(this.btnJobOfferHowtoDetermine_Click);
            // 
            // txtJobOfferHowtoDetermine
            // 
            this.txtJobOfferHowtoDetermine.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferHowtoDetermine.Location = new System.Drawing.Point(350, 604);
            this.txtJobOfferHowtoDetermine.Multiline = true;
            this.txtJobOfferHowtoDetermine.Name = "txtJobOfferHowtoDetermine";
            this.txtJobOfferHowtoDetermine.Size = new System.Drawing.Size(447, 20);
            this.txtJobOfferHowtoDetermine.TabIndex = 56;
            // 
            // lblJobOfferHowtoQualify
            // 
            this.lblJobOfferHowtoQualify.AutoSize = true;
            this.lblJobOfferHowtoQualify.Location = new System.Drawing.Point(13, 607);
            this.lblJobOfferHowtoQualify.Name = "lblJobOfferHowtoQualify";
            this.lblJobOfferHowtoQualify.Size = new System.Drawing.Size(323, 13);
            this.lblJobOfferHowtoQualify.TabIndex = 55;
            this.lblJobOfferHowtoQualify.Text = "How did you determine the foreign worker was qualified for the job?";
            // 
            // btnJobOfferHowDidYouFind
            // 
            this.btnJobOfferHowDidYouFind.Location = new System.Drawing.Point(885, 576);
            this.btnJobOfferHowDidYouFind.Name = "btnJobOfferHowDidYouFind";
            this.btnJobOfferHowDidYouFind.Size = new System.Drawing.Size(75, 23);
            this.btnJobOfferHowDidYouFind.TabIndex = 54;
            this.btnJobOfferHowDidYouFind.Text = "Details";
            this.btnJobOfferHowDidYouFind.UseVisualStyleBackColor = true;
            this.btnJobOfferHowDidYouFind.Click += new System.EventHandler(this.btnJobOfferHowDidYouFind_Click);
            // 
            // lblJobOfferHowDidYouFind
            // 
            this.lblJobOfferHowDidYouFind.AutoSize = true;
            this.lblJobOfferHowDidYouFind.Location = new System.Drawing.Point(14, 579);
            this.lblJobOfferHowDidYouFind.Name = "lblJobOfferHowDidYouFind";
            this.lblJobOfferHowDidYouFind.Size = new System.Drawing.Size(301, 13);
            this.lblJobOfferHowDidYouFind.TabIndex = 53;
            this.lblJobOfferHowDidYouFind.Text = "How did you find or identify the foreign worker for this position?";
            // 
            // txtJobOfferHowDidYouFind
            // 
            this.txtJobOfferHowDidYouFind.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferHowDidYouFind.Location = new System.Drawing.Point(350, 576);
            this.txtJobOfferHowDidYouFind.Multiline = true;
            this.txtJobOfferHowDidYouFind.Name = "txtJobOfferHowDidYouFind";
            this.txtJobOfferHowDidYouFind.Size = new System.Drawing.Size(447, 20);
            this.txtJobOfferHowDidYouFind.TabIndex = 52;
            // 
            // btnJobOfferWhoFillInTheJob
            // 
            this.btnJobOfferWhoFillInTheJob.Location = new System.Drawing.Point(885, 550);
            this.btnJobOfferWhoFillInTheJob.Name = "btnJobOfferWhoFillInTheJob";
            this.btnJobOfferWhoFillInTheJob.Size = new System.Drawing.Size(75, 23);
            this.btnJobOfferWhoFillInTheJob.TabIndex = 51;
            this.btnJobOfferWhoFillInTheJob.Text = "Details";
            this.btnJobOfferWhoFillInTheJob.UseVisualStyleBackColor = true;
            this.btnJobOfferWhoFillInTheJob.Click += new System.EventHandler(this.btnJobOfferWhoFillInTheJob_Click);
            // 
            // lblJobOfferWhoCurrentInThePosition
            // 
            this.lblJobOfferWhoCurrentInThePosition.AutoSize = true;
            this.lblJobOfferWhoCurrentInThePosition.Location = new System.Drawing.Point(14, 553);
            this.lblJobOfferWhoCurrentInThePosition.Name = "lblJobOfferWhoCurrentInThePosition";
            this.lblJobOfferWhoCurrentInThePosition.Size = new System.Drawing.Size(324, 13);
            this.lblJobOfferWhoCurrentInThePosition.TabIndex = 50;
            this.lblJobOfferWhoCurrentInThePosition.Text = "Who is currently filling the duties and responsibilities of the position?";
            // 
            // txtJobOfferWhoFillInThisJob
            // 
            this.txtJobOfferWhoFillInThisJob.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferWhoFillInThisJob.Location = new System.Drawing.Point(350, 550);
            this.txtJobOfferWhoFillInThisJob.Name = "txtJobOfferWhoFillInThisJob";
            this.txtJobOfferWhoFillInThisJob.Size = new System.Drawing.Size(447, 20);
            this.txtJobOfferWhoFillInThisJob.TabIndex = 49;
            // 
            // lblJobOfferProvideAssistant
            // 
            this.lblJobOfferProvideAssistant.AutoSize = true;
            this.lblJobOfferProvideAssistant.Location = new System.Drawing.Point(19, 526);
            this.lblJobOfferProvideAssistant.Name = "lblJobOfferProvideAssistant";
            this.lblJobOfferProvideAssistant.Size = new System.Drawing.Size(259, 13);
            this.lblJobOfferProvideAssistant.TabIndex = 48;
            this.lblJobOfferProvideAssistant.Text = "No, but the employer will assist by doing the following:";
            // 
            // txtJobOfferProvideAssistant
            // 
            this.txtJobOfferProvideAssistant.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferProvideAssistant.Location = new System.Drawing.Point(284, 523);
            this.txtJobOfferProvideAssistant.Multiline = true;
            this.txtJobOfferProvideAssistant.Name = "txtJobOfferProvideAssistant";
            this.txtJobOfferProvideAssistant.Size = new System.Drawing.Size(677, 20);
            this.txtJobOfferProvideAssistant.TabIndex = 47;
            // 
            // chkJobOfferProvideRentNA
            // 
            this.chkJobOfferProvideRentNA.AutoSize = true;
            this.chkJobOfferProvideRentNA.Location = new System.Drawing.Point(863, 502);
            this.chkJobOfferProvideRentNA.Name = "chkJobOfferProvideRentNA";
            this.chkJobOfferProvideRentNA.Size = new System.Drawing.Size(95, 17);
            this.chkJobOfferProvideRentNA.TabIndex = 46;
            this.chkJobOfferProvideRentNA.Text = "Not Appliacble";
            this.chkJobOfferProvideRentNA.UseVisualStyleBackColor = true;
            // 
            // cmbJobOfferProvideRent
            // 
            this.cmbJobOfferProvideRent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbJobOfferProvideRent.FormattingEnabled = true;
            this.cmbJobOfferProvideRent.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months"});
            this.cmbJobOfferProvideRent.Location = new System.Drawing.Point(479, 500);
            this.cmbJobOfferProvideRent.Name = "cmbJobOfferProvideRent";
            this.cmbJobOfferProvideRent.Size = new System.Drawing.Size(53, 21);
            this.cmbJobOfferProvideRent.TabIndex = 45;
            // 
            // lblJobOfferAccomodationDescription
            // 
            this.lblJobOfferAccomodationDescription.AutoSize = true;
            this.lblJobOfferAccomodationDescription.Location = new System.Drawing.Point(539, 503);
            this.lblJobOfferAccomodationDescription.Name = "lblJobOfferAccomodationDescription";
            this.lblJobOfferAccomodationDescription.Size = new System.Drawing.Size(60, 13);
            this.lblJobOfferAccomodationDescription.TabIndex = 44;
            this.lblJobOfferAccomodationDescription.Text = "Description";
            // 
            // lblJobOfferProvideRent
            // 
            this.lblJobOfferProvideRent.AutoSize = true;
            this.lblJobOfferProvideRent.Location = new System.Drawing.Point(297, 502);
            this.lblJobOfferProvideRent.Name = "lblJobOfferProvideRent";
            this.lblJobOfferProvideRent.Size = new System.Drawing.Size(122, 13);
            this.lblJobOfferProvideRent.TabIndex = 44;
            this.lblJobOfferProvideRent.Text = "Yes, we provide the rent";
            // 
            // txtJobOfferAccomadationDescription
            // 
            this.txtJobOfferAccomadationDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferAccomadationDescription.Location = new System.Drawing.Point(603, 501);
            this.txtJobOfferAccomadationDescription.Name = "txtJobOfferAccomadationDescription";
            this.txtJobOfferAccomadationDescription.Size = new System.Drawing.Size(254, 20);
            this.txtJobOfferAccomadationDescription.TabIndex = 43;
            // 
            // txtJobOfferProvideRent
            // 
            this.txtJobOfferProvideRent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferProvideRent.Location = new System.Drawing.Point(423, 500);
            this.txtJobOfferProvideRent.Name = "txtJobOfferProvideRent";
            this.txtJobOfferProvideRent.Size = new System.Drawing.Size(41, 20);
            this.txtJobOfferProvideRent.TabIndex = 43;
            // 
            // chkJobOfferProvideAccomadation
            // 
            this.chkJobOfferProvideAccomadation.AutoSize = true;
            this.chkJobOfferProvideAccomadation.Location = new System.Drawing.Point(17, 501);
            this.chkJobOfferProvideAccomadation.Name = "chkJobOfferProvideAccomadation";
            this.chkJobOfferProvideAccomadation.Size = new System.Drawing.Size(283, 17);
            this.chkJobOfferProvideAccomadation.TabIndex = 42;
            this.chkJobOfferProvideAccomadation.Text = "Will you provide the TFW with suitable accomadation?";
            this.chkJobOfferProvideAccomadation.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(885, 475);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 41;
            this.button5.Text = "Details";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(219, 475);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(198, 13);
            this.label30.TabIndex = 40;
            this.label30.Text = "If no, explain;if yes, brief the training plan";
            // 
            // txtJobOfferTrainCanadian
            // 
            this.txtJobOfferTrainCanadian.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferTrainCanadian.Location = new System.Drawing.Point(423, 473);
            this.txtJobOfferTrainCanadian.Multiline = true;
            this.txtJobOfferTrainCanadian.Name = "txtJobOfferTrainCanadian";
            this.txtJobOfferTrainCanadian.Size = new System.Drawing.Size(374, 20);
            this.txtJobOfferTrainCanadian.TabIndex = 39;
            // 
            // chkJobOfferTrainCanadian
            // 
            this.chkJobOfferTrainCanadian.AutoSize = true;
            this.chkJobOfferTrainCanadian.Checked = true;
            this.chkJobOfferTrainCanadian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJobOfferTrainCanadian.Location = new System.Drawing.Point(19, 475);
            this.chkJobOfferTrainCanadian.Name = "chkJobOfferTrainCanadian";
            this.chkJobOfferTrainCanadian.Size = new System.Drawing.Size(204, 17);
            this.chkJobOfferTrainCanadian.TabIndex = 38;
            this.chkJobOfferTrainCanadian.Text = "Do you plan to hire or train Canadian?";
            this.chkJobOfferTrainCanadian.UseVisualStyleBackColor = true;
            // 
            // btnJobOfferRationale
            // 
            this.btnJobOfferRationale.Location = new System.Drawing.Point(885, 445);
            this.btnJobOfferRationale.Name = "btnJobOfferRationale";
            this.btnJobOfferRationale.Size = new System.Drawing.Size(75, 23);
            this.btnJobOfferRationale.TabIndex = 37;
            this.btnJobOfferRationale.Text = "Details";
            this.btnJobOfferRationale.UseVisualStyleBackColor = true;
            this.btnJobOfferRationale.Click += new System.EventHandler(this.btnJobOfferRationale_Click);
            // 
            // txtJobOfferOfferRationale
            // 
            this.txtJobOfferOfferRationale.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferOfferRationale.Location = new System.Drawing.Point(19, 445);
            this.txtJobOfferOfferRationale.Multiline = true;
            this.txtJobOfferOfferRationale.Name = "txtJobOfferOfferRationale";
            this.txtJobOfferOfferRationale.Size = new System.Drawing.Size(778, 24);
            this.txtJobOfferOfferRationale.TabIndex = 36;
            // 
            // lblJobOfferOfferRational
            // 
            this.lblJobOfferOfferRational.AutoSize = true;
            this.lblJobOfferOfferRational.Location = new System.Drawing.Point(16, 429);
            this.lblJobOfferOfferRational.Name = "lblJobOfferOfferRational";
            this.lblJobOfferOfferRational.Size = new System.Drawing.Size(202, 13);
            this.lblJobOfferOfferRational.TabIndex = 35;
            this.lblJobOfferOfferRational.Text = "The rational providing this job to the TFW";
            // 
            // btnJobOfferBenefitDetails
            // 
            this.btnJobOfferBenefitDetails.Location = new System.Drawing.Point(885, 398);
            this.btnJobOfferBenefitDetails.Name = "btnJobOfferBenefitDetails";
            this.btnJobOfferBenefitDetails.Size = new System.Drawing.Size(75, 23);
            this.btnJobOfferBenefitDetails.TabIndex = 34;
            this.btnJobOfferBenefitDetails.Text = "Details";
            this.btnJobOfferBenefitDetails.UseVisualStyleBackColor = true;
            this.btnJobOfferBenefitDetails.Click += new System.EventHandler(this.btnJobOfferBenefitDetails_Click);
            // 
            // txtJobOfferBenefitBrief
            // 
            this.txtJobOfferBenefitBrief.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferBenefitBrief.Location = new System.Drawing.Point(19, 398);
            this.txtJobOfferBenefitBrief.Multiline = true;
            this.txtJobOfferBenefitBrief.Name = "txtJobOfferBenefitBrief";
            this.txtJobOfferBenefitBrief.Size = new System.Drawing.Size(778, 24);
            this.txtJobOfferBenefitBrief.TabIndex = 33;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(847, 382);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 13);
            this.label33.TabIndex = 32;
            this.label33.Text = "Other Benefits";
            // 
            // lblJobOfferJobCreation
            // 
            this.lblJobOfferJobCreation.AutoSize = true;
            this.lblJobOfferJobCreation.Location = new System.Drawing.Point(649, 382);
            this.lblJobOfferJobCreation.Name = "lblJobOfferJobCreation";
            this.lblJobOfferJobCreation.Size = new System.Drawing.Size(148, 13);
            this.lblJobOfferJobCreation.TabIndex = 31;
            this.lblJobOfferJobCreation.Text = "Direct job creation or retaining";
            // 
            // lblJobOfferSkillTransfer
            // 
            this.lblJobOfferSkillTransfer.AutoSize = true;
            this.lblJobOfferSkillTransfer.Location = new System.Drawing.Point(488, 382);
            this.lblJobOfferSkillTransfer.Name = "lblJobOfferSkillTransfer";
            this.lblJobOfferSkillTransfer.Size = new System.Drawing.Size(136, 13);
            this.lblJobOfferSkillTransfer.TabIndex = 30;
            this.lblJobOfferSkillTransfer.Text = "Knowledge or Skill Transfer";
            // 
            // lblFillingLabourShortage
            // 
            this.lblFillingLabourShortage.AutoSize = true;
            this.lblFillingLabourShortage.Location = new System.Drawing.Point(347, 382);
            this.lblFillingLabourShortage.Name = "lblFillingLabourShortage";
            this.lblFillingLabourShortage.Size = new System.Drawing.Size(118, 13);
            this.lblFillingLabourShortage.TabIndex = 29;
            this.lblFillingLabourShortage.Text = "Filling a labour shortage";
            // 
            // lblJobOfferPotentialBenifit
            // 
            this.lblJobOfferPotentialBenifit.AutoSize = true;
            this.lblJobOfferPotentialBenifit.Location = new System.Drawing.Point(16, 382);
            this.lblJobOfferPotentialBenifit.Name = "lblJobOfferPotentialBenifit";
            this.lblJobOfferPotentialBenifit.Size = new System.Drawing.Size(302, 13);
            this.lblJobOfferPotentialBenifit.TabIndex = 28;
            this.lblJobOfferPotentialBenifit.Text = "Please justify why hiring TFW can bring this benifits to Canada:";
            // 
            // lblJobOfferRecruitCanadian
            // 
            this.lblJobOfferRecruitCanadian.AutoSize = true;
            this.lblJobOfferRecruitCanadian.Location = new System.Drawing.Point(202, 352);
            this.lblJobOfferRecruitCanadian.Name = "lblJobOfferRecruitCanadian";
            this.lblJobOfferRecruitCanadian.Size = new System.Drawing.Size(322, 13);
            this.lblJobOfferRecruitCanadian.TabIndex = 27;
            this.lblJobOfferRecruitCanadian.Text = "If no, explain;if yes, provide Jobbank or WorkBC etc recruit number";
            // 
            // txtJobOfferRecruitCanadian
            // 
            this.txtJobOfferRecruitCanadian.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferRecruitCanadian.Location = new System.Drawing.Point(530, 350);
            this.txtJobOfferRecruitCanadian.Multiline = true;
            this.txtJobOfferRecruitCanadian.Name = "txtJobOfferRecruitCanadian";
            this.txtJobOfferRecruitCanadian.Size = new System.Drawing.Size(431, 20);
            this.txtJobOfferRecruitCanadian.TabIndex = 26;
            // 
            // chkJobOfferRecruitCanadian
            // 
            this.chkJobOfferRecruitCanadian.AutoSize = true;
            this.chkJobOfferRecruitCanadian.Checked = true;
            this.chkJobOfferRecruitCanadian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJobOfferRecruitCanadian.Location = new System.Drawing.Point(22, 353);
            this.chkJobOfferRecruitCanadian.Name = "chkJobOfferRecruitCanadian";
            this.chkJobOfferRecruitCanadian.Size = new System.Drawing.Size(172, 17);
            this.chkJobOfferRecruitCanadian.TabIndex = 25;
            this.chkJobOfferRecruitCanadian.Text = "Attempted to recruit Canadian?";
            this.chkJobOfferRecruitCanadian.UseVisualStyleBackColor = true;
            // 
            // lblJobOfferUnionConsulted
            // 
            this.lblJobOfferUnionConsulted.AutoSize = true;
            this.lblJobOfferUnionConsulted.Location = new System.Drawing.Point(202, 328);
            this.lblJobOfferUnionConsulted.Name = "lblJobOfferUnionConsulted";
            this.lblJobOfferUnionConsulted.Size = new System.Drawing.Size(264, 13);
            this.lblJobOfferUnionConsulted.TabIndex = 24;
            this.lblJobOfferUnionConsulted.Text = "If no, explain;if yes, provide union opion and attestaton";
            // 
            // txtJobOfferUnionExpOrOpinion
            // 
            this.txtJobOfferUnionExpOrOpinion.Location = new System.Drawing.Point(472, 326);
            this.txtJobOfferUnionExpOrOpinion.Multiline = true;
            this.txtJobOfferUnionExpOrOpinion.Name = "txtJobOfferUnionExpOrOpinion";
            this.txtJobOfferUnionExpOrOpinion.Size = new System.Drawing.Size(489, 20);
            this.txtJobOfferUnionExpOrOpinion.TabIndex = 23;
            // 
            // chkJobOfferUnionConsulted
            // 
            this.chkJobOfferUnionConsulted.AutoSize = true;
            this.chkJobOfferUnionConsulted.Location = new System.Drawing.Point(19, 328);
            this.chkJobOfferUnionConsulted.Name = "chkJobOfferUnionConsulted";
            this.chkJobOfferUnionConsulted.Size = new System.Drawing.Size(156, 17);
            this.chkJobOfferUnionConsulted.TabIndex = 22;
            this.chkJobOfferUnionConsulted.Text = "Has union been cnosulted?";
            this.chkJobOfferUnionConsulted.UseVisualStyleBackColor = true;
            // 
            // chkJobOfferIsUnion
            // 
            this.chkJobOfferIsUnion.AutoSize = true;
            this.chkJobOfferIsUnion.Location = new System.Drawing.Point(19, 305);
            this.chkJobOfferIsUnion.Name = "chkJobOfferIsUnion";
            this.chkJobOfferIsUnion.Size = new System.Drawing.Size(147, 17);
            this.chkJobOfferIsUnion.TabIndex = 21;
            this.chkJobOfferIsUnion.Text = "Is this job part of a union?";
            this.chkJobOfferIsUnion.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(202, 305);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(122, 13);
            this.label29.TabIndex = 20;
            this.label29.Text = "Name and local of union";
            // 
            // txtJobOfferUnionName
            // 
            this.txtJobOfferUnionName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferUnionName.Location = new System.Drawing.Point(350, 303);
            this.txtJobOfferUnionName.Multiline = true;
            this.txtJobOfferUnionName.Name = "txtJobOfferUnionName";
            this.txtJobOfferUnionName.Size = new System.Drawing.Size(611, 20);
            this.txtJobOfferUnionName.TabIndex = 19;
            // 
            // cmbJobOfferDWM
            // 
            this.cmbJobOfferDWM.FormattingEnabled = true;
            this.cmbJobOfferDWM.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months"});
            this.cmbJobOfferDWM.Location = new System.Drawing.Point(883, 276);
            this.cmbJobOfferDWM.Name = "cmbJobOfferDWM";
            this.cmbJobOfferDWM.Size = new System.Drawing.Size(78, 21);
            this.cmbJobOfferDWM.TabIndex = 17;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(649, 280);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(164, 13);
            this.label28.TabIndex = 16;
            this.label28.Text = "How long can the TFW obtain it?";
            // 
            // txtJobOfferHowlongLicense
            // 
            this.txtJobOfferHowlongLicense.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferHowlongLicense.Location = new System.Drawing.Point(819, 277);
            this.txtJobOfferHowlongLicense.Name = "txtJobOfferHowlongLicense";
            this.txtJobOfferHowlongLicense.Size = new System.Drawing.Size(49, 20);
            this.txtJobOfferHowlongLicense.TabIndex = 15;
            // 
            // chkJobOfferLicenseReady
            // 
            this.chkJobOfferLicenseReady.AutoSize = true;
            this.chkJobOfferLicenseReady.Location = new System.Drawing.Point(531, 278);
            this.chkJobOfferLicenseReady.Name = "chkJobOfferLicenseReady";
            this.chkJobOfferLicenseReady.Size = new System.Drawing.Size(103, 17);
            this.chkJobOfferLicenseReady.TabIndex = 14;
            this.chkJobOfferLicenseReady.Text = "License Ready?";
            this.chkJobOfferLicenseReady.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(202, 280);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(144, 13);
            this.label27.TabIndex = 13;
            this.label27.Text = "Name of the license authority";
            // 
            // txtJobOfferLicenseAuthority
            // 
            this.txtJobOfferLicenseAuthority.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferLicenseAuthority.Location = new System.Drawing.Point(350, 276);
            this.txtJobOfferLicenseAuthority.Name = "txtJobOfferLicenseAuthority";
            this.txtJobOfferLicenseAuthority.Size = new System.Drawing.Size(175, 20);
            this.txtJobOfferLicenseAuthority.TabIndex = 12;
            // 
            // chkJobOfferLicenseNeeded
            // 
            this.chkJobOfferLicenseNeeded.AutoSize = true;
            this.chkJobOfferLicenseNeeded.Location = new System.Drawing.Point(19, 279);
            this.chkJobOfferLicenseNeeded.Name = "chkJobOfferLicenseNeeded";
            this.chkJobOfferLicenseNeeded.Size = new System.Drawing.Size(156, 17);
            this.chkJobOfferLicenseNeeded.TabIndex = 11;
            this.chkJobOfferLicenseNeeded.Text = "Does this job need license?";
            this.chkJobOfferLicenseNeeded.UseVisualStyleBackColor = true;
            // 
            // txtJobOfferOtherBenifits
            // 
            this.txtJobOfferOtherBenifits.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferOtherBenifits.Location = new System.Drawing.Point(502, 194);
            this.txtJobOfferOtherBenifits.Name = "txtJobOfferOtherBenifits";
            this.txtJobOfferOtherBenifits.Size = new System.Drawing.Size(456, 20);
            this.txtJobOfferOtherBenifits.TabIndex = 10;
            // 
            // lblJobOfferOtherBenifits
            // 
            this.lblJobOfferOtherBenifits.AutoSize = true;
            this.lblJobOfferOtherBenifits.Location = new System.Drawing.Point(420, 196);
            this.lblJobOfferOtherBenifits.Name = "lblJobOfferOtherBenifits";
            this.lblJobOfferOtherBenifits.Size = new System.Drawing.Size(74, 13);
            this.lblJobOfferOtherBenifits.TabIndex = 9;
            this.lblJobOfferOtherBenifits.Text = "Other Benefits";
            // 
            // chkJobOfferFullDuration
            // 
            this.chkJobOfferFullDuration.AutoSize = true;
            this.chkJobOfferFullDuration.Location = new System.Drawing.Point(146, 223);
            this.chkJobOfferFullDuration.Name = "chkJobOfferFullDuration";
            this.chkJobOfferFullDuration.Size = new System.Drawing.Size(398, 17);
            this.chkJobOfferFullDuration.TabIndex = 8;
            this.chkJobOfferFullDuration.Text = "Is the job offer fully cover the duration of the LMIA stated ? if no, explain bel" +
    "ow:";
            this.chkJobOfferFullDuration.UseVisualStyleBackColor = true;
            // 
            // chkJobOfferSeasonal
            // 
            this.chkJobOfferSeasonal.AutoSize = true;
            this.chkJobOfferSeasonal.Location = new System.Drawing.Point(19, 223);
            this.chkJobOfferSeasonal.Name = "chkJobOfferSeasonal";
            this.chkJobOfferSeasonal.Size = new System.Drawing.Size(121, 17);
            this.chkJobOfferSeasonal.TabIndex = 7;
            this.chkJobOfferSeasonal.Text = "Is this job seasonal?";
            this.chkJobOfferSeasonal.UseVisualStyleBackColor = true;
            // 
            // txtJobOfferRemuneraton
            // 
            this.txtJobOfferRemuneraton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferRemuneraton.Location = new System.Drawing.Point(332, 191);
            this.txtJobOfferRemuneraton.Name = "txtJobOfferRemuneraton";
            this.txtJobOfferRemuneraton.Size = new System.Drawing.Size(76, 20);
            this.txtJobOfferRemuneraton.TabIndex = 6;
            this.txtJobOfferRemuneraton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJobOfferVacationDays
            // 
            this.txtJobOfferVacationDays.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferVacationDays.Location = new System.Drawing.Point(128, 193);
            this.txtJobOfferVacationDays.Name = "txtJobOfferVacationDays";
            this.txtJobOfferVacationDays.Size = new System.Drawing.Size(76, 20);
            this.txtJobOfferVacationDays.TabIndex = 6;
            this.txtJobOfferVacationDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJobOfferRemuneration
            // 
            this.txtJobOfferRemuneration.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferRemuneration.Location = new System.Drawing.Point(19, 246);
            this.txtJobOfferRemuneration.Multiline = true;
            this.txtJobOfferRemuneration.Name = "txtJobOfferRemuneration";
            this.txtJobOfferRemuneration.Size = new System.Drawing.Size(939, 20);
            this.txtJobOfferRemuneration.TabIndex = 6;
            // 
            // rdbJobOfferRemuneration
            // 
            this.rdbJobOfferRemuneration.AutoSize = true;
            this.rdbJobOfferRemuneration.Location = new System.Drawing.Point(210, 194);
            this.rdbJobOfferRemuneration.Name = "rdbJobOfferRemuneration";
            this.rdbJobOfferRemuneration.Size = new System.Drawing.Size(116, 17);
            this.rdbJobOfferRemuneration.TabIndex = 5;
            this.rdbJobOfferRemuneration.TabStop = true;
            this.rdbJobOfferRemuneration.Text = "Or Remuneration %";
            this.rdbJobOfferRemuneration.UseVisualStyleBackColor = true;
            // 
            // rdbJobOfferVacationDays
            // 
            this.rdbJobOfferVacationDays.AutoSize = true;
            this.rdbJobOfferVacationDays.Location = new System.Drawing.Point(22, 194);
            this.rdbJobOfferVacationDays.Name = "rdbJobOfferVacationDays";
            this.rdbJobOfferVacationDays.Size = new System.Drawing.Size(92, 17);
            this.rdbJobOfferVacationDays.TabIndex = 5;
            this.rdbJobOfferVacationDays.TabStop = true;
            this.rdbJobOfferVacationDays.Text = "Vacation days";
            this.rdbJobOfferVacationDays.UseVisualStyleBackColor = true;
            // 
            // grpLMIALanguage
            // 
            this.grpLMIALanguage.Controls.Add(this.chkLMIAOtherLanguage);
            this.grpLMIALanguage.Controls.Add(this.chkLMIAWritingEnglisAndFrench);
            this.grpLMIALanguage.Controls.Add(this.chkLMIAWritingEnglisOrFrench);
            this.grpLMIALanguage.Controls.Add(this.chkLMIAOralEnglisAndFrench);
            this.grpLMIALanguage.Controls.Add(this.chkLMIAWritingFrench);
            this.grpLMIALanguage.Controls.Add(this.chkLMIAOralEnglisOrFrench);
            this.grpLMIALanguage.Controls.Add(this.chkLMIAWritingEnglish);
            this.grpLMIALanguage.Controls.Add(this.chkLMIAOralFrench);
            this.grpLMIALanguage.Controls.Add(this.txtLMIAOtherLanguage);
            this.grpLMIALanguage.Controls.Add(this.chkLIMAWriting);
            this.grpLMIALanguage.Controls.Add(this.chkLMIAoralEnglish);
            this.grpLMIALanguage.Controls.Add(this.chkLIMAOralEnglish);
            this.grpLMIALanguage.Controls.Add(this.chkLanguageRequired);
            this.grpLMIALanguage.Location = new System.Drawing.Point(17, 34);
            this.grpLMIALanguage.Name = "grpLMIALanguage";
            this.grpLMIALanguage.Size = new System.Drawing.Size(950, 150);
            this.grpLMIALanguage.TabIndex = 4;
            this.grpLMIALanguage.TabStop = false;
            this.grpLMIALanguage.Text = "Language Requirement";
            // 
            // chkLMIAOtherLanguage
            // 
            this.chkLMIAOtherLanguage.AutoSize = true;
            this.chkLMIAOtherLanguage.Location = new System.Drawing.Point(8, 94);
            this.chkLMIAOtherLanguage.Name = "chkLMIAOtherLanguage";
            this.chkLMIAOtherLanguage.Size = new System.Drawing.Size(466, 17);
            this.chkLMIAOtherLanguage.TabIndex = 2;
            this.chkLMIAOtherLanguage.Text = "Is this job required to have language ability other than English or French, pleas" +
    "e explain below";
            this.chkLMIAOtherLanguage.UseVisualStyleBackColor = true;
            // 
            // chkLMIAWritingEnglisAndFrench
            // 
            this.chkLMIAWritingEnglisAndFrench.AutoSize = true;
            this.chkLMIAWritingEnglisAndFrench.Location = new System.Drawing.Point(755, 64);
            this.chkLMIAWritingEnglisAndFrench.Name = "chkLMIAWritingEnglisAndFrench";
            this.chkLMIAWritingEnglisAndFrench.Size = new System.Drawing.Size(117, 17);
            this.chkLMIAWritingEnglisAndFrench.TabIndex = 1;
            this.chkLMIAWritingEnglisAndFrench.Text = "English and French";
            this.chkLMIAWritingEnglisAndFrench.UseVisualStyleBackColor = true;
            // 
            // chkLMIAWritingEnglisOrFrench
            // 
            this.chkLMIAWritingEnglisOrFrench.AutoSize = true;
            this.chkLMIAWritingEnglisOrFrench.Location = new System.Drawing.Point(650, 64);
            this.chkLMIAWritingEnglisOrFrench.Name = "chkLMIAWritingEnglisOrFrench";
            this.chkLMIAWritingEnglisOrFrench.Size = new System.Drawing.Size(108, 17);
            this.chkLMIAWritingEnglisOrFrench.TabIndex = 1;
            this.chkLMIAWritingEnglisOrFrench.Text = "English or French";
            this.chkLMIAWritingEnglisOrFrench.UseVisualStyleBackColor = true;
            // 
            // chkLMIAOralEnglisAndFrench
            // 
            this.chkLMIAOralEnglisAndFrench.AutoSize = true;
            this.chkLMIAOralEnglisAndFrench.Location = new System.Drawing.Point(262, 64);
            this.chkLMIAOralEnglisAndFrench.Name = "chkLMIAOralEnglisAndFrench";
            this.chkLMIAOralEnglisAndFrench.Size = new System.Drawing.Size(117, 17);
            this.chkLMIAOralEnglisAndFrench.TabIndex = 1;
            this.chkLMIAOralEnglisAndFrench.Text = "English and French";
            this.chkLMIAOralEnglisAndFrench.UseVisualStyleBackColor = true;
            // 
            // chkLMIAWritingFrench
            // 
            this.chkLMIAWritingFrench.AutoSize = true;
            this.chkLMIAWritingFrench.Location = new System.Drawing.Point(585, 64);
            this.chkLMIAWritingFrench.Name = "chkLMIAWritingFrench";
            this.chkLMIAWritingFrench.Size = new System.Drawing.Size(59, 17);
            this.chkLMIAWritingFrench.TabIndex = 1;
            this.chkLMIAWritingFrench.Text = "French";
            this.chkLMIAWritingFrench.UseVisualStyleBackColor = true;
            // 
            // chkLMIAOralEnglisOrFrench
            // 
            this.chkLMIAOralEnglisOrFrench.AutoSize = true;
            this.chkLMIAOralEnglisOrFrench.Location = new System.Drawing.Point(157, 64);
            this.chkLMIAOralEnglisOrFrench.Name = "chkLMIAOralEnglisOrFrench";
            this.chkLMIAOralEnglisOrFrench.Size = new System.Drawing.Size(108, 17);
            this.chkLMIAOralEnglisOrFrench.TabIndex = 1;
            this.chkLMIAOralEnglisOrFrench.Text = "English or French";
            this.chkLMIAOralEnglisOrFrench.UseVisualStyleBackColor = true;
            // 
            // chkLMIAWritingEnglish
            // 
            this.chkLMIAWritingEnglish.AutoSize = true;
            this.chkLMIAWritingEnglish.Checked = true;
            this.chkLMIAWritingEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLMIAWritingEnglish.Location = new System.Drawing.Point(519, 64);
            this.chkLMIAWritingEnglish.Name = "chkLMIAWritingEnglish";
            this.chkLMIAWritingEnglish.Size = new System.Drawing.Size(60, 17);
            this.chkLMIAWritingEnglish.TabIndex = 1;
            this.chkLMIAWritingEnglish.Text = "English";
            this.chkLMIAWritingEnglish.UseVisualStyleBackColor = true;
            // 
            // chkLMIAOralFrench
            // 
            this.chkLMIAOralFrench.AutoSize = true;
            this.chkLMIAOralFrench.Location = new System.Drawing.Point(92, 64);
            this.chkLMIAOralFrench.Name = "chkLMIAOralFrench";
            this.chkLMIAOralFrench.Size = new System.Drawing.Size(59, 17);
            this.chkLMIAOralFrench.TabIndex = 1;
            this.chkLMIAOralFrench.Text = "French";
            this.chkLMIAOralFrench.UseVisualStyleBackColor = true;
            // 
            // txtLMIAOtherLanguage
            // 
            this.txtLMIAOtherLanguage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLMIAOtherLanguage.Location = new System.Drawing.Point(8, 127);
            this.txtLMIAOtherLanguage.Name = "txtLMIAOtherLanguage";
            this.txtLMIAOtherLanguage.Size = new System.Drawing.Size(929, 20);
            this.txtLMIAOtherLanguage.TabIndex = 1;
            // 
            // chkLIMAWriting
            // 
            this.chkLIMAWriting.AutoSize = true;
            this.chkLIMAWriting.Checked = true;
            this.chkLIMAWriting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLIMAWriting.Location = new System.Drawing.Point(499, 41);
            this.chkLIMAWriting.Name = "chkLIMAWriting";
            this.chkLIMAWriting.Size = new System.Drawing.Size(355, 17);
            this.chkLIMAWriting.TabIndex = 0;
            this.chkLIMAWriting.Text = "The offer of employment requires the ability to communicate  in writing:";
            this.chkLIMAWriting.UseVisualStyleBackColor = true;
            // 
            // chkLMIAoralEnglish
            // 
            this.chkLMIAoralEnglish.AutoSize = true;
            this.chkLMIAoralEnglish.Checked = true;
            this.chkLMIAoralEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLMIAoralEnglish.Location = new System.Drawing.Point(26, 64);
            this.chkLMIAoralEnglish.Name = "chkLMIAoralEnglish";
            this.chkLMIAoralEnglish.Size = new System.Drawing.Size(60, 17);
            this.chkLMIAoralEnglish.TabIndex = 1;
            this.chkLMIAoralEnglish.Text = "English";
            this.chkLMIAoralEnglish.UseVisualStyleBackColor = true;
            // 
            // chkLIMAOralEnglish
            // 
            this.chkLIMAOralEnglish.AutoSize = true;
            this.chkLIMAOralEnglish.Checked = true;
            this.chkLIMAOralEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLIMAOralEnglish.Location = new System.Drawing.Point(6, 41);
            this.chkLIMAOralEnglish.Name = "chkLIMAOralEnglish";
            this.chkLIMAOralEnglish.Size = new System.Drawing.Size(346, 17);
            this.chkLIMAOralEnglish.TabIndex = 0;
            this.chkLIMAOralEnglish.Text = "The offer of employment requires the ability to communicate orally in:";
            this.chkLIMAOralEnglish.UseVisualStyleBackColor = true;
            // 
            // chkLanguageRequired
            // 
            this.chkLanguageRequired.AutoSize = true;
            this.chkLanguageRequired.Checked = true;
            this.chkLanguageRequired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLanguageRequired.Location = new System.Drawing.Point(6, 19);
            this.chkLanguageRequired.Name = "chkLanguageRequired";
            this.chkLanguageRequired.Size = new System.Drawing.Size(265, 17);
            this.chkLanguageRequired.TabIndex = 3;
            this.chkLanguageRequired.Text = "This offer requires the English or/and French ability";
            this.chkLanguageRequired.UseVisualStyleBackColor = true;
            // 
            // cmbDurationUnit
            // 
            this.cmbDurationUnit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbDurationUnit.FormattingEnabled = true;
            this.cmbDurationUnit.Location = new System.Drawing.Point(333, 3);
            this.cmbDurationUnit.Name = "cmbDurationUnit";
            this.cmbDurationUnit.Size = new System.Drawing.Size(78, 21);
            this.cmbDurationUnit.TabIndex = 2;
            // 
            // txtJobOfferExpectedDuration
            // 
            this.txtJobOfferExpectedDuration.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferExpectedDuration.Location = new System.Drawing.Point(284, 4);
            this.txtJobOfferExpectedDuration.Name = "txtJobOfferExpectedDuration";
            this.txtJobOfferExpectedDuration.Size = new System.Drawing.Size(43, 20);
            this.txtJobOfferExpectedDuration.TabIndex = 1;
            this.txtJobOfferExpectedDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(189, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Expected duration";
            // 
            // txtJobOfferDurationRationale
            // 
            this.txtJobOfferDurationRationale.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferDurationRationale.Location = new System.Drawing.Point(516, 5);
            this.txtJobOfferDurationRationale.Multiline = true;
            this.txtJobOfferDurationRationale.Name = "txtJobOfferDurationRationale";
            this.txtJobOfferDurationRationale.Size = new System.Drawing.Size(217, 20);
            this.txtJobOfferDurationRationale.TabIndex = 1;
            // 
            // lblJobOfferDurationRationale
            // 
            this.lblJobOfferDurationRationale.AutoSize = true;
            this.lblJobOfferDurationRationale.Location = new System.Drawing.Point(422, 8);
            this.lblJobOfferDurationRationale.Name = "lblJobOfferDurationRationale";
            this.lblJobOfferDurationRationale.Size = new System.Drawing.Size(95, 13);
            this.lblJobOfferDurationRationale.TabIndex = 0;
            this.lblJobOfferDurationRationale.Text = "Duration Rationale";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(745, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(103, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Expected Start Date";
            // 
            // txtJobOfferNumberofTFW
            // 
            this.txtJobOfferNumberofTFW.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobOfferNumberofTFW.Location = new System.Drawing.Point(116, 5);
            this.txtJobOfferNumberofTFW.Name = "txtJobOfferNumberofTFW";
            this.txtJobOfferNumberofTFW.Size = new System.Drawing.Size(54, 20);
            this.txtJobOfferNumberofTFW.TabIndex = 1;
            this.txtJobOfferNumberofTFW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Number of TFWs";
            // 
            // tabAdvisor
            // 
            this.tabAdvisor.AutoScroll = true;
            this.tabAdvisor.CausesValidation = false;
            this.tabAdvisor.Controls.Add(this.tbcSubAdvisor);
            this.tabAdvisor.Location = new System.Drawing.Point(4, 22);
            this.tabAdvisor.Name = "tabAdvisor";
            this.tabAdvisor.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAdvisor.Size = new System.Drawing.Size(991, 658);
            this.tabAdvisor.TabIndex = 0;
            this.tabAdvisor.Text = "Advisor";
            this.tabAdvisor.UseVisualStyleBackColor = true;
            // 
            // tbcSubAdvisor
            // 
            this.tbcSubAdvisor.Controls.Add(this.tabAnalysis);
            this.tbcSubAdvisor.Controls.Add(this.tabBusinessDetails);
            this.tbcSubAdvisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcSubAdvisor.Location = new System.Drawing.Point(3, 3);
            this.tbcSubAdvisor.Name = "tbcSubAdvisor";
            this.tbcSubAdvisor.SelectedIndex = 0;
            this.tbcSubAdvisor.Size = new System.Drawing.Size(985, 652);
            this.tbcSubAdvisor.TabIndex = 0;
            // 
            // tabAnalysis
            // 
            this.tabAnalysis.AutoScroll = true;
            this.tabAnalysis.Controls.Add(this.grpApplicationStream);
            this.tabAnalysis.Controls.Add(this.grpLabourMarketFactors);
            this.tabAnalysis.Controls.Add(this.grpIndicator);
            this.tabAnalysis.Controls.Add(this.jobPositionAdvisor);
            this.tabAnalysis.Controls.Add(this.groupBox1);
            this.tabAnalysis.Controls.Add(this.financialAdvisor);
            this.tabAnalysis.Controls.Add(this.btnAnalysisClear);
            this.tabAnalysis.Controls.Add(this.btnAnalysisDelete);
            this.tabAnalysis.Controls.Add(this.btnAnalysisUpdate);
            this.tabAnalysis.Controls.Add(this.btnAnalysisInsert);
            this.tabAnalysis.Location = new System.Drawing.Point(4, 22);
            this.tabAnalysis.Name = "tabAnalysis";
            this.tabAnalysis.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAnalysis.Size = new System.Drawing.Size(977, 626);
            this.tabAnalysis.TabIndex = 0;
            this.tabAnalysis.Text = "Analysis";
            this.tabAnalysis.UseVisualStyleBackColor = true;
            // 
            // grpApplicationStream
            // 
            this.grpApplicationStream.Controls.Add(this.cmbLMIAProgram);
            this.grpApplicationStream.Controls.Add(this.txtAnotherEmployer);
            this.grpApplicationStream.Controls.Add(this.cmbStream);
            this.grpApplicationStream.Controls.Add(this.ckbOtherEmployer);
            this.grpApplicationStream.Controls.Add(this.lblSubCategory);
            this.grpApplicationStream.Controls.Add(this.lblAnotherEmployer);
            this.grpApplicationStream.Controls.Add(this.lblProgram);
            this.grpApplicationStream.Location = new System.Drawing.Point(5, 5);
            this.grpApplicationStream.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpApplicationStream.Name = "grpApplicationStream";
            this.grpApplicationStream.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpApplicationStream.Size = new System.Drawing.Size(969, 77);
            this.grpApplicationStream.TabIndex = 30;
            this.grpApplicationStream.TabStop = false;
            this.grpApplicationStream.Text = "Application Information";
            // 
            // cmbLMIAProgram
            // 
            this.cmbLMIAProgram.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbLMIAProgram.FormattingEnabled = true;
            this.cmbLMIAProgram.Location = new System.Drawing.Point(146, 28);
            this.cmbLMIAProgram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLMIAProgram.Name = "cmbLMIAProgram";
            this.cmbLMIAProgram.Size = new System.Drawing.Size(177, 21);
            this.cmbLMIAProgram.TabIndex = 12;
            this.cmbLMIAProgram.SelectionChangeCommitted += new System.EventHandler(this.cmbLMIAProgram_SelectionChangeCommitted);
            // 
            // txtAnotherEmployer
            // 
            this.txtAnotherEmployer.BackColor = System.Drawing.SystemColors.Window;
            this.txtAnotherEmployer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtAnotherEmployer.Location = new System.Drawing.Point(865, 29);
            this.txtAnotherEmployer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnotherEmployer.Name = "txtAnotherEmployer";
            this.txtAnotherEmployer.Size = new System.Drawing.Size(81, 20);
            this.txtAnotherEmployer.TabIndex = 3;
            // 
            // cmbStream
            // 
            this.cmbStream.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbStream.FormattingEnabled = true;
            this.cmbStream.Location = new System.Drawing.Point(433, 31);
            this.cmbStream.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStream.Name = "cmbStream";
            this.cmbStream.Size = new System.Drawing.Size(133, 21);
            this.cmbStream.TabIndex = 1;
            this.cmbStream.SelectionChangeCommitted += new System.EventHandler(this.cmbStream_SelectionChangeCommitted);
            // 
            // ckbOtherEmployer
            // 
            this.ckbOtherEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbOtherEmployer.AutoSize = true;
            this.ckbOtherEmployer.Location = new System.Drawing.Point(593, 31);
            this.ckbOtherEmployer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbOtherEmployer.Name = "ckbOtherEmployer";
            this.ckbOtherEmployer.Size = new System.Drawing.Size(139, 17);
            this.ckbOtherEmployer.TabIndex = 2;
            this.ckbOtherEmployer.Text = "More Than 1 Employer?";
            this.ckbOtherEmployer.UseVisualStyleBackColor = true;
            this.ckbOtherEmployer.CheckedChanged += new System.EventHandler(this.ckbOtherEmployer_CheckedChanged);
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Location = new System.Drawing.Point(335, 32);
            this.lblSubCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(73, 13);
            this.lblSubCategory.TabIndex = 8;
            this.lblSubCategory.Text = "Select Stream";
            // 
            // lblAnotherEmployer
            // 
            this.lblAnotherEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnotherEmployer.AutoSize = true;
            this.lblAnotherEmployer.Location = new System.Drawing.Point(742, 32);
            this.lblAnotherEmployer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnotherEmployer.Name = "lblAnotherEmployer";
            this.lblAnotherEmployer.Size = new System.Drawing.Size(110, 13);
            this.lblAnotherEmployer.TabIndex = 11;
            this.lblAnotherEmployer.Text = "Other Employer Name";
            // 
            // lblProgram
            // 
            this.lblProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(23, 32);
            this.lblProgram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(101, 13);
            this.lblProgram.TabIndex = 10;
            this.lblProgram.Text = "Application Program";
            // 
            // grpLabourMarketFactors
            // 
            this.grpLabourMarketFactors.Controls.Add(this.label26);
            this.grpLabourMarketFactors.Controls.Add(this.ckbLmFactor);
            this.grpLabourMarketFactors.Controls.Add(this.txtOccupationProfile);
            this.grpLabourMarketFactors.Controls.Add(this.btnOccupationProfile);
            this.grpLabourMarketFactors.Controls.Add(this.txtCOPSRating);
            this.grpLabourMarketFactors.Controls.Add(this.btnCOPSRate);
            this.grpLabourMarketFactors.Controls.Add(this.txtUnemployRate);
            this.grpLabourMarketFactors.Controls.Add(this.btnUmemploymentRate);
            this.grpLabourMarketFactors.Location = new System.Drawing.Point(7, 354);
            this.grpLabourMarketFactors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLabourMarketFactors.Name = "grpLabourMarketFactors";
            this.grpLabourMarketFactors.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLabourMarketFactors.Size = new System.Drawing.Size(343, 348);
            this.grpLabourMarketFactors.TabIndex = 29;
            this.grpLabourMarketFactors.TabStop = false;
            this.grpLabourMarketFactors.Text = "Labour market factors";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(51, 126);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(218, 13);
            this.label26.TabIndex = 13;
            this.label26.Text = "Check what hiring TFW can bring to Canada";
            // 
            // ckbLmFactor
            // 
            this.ckbLmFactor.CheckOnClick = true;
            this.ckbLmFactor.FormattingEnabled = true;
            this.ckbLmFactor.Location = new System.Drawing.Point(15, 150);
            this.ckbLmFactor.Name = "ckbLmFactor";
            this.ckbLmFactor.Size = new System.Drawing.Size(315, 154);
            this.ckbLmFactor.TabIndex = 3;
            this.ckbLmFactor.ThreeDCheckBoxes = true;
            // 
            // txtOccupationProfile
            // 
            this.txtOccupationProfile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtOccupationProfile.Location = new System.Drawing.Point(145, 88);
            this.txtOccupationProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOccupationProfile.Name = "txtOccupationProfile";
            this.txtOccupationProfile.Size = new System.Drawing.Size(184, 20);
            this.txtOccupationProfile.TabIndex = 2;
            this.txtOccupationProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOccupationProfile
            // 
            this.btnOccupationProfile.Location = new System.Drawing.Point(15, 85);
            this.btnOccupationProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOccupationProfile.Name = "btnOccupationProfile";
            this.btnOccupationProfile.Size = new System.Drawing.Size(115, 23);
            this.btnOccupationProfile.TabIndex = 9;
            this.btnOccupationProfile.Text = "Occupation Profile";
            this.btnOccupationProfile.UseVisualStyleBackColor = true;
            this.btnOccupationProfile.Click += new System.EventHandler(this.btnOccupationProfile_Click);
            // 
            // txtCOPSRating
            // 
            this.txtCOPSRating.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCOPSRating.Location = new System.Drawing.Point(145, 55);
            this.txtCOPSRating.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCOPSRating.Name = "txtCOPSRating";
            this.txtCOPSRating.Size = new System.Drawing.Size(184, 20);
            this.txtCOPSRating.TabIndex = 1;
            this.txtCOPSRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCOPSRate
            // 
            this.btnCOPSRate.Location = new System.Drawing.Point(15, 53);
            this.btnCOPSRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCOPSRate.Name = "btnCOPSRate";
            this.btnCOPSRate.Size = new System.Drawing.Size(93, 22);
            this.btnCOPSRate.TabIndex = 7;
            this.btnCOPSRate.Text = "COPS Rating";
            this.btnCOPSRate.UseVisualStyleBackColor = true;
            this.btnCOPSRate.Click += new System.EventHandler(this.btnCOPSRate_Click);
            // 
            // txtUnemployRate
            // 
            this.txtUnemployRate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUnemployRate.Location = new System.Drawing.Point(145, 20);
            this.txtUnemployRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnemployRate.Name = "txtUnemployRate";
            this.txtUnemployRate.Size = new System.Drawing.Size(184, 20);
            this.txtUnemployRate.TabIndex = 0;
            this.txtUnemployRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUmemploymentRate
            // 
            this.btnUmemploymentRate.Location = new System.Drawing.Point(15, 18);
            this.btnUmemploymentRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUmemploymentRate.Name = "btnUmemploymentRate";
            this.btnUmemploymentRate.Size = new System.Drawing.Size(113, 22);
            this.btnUmemploymentRate.TabIndex = 6;
            this.btnUmemploymentRate.Text = "Unemployment Rate";
            this.btnUmemploymentRate.UseVisualStyleBackColor = true;
            this.btnUmemploymentRate.Click += new System.EventHandler(this.btnUmemploymentRate_Click);
            // 
            // grpIndicator
            // 
            this.grpIndicator.Controls.Add(this.dgvQualificationIndicator);
            this.grpIndicator.Location = new System.Drawing.Point(728, 86);
            this.grpIndicator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpIndicator.Name = "grpIndicator";
            this.grpIndicator.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpIndicator.Size = new System.Drawing.Size(243, 260);
            this.grpIndicator.TabIndex = 28;
            this.grpIndicator.TabStop = false;
            this.grpIndicator.Text = "Indicators";
            // 
            // dgvQualificationIndicator
            // 
            this.dgvQualificationIndicator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQualificationIndicator.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQualificationIndicator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQualificationIndicator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckPoint,
            this.Result});
            this.dgvQualificationIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQualificationIndicator.EnableHeadersVisualStyles = false;
            this.dgvQualificationIndicator.Location = new System.Drawing.Point(2, 15);
            this.dgvQualificationIndicator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvQualificationIndicator.Name = "dgvQualificationIndicator";
            this.dgvQualificationIndicator.RowHeadersVisible = false;
            this.dgvQualificationIndicator.RowTemplate.Height = 28;
            this.dgvQualificationIndicator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQualificationIndicator.Size = new System.Drawing.Size(239, 243);
            this.dgvQualificationIndicator.TabIndex = 1;
            // 
            // CheckPoint
            // 
            this.CheckPoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CheckPoint.FillWeight = 200F;
            this.CheckPoint.HeaderText = "Check Point";
            this.CheckPoint.Name = "CheckPoint";
            this.CheckPoint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Result
            // 
            this.Result.FillWeight = 50F;
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.Width = 65;
            // 
            // jobPositionAdvisor
            // 
            this.jobPositionAdvisor.Location = new System.Drawing.Point(4, 86);
            this.jobPositionAdvisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobPositionAdvisor.Name = "jobPositionAdvisor";
            this.jobPositionAdvisor.Size = new System.Drawing.Size(722, 156);
            this.jobPositionAdvisor.TabIndex = 0;
            this.jobPositionAdvisor.Leave += new System.EventHandler(this.jobPositionAdvisor_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSituationImpact);
            this.groupBox1.Controls.Add(this.txtEmployerSituation);
            this.groupBox1.Location = new System.Drawing.Point(361, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 354);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reasonable Employment Need";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "The impact of the current situation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "The situation the employer is currely facing";
            // 
            // txtSituationImpact
            // 
            this.txtSituationImpact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSituationImpact.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSituationImpact.Location = new System.Drawing.Point(0, 217);
            this.txtSituationImpact.Multiline = true;
            this.txtSituationImpact.Name = "txtSituationImpact";
            this.txtSituationImpact.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSituationImpact.Size = new System.Drawing.Size(612, 137);
            this.txtSituationImpact.TabIndex = 1;
            // 
            // txtEmployerSituation
            // 
            this.txtEmployerSituation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployerSituation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmployerSituation.Location = new System.Drawing.Point(0, 53);
            this.txtEmployerSituation.Multiline = true;
            this.txtEmployerSituation.Name = "txtEmployerSituation";
            this.txtEmployerSituation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEmployerSituation.Size = new System.Drawing.Size(613, 121);
            this.txtEmployerSituation.TabIndex = 0;
            // 
            // financialAdvisor
            // 
            this.financialAdvisor.Location = new System.Drawing.Point(7, 241);
            this.financialAdvisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.financialAdvisor.Name = "financialAdvisor";
            this.financialAdvisor.Size = new System.Drawing.Size(720, 105);
            this.financialAdvisor.TabIndex = 1;
            this.financialAdvisor.Leave += new System.EventHandler(this.financialAdvisor_Leave);
            // 
            // btnAnalysisClear
            // 
            this.btnAnalysisClear.Location = new System.Drawing.Point(288, 711);
            this.btnAnalysisClear.Name = "btnAnalysisClear";
            this.btnAnalysisClear.Size = new System.Drawing.Size(75, 23);
            this.btnAnalysisClear.TabIndex = 5;
            this.btnAnalysisClear.Text = "Clear";
            this.btnAnalysisClear.UseVisualStyleBackColor = true;
            this.btnAnalysisClear.Click += new System.EventHandler(this.btnAnalysisNew_Click);
            // 
            // btnAnalysisDelete
            // 
            this.btnAnalysisDelete.Location = new System.Drawing.Point(195, 711);
            this.btnAnalysisDelete.Name = "btnAnalysisDelete";
            this.btnAnalysisDelete.Size = new System.Drawing.Size(75, 23);
            this.btnAnalysisDelete.TabIndex = 4;
            this.btnAnalysisDelete.Text = "Delete";
            this.btnAnalysisDelete.UseVisualStyleBackColor = true;
            this.btnAnalysisDelete.Click += new System.EventHandler(this.btnAnalysisDelete_Click);
            // 
            // btnAnalysisUpdate
            // 
            this.btnAnalysisUpdate.Location = new System.Drawing.Point(101, 711);
            this.btnAnalysisUpdate.Name = "btnAnalysisUpdate";
            this.btnAnalysisUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAnalysisUpdate.TabIndex = 3;
            this.btnAnalysisUpdate.Text = "Update";
            this.btnAnalysisUpdate.UseVisualStyleBackColor = true;
            this.btnAnalysisUpdate.Click += new System.EventHandler(this.btnAnalysisUpdate_Click);
            // 
            // btnAnalysisInsert
            // 
            this.btnAnalysisInsert.Location = new System.Drawing.Point(7, 711);
            this.btnAnalysisInsert.Name = "btnAnalysisInsert";
            this.btnAnalysisInsert.Size = new System.Drawing.Size(75, 23);
            this.btnAnalysisInsert.TabIndex = 2;
            this.btnAnalysisInsert.Text = "Insert";
            this.btnAnalysisInsert.UseVisualStyleBackColor = true;
            this.btnAnalysisInsert.Click += new System.EventHandler(this.btnAnalysisInsert_Click);
            // 
            // tabBusinessDetails
            // 
            this.tabBusinessDetails.Controls.Add(this.btnUpdateBD);
            this.tabBusinessDetails.Controls.Add(this.btnDeleteBD);
            this.tabBusinessDetails.Controls.Add(this.btnBDClear);
            this.tabBusinessDetails.Controls.Add(this.groupBox3);
            this.tabBusinessDetails.Controls.Add(this.grpLayOff);
            this.tabBusinessDetails.Controls.Add(this.grpLMIARecord);
            this.tabBusinessDetails.Controls.Add(this.grpEmployeeStructure);
            this.tabBusinessDetails.Location = new System.Drawing.Point(4, 22);
            this.tabBusinessDetails.Name = "tabBusinessDetails";
            this.tabBusinessDetails.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabBusinessDetails.Size = new System.Drawing.Size(980, 748);
            this.tabBusinessDetails.TabIndex = 1;
            this.tabBusinessDetails.Text = "Business Details";
            this.tabBusinessDetails.UseVisualStyleBackColor = true;
            this.tabBusinessDetails.Layout += new System.Windows.Forms.LayoutEventHandler(this.tabBusinessDetails_Layout);
            // 
            // btnUpdateBD
            // 
            this.btnUpdateBD.Location = new System.Drawing.Point(619, 621);
            this.btnUpdateBD.Name = "btnUpdateBD";
            this.btnUpdateBD.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBD.TabIndex = 4;
            this.btnUpdateBD.Text = "Update";
            this.btnUpdateBD.UseVisualStyleBackColor = true;
            this.btnUpdateBD.Click += new System.EventHandler(this.btnUpdateBD_Click);
            // 
            // btnDeleteBD
            // 
            this.btnDeleteBD.Location = new System.Drawing.Point(705, 621);
            this.btnDeleteBD.Name = "btnDeleteBD";
            this.btnDeleteBD.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBD.TabIndex = 4;
            this.btnDeleteBD.Text = "Delete";
            this.btnDeleteBD.UseVisualStyleBackColor = true;
            this.btnDeleteBD.Click += new System.EventHandler(this.btnDeleteBD_Click);
            // 
            // btnBDClear
            // 
            this.btnBDClear.Location = new System.Drawing.Point(786, 621);
            this.btnBDClear.Name = "btnBDClear";
            this.btnBDClear.Size = new System.Drawing.Size(75, 23);
            this.btnBDClear.TabIndex = 4;
            this.btnBDClear.Text = "Clear";
            this.btnBDClear.UseVisualStyleBackColor = true;
            this.btnBDClear.Click += new System.EventHandler(this.btnNewBD_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkBizDetailQ10);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.chkBizDetailQ10Explain);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Location = new System.Drawing.Point(6, 482);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(967, 103);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receive support from government";
            // 
            // chkBizDetailQ10
            // 
            this.chkBizDetailQ10.AutoSize = true;
            this.chkBizDetailQ10.Location = new System.Drawing.Point(12, 19);
            this.chkBizDetailQ10.Name = "chkBizDetailQ10";
            this.chkBizDetailQ10.Size = new System.Drawing.Size(592, 17);
            this.chkBizDetailQ10.TabIndex = 0;
            this.chkBizDetailQ10.Text = "10. Does your business receive support through Employment and Social Development " +
    "Canada\'s Work-Sharing program?";
            this.chkBizDetailQ10.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(326, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(255, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "You answered yes, so how many Canadians laid off?";
            // 
            // chkBizDetailQ10Explain
            // 
            this.chkBizDetailQ10Explain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chkBizDetailQ10Explain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chkBizDetailQ10Explain.Location = new System.Drawing.Point(49, 72);
            this.chkBizDetailQ10Explain.Name = "chkBizDetailQ10Explain";
            this.chkBizDetailQ10Explain.Size = new System.Drawing.Size(899, 20);
            this.chkBizDetailQ10Explain.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(46, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "If yes, provide details";
            // 
            // grpLayOff
            // 
            this.grpLayOff.Controls.Add(this.chkBizDetailQ9);
            this.grpLayOff.Controls.Add(this.label19);
            this.grpLayOff.Controls.Add(this.txtLayoffCanadians);
            this.grpLayOff.Controls.Add(this.txtTFWs);
            this.grpLayOff.Controls.Add(this.label18);
            this.grpLayOff.Controls.Add(this.chkBizDetailQ9Explain);
            this.grpLayOff.Controls.Add(this.label20);
            this.grpLayOff.Location = new System.Drawing.Point(6, 364);
            this.grpLayOff.Name = "grpLayOff";
            this.grpLayOff.Size = new System.Drawing.Size(967, 103);
            this.grpLayOff.TabIndex = 2;
            this.grpLayOff.TabStop = false;
            this.grpLayOff.Text = "Lay Off";
            // 
            // chkBizDetailQ9
            // 
            this.chkBizDetailQ9.AutoSize = true;
            this.chkBizDetailQ9.Location = new System.Drawing.Point(12, 19);
            this.chkBizDetailQ9.Name = "chkBizDetailQ9";
            this.chkBizDetailQ9.Size = new System.Drawing.Size(281, 17);
            this.chkBizDetailQ9.TabIndex = 0;
            this.chkBizDetailQ9.Text = "9. Were any employees laid off in the past 12 months?";
            this.chkBizDetailQ9.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(724, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "How many TFW?";
            // 
            // txtLayoffCanadians
            // 
            this.txtLayoffCanadians.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLayoffCanadians.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLayoffCanadians.Location = new System.Drawing.Point(619, 16);
            this.txtLayoffCanadians.Name = "txtLayoffCanadians";
            this.txtLayoffCanadians.Size = new System.Drawing.Size(69, 20);
            this.txtLayoffCanadians.TabIndex = 3;
            this.txtLayoffCanadians.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTFWs
            // 
            this.txtTFWs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTFWs.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTFWs.Location = new System.Drawing.Point(848, 17);
            this.txtTFWs.Name = "txtTFWs";
            this.txtTFWs.Size = new System.Drawing.Size(100, 20);
            this.txtTFWs.TabIndex = 4;
            this.txtTFWs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(326, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(255, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "You answered yes, so how many Canadians laid off?";
            // 
            // chkBizDetailQ9Explain
            // 
            this.chkBizDetailQ9Explain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chkBizDetailQ9Explain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chkBizDetailQ9Explain.Location = new System.Drawing.Point(49, 72);
            this.chkBizDetailQ9Explain.Name = "chkBizDetailQ9Explain";
            this.chkBizDetailQ9Explain.Size = new System.Drawing.Size(899, 20);
            this.chkBizDetailQ9Explain.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(46, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(236, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Reason(s) for layoff(s) and occupations affected:";
            // 
            // grpLMIARecord
            // 
            this.grpLMIARecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLMIARecord.Controls.Add(this.DTPQ8);
            this.grpLMIARecord.Controls.Add(this.chkLMIAMisRep);
            this.grpLMIARecord.Controls.Add(this.chkLMIACompliance1415);
            this.grpLMIARecord.Controls.Add(this.chkBizDetailQ8);
            this.grpLMIARecord.Controls.Add(this.chkLMIA1415);
            this.grpLMIARecord.Controls.Add(this.chkLMIACompliance1213);
            this.grpLMIARecord.Controls.Add(this.chkLMIA1213);
            this.grpLMIARecord.Controls.Add(this.label15);
            this.grpLMIARecord.Controls.Add(this.label17);
            this.grpLMIARecord.Controls.Add(this.label12);
            this.grpLMIARecord.Controls.Add(this.txtLMIASFN);
            this.grpLMIARecord.Controls.Add(this.txtLMIAPublicPolicy);
            this.grpLMIARecord.Location = new System.Drawing.Point(3, 173);
            this.grpLMIARecord.Name = "grpLMIARecord";
            this.grpLMIARecord.Size = new System.Drawing.Size(969, 182);
            this.grpLMIARecord.TabIndex = 1;
            this.grpLMIARecord.TabStop = false;
            this.grpLMIARecord.Text = "LMIA Record";
            // 
            // DTPQ8
            // 
            this.DTPQ8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPQ8.Location = new System.Drawing.Point(377, 94);
            this.DTPQ8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTPQ8.Name = "DTPQ8";
            this.DTPQ8.Size = new System.Drawing.Size(144, 20);
            this.DTPQ8.TabIndex = 6;
            // 
            // chkLMIAMisRep
            // 
            this.chkLMIAMisRep.AutoSize = true;
            this.chkLMIAMisRep.Location = new System.Drawing.Point(54, 95);
            this.chkLMIAMisRep.Name = "chkLMIAMisRep";
            this.chkLMIAMisRep.Size = new System.Drawing.Size(159, 17);
            this.chkLMIAMisRep.TabIndex = 5;
            this.chkLMIAMisRep.Text = "Revocation due to MisRep?";
            this.chkLMIAMisRep.UseVisualStyleBackColor = true;
            // 
            // chkLMIACompliance1415
            // 
            this.chkLMIACompliance1415.AutoSize = true;
            this.chkLMIACompliance1415.Location = new System.Drawing.Point(499, 47);
            this.chkLMIACompliance1415.Name = "chkLMIACompliance1415";
            this.chkLMIACompliance1415.Size = new System.Drawing.Size(267, 17);
            this.chkLMIACompliance1415.TabIndex = 3;
            this.chkLMIACompliance1415.Text = "Did you comply with the rquirement in LMIA annex?";
            this.chkLMIACompliance1415.UseVisualStyleBackColor = true;
            // 
            // chkBizDetailQ8
            // 
            this.chkBizDetailQ8.AutoSize = true;
            this.chkBizDetailQ8.Location = new System.Drawing.Point(14, 72);
            this.chkBizDetailQ8.Name = "chkBizDetailQ8";
            this.chkBizDetailQ8.Size = new System.Drawing.Size(527, 17);
            this.chkBizDetailQ8.TabIndex = 4;
            this.chkBizDetailQ8.Text = "8.Have you had an LMIA revoked within the previous 2 years from the date you subm" +
    "itted this application?";
            this.chkBizDetailQ8.UseVisualStyleBackColor = true;
            // 
            // chkLMIA1415
            // 
            this.chkLMIA1415.AutoSize = true;
            this.chkLMIA1415.Location = new System.Drawing.Point(14, 49);
            this.chkLMIA1415.Name = "chkLMIA1415";
            this.chkLMIA1415.Size = new System.Drawing.Size(405, 17);
            this.chkLMIA1415.TabIndex = 2;
            this.chkLMIA1415.Text = "7. Did you employ a TFW (as the result of receiving a positive LMIA) in 2014-15?";
            this.chkLMIA1415.UseVisualStyleBackColor = true;
            // 
            // chkLMIACompliance1213
            // 
            this.chkLMIACompliance1213.AutoSize = true;
            this.chkLMIACompliance1213.Location = new System.Drawing.Point(499, 24);
            this.chkLMIACompliance1213.Name = "chkLMIACompliance1213";
            this.chkLMIACompliance1213.Size = new System.Drawing.Size(267, 17);
            this.chkLMIACompliance1213.TabIndex = 1;
            this.chkLMIACompliance1213.Text = "Did you comply with the rquirement in LMIA annex?";
            this.chkLMIACompliance1213.UseVisualStyleBackColor = true;
            // 
            // chkLMIA1213
            // 
            this.chkLMIA1213.AutoSize = true;
            this.chkLMIA1213.Location = new System.Drawing.Point(14, 26);
            this.chkLMIA1213.Name = "chkLMIA1213";
            this.chkLMIA1213.Size = new System.Drawing.Size(405, 17);
            this.chkLMIA1213.TabIndex = 0;
            this.chkLMIA1213.Text = "6. Did you employ a TFW (as the result of receiving a positive LMIA) in 2012-13?";
            this.chkLMIA1213.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(524, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "System File Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(49, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(583, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "If the public policy considerations that justified the revocation are no longer r" +
    "elevant, please provide a detailed explanation:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(263, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Revocation Date";
            // 
            // txtLMIASFN
            // 
            this.txtLMIASFN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLMIASFN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLMIASFN.Location = new System.Drawing.Point(666, 95);
            this.txtLMIASFN.Name = "txtLMIASFN";
            this.txtLMIASFN.Size = new System.Drawing.Size(100, 20);
            this.txtLMIASFN.TabIndex = 7;
            this.txtLMIASFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLMIAPublicPolicy
            // 
            this.txtLMIAPublicPolicy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLMIAPublicPolicy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLMIAPublicPolicy.Location = new System.Drawing.Point(52, 147);
            this.txtLMIAPublicPolicy.Name = "txtLMIAPublicPolicy";
            this.txtLMIAPublicPolicy.Size = new System.Drawing.Size(899, 20);
            this.txtLMIAPublicPolicy.TabIndex = 8;
            // 
            // grpEmployeeStructure
            // 
            this.grpEmployeeStructure.Controls.Add(this.txtBizDetailQ5);
            this.grpEmployeeStructure.Controls.Add(this.txtBizDetailQ4);
            this.grpEmployeeStructure.Controls.Add(this.label11);
            this.grpEmployeeStructure.Controls.Add(this.txtBizDetailQ3);
            this.grpEmployeeStructure.Controls.Add(this.label10);
            this.grpEmployeeStructure.Controls.Add(this.txtBizDetailQ2);
            this.grpEmployeeStructure.Controls.Add(this.label9);
            this.grpEmployeeStructure.Controls.Add(this.txtBizDetailQ1);
            this.grpEmployeeStructure.Controls.Add(this.label8);
            this.grpEmployeeStructure.Controls.Add(this.label7);
            this.grpEmployeeStructure.Controls.Add(this.label6);
            this.grpEmployeeStructure.Location = new System.Drawing.Point(3, 3);
            this.grpEmployeeStructure.Name = "grpEmployeeStructure";
            this.grpEmployeeStructure.Size = new System.Drawing.Size(970, 164);
            this.grpEmployeeStructure.TabIndex = 0;
            this.grpEmployeeStructure.TabStop = false;
            this.grpEmployeeStructure.Text = "Employee Structure";
            // 
            // txtBizDetailQ5
            // 
            this.txtBizDetailQ5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBizDetailQ5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBizDetailQ5.Location = new System.Drawing.Point(851, 124);
            this.txtBizDetailQ5.Name = "txtBizDetailQ5";
            this.txtBizDetailQ5.Size = new System.Drawing.Size(100, 20);
            this.txtBizDetailQ5.TabIndex = 4;
            this.txtBizDetailQ5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBizDetailQ4
            // 
            this.txtBizDetailQ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBizDetailQ4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBizDetailQ4.Location = new System.Drawing.Point(851, 98);
            this.txtBizDetailQ4.Name = "txtBizDetailQ4";
            this.txtBizDetailQ4.Size = new System.Drawing.Size(100, 20);
            this.txtBizDetailQ4.TabIndex = 3;
            this.txtBizDetailQ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(526, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "5. Total number of TFWs (as the result of receiving a positive LMIA) at the work " +
    "location specified on this form:";
            // 
            // txtBizDetailQ3
            // 
            this.txtBizDetailQ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBizDetailQ3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBizDetailQ3.Location = new System.Drawing.Point(851, 72);
            this.txtBizDetailQ3.Name = "txtBizDetailQ3";
            this.txtBizDetailQ3.Size = new System.Drawing.Size(100, 20);
            this.txtBizDetailQ3.TabIndex = 2;
            this.txtBizDetailQ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(629, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "4. Total number of employees (including Canadians/permanent residents and TFWs) w" +
    "orking in this occupation at this work location.";
            // 
            // txtBizDetailQ2
            // 
            this.txtBizDetailQ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBizDetailQ2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBizDetailQ2.Location = new System.Drawing.Point(851, 46);
            this.txtBizDetailQ2.Name = "txtBizDetailQ2";
            this.txtBizDetailQ2.Size = new System.Drawing.Size(100, 20);
            this.txtBizDetailQ2.TabIndex = 1;
            this.txtBizDetailQ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(490, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "3. Total number of Canadian/permanent resident employees at the work location spe" +
    "cified on this form:";
            // 
            // txtBizDetailQ1
            // 
            this.txtBizDetailQ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBizDetailQ1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBizDetailQ1.Location = new System.Drawing.Point(851, 20);
            this.txtBizDetailQ1.Name = "txtBizDetailQ1";
            this.txtBizDetailQ1.Size = new System.Drawing.Size(100, 20);
            this.txtBizDetailQ1.TabIndex = 0;
            this.txtBizDetailQ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(438, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "2. Total number of employees currently employed at the work location specified on" +
    " this form:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-122, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(517, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "1. Number of employees currently employed nationally under this Canada Revenue Ag" +
    "ency Business number";
            // 
            // tabBase
            // 
            this.tabBase.Controls.Add(this.tabAdvisor);
            this.tabBase.Controls.Add(this.tabApplication);
            this.tabBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBase.Location = new System.Drawing.Point(0, 0);
            this.tabBase.Name = "tabBase";
            this.tabBase.SelectedIndex = 0;
            this.tabBase.Size = new System.Drawing.Size(999, 684);
            this.tabBase.TabIndex = 0;
            // 
            // LMIAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(999, 684);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabBase);
            this.Name = "LMIAForm";
            this.Text = "LMIA adviser and Application ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LMIAForm_FormClosing);
            this.Load += new System.EventHandler(this.LMIAForm_Load);
            this.TextChanged += new System.EventHandler(this.LMIAForm_TextChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabApplication.ResumeLayout(false);
            this.tabLMIAApplication.ResumeLayout(false);
            this.tabAD.ResumeLayout(false);
            this.tabAD.PerformLayout();
            this.grpWorkLocation.ResumeLayout(false);
            this.grpWorkLocation.PerformLayout();
            this.grpJobAd.ResumeLayout(false);
            this.grpJobAd.PerformLayout();
            this.tabMainDuties.ResumeLayout(false);
            this.grpPositionMainDuties.ResumeLayout(false);
            this.grpPositionMainDuties.PerformLayout();
            this.grpESDCMainDuties.ResumeLayout(false);
            this.grpESDCMainDuties.PerformLayout();
            this.tabQualifications.ResumeLayout(false);
            this.grpPositionQualification.ResumeLayout(false);
            this.grpSkill.ResumeLayout(false);
            this.grpSkill.PerformLayout();
            this.grpLanguage.ResumeLayout(false);
            this.grpLanguage.PerformLayout();
            this.grpOthers.ResumeLayout(false);
            this.grpOthers.PerformLayout();
            this.grpWorkExp.ResumeLayout(false);
            this.grpWorkExp.PerformLayout();
            this.grpESDCQualification.ResumeLayout(false);
            this.grpESDCQualification.PerformLayout();
            this.tabMedia.ResumeLayout(false);
            this.tabMedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).EndInit();
            this.tabJobOffer.ResumeLayout(false);
            this.tabJobOffer.PerformLayout();
            this.grpLMIALanguage.ResumeLayout(false);
            this.grpLMIALanguage.PerformLayout();
            this.tabAdvisor.ResumeLayout(false);
            this.tbcSubAdvisor.ResumeLayout(false);
            this.tabAnalysis.ResumeLayout(false);
            this.grpApplicationStream.ResumeLayout(false);
            this.grpApplicationStream.PerformLayout();
            this.grpLabourMarketFactors.ResumeLayout(false);
            this.grpLabourMarketFactors.PerformLayout();
            this.grpIndicator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualificationIndicator)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabBusinessDetails.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpLayOff.ResumeLayout(false);
            this.grpLayOff.PerformLayout();
            this.grpLMIARecord.ResumeLayout(false);
            this.grpLMIARecord.PerformLayout();
            this.grpEmployeeStructure.ResumeLayout(false);
            this.grpEmployeeStructure.PerformLayout();
            this.tabBase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tssLMIAEmployer;
        public System.Windows.Forms.ToolStripStatusLabel tssLMIAEmployee;
        public System.Windows.Forms.ToolStripStatusLabel tssLMIARCIC;
        public System.Windows.Forms.ToolStripStatusLabel tssLMIAProgram;
        public System.Windows.Forms.ToolStripStatusLabel tssLMIAStream;
        public System.Windows.Forms.ToolStripStatusLabel tssLMIAApplication;
        private System.Windows.Forms.TabPage tabApplication;
        public System.Windows.Forms.TabPage tabAD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabMainDuties;
        private System.Windows.Forms.TabPage tabQualifications;
        private System.Windows.Forms.Button btnJobPostSave;
        private System.Windows.Forms.Button btnGoForPosting;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblSpecific;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label lblOfficial;
        public System.Windows.Forms.TabPage tabJobOffer;
        public System.Windows.Forms.DateTimePicker dtpJobOfferStartDate;
        private System.Windows.Forms.Button btnJobOfferClear;
        private System.Windows.Forms.Button btnJobOfferSave;
        public System.Windows.Forms.Button btnJobOfferWhentoOffer;
        public System.Windows.Forms.TextBox txtJobOfferWhentoOffer;
        public System.Windows.Forms.Label lblJobOfferWhentoOffer;
        public System.Windows.Forms.Button btnJobOfferHowtoDetermine;
        public System.Windows.Forms.TextBox txtJobOfferHowtoDetermine;
        public System.Windows.Forms.Label lblJobOfferHowtoQualify;
        public System.Windows.Forms.Button btnJobOfferHowDidYouFind;
        public System.Windows.Forms.Label lblJobOfferHowDidYouFind;
        public System.Windows.Forms.TextBox txtJobOfferHowDidYouFind;
        public System.Windows.Forms.Button btnJobOfferWhoFillInTheJob;
        public System.Windows.Forms.Label lblJobOfferWhoCurrentInThePosition;
        public System.Windows.Forms.TextBox txtJobOfferWhoFillInThisJob;
        private System.Windows.Forms.Label lblJobOfferProvideAssistant;
        public System.Windows.Forms.TextBox txtJobOfferProvideAssistant;
        public System.Windows.Forms.CheckBox chkJobOfferProvideRentNA;
        public System.Windows.Forms.ComboBox cmbJobOfferProvideRent;
        public System.Windows.Forms.Label lblJobOfferAccomodationDescription;
        public System.Windows.Forms.Label lblJobOfferProvideRent;
        public System.Windows.Forms.TextBox txtJobOfferAccomadationDescription;
        public System.Windows.Forms.TextBox txtJobOfferProvideRent;
        public System.Windows.Forms.CheckBox chkJobOfferProvideAccomadation;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label30;
        public System.Windows.Forms.TextBox txtJobOfferTrainCanadian;
        public System.Windows.Forms.CheckBox chkJobOfferTrainCanadian;
        public System.Windows.Forms.Button btnJobOfferRationale;
        public System.Windows.Forms.TextBox txtJobOfferOfferRationale;
        private System.Windows.Forms.Label lblJobOfferOfferRational;
        public System.Windows.Forms.Button btnJobOfferBenefitDetails;
        public System.Windows.Forms.TextBox txtJobOfferBenefitBrief;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblJobOfferJobCreation;
        private System.Windows.Forms.Label lblJobOfferSkillTransfer;
        private System.Windows.Forms.Label lblFillingLabourShortage;
        private System.Windows.Forms.Label lblJobOfferPotentialBenifit;
        public System.Windows.Forms.Label lblJobOfferRecruitCanadian;
        public System.Windows.Forms.TextBox txtJobOfferRecruitCanadian;
        public System.Windows.Forms.CheckBox chkJobOfferRecruitCanadian;
        public System.Windows.Forms.Label lblJobOfferUnionConsulted;
        public System.Windows.Forms.TextBox txtJobOfferUnionExpOrOpinion;
        public System.Windows.Forms.CheckBox chkJobOfferUnionConsulted;
        public System.Windows.Forms.CheckBox chkJobOfferIsUnion;
        public System.Windows.Forms.Label label29;
        public System.Windows.Forms.TextBox txtJobOfferUnionName;
        public System.Windows.Forms.ComboBox cmbJobOfferDWM;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.TextBox txtJobOfferHowlongLicense;
        public System.Windows.Forms.CheckBox chkJobOfferLicenseReady;
        public System.Windows.Forms.Label label27;
        public System.Windows.Forms.TextBox txtJobOfferLicenseAuthority;
        public System.Windows.Forms.CheckBox chkJobOfferLicenseNeeded;
        public System.Windows.Forms.TextBox txtJobOfferOtherBenifits;
        public System.Windows.Forms.Label lblJobOfferOtherBenifits;
        public System.Windows.Forms.CheckBox chkJobOfferFullDuration;
        public System.Windows.Forms.CheckBox chkJobOfferSeasonal;
        public System.Windows.Forms.TextBox txtJobOfferRemuneraton;
        public System.Windows.Forms.TextBox txtJobOfferVacationDays;
        public System.Windows.Forms.TextBox txtJobOfferRemuneration;
        public System.Windows.Forms.RadioButton rdbJobOfferRemuneration;
        public System.Windows.Forms.RadioButton rdbJobOfferVacationDays;
        private System.Windows.Forms.GroupBox grpLMIALanguage;
        public System.Windows.Forms.CheckBox chkLMIAOtherLanguage;
        public System.Windows.Forms.CheckBox chkLMIAWritingEnglisAndFrench;
        public System.Windows.Forms.CheckBox chkLMIAWritingEnglisOrFrench;
        public System.Windows.Forms.CheckBox chkLMIAOralEnglisAndFrench;
        public System.Windows.Forms.CheckBox chkLMIAWritingFrench;
        public System.Windows.Forms.CheckBox chkLMIAOralEnglisOrFrench;
        public System.Windows.Forms.CheckBox chkLMIAWritingEnglish;
        public System.Windows.Forms.CheckBox chkLMIAOralFrench;
        public System.Windows.Forms.TextBox txtLMIAOtherLanguage;
        public System.Windows.Forms.CheckBox chkLIMAWriting;
        public System.Windows.Forms.CheckBox chkLMIAoralEnglish;
        public System.Windows.Forms.CheckBox chkLIMAOralEnglish;
        public System.Windows.Forms.CheckBox chkLanguageRequired;
        public System.Windows.Forms.ComboBox cmbDurationUnit;
        public System.Windows.Forms.TextBox txtJobOfferExpectedDuration;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.TextBox txtJobOfferDurationRationale;
        private System.Windows.Forms.Label lblJobOfferDurationRationale;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.TextBox txtJobOfferNumberofTFW;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tabAdvisor;
        private System.Windows.Forms.TabControl tbcSubAdvisor;
        private System.Windows.Forms.TabPage tabBusinessDetails;
        private System.Windows.Forms.Button btnUpdateBD;
        private System.Windows.Forms.Button btnDeleteBD;
        private System.Windows.Forms.Button btnBDClear;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.CheckBox chkBizDetailQ10;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox chkBizDetailQ10Explain;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox grpLayOff;
        public System.Windows.Forms.CheckBox chkBizDetailQ9;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtLayoffCanadians;
        public System.Windows.Forms.TextBox txtTFWs;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox chkBizDetailQ9Explain;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox grpLMIARecord;
        public System.Windows.Forms.DateTimePicker DTPQ8;
        public System.Windows.Forms.CheckBox chkLMIAMisRep;
        public System.Windows.Forms.CheckBox chkLMIACompliance1415;
        public System.Windows.Forms.CheckBox chkBizDetailQ8;
        public System.Windows.Forms.CheckBox chkLMIA1415;
        public System.Windows.Forms.CheckBox chkLMIACompliance1213;
        public System.Windows.Forms.CheckBox chkLMIA1213;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtLMIASFN;
        public System.Windows.Forms.TextBox txtLMIAPublicPolicy;
        private System.Windows.Forms.GroupBox grpEmployeeStructure;
        public System.Windows.Forms.TextBox txtBizDetailQ5;
        public System.Windows.Forms.TextBox txtBizDetailQ4;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtBizDetailQ3;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtBizDetailQ2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtBizDetailQ1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabBase;
        public System.Windows.Forms.CheckedListBox chkJobAdBenefit;
        private System.Windows.Forms.Button btnJobAdClear;
        private System.Windows.Forms.Button btnJobAdSave;
        private System.Windows.Forms.GroupBox grpJobAd;
        private System.Windows.Forms.TabPage tabAnalysis;
        public System.Windows.Forms.GroupBox grpApplicationStream;
        public System.Windows.Forms.ComboBox cmbLMIAProgram;
        public System.Windows.Forms.TextBox txtAnotherEmployer;
        public System.Windows.Forms.ComboBox cmbStream;
        public System.Windows.Forms.CheckBox ckbOtherEmployer;
        private System.Windows.Forms.Label lblSubCategory;
        public System.Windows.Forms.Label lblAnotherEmployer;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.GroupBox grpLabourMarketFactors;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.CheckedListBox ckbLmFactor;
        public System.Windows.Forms.TextBox txtOccupationProfile;
        private System.Windows.Forms.Button btnOccupationProfile;
        public System.Windows.Forms.TextBox txtCOPSRating;
        private System.Windows.Forms.Button btnCOPSRate;
        public System.Windows.Forms.TextBox txtUnemployRate;
        private System.Windows.Forms.Button btnUmemploymentRate;
        private System.Windows.Forms.GroupBox grpIndicator;
        public System.Windows.Forms.DataGridView dgvQualificationIndicator;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        public JobPosition jobPositionAdvisor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSituationImpact;
        public System.Windows.Forms.TextBox txtEmployerSituation;
        public financial financialAdvisor;
        private System.Windows.Forms.Button btnAnalysisClear;
        private System.Windows.Forms.Button btnAnalysisDelete;
        private System.Windows.Forms.Button btnAnalysisUpdate;
        public System.Windows.Forms.Button btnAnalysisInsert;
        private System.Windows.Forms.GroupBox grpWorkLocation;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cmbWorkLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label34;
        public System.Windows.Forms.TextBox txtJobAdPostCode;
        public System.Windows.Forms.TextBox txtJobAdStreetName;
        public System.Windows.Forms.TextBox txtJobAdStreetNo;
        public System.Windows.Forms.TextBox txtJobAdCity;
        public System.Windows.Forms.TextBox txtJobAdUnit;
        public System.Windows.Forms.TextBox txtEmploymentTerm;
        public System.Windows.Forms.TabControl tabLMIAApplication;
        public System.Windows.Forms.TextBox txtJobAdContactInfo;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btnJobAdPreview;
        public System.Windows.Forms.GroupBox grpPositionMainDuties;
        public System.Windows.Forms.TextBox txtPositionMainDuties;
        private System.Windows.Forms.GroupBox grpESDCMainDuties;
        public System.Windows.Forms.TextBox txtNOCMainDuties;
        public System.Windows.Forms.GroupBox grpPositionQualification;
        private System.Windows.Forms.GroupBox grpSkill;
        public System.Windows.Forms.TextBox txtPositionSkillReq;
        private System.Windows.Forms.GroupBox grpLanguage;
        public System.Windows.Forms.TextBox txtPositionLanguage;
        private System.Windows.Forms.GroupBox grpOthers;
        public System.Windows.Forms.TextBox txtPositionOthers;
        private System.Windows.Forms.GroupBox grpWorkExp;
        public System.Windows.Forms.TextBox txtPositionWorkExp;
        private System.Windows.Forms.GroupBox grpESDCQualification;
        public System.Windows.Forms.TextBox txtESDCQualification;
        private DBOps dbOpsQualification;
        public System.Windows.Forms.ComboBox cmbLMIAEduReq;
        public System.Windows.Forms.TextBox txtOtherBenefit;
        private System.Windows.Forms.Label lblOtherBenefit;
        public System.Windows.Forms.TextBox txtJobAdPreview;
        public System.Windows.Forms.DataGridView dgvJobPost;
        public System.Windows.Forms.DataGridView dgvMedia;
        public System.Windows.Forms.Button btnMediaSave;
        public System.Windows.Forms.TabPage tabMedia;
        public Data.CanadaProvinces canadaProvincesJobAd;
        private System.Windows.Forms.Button btnNocSave;
        private System.Windows.Forms.Button btnJobPostDelete;
    }
}