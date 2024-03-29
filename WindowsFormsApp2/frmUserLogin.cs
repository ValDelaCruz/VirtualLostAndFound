﻿using MySql.Data.MySqlClient;
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
    public partial class frmUserLogin : Form
    {

        MySqlConnection connection = new MySqlConnection();


        public frmUserLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.txtfldPassword.Size = new Size(this.txtfldPassword.Size.Width, 50);
        }



        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            
            DataTable QueryResults = new DataTable();
            string SQLQuery = ($"SELECT * FROM Users WHERE username ='{txtfldUsername.Text}' AND password ='{txtfldPassword.Text}';");

            QueryResults = DatabaseManager.ExecuteCommand(SQLQuery);

            if(txtfldUsername.Text == "AdminDelaCruz" && txtfldPassword.Text == "admin123")
            {
                if (QueryResults.Rows.Count > 0)
                {
                    UserSession.userDetails = QueryResults;
                    MessageBox.Show("Login Successfully!");
                    frmAdminTable admin = new frmAdminTable();
                    admin.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid Username and/or Password! Please Try again.");
                    txtfldUsername.ResetText();
                    txtfldPassword.ResetText();
                }
            }
            else
            {
                if (QueryResults.Rows.Count > 0)
                {
                    UserSession.userDetails = QueryResults;
                    MessageBox.Show("Login Successfully!");
                    frmHome frmHome = new frmHome();
                    frmHome.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid Username and/or Password! Please Try again.");
                    txtfldUsername.ResetText();
                    txtfldPassword.ResetText();
                }
            }
             
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.Show();
            this.Visible = false;
        }

        private void txtfldUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtfldUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtfldPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
