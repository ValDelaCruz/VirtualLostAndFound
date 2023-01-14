using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsApp2
{
    public partial class frmFinderPost : Form
    {
        public frmFinderPost()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice videoSource;
        string fileName;

        private void btnUserLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string SQLQuery = ($@"INSERT INTO FinderPost (ItemType, ItemColor, ItemBrand, ItemModel, LocationFound, DateFound, TimeFound, UploadedItem)
                                VALUES('{tbItemType.Text}', '{tbItemColor.Text}', '{tbItemBrand.Text}',  '{tbItemModel.Text}', '{tbLocationFound.Text}', '{dtpDateFound.Text}', '{tbTimeFound.Text}','{fileName}')");

            DatabaseManager.ExecuteCommand(SQLQuery);

            if (tbItemType.Text == "" || tbItemBrand.Text == "" || tbItemColor.Text == "" || tbLocationFound.Text == "" || dtpDateFound.Text == "" || tbTimeFound.Text == "" || pbCam2.Image == null)
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
                        frmFinderTable frmFinderTable = new frmFinderTable();
                        frmFinderTable.Show();
                        this.Visible = false;

                    }
                    else if (DatabaseManager.ErrorCode == 1062)
                    {
                        MessageBox.Show("The data already exists!");
                        tbItemType.ResetText();
                        tbItemBrand.ResetText();
                        tbItemModel.ResetText();
                        tbItemColor.ResetText();
                        tbLocationFound.ResetText();                     
                        tbTimeFound.ResetText();                                            
                    }
                    else
                    {
                        MessageBox.Show("You have entered an incorrect data!");
                        MessageBox.Show(DatabaseManager.ErrorCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmFinderTable frmFinderTable = new frmFinderTable();
            frmFinderTable.Show();
            this.Visible = false;
        }
        private void tbItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void tbItemColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void tbItemBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void tbLocationFound_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }      
        private void btnStart_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(CaptureDevices[cbSource.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
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
            fileName = @"C:\\Users\\Ysah\\Pictures\\VirtualLostAndFound Reports\\" + tbItemBrand.Text + tbItemColor.Text + ".jpg";
            var bitmap = new Bitmap(pbCam2.Width, pbCam2.Height);
            pbCam2.DrawToBitmap(bitmap, pbCam2.ClientRectangle);
            System.Drawing.Imaging.ImageFormat imageFormat = null;
            imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            bitmap.Save(fileName, imageFormat);
        }

        private void btnProof_Click(object sender, EventArgs e)
        {
            //SHOWING PROFILE PICTURE UPLOAD SECTION
            if (tbItemType.Text == "" || tbItemBrand.Text == "" || tbItemModel.Text == "" || tbItemColor.Text == "" || tbLocationFound.Text == "" || dtpDateFound.Text == "" || tbTimeFound.Text == "")
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

        private void frmFinderPost_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                videoSource.Stop();
            }
            catch
            {
                return;
            }
        }

        private void frmFinderPost_Load(object sender, EventArgs e)
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
    } 
}
