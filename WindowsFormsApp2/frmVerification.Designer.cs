namespace WindowsFormsApp2
{
    partial class pbUploadVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pbUploadVerification));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSkip = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.pbUpload = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Location = new System.Drawing.Point(373, 507);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(149, 39);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(884, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Upload an image to verify that you are the owner of the found item.  If you don\'t" +
    " have evidence proving you are the owner, please click the SKIP button.";
            // 
            // lblSkip
            // 
            this.lblSkip.AutoSize = true;
            this.lblSkip.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkip.ForeColor = System.Drawing.Color.Chocolate;
            this.lblSkip.Location = new System.Drawing.Point(866, 624);
            this.lblSkip.Name = "lblSkip";
            this.lblSkip.Size = new System.Drawing.Size(58, 24);
            this.lblSkip.TabIndex = 15;
            this.lblSkip.Text = "SKIP";
            this.lblSkip.Click += new System.EventHandler(this.lblSkip_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilePath.Location = new System.Drawing.Point(302, 433);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.ReadOnly = true;
            this.tbFilePath.Size = new System.Drawing.Size(300, 27);
            this.tbFilePath.TabIndex = 16;
            // 
            // pbUpload
            // 
            this.pbUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbUpload.Image = global::WindowsFormsApp2.Properties.Resources.add__1___1_;
            this.pbUpload.Location = new System.Drawing.Point(302, 121);
            this.pbUpload.Name = "pbUpload";
            this.pbUpload.Size = new System.Drawing.Size(300, 288);
            this.pbUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpload.TabIndex = 23;
            this.pbUpload.TabStop = false;
            this.pbUpload.Click += new System.EventHandler(this.pbUpload_Click);
            // 
            // pbUploadVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 657);
            this.Controls.Add(this.pbUpload);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.lblSkip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pbUploadVerification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pbUploadVerification_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSkip;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.PictureBox pbUpload;
    }
}