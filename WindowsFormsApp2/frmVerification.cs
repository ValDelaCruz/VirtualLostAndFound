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
    public partial class frmVerification : Form
    {
        public frmVerification()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uploaded Successfully!");
            frmSeekerTable frmSeekerTable = new frmSeekerTable();
            frmSeekerTable.Show();
        }

        private void lblSkip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Claim Successfully!");
            frmSeekerTable frmSeekerTable = new frmSeekerTable();
            frmSeekerTable.Show();
        }
    }
}
