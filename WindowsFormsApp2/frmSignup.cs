using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class frmSignup : Form
    {

        public frmSignup()
        {
            InitializeComponent();
            this.CenterToScreen();
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.Show();
            this.Visible = false;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string SQLQuery = ($@"INSERT INTO Users (FirstName, MiddleInitial, LastName, UserType, ContactNo, Email, Username, Password, Profile_Picture)
                                VALUES('{tbFirstName.Text}', '{tbMiddleInitial.Text}', '{tbLastName.Text}', '{cbUserType.Text}', '{tbContactNo.Text}', '{tbEmail.Text}', '{tbUsername.Text}', '{tbPassword.Text}', '{tbFilePath.Text}')");
            
            DatabaseManager.ExecuteCommand(SQLQuery);

            if (tbFirstName.Text == "" || tbMiddleInitial.Text == "" || tbLastName.Text == "" || cbUserType.Text == "" || tbContactNo.Text == "" || tbEmail.Text == "" || tbUsername.Text == "" || tbPassword.Text == "" || tbFilePath.Text == "" )
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
                        frmWelcome welcome = new frmWelcome();
                        welcome.Show();
                        this.Visible = false;

                    }
                    else if (DatabaseManager.ErrorCode == 1062)
                    {
                        MessageBox.Show("The data already exists!");
                        tbFirstName.ResetText();
                        tbMiddleInitial.ResetText();
                        tbLastName.ResetText();
                        cbUserType.Items.Clear();
                        tbContactNo.ResetText();
                        tbEmail.ResetText();
                        tbUsername.ResetText();
                        tbPassword.ResetText();
                        tbFilePath.ResetText();
                        pbSignUpImage.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("You have entered an incorrect data!");                      
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
          
            
        }
        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                
            }
            
        }

        private void tbMiddleInitial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void tbContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void pbSignUpImage_Click(object sender, EventArgs e)
        {
            
                //For Profile Picture Upload
                OpenFileDialog opnFileDialog = new OpenFileDialog();

                opnFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (opnFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbSignUpImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    string picturePath = opnFileDialog.FileName.ToString(); 
                    tbFilePath.Text = picturePath;
                    pbSignUpImage.ImageLocation = picturePath;
                    pbSignUpImage.Image = new Bitmap(opnFileDialog.FileName);
                }

        }

        private void frmSignup_Load_1(object sender, EventArgs e)
        {

        }
    }
}
