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

namespace WindowsFormsApp2
{
    public partial class frmSignup : Form
    {

        bool uniqueUsrnm = false;
        bool verifiedPass = false;

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
            string SQLQuery = ($@"INSERT INTO Users (FirstName, MiddleInitial, LastName, UserType, ContactNo, Email, Username, Password)
                                VALUES('{tbFirstName.Text}', '{tbMiddleInitial.Text}', '{tbLastName.Text}', '{cbUserType.Text}', '{tbContactNo.Text}', '{tbEmail.Text}', '{tbUsername.Text}', '{tbPassword.Text}')");
            DatabaseManager.ExecuteCommand(SQLQuery);
         
            if (tbFirstName.Text == "" || tbMiddleInitial.Text == "" || tbLastName.Text == "" || cbUserType.Text == "" || tbContactNo.Text == "" || tbEmail.Text == "" || tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please enter required fields!");
            }
            else
            {
                try
                {
                    if (DatabaseManager.ErrorCode == -1)
                    {
                        MessageBox.Show("Successfully Registered");
                        tbFirstName.ResetText();
                        tbMiddleInitial.ResetText();
                        tbLastName.ResetText();
                        cbUserType.Items.Clear();
                        tbContactNo.ResetText();
                        tbEmail.ResetText();
                        tbUsername.ResetText();
                        tbPassword.ResetText();
                    }
                    else if (DatabaseManager.ErrorCode == 1062)
                    {
                        MessageBox.Show("Username already exists! Try another one.");
                        tbUsername.ResetText();
                        tbPassword.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Unexpected Error contact administrator.");
                        tbUsername.ResetText();
                        tbPassword.ResetText();

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
          
            
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {

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

    }
}
