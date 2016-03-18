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
            this.lblTopic.Location = new System.Drawing.Point(42, 42);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(51, 20);
            this.lblTopic.TabIndex = 0;
            this.lblTopic.Text = "label1";
            // 
            // txtTxtDetails
            // 
            this.txtTxtDetails.Location = new System.Drawing.Point(32, 65);
            this.txtTxtDetails.Multiline = true;
            this.txtTxtDetails.Name = "txtTxtDetails";
            this.txtTxtDetails.Size = new System.Drawing.Size(814, 829);
            this.txtTxtDetails.TabIndex = 1;
            this.txtTxtDetails.TextChanged += new System.EventHandler(this.txtTxtDetails_TextChanged);
            // 
            // btnTxtDetailsSave
            // 
            this.btnTxtDetailsSave.Location = new System.Drawing.Point(670, 934);
            this.btnTxtDetailsSave.Name = "btnTxtDetailsSave";
            this.btnTxtDetailsSave.Size = new System.Drawing.Size(76, 37);
            this.btnTxtDetailsSave.TabIndex = 2;
            this.btnTxtDetailsSave.Text = "Save";
            this.btnTxtDetailsSave.UseVisualStyleBackColor = true;
            this.btnTxtDetailsSave.Click += new System.EventHandler(this.btnTxtDetailsSave_Click);
            // 
            // btnTxtDetailsClose
            // 
            this.btnTxtDetailsClose.Location = new System.Drawing.Point(770, 934);
            this.btnTxtDetailsClose.Name = "btnTxtDetailsClose";
            this.btnTxtDetailsClose.Size = new System.Drawing.Size(76, 37);
            this.btnTxtDetailsClose.TabIndex = 2;
            this.btnTxtDetailsClose.Text = "Close";
            this.btnTxtDetailsClose.UseVisualStyleBackColor = true;
            this.btnTxtDetailsClose.Click += new System.EventHandler(this.btnTxtDetailsClose_Click);
            // 
            // txtDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(887, 1023);
            this.Controls.Add(this.btnTxtDetailsClose);
            this.Controls.Add(this.btnTxtDetailsSave);
            this.Controls.Add(this.txtTxtDetails);
            this.Controls.Add(this.lblTopic);
            this.Name = "txtDetails";
            this.Text = "txtDetails";
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