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
            MessageBox.Show("Registered Successfully!");
        }
    }
}
