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
    public partial class frmFinderTable : Form
    {
        public frmFinderTable()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmFinderPost frmFinderPost = new frmFinderPost();
            frmFinderPost.Show();
            this.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Visible = false;
        } 
    }
}
