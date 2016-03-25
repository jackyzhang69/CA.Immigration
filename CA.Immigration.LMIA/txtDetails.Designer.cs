namespace CA.Immigration.LMIA
{
    partial class txtDetails
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
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtTxtDetails = new System.Windows.Forms.TextBox();
            this.btnTxtDetailsSave = new System.Windows.Forms.Button();
            this.btnTxtDetailsClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(28, 27);
            this.lblTopic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(35, 13);
            this.lblTopic.TabIndex = 0;
            this.lblTopic.Text = "label1";
            // 
            // txtTxtDetails
            // 
            this.txtTxtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTxtDetails.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTxtDetails.Location = new System.Drawing.Point(21, 42);
            this.txtTxtDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtTxtDetails.Multiline = true;
            this.txtTxtDetails.Name = "txtTxtDetails";
            this.txtTxtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTxtDetails.Size = new System.Drawing.Size(544, 540);
            this.txtTxtDetails.TabIndex = 1;
            this.txtTxtDetails.TextChanged += new System.EventHandler(this.txtTxtDetails_TextChanged);
            // 
            // btnTxtDetailsSave
            // 
            this.btnTxtDetailsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTxtDetailsSave.Location = new System.Drawing.Point(447, 607);
            this.btnTxtDetailsSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnTxtDetailsSave.Name = "btnTxtDetailsSave";
            this.btnTxtDetailsSave.Size = new System.Drawing.Size(51, 24);
            this.btnTxtDetailsSave.TabIndex = 2;
            this.btnTxtDetailsSave.Text = "Save";
            this.btnTxtDetailsSave.UseVisualStyleBackColor = true;
            this.btnTxtDetailsSave.Click += new System.EventHandler(this.btnTxtDetailsSave_Click);
            // 
            // btnTxtDetailsClose
            // 
            this.btnTxtDetailsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTxtDetailsClose.Location = new System.Drawing.Point(513, 607);
            this.btnTxtDetailsClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnTxtDetailsClose.Name = "btnTxtDetailsClose";
            this.btnTxtDetailsClose.Size = new System.Drawing.Size(51, 24);
            this.btnTxtDetailsClose.TabIndex = 2;
            this.btnTxtDetailsClose.Text = "Close";
            this.btnTxtDetailsClose.UseVisualStyleBackColor = true;
            this.btnTxtDetailsClose.Click += new System.EventHandler(this.btnTxtDetailsClose_Click);
            // 
            // txtDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(591, 665);
            this.Controls.Add(this.btnTxtDetailsClose);
            this.Controls.Add(this.btnTxtDetailsSave);
            this.Controls.Add(this.txtTxtDetails);
            this.Controls.Add(this.lblTopic);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "txtDetails";
            this.Load += new System.EventHandler(this.txtDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox txtTxtDetails;
        private System.Windows.Forms.Button btnTxtDetailsSave;
        private System.Windows.Forms.Button btnTxtDetailsClose;
    }
}