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
            /*
            frmAdminTable adminTable = new frmAdminTable();
            dgvReports.ColumnCount = 7;
            dgvReports.RowCount = 7;
            adminTable.Display(dgvReports.SelectedRows[0].Cells[0].Value.ToString(), dgvReports.SelectedRows[0].Cells[1].Value.ToString(),
              dgvReports.SelectedRows[0].Cells[2].Value.ToString(),
              dgvReports.SelectedRows[0].Cells[3].Value.ToString(),
              dgvReports.SelectedRows[0].Cells[4].Value.ToString(),
              dgvReports.SelectedRows[0].Cells[5].Value.ToString(),
              dgvReports.SelectedRows[0].Cells[6].Value.ToString(),
              dgvReports.SelectedRows[0].Cells[7].Value.ToString()); */
              
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
