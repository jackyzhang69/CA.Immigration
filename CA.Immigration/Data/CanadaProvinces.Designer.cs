namespace CA.Immigration.Data
{
    partial class CanadaProvinces
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
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbProvince
            // 
            this.cmbProvince.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(87, 8);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(66, 28);
            this.cmbProvince.TabIndex = 7;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(3, 15);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(73, 20);
            this.lblProvince.TabIndex = 8;
            this.lblProvince.Text = "Province ";
            // 
            // CanadaProvinces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbProvince);
            this.Controls.Add(this.lblProvince);
            this.Name = "CanadaProvinces";
            this.Size = new System.Drawing.Size(158, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.Label lblProvince;
    }
}
