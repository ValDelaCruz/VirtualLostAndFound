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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnFinder_Click(object sender, EventArgs e)
        {
            frmFinderTable frmFinderTable = new frmFinderTable();
            frmFinderTable.Show();
            this.Visible = false;
        }

        private void btnSeeker_Click(object sender, EventArgs e)
        {
            frmSeekerTable frmSeekerTable = new frmSeekerTable();
            frmSeekerTable.Show();
            this.Visible = false;
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile();
            frmProfile.Show();
            this.Visible = false;
        }

        private void lblHelpCenter_Click(object sender, EventArgs e)
        {
            frmHelpCenter frmHelpCenter = new frmHelpCenter();
            frmHelpCenter.Show();
            this.Visible = false;
        }
    }
}
