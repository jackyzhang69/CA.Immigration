namespace CA.Immigration.Data
{
    partial class SelectRCIC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelectRCIC = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a RCIC";
            // 
            // cmbSelectRCIC
            // 
            this.cmbSelectRCIC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbSelectRCIC.FormattingEnabled = true;
            this.cmbSelectRCIC.Location = new System.Drawing.Point(141, 9);
            this.cmbSelectRCIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSelectRCIC.Name = "cmbSelectRCIC";
            this.cmbSelectRCIC.Size = new System.Drawing.Size(265, 28);
            this.cmbSelectRCIC.TabIndex = 1;
            this.cmbSelectRCIC.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectRCIC_SelectionChangeCommitted);
            // 
            // SelectRCIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbSelectRCIC);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectRCIC";
            this.Size = new System.Drawing.Size(412, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbSelectRCIC;
    }
}
