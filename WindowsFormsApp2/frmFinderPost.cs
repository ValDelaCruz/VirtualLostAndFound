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
    public partial class frmFinderPost : Form
    {
        public frmFinderPost()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Posted!");
            frmFinderTable frmFinderTable = new frmFinderTable();
            frmFinderTable.Show();
            this.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmFinderTable frmFinderTable = new frmFinderTable();
            frmFinderTable.Show();
            this.Visible = false;
        }


    } 
}
