namespace WindowsFormsApp2
{
    partial class frmUserLogin
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
            this.txtfldUsername = new System.Windows.Forms.TextBox();
            this.txtfldPassword = new System.Windows.Forms.TextBox();
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfldUsername
            // 
            this.txtfldUsername.BackColor = System.Drawing.Color.Chocolate;
            this.txtfldUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfldUsername.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfldUsername.ForeColor = System.Drawing.Color.White;
            this.txtfldUsername.Location = new System.Drawing.Point(852, 352);
            this.txtfldUsername.Name = "txtfldUsername";
            this.txtfldUsername.Size = new System.Drawing.Size(271, 31);
            this.txtfldUsername.TabIndex = 2;
            this.txtfldUsername.Text = "Username";
            this.txtfldUsername.TextChanged += new System.EventHandler(this.txtfldUsername_TextChanged);
            // 
            // txtfldPassword
            // 
            this.txtfldPassword.BackColor = System.Drawing.Color.Chocolate;
            this.txtfldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfldPassword.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfldPassword.ForeColor = System.Drawing.Color.White;
            this.txtfldPassword.Location = new System.Drawing.Point(852, 409);
            this.txtfldPassword.Name = "txtfldPassword";
            this.txtfldPassword.PasswordChar = '*';
            this.txtfldPassword.Size = new System.Drawing.Size(271, 31);
            this.txtfldPassword.TabIndex = 3;
            this.txtfldPassword.Text = "Password";
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.BackColor = System.Drawing.Color.Teal;
            this.btnUserLogin.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLogin.ForeColor = System.Drawing.Color.White;
            this.btnUserLogin.Location = new System.Drawing.Point(930, 472);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(121, 36);
            this.btnUserLogin.TabIndex = 4;
            this.btnUserLogin.Text = "Log In";
            this.btnUserLogin.UseVisualStyleBackColor = false;
            this.btnUserLogin.Click += new System.EventHandler(this.btnUserLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(299, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 88);
            this.label2.TabIndex = 5;
            this.label2.Text = "VIRTUAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(115, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(721, 88);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOST AND FOUND";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 36);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.VLF_logo_removebg_preview__1___1_1;
            this.pictureBox1.Location = new System.Drawing.Point(263, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUserLogin);
            this.Controls.Add(this.txtfldPassword);
            this.Controls.Add(this.txtfldUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUserLogin";
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.frmUserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtfldUsername;
        private System.Windows.Forms.TextBox txtfldPassword;
        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}