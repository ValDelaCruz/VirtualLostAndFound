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
    public partial class frmProfile : Form
    {
        public frmProfile()
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

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.Show();
            this.Visible = false;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pbProfilePic.Width - 3, pbProfilePic.Height - 3);
            Region rg = new Region(gp);
            pbProfilePic.Region = rg;
            pbProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;

            foreach (DataRow row in UserSession.userDetails.Rows)
            {
                lblFullName.Text = row["Firstname"].ToString() + " " + row["MiddleInitial"].ToString() + " " + row["LastName"].ToString();
                lblUserType.Text = row["PermissionLevel"].ToString();
                lblContact.Text = row["ContactNo"].ToString();
                lblEmail.Text = row["Email"].ToString();
                lblUsername.Text = row["Username"].ToString();
                pbProfilePic.Image = Image.FromFile(row["ProfilePicture"].ToString());
            }
        }

        private void frmProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
