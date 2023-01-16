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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmUserLogin frmUserLogin = new frmUserLogin();
            frmUserLogin.Show();
            this.Visible = false;

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            frmSignup signup = new frmSignup();
            signup.Show();
            this.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmClaimedHistory frmAdminLogin = new frmClaimedHistory();
            frmAdminLogin.Show();
            this.Visible = false;

        }

        private void frmWelcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
