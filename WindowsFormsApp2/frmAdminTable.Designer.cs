namespace WindowsFormsApp2
{
    partial class frmAdminTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminTable));
            this.label2 = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Button();
            this.lblItemType = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRequestItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(235, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(725, 91);
            this.label2.TabIndex = 6;
            this.label2.Text = "ITEM FOUND LIST";
            // 
            // lblLogOut
            // 
            this.lblLogOut.BackColor = System.Drawing.Color.Teal;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.White;
            this.lblLogOut.Location = new System.Drawing.Point(1146, 889);
            this.lblLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(121, 39);
            this.lblLogOut.TabIndex = 22;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.UseVisualStyleBackColor = false;
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemType.ForeColor = System.Drawing.Color.Chocolate;
            this.lblItemType.Location = new System.Drawing.Point(34, 126);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(164, 25);
            this.lblItemType.TabIndex = 23;
            this.lblItemType.Text = "Claimed History";
            this.lblItemType.Click += new System.EventHandler(this.lblItemType_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1078, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 28;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRequestItems
            // 
            this.dgvRequestItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestItems.Location = new System.Drawing.Point(39, 154);
            this.dgvRequestItems.Name = "dgvRequestItems";
            this.dgvRequestItems.RowHeadersWidth = 51;
            this.dgvRequestItems.RowTemplate.Height = 24;
            this.dgvRequestItems.Size = new System.Drawing.Size(1137, 481);
            this.dgvRequestItems.TabIndex = 29;
            // 
            // frmAdminTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 707);
            this.Controls.Add(this.dgvRequestItems);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmAdminTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminTable_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lblLogOut;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvRequestItems;
    }
}