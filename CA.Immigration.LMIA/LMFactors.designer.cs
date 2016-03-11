namespace CA.Immigration.LMIA
{
    partial class LMFactors
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
            this.grbLabourMarketFactor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbLmFactor = new System.Windows.Forms.CheckedListBox();
            this.txtOccupationProfile = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCOPSRating = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtUnemployRate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grbLabourMarketFactor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLabourMarketFactor
            // 
            this.grbLabourMarketFactor.Controls.Add(this.label1);
            this.grbLabourMarketFactor.Controls.Add(this.ckbLmFactor);
            this.grbLabourMarketFactor.Controls.Add(this.txtOccupationProfile);
            this.grbLabourMarketFactor.Controls.Add(this.button3);
            this.grbLabourMarketFactor.Controls.Add(this.txtCOPSRating);
            this.grbLabourMarketFactor.Controls.Add(this.button2);
            this.grbLabourMarketFactor.Controls.Add(this.txtUnemployRate);
            this.grbLabourMarketFactor.Controls.Add(this.button1);
            this.grbLabourMarketFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbLabourMarketFactor.Location = new System.Drawing.Point(0, 0);
            this.grbLabourMarketFactor.Margin = new System.Windows.Forms.Padding(2);
            this.grbLabourMarketFactor.Name = "grbLabourMarketFactor";
            this.grbLabourMarketFactor.Padding = new System.Windows.Forms.Padding(2);
            this.grbLabourMarketFactor.Size = new System.Drawing.Size(333, 355);
            this.grbLabourMarketFactor.TabIndex = 2;
            this.grbLabourMarketFactor.TabStop = false;
            this.grbLabourMarketFactor.Text = "Labour Market Factors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Check what hiring TFW can bring to Canada";
            // 
            // ckbLmFactor
            // 
            this.ckbLmFactor.CheckOnClick = true;
            this.ckbLmFactor.FormattingEnabled = true;
            this.ckbLmFactor.Items.AddRange(new object[] {
            "Job Creation / Job Retention of Canadians",
            "Development or Transfer of Skills and Knowledge",
            "Filling a Labour Shortage",
            "Prevailing Wage Rate Offered",
            "Reasonable Efforts to Hire or Train Canadians",
            "Labour Dispute Settlements Unaffected",
            "Employer’s Commitments Fulfilled",
            "Employer is Actively Engaged in Business of Offered Position",
            "Offer is Consistent with Reasonable Employment Need",
            "Reasonably Able to Fulfill Terms of Offer",
            "Past Compliance"});
            this.ckbLmFactor.Location = new System.Drawing.Point(9, 175);
            this.ckbLmFactor.Name = "ckbLmFactor";
            this.ckbLmFactor.Size = new System.Drawing.Size(315, 154);
            this.ckbLmFactor.TabIndex = 4;
            this.ckbLmFactor.ThreeDCheckBoxes = true;
            // 
            // txtOccupationProfile
            // 
            this.txtOccupationProfile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtOccupationProfile.Location = new System.Drawing.Point(140, 98);
            this.txtOccupationProfile.Margin = new System.Windows.Forms.Padding(2);
            this.txtOccupationProfile.Name = "txtOccupationProfile";
            this.txtOccupationProfile.Size = new System.Drawing.Size(184, 20);
            this.txtOccupationProfile.TabIndex = 3;
            this.txtOccupationProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 95);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Occupation Profile";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtCOPSRating
            // 
            this.txtCOPSRating.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCOPSRating.Location = new System.Drawing.Point(140, 65);
            this.txtCOPSRating.Margin = new System.Windows.Forms.Padding(2);
            this.txtCOPSRating.Name = "txtCOPSRating";
            this.txtCOPSRating.Size = new System.Drawing.Size(184, 20);
            this.txtCOPSRating.TabIndex = 3;
            this.txtCOPSRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 63);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "COPS Rating";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtUnemployRate
            // 
            this.txtUnemployRate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUnemployRate.Location = new System.Drawing.Point(140, 30);
            this.txtUnemployRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnemployRate.Name = "txtUnemployRate";
            this.txtUnemployRate.Size = new System.Drawing.Size(184, 20);
            this.txtUnemployRate.TabIndex = 1;
            this.txtUnemployRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Unemployment Rate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LMFactors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbLabourMarketFactor);
            this.Name = "LMFactors";
            this.Size = new System.Drawing.Size(333, 355);
            this.grbLabourMarketFactor.ResumeLayout(false);
            this.grbLabourMarketFactor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLabourMarketFactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtUnemployRate;
        public System.Windows.Forms.TextBox txtCOPSRating;
        public System.Windows.Forms.TextBox txtOccupationProfile;
        public System.Windows.Forms.CheckedListBox ckbLmFactor;
    }
}
