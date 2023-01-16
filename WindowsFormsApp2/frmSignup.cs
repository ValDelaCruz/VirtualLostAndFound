using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsApp2
{
    public partial class frmSignup : Form
    {

        public frmSignup()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice videoSource;
        string fileName;
       

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.Show();
            this.Visible = false;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string SQLQuery = ($@"INSERT INTO Users (FirstName, MiddleInitial, LastName, PermissionLevel, ContactNo, Email, Username, Password, ProfilePicture)
                                VALUES('{tbFirstName.Text}', '{tbMiddleInitial.Text}', '{tbLastName.Text}', '{cbUserType.Text}', '{tbContactNo.Text}', '{tbEmail.Text}', '{tbUsername.Text}', '{tbPassword.Text}','{fileName}')");
            
            DatabaseManager.ExecuteCommand(SQLQuery);

            if (tbFirstName.Text == "" || tbLastName.Text == "" || cbUserType.Text == "" || tbContactNo.Text == "" || tbEmail.Text == "" || tbUsername.Text == "" || tbPassword.Text == "" || pbCam2.Image == null)
            {
                MessageBox.Show("All fields are required!");
                
            }
            else
            {
                try
                {
                    if (DatabaseManager.ErrorCode == -1)
                    {
                        MessageBox.Show("Successfully Registered");
                        frmWelcome welcome = new frmWelcome();
                        welcome.Show();
                        this.Visible = false;

                    }
                    else if (DatabaseManager.ErrorCode == 1062)
                    {
                        MessageBox.Show("The data already exists!");
                        tbFirstName.ResetText();
                        tbLastName.ResetText();                     
                        tbContactNo.ResetText();
                        tbEmail.ResetText();
                        tbUsername.ResetText();
                        tbPassword.ResetText();
                        pbCam2.Image = null;

                    }
                    else
                    {
                        MessageBox.Show("You have entered an incorrect data!");
                        MessageBox.Show(DatabaseManager.ErrorCode.ToString());                      
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
          
            
        }
        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                
            }
            
        }

        private void tbMiddleInitial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void tbContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }     
        private void frmSignup_Load_1(object sender, EventArgs e)
        {
            //HIDING UPLOAD PROFILE PICTURE SECTION
            pnlProfilePicture.Visible = false;
            btnStart.Visible = false;
            btnCapture.Visible = false;
            btnReset.Visible = false;

            //OPENING CAMERA DEVICES SELECTION
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevices)
            {
                cbSource.Items.Add(Device.Name);
            }

            cbSource.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(CaptureDevices[cbSource.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler (VideoSource_NewFrame);
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbCam.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            videoSource.Stop();
            pbCam.Image = null;
            pbCam.Invalidate();
            pbCam2.Image = null;
            pbCam2.Invalidate();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            //Profile Picture Setting and Saving to database
                pbCam2.Image = pbCam.Image;
                fileName = @"C:\\Users\\Ysah\\Pictures\\VLF Profile Picture\\" + tbFirstName.Text + tbLastName.Text + ".jpg";
                var bitmap = new Bitmap(pbCam2.Width, pbCam2.Height);
                pbCam2.DrawToBitmap(bitmap, pbCam2.ClientRectangle);
                System.Drawing.Imaging.ImageFormat imageFormat = null;
                imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                bitmap.Save(fileName, imageFormat);
        }

        private void frmSignup_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            videoSource.Stop();
            Environment.Exit(0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SHOWING PROFILE PICTURE UPLOAD SECTION
            if (tbFirstName.Text == "" || tbMiddleInitial.Text == "" || tbLastName.Text == "" || cbUserType.Text == "" || tbContactNo.Text == "" || tbEmail.Text == "" || tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please complete the following requirements!");
            }
            else
            {
                pnlProfilePicture.Visible = true;
                btnStart.Visible = true;
                btnCapture.Visible = true;
                btnReset.Visible = true;
            }  
        }
    }
}
