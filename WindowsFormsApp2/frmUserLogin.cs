using MySql.Data.MySqlClient;
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

            if (QueryResults.Rows.Count > 0)
            {
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.Show();
            this.Visible = false;
        }

        private void txtfldUsername_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
