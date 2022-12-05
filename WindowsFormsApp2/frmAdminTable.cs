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
    public partial class frmAdminTable : Form
    {
        public frmAdminTable()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.Show();
            this.Visible = false;
        }

        private void lblItemType_Click(object sender, EventArgs e)
        {
            frmClaimedHistory frmClaimedHistory = new frmClaimedHistory();
            frmClaimedHistory.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.Show();
            this.Visible = false;
        }
    }
}
