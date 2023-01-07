using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class pbUploadVerification : Form
    {
        public pbUploadVerification()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string SQLQuery = ($@"INSERT INTO Proofs (UploadedProof)
                                VALUES('{tbFilePath.Text}')");

            DatabaseManager.ExecuteCommand(SQLQuery);
            try
            {
                if (DatabaseManager.ErrorCode == -1)
                {
                    MessageBox.Show("Uploaded Successfully!");
                    frmSeekerTable frmSeekerTable = new frmSeekerTable();
                    frmSeekerTable.Show();
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("You have entered an incorrect data!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void lblSkip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Claim Successfully!");
            frmSeekerTable frmSeekerTable = new frmSeekerTable();
            frmSeekerTable.Show();
            this.Visible = false;
        }

        private void pbUpload_Click(object sender, EventArgs e)
        {
            //For Profile Picture Upload
            OpenFileDialog opnFileDialog = new OpenFileDialog();

            opnFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (opnFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbUpload.SizeMode = PictureBoxSizeMode.StretchImage;
                string picturePath = opnFileDialog.FileName.ToString();
                tbFilePath.Text = picturePath;
                pbUpload.ImageLocation = picturePath;
                pbUpload.Image = new Bitmap(opnFileDialog.FileName);
            }
        }
    }
}
