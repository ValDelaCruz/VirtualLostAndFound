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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            splash.Width += 3;

            if(splash.Width >= 684)
            {
                timer.Stop();
                frmWelcome welcome = new frmWelcome();
                welcome.Show();
                this.Visible = false;
            }
            
        }
    }
}
