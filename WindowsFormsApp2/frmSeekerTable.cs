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
    public partial class frmSeekerTable : Form
    {
        public frmSeekerTable()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Visible = false;
        }

        private void btnRequestClaim_Click(object sender, EventArgs e)
        {
            pbUploadVerification frmVerification = new pbUploadVerification();
            frmVerification.Show();
            this.Visible = false;
        }

        private void frmSeekerTable_Load(object sender, EventArgs e)
        {

            dgvReports.DataSource = DatabaseManager.RetrieveData();
        }

        private void frmSeekerTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
