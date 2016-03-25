namespace CA.Immigration.LMIA
{
    partial class JobPosition
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbPosition = new System.Windows.Forms.GroupBox();
            this.chkNoSame = new System.Windows.Forms.CheckBox();
            this.btnCheckNOC = new System.Windows.Forms.Button();
            this.btnJobBank = new System.Windows.Forms.Button();
            this.btnTop100 = new System.Windows.Forms.Button();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtWorkingHours = new System.Windows.Forms.TextBox();
            this.lblWorkingHours = new System.Windows.Forms.Label();
            this.txtLocalNocHighest = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtLocalNocLowest = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSameHighest = new System.Windows.Forms.TextBox();
            this.txtLocalNOCMedian = new System.Windows.Forms.TextBox();
            this.lblSameHighest = new System.Windows.Forms.Label();
            this.lblLocalNOCMedian = new System.Windows.Forms.Label();
            this.txtSameLowest = new System.Windows.Forms.TextBox();
            this.txtProvincialMedian = new System.Windows.Forms.TextBox();
            this.lblSameLowest = new System.Windows.Forms.Label();
            this.lblProvincialMedian = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lblWage = new System.Windows.Forms.Label();
            this.txtNoc = new System.Windows.Forms.TextBox();
            this.lblNOC = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.grbPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPosition
            // 
            this.grbPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbPosition.Controls.Add(this.chkNoSame);
            this.grbPosition.Controls.Add(this.btnCheckNOC);
            this.grbPosition.Controls.Add(this.btnJobBank);
            this.grbPosition.Controls.Add(this.btnTop100);
            this.grbPosition.Controls.Add(this.cmbProvince);
            this.grbPosition.Controls.Add(this.lblProvince);
            this.grbPosition.Controls.Add(this.txtWorkingHours);
            this.grbPosition.Controls.Add(this.lblWorkingHours);
            this.grbPosition.Controls.Add(this.txtLocalNocHighest);
            this.grbPosition.Controls.Add(this.label20);
            this.grbPosition.Controls.Add(this.txtLocalNocLowest);
            this.grbPosition.Controls.Add(this.label19);
            this.grbPosition.Controls.Add(this.txtSameHighest);
            this.grbPosition.Controls.Add(this.txtLocalNOCMedian);
            this.grbPosition.Controls.Add(this.lblSameHighest);
            this.grbPosition.Controls.Add(this.lblLocalNOCMedian);
            this.grbPosition.Controls.Add(this.txtSameLowest);
            this.grbPosition.Controls.Add(this.txtProvincialMedian);
            this.grbPosition.Controls.Add(this.lblSameLowest);
            this.grbPosition.Controls.Add(this.lblProvincialMedian);
            this.grbPosition.Controls.Add(this.txtHourlyRate);
            this.grbPosition.Controls.Add(this.lblWage);
            this.grbPosition.Controls.Add(this.txtNoc);
            this.grbPosition.Controls.Add(this.lblNOC);
            this.grbPosition.Controls.Add(this.txtJobTitle);
            this.grbPosition.Controls.Add(this.lblJobTitle);
            this.grbPosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbPosition.Location = new System.Drawing.Point(0, 0);
            this.grbPosition.Name = "grbPosition";
            this.grbPosition.Size = new System.Drawing.Size(1014, 237);
            this.grbPosition.TabIndex = 0;
            this.grbPosition.TabStop = false;
            this.grbPosition.Text = "Position Information";
            // 
            // chkNoSame
            // 
            this.chkNoSame.AutoSize = true;
            this.chkNoSame.Location = new System.Drawing.Point(840, 135);
            this.chkNoSame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkNoSame.Name = "chkNoSame";
            this.chkNoSame.Size = new System.Drawing.Size(157, 24);
            this.chkNoSame.TabIndex = 11;
            this.chkNoSame.Text = "No same position";
            this.chkNoSame.UseVisualStyleBackColor = true;
            this.chkNoSame.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCheckNOC
            // 
            this.btnCheckNOC.Location = new System.Drawing.Point(339, 183);
            this.btnCheckNOC.Name = "btnCheckNOC";
            this.btnCheckNOC.Size = new System.Drawing.Size(297, 34);
            this.btnCheckNOC.TabIndex = 13;
            this.btnCheckNOC.Text = "Check NOC Code Based on Job Title";
            this.btnCheckNOC.UseVisualStyleBackColor = true;
            this.btnCheckNOC.Click += new System.EventHandler(this.btnCheckNOC_Click);
            // 
            // btnJobBank
            // 
            this.btnJobBank.Location = new System.Drawing.Point(710, 183);
            this.btnJobBank.Name = "btnJobBank";
            this.btnJobBank.Size = new System.Drawing.Size(288, 34);
            this.btnJobBank.TabIndex = 14;
            this.btnJobBank.Text = "Check Job Bank Based On NOC";
            this.btnJobBank.UseVisualStyleBackColor = true;
            this.btnJobBank.Click += new System.EventHandler(this.btnJobBank_Click);
            // 
            // btnTop100
            // 
            this.btnTop100.Location = new System.Drawing.Point(22, 183);
            this.btnTop100.Name = "btnTop100";
            this.btnTop100.Size = new System.Drawing.Size(208, 34);
            this.btnTop100.TabIndex = 12;
            this.btnTop100.Text = "BC Ocuupation Top 100";
            this.btnTop100.UseVisualStyleBackColor = true;
            this.btnTop100.Click += new System.EventHandler(this.btnTop100_Click);
            // 
            // cmbProvince
            // 
            this.cmbProvince.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NS",
            "NT",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.cmbProvince.Location = new System.Drawing.Point(516, 31);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(66, 28);
            this.cmbProvince.TabIndex = 2;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(432, 38);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(73, 20);
            this.lblProvince.TabIndex = 6;
            this.lblProvince.Text = "Province ";
            // 
            // txtWorkingHours
            // 
            this.txtWorkingHours.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtWorkingHours.Location = new System.Drawing.Point(738, 32);
            this.txtWorkingHours.Name = "txtWorkingHours";
            this.txtWorkingHours.Size = new System.Drawing.Size(62, 26);
            this.txtWorkingHours.TabIndex = 3;
            this.txtWorkingHours.Text = "40";
            this.txtWorkingHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWorkingHours.Leave += new System.EventHandler(this.txtWorkingHours_Leave);
            // 
            // lblWorkingHours
            // 
            this.lblWorkingHours.AutoSize = true;
            this.lblWorkingHours.Location = new System.Drawing.Point(615, 37);
            this.lblWorkingHours.Name = "lblWorkingHours";
            this.lblWorkingHours.Size = new System.Drawing.Size(114, 20);
            this.lblWorkingHours.TabIndex = 4;
            this.lblWorkingHours.Text = "Working Hours";
            // 
            // txtLocalNocHighest
            // 
            this.txtLocalNocHighest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLocalNocHighest.Location = new System.Drawing.Point(933, 92);
            this.txtLocalNocHighest.Name = "txtLocalNocHighest";
            this.txtLocalNocHighest.Size = new System.Drawing.Size(66, 26);
            this.txtLocalNocHighest.TabIndex = 8;
            this.txtLocalNocHighest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(782, 95);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 20);
            this.label20.TabIndex = 2;
            this.label20.Text = "Local NOC Highest";
            // 
            // txtLocalNocLowest
            // 
            this.txtLocalNocLowest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLocalNocLowest.Location = new System.Drawing.Point(678, 89);
            this.txtLocalNocLowest.Name = "txtLocalNocLowest";
            this.txtLocalNocLowest.Size = new System.Drawing.Size(66, 26);
            this.txtLocalNocLowest.TabIndex = 7;
            this.txtLocalNocLowest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(531, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Local NOC Lowest";
            // 
            // txtSameHighest
            // 
            this.txtSameHighest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSameHighest.Location = new System.Drawing.Point(720, 132);
            this.txtSameHighest.Name = "txtSameHighest";
            this.txtSameHighest.Size = new System.Drawing.Size(66, 26);
            this.txtSameHighest.TabIndex = 10;
            this.txtSameHighest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLocalNOCMedian
            // 
            this.txtLocalNOCMedian.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLocalNOCMedian.Location = new System.Drawing.Point(417, 86);
            this.txtLocalNOCMedian.Name = "txtLocalNOCMedian";
            this.txtLocalNOCMedian.Size = new System.Drawing.Size(66, 26);
            this.txtLocalNOCMedian.TabIndex = 6;
            this.txtLocalNOCMedian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSameHighest
            // 
            this.lblSameHighest.AutoSize = true;
            this.lblSameHighest.Location = new System.Drawing.Point(412, 135);
            this.lblSameHighest.Name = "lblSameHighest";
            this.lblSameHighest.Size = new System.Drawing.Size(302, 20);
            this.lblSameHighest.TabIndex = 2;
            this.lblSameHighest.Text = "Same place same position Highest Salary";
            // 
            // lblLocalNOCMedian
            // 
            this.lblLocalNOCMedian.AutoSize = true;
            this.lblLocalNOCMedian.Location = new System.Drawing.Point(270, 89);
            this.lblLocalNOCMedian.Name = "lblLocalNOCMedian";
            this.lblLocalNOCMedian.Size = new System.Drawing.Size(141, 20);
            this.lblLocalNOCMedian.TabIndex = 2;
            this.lblLocalNOCMedian.Text = "Local NOC Median";
            // 
            // txtSameLowest
            // 
            this.txtSameLowest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSameLowest.Location = new System.Drawing.Point(322, 132);
            this.txtSameLowest.Name = "txtSameLowest";
            this.txtSameLowest.Size = new System.Drawing.Size(79, 26);
            this.txtSameLowest.TabIndex = 9;
            this.txtSameLowest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProvincialMedian
            // 
            this.txtProvincialMedian.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtProvincialMedian.Location = new System.Drawing.Point(189, 83);
            this.txtProvincialMedian.Name = "txtProvincialMedian";
            this.txtProvincialMedian.Size = new System.Drawing.Size(66, 26);
            this.txtProvincialMedian.TabIndex = 5;
            this.txtProvincialMedian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSameLowest
            // 
            this.lblSameLowest.AutoSize = true;
            this.lblSameLowest.Location = new System.Drawing.Point(18, 137);
            this.lblSameLowest.Name = "lblSameLowest";
            this.lblSameLowest.Size = new System.Drawing.Size(298, 20);
            this.lblSameLowest.TabIndex = 0;
            this.lblSameLowest.Text = "Same place same position Lowest Salary";
            // 
            // lblProvincialMedian
            // 
            this.lblProvincialMedian.AutoSize = true;
            this.lblProvincialMedian.Location = new System.Drawing.Point(18, 88);
            this.lblProvincialMedian.Name = "lblProvincialMedian";
            this.lblProvincialMedian.Size = new System.Drawing.Size(131, 20);
            this.lblProvincialMedian.TabIndex = 0;
            this.lblProvincialMedian.Text = "Provincial Median";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtHourlyRate.Location = new System.Drawing.Point(933, 31);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(66, 26);
            this.txtHourlyRate.TabIndex = 4;
            this.txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(832, 37);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(93, 20);
            this.lblWage.TabIndex = 0;
            this.lblWage.Text = "Hourly Rate";
            // 
            // txtNoc
            // 
            this.txtNoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNoc.Location = new System.Drawing.Point(339, 32);
            this.txtNoc.Name = "txtNoc";
            this.txtNoc.Size = new System.Drawing.Size(62, 26);
            this.txtNoc.TabIndex = 1;
            this.txtNoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNOC
            // 
            this.lblNOC.AutoSize = true;
            this.lblNOC.Location = new System.Drawing.Point(288, 38);
            this.lblNOC.Name = "lblNOC";
            this.lblNOC.Size = new System.Drawing.Size(43, 20);
            this.lblNOC.TabIndex = 0;
            this.lblNOC.Text = "NOC";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobTitle.Location = new System.Drawing.Point(92, 34);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(163, 26);
            this.txtJobTitle.TabIndex = 0;
            this.txtJobTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(18, 38);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(68, 20);
            this.lblJobTitle.TabIndex = 0;
            this.lblJobTitle.Text = "Job Title";
            // 
            // JobPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPosition);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "JobPosition";
            this.Size = new System.Drawing.Size(1014, 240);
            this.grbPosition.ResumeLayout(false);
            this.grbPosition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPosition;
        private System.Windows.Forms.Button btnCheckNOC;
        private System.Windows.Forms.Button btnJobBank;
        private System.Windows.Forms.Button btnTop100;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblWorkingHours;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblLocalNOCMedian;
        private System.Windows.Forms.Label lblProvincialMedian;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Label lblNOC;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblSameHighest;
        private System.Windows.Forms.Label lblSameLowest;
        public System.Windows.Forms.CheckBox chkNoSame;
        public System.Windows.Forms.TextBox txtSameLowest;
        public System.Windows.Forms.TextBox txtSameHighest;
        public System.Windows.Forms.TextBox txtJobTitle;
        public System.Windows.Forms.TextBox txtNoc;
        public System.Windows.Forms.TextBox txtHourlyRate;
        public System.Windows.Forms.TextBox txtProvincialMedian;
        public System.Windows.Forms.TextBox txtLocalNOCMedian;
        public System.Windows.Forms.TextBox txtLocalNocLowest;
        public System.Windows.Forms.TextBox txtLocalNocHighest;
        public System.Windows.Forms.TextBox txtWorkingHours;
        public System.Windows.Forms.ComboBox cmbProvince;
    }
}
