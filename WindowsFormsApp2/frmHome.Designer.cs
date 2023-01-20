namespace WindowsFormsApp2
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinder = new System.Windows.Forms.Button();
            this.btnSeeker = new System.Windows.Forms.Button();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblHelpCenter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(436, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 88);
            this.label2.TabIndex = 2;
            this.label2.Text = "VIRTUAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(275, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(721, 88);
            this.label3.TabIndex = 3;
            this.label3.Text = "LOST AND FOUND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "The Lost and Found now Online!";
            // 
            // btnFinder
            // 
            this.btnFinder.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFinder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinder.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFinder.Location = new System.Drawing.Point(506, 419);
            this.btnFinder.Name = "btnFinder";
            this.btnFinder.Size = new System.Drawing.Size(190, 58);
            this.btnFinder.TabIndex = 7;
            this.btnFinder.Text = "Finder";
            this.btnFinder.UseVisualStyleBackColor = false;
            this.btnFinder.Click += new System.EventHandler(this.btnFinder_Click);
            // 
            // btnSeeker
            // 
            this.btnSeeker.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSeeker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeker.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSeeker.Location = new System.Drawing.Point(506, 524);
            this.btnSeeker.Name = "btnSeeker";
            this.btnSeeker.Size = new System.Drawing.Size(190, 58);
            this.btnSeeker.TabIndex = 8;
            this.btnSeeker.Text = "Seeker";
            this.btnSeeker.UseVisualStyleBackColor = false;
            this.btnSeeker.Click += new System.EventHandler(this.btnSeeker_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.Teal;
            this.lblProfile.Location = new System.Drawing.Point(1102, 32);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(87, 28);
            this.lblProfile.TabIndex = 24;
            this.lblProfile.Text = "Profile";
            this.lblProfile.Click += new System.EventHandler(this.lblProfile_Click);
            // 
            // lblHelpCenter
            // 
            this.lblHelpCenter.AutoSize = true;
            this.lblHelpCenter.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpCenter.ForeColor = System.Drawing.Color.Teal;
            this.lblHelpCenter.Location = new System.Drawing.Point(12, 616);
            this.lblHelpCenter.Name = "lblHelpCenter";
            this.lblHelpCenter.Size = new System.Drawing.Size(146, 28);
            this.lblHelpCenter.TabIndex = 25;
            this.lblHelpCenter.Text = "Help Center";
            this.lblHelpCenter.Click += new System.EventHandler(this.lblHelpCenter_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 653);
            this.Controls.Add(this.lblHelpCenter);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.btnSeeker);
            this.Controls.Add(this.btnFinder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinder;
        private System.Windows.Forms.Button btnSeeker;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblHelpCenter;
    }
}