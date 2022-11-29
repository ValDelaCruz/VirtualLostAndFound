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
    public partial class frmClaimedHistory : Form
    {
        public frmClaimedHistory()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Successfully!");
            frmAdminTable frmAdminTable = new frmAdminTable();
            frmAdminTable.Show();
            this.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.Show();
            this.Visible = false;
        }

    }
}
