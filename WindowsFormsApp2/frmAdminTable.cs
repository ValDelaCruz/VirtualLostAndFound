using System;
using System.CodeDom;
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
        /*
        public void Display(string ItemID, string ItemType, string ItemColor, string ItemBrand, string ItemModel, string LocationFound, string DateFound, string TimeFound)
        {
            dgvRequestItems.Rows.Add();
            dgvRequestItems.Rows[0].Cells[0].Value = ItemID;
            dgvRequestItems.Rows[0].Cells[1].Value = ItemType;
            dgvRequestItems.Rows[0].Cells[2].Value = ItemColor;
            dgvRequestItems.Rows[0].Cells[3].Value = ItemBrand;
            dgvRequestItems.Rows[0].Cells[4].Value = ItemModel;
            dgvRequestItems.Rows[0].Cells[4].Value = LocationFound;
            dgvRequestItems.Rows[0].Cells[5].Value = DateFound;
            dgvRequestItems.Rows[0].Cells[6].Value = TimeFound;
           
        }
         */
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

        private void frmAdminTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
