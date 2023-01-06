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
    public partial class frmFinderPost : Form
    {
        public frmFinderPost()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string SQLQuery = ($@"INSERT INTO FinderPost (ItemType, ItemColor, ItemBrand, LocationFound, DateFound, TimeFound, UploadedItem)
                                VALUES('{tbItemType.Text}', '{tbItemColor.Text}', '{tbItemBrand.Text}', '{tbLocationFound.Text}', '{dtpDateFound.Text}', '{tbTimeFound.Text}', '{tbFilePath.Text}')");

            DatabaseManager.ExecuteCommand(SQLQuery);

            if (tbItemType.Text == "" || tbItemColor.Text == "" || tbItemBrand.Text == "" || tbLocationFound.Text == "" || dtpDateFound.Text == "" || tbTimeFound.Text == "" || tbFilePath.Text == "")
            {
                MessageBox.Show("Please complete the following requirements!");
            }
            else
            {
                try
                {
                    if (DatabaseManager.ErrorCode == -1)
                    {
                        MessageBox.Show("Successfully Registered");
                        frmFinderTable frmFinderTable = new frmFinderTable();
                        frmFinderTable.Show();
                        this.Visible = false;

                    }
                    else if (DatabaseManager.ErrorCode == 1062)
                    {
                        MessageBox.Show("The data already exists!");
                        tbItemType.ResetText();
                        tbItemColor.ResetText();
                        tbItemBrand.ResetText();
                        tbLocationFound.ResetText();
                        dtpDateFound.ResetText();
                        tbTimeFound.ResetText();
                        tbFilePath.ResetText();                      
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmFinderTable frmFinderTable = new frmFinderTable();
            frmFinderTable.Show();
            this.Visible = false;
        }

        private void pbUpload_MouseClick(object sender, MouseEventArgs e)
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

        private void tbItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void tbItemColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void tbItemBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void tbLocationFound_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    } 
}
