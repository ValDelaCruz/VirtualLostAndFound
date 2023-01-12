namespace WindowsFormsApp2
{
    partial class frmHelpCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelpCenter));
            this.btnBack = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFAQs1 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(15, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 36);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Teal;
            this.lbl2.Location = new System.Drawing.Point(27, 71);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(103, 24);
            this.lbl2.TabIndex = 25;
            this.lbl2.Text = "Overview";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Teal;
            this.lbl3.Location = new System.Drawing.Point(15, 59);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(1312, 302);
            this.lbl3.TabIndex = 26;
            this.lbl3.Text = resources.GetString("lbl3.Text");
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Chocolate;
            this.lbl1.Location = new System.Drawing.Point(515, 11);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(195, 38);
            this.lbl1.TabIndex = 23;
            this.lbl1.Text = "Help Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(109, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "FAQs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(44, 683);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1398, 82);
            this.label4.TabIndex = 36;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // cbFAQs1
            // 
            this.cbFAQs1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFAQs1.ForeColor = System.Drawing.Color.Teal;
            this.cbFAQs1.FormattingEnabled = true;
            this.cbFAQs1.Items.AddRange(new object[] {
            "                If you can’t sign up, one possible reason is that you didn’t fill" +
                " out all of the information the registration is asking ",
            "you for. If not, it is possible that you didn’t upload your profile picture which" +
                " is required. The system will require ",
            "you to be able to provide all the information and image it is asking for, otherwi" +
                "se, it will reject or deny your ",
            "registration. ",
            "",
            "               If none of the possible reason above happened, or if further probl" +
                "ems occurred during registration, ",
            "please contact the developers of the system with their contact information below." +
                ""});
            this.cbFAQs1.Location = new System.Drawing.Point(113, 416);
            this.cbFAQs1.Margin = new System.Windows.Forms.Padding(4);
            this.cbFAQs1.Name = "cbFAQs1";
            this.cbFAQs1.Size = new System.Drawing.Size(1205, 28);
            this.cbFAQs1.TabIndex = 37;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Teal;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            "You can scroll to find your lost item, but it may be troublesome, so, you can use" +
                " the search feature the system provides. Once you have found the item you have l" +
                "ost, look for the column named ",
            "“Action”, then click Request Claim. After that, you will be directed to the Image" +
                " Verification form, and the system will ask you to provide a picture proving tha" +
                "t you are the owner of the item you ",
            "are requesting to claim. Once you have uploaded the image of the item you have lo" +
                "st, click the Submit button. If you do not have any pictures of your lost item, " +
                "you may click SKIP. Your request ",
            "to claim an item will be received by the admin, then just wait for their reply."});
            this.comboBox1.Location = new System.Drawing.Point(113, 452);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1205, 28);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.Text = "•How to claim an item in the system?";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.Teal;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            "your username and password, log in to your account. After logging in, you can use" +
                " the system, and even claim an item in the Seeker’s View form."});
            this.comboBox2.Location = new System.Drawing.Point(113, 488);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(1205, 28);
            this.comboBox2.TabIndex = 39;
            this.comboBox2.Text = "•Does a student need an account to claim an item in the system?";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.Teal;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            resources.GetString("comboBox3.Items"),
            resources.GetString("comboBox3.Items1"),
            "form again, and in the table, you will be able to see the post you have made, as " +
                "well as your previous posts."});
            this.comboBox3.Location = new System.Drawing.Point(113, 524);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(1205, 28);
            this.comboBox3.TabIndex = 40;
            this.comboBox3.Text = "•How to post the item I found?";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.Color.Teal;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            resources.GetString("comboBox4.Items"),
            "As a finder, if you want to see your posts, just click the Finder button in the H" +
                "ome Page, and you will see all the posts you’ve made."});
            this.comboBox4.Location = new System.Drawing.Point(113, 560);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(1205, 28);
            this.comboBox4.TabIndex = 41;
            this.comboBox4.Text = "•How to view all the items lost or found?";
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.ForeColor = System.Drawing.Color.Teal;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "               No, found item and lost item are just the same. It only differs in" +
                " perspective, like, if you are the finder, then the item you have found will be " +
                "called “found item”. ",
            "If you are the seeker, then the item you have lost will be called “lost item”. "});
            this.comboBox5.Location = new System.Drawing.Point(113, 596);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(1205, 28);
            this.comboBox5.TabIndex = 42;
            this.comboBox5.Text = "•Is there a difference between found item and lost item?";
            // 
            // comboBox6
            // 
            this.comboBox6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.Color.Teal;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "                To use the search feature of the Virtual Lost and Found System, c" +
                "lick the Seeker button in the Home Page, and you will be directed to the Seeker’" +
                "s View form, ",
            "just type any keyword in the text box beside the Search button, then click the Se" +
                "arch button. All the items matching the keyword you have searched will be seen i" +
                "n the ",
            "table."});
            this.comboBox6.Location = new System.Drawing.Point(113, 632);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(1205, 28);
            this.comboBox6.TabIndex = 43;
            this.comboBox6.Text = "•How to search for the items?";
            // 
            // frmHelpCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1106, 806);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbFAQs1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbl3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHelpCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help Center";
            this.Load += new System.EventHandler(this.frmHelpCenter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFAQs1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
    }
}