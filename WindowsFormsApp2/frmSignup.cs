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
            string firstname = tbFirstName.Text;
            string middleinitial = tbMiddleInitial.Text;
            string lastname = tbLastName.Text;
            string usertype = cbUserType.Text;
            string contactNo = tbContactNo.Text;
            string email = tbEmail.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            
        }
    }
}
