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
            this.grbPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPosition.Name = "grbPosition";
            this.grbPosition.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPosition.Size = new System.Drawing.Size(676, 154);
            this.grbPosition.TabIndex = 0;
            this.grbPosition.TabStop = false;
            this.grbPosition.Text = "Position Information";
            // 
            // chkNoSame
            // 
            this.chkNoSame.AutoSize = true;
            this.chkNoSame.Location = new System.Drawing.Point(560, 88);
            this.chkNoSame.Name = "chkNoSame";
            this.chkNoSame.Size = new System.Drawing.Size(107, 17);
            this.chkNoSame.TabIndex = 11;
            this.chkNoSame.Text = "No same position";
            this.chkNoSame.UseVisualStyleBackColor = true;
            this.chkNoSame.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCheckNOC
            // 
            this.btnCheckNOC.Location = new System.Drawing.Point(226, 119);
            this.btnCheckNOC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckNOC.Name = "btnCheckNOC";
            this.btnCheckNOC.Size = new System.Drawing.Size(198, 22);
            this.btnCheckNOC.TabIndex = 13;
            this.btnCheckNOC.Text = "Check NOC Code Based on Job Title";
            this.btnCheckNOC.UseVisualStyleBackColor = true;
            this.btnCheckNOC.Click += new System.EventHandler(this.btnCheckNOC_Click);
            // 
            // btnJobBank
            // 
            this.btnJobBank.Location = new System.Drawing.Point(473, 119);
            this.btnJobBank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJobBank.Name = "btnJobBank";
            this.btnJobBank.Size = new System.Drawing.Size(192, 22);
            this.btnJobBank.TabIndex = 14;
            this.btnJobBank.Text = "Check Job Bank Based On NOC";
            this.btnJobBank.UseVisualStyleBackColor = true;
            this.btnJobBank.Click += new System.EventHandler(this.btnJobBank_Click);
            // 
            // btnTop100
            // 
            this.btnTop100.Location = new System.Drawing.Point(15, 119);
            this.btnTop100.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTop100.Name = "btnTop100";
            this.btnTop100.Size = new System.Drawing.Size(139, 22);
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
            this.cmbProvince.Location = new System.Drawing.Point(344, 20);
            this.cmbProvince.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(45, 21);
            this.cmbProvince.TabIndex = 2;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(288, 25);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 6;
            this.lblProvince.Text = "Province ";
            // 
            // txtWorkingHours
            // 
            this.txtWorkingHours.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtWorkingHours.Location = new System.Drawing.Point(492, 21);
            this.txtWorkingHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWorkingHours.Name = "txtWorkingHours";
            this.txtWorkingHours.Size = new System.Drawing.Size(43, 20);
            this.txtWorkingHours.TabIndex = 3;
            this.txtWorkingHours.Leave += new System.EventHandler(this.txtWorkingHours_Leave);
            // 
            // lblWorkingHours
            // 
            this.lblWorkingHours.AutoSize = true;
            this.lblWorkingHours.Location = new System.Drawing.Point(410, 24);
            this.lblWorkingHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorkingHours.Name = "lblWorkingHours";
            this.lblWorkingHours.Size = new System.Drawing.Size(78, 13);
            this.lblWorkingHours.TabIndex = 4;
            this.lblWorkingHours.Text = "Working Hours";
            // 
            // txtLocalNocHighest
            // 
            this.txtLocalNocHighest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLocalNocHighest.Location = new System.Drawing.Point(622, 60);
            this.txtLocalNocHighest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocalNocHighest.Name = "txtLocalNocHighest";
            this.txtLocalNocHighest.Size = new System.Drawing.Size(45, 20);
            this.txtLocalNocHighest.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(521, 62);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Local NOC Highest";
            // 
            // txtLocalNocLowest
            // 
            this.txtLocalNocLowest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLocalNocLowest.Location = new System.Drawing.Point(452, 58);
            this.txtLocalNocLowest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocalNocLowest.Name = "txtLocalNocLowest";
            this.txtLocalNocLowest.Size = new System.Drawing.Size(45, 20);
            this.txtLocalNocLowest.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(354, 60);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Local NOC Lowest";
            // 
            // txtSameHighest
            // 
            this.txtSameHighest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSameHighest.Location = new System.Drawing.Point(480, 86);
            this.txtSameHighest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSameHighest.Name = "txtSameHighest";
            this.txtSameHighest.Size = new System.Drawing.Size(45, 20);
            this.txtSameHighest.TabIndex = 10;
            // 
            // txtLocalNOCMedian
            // 
            this.txtLocalNOCMedian.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLocalNOCMedian.Location = new System.Drawing.Point(278, 56);
            this.txtLocalNOCMedian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocalNOCMedian.Name = "txtLocalNOCMedian";
            this.txtLocalNOCMedian.Size = new System.Drawing.Size(45, 20);
            this.txtLocalNOCMedian.TabIndex = 6;
            // 
            // lblSameHighest
            // 
            this.lblSameHighest.AutoSize = true;
            this.lblSameHighest.Location = new System.Drawing.Point(275, 88);
            this.lblSameHighest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSameHighest.Name = "lblSameHighest";
            this.lblSameHighest.Size = new System.Drawing.Size(201, 13);
            this.lblSameHighest.TabIndex = 2;
            this.lblSameHighest.Text = "Same place same position Highest Salary";
            // 
            // lblLocalNOCMedian
            // 
            this.lblLocalNOCMedian.AutoSize = true;
            this.lblLocalNOCMedian.Location = new System.Drawing.Point(180, 58);
            this.lblLocalNOCMedian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalNOCMedian.Name = "lblLocalNOCMedian";
            this.lblLocalNOCMedian.Size = new System.Drawing.Size(97, 13);
            this.lblLocalNOCMedian.TabIndex = 2;
            this.lblLocalNOCMedian.Text = "Local NOC Median";
            // 
            // txtSameLowest
            // 
            this.txtSameLowest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSameLowest.Location = new System.Drawing.Point(215, 86);
            this.txtSameLowest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSameLowest.Name = "txtSameLowest";
            this.txtSameLowest.Size = new System.Drawing.Size(54, 20);
            this.txtSameLowest.TabIndex = 9;
            // 
            // txtProvincialMedian
            // 
            this.txtProvincialMedian.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtProvincialMedian.Location = new System.Drawing.Point(126, 54);
            this.txtProvincialMedian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProvincialMedian.Name = "txtProvincialMedian";
            this.txtProvincialMedian.Size = new System.Drawing.Size(45, 20);
            this.txtProvincialMedian.TabIndex = 5;
            // 
            // lblSameLowest
            // 
            this.lblSameLowest.AutoSize = true;
            this.lblSameLowest.Location = new System.Drawing.Point(12, 89);
            this.lblSameLowest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSameLowest.Name = "lblSameLowest";
            this.lblSameLowest.Size = new System.Drawing.Size(199, 13);
            this.lblSameLowest.TabIndex = 0;
            this.lblSameLowest.Text = "Same place same position Lowest Salary";
            // 
            // lblProvincialMedian
            // 
            this.lblProvincialMedian.AutoSize = true;
            this.lblProvincialMedian.Location = new System.Drawing.Point(12, 57);
            this.lblProvincialMedian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvincialMedian.Name = "lblProvincialMedian";
            this.lblProvincialMedian.Size = new System.Drawing.Size(91, 13);
            this.lblProvincialMedian.TabIndex = 0;
            this.lblProvincialMedian.Text = "Provincial Median";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtHourlyRate.Location = new System.Drawing.Point(622, 20);
            this.txtHourlyRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(45, 20);
            this.txtHourlyRate.TabIndex = 4;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(555, 24);
            this.lblWage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(63, 13);
            this.lblWage.TabIndex = 0;
            this.lblWage.Text = "Hourly Rate";
            // 
            // txtNoc
            // 
            this.txtNoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNoc.Location = new System.Drawing.Point(226, 21);
            this.txtNoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNoc.Name = "txtNoc";
            this.txtNoc.Size = new System.Drawing.Size(43, 20);
            this.txtNoc.TabIndex = 1;
            // 
            // lblNOC
            // 
            this.lblNOC.AutoSize = true;
            this.lblNOC.Location = new System.Drawing.Point(192, 25);
            this.lblNOC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNOC.Name = "lblNOC";
            this.lblNOC.Size = new System.Drawing.Size(30, 13);
            this.lblNOC.TabIndex = 0;
            this.lblNOC.Text = "NOC";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtJobTitle.Location = new System.Drawing.Point(61, 22);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(110, 20);
            this.txtJobTitle.TabIndex = 0;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(12, 25);
            this.lblJobTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(47, 13);
            this.lblJobTitle.TabIndex = 0;
            this.lblJobTitle.Text = "Job Title";
            // 
            // JobPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbPosition);
            this.Name = "JobPosition";
            this.Size = new System.Drawing.Size(676, 156);
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
