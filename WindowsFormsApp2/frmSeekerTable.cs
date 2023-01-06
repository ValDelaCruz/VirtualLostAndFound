﻿using System;
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
            frmVerification frmVerification = new frmVerification();
            frmVerification.Show();
            this.Visible = false;
        }

        private void frmSeekerTable_Load(object sender, EventArgs e)
        {

            dgvReports.DataSource = DatabaseManager.RetrieveData();
        }
    }
}
