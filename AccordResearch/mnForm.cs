using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Imaging.Filters;
using Accord.Video;
using Accord.Video.DirectShow;

namespace AccordResearch
{
    public partial class mnForm : Form
    {
        // Set true for see exceptions.
        private bool debug = false;
        // creating global variables.
        private FilterInfoCollection devices = null;
        private VideoCaptureDevice captureDevice = null;
        private bool frameRotateX = false;
        private bool frameRotateY = false;
        private bool frameGray = false;
        private bool faceDetection = false;

        public mnForm()
        {
            InitializeComponent();
        }

        // Get video input device list.
        private void fillDeviceList()
        {
            try {
                if (captureDevice != null && captureDevice.IsRunning)
                {
                    stopCapture();
                }
                devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo dev in devices)
                {
                    lstDev.Items.Add(dev.Name);
                }
            }
            catch (Exception ex)
            {
                if (debug)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Сhange play/pause button image depending on view state.
        private void changeBtnImg()
        {
            btnPlayPause.Image = captureDevice.IsRunning ? Properties.Resources.pause : Properties.Resources.play;
        }

        // Set active/inactive state for ToolStripButton object by state flag.
        private void btnBG(ToolStripButton btn, bool flag)
        {
            btn.BackColor = flag ? SystemColors.ActiveCaption : SystemColors.Control;
        }

        // Event handler.
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Get captured image.
            Bitmap frame = new Bitmap(eventArgs.Frame);
            if (frameRotateX)
            {
                // Expand button pressed. Expand image.
                frame.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            if (frameRotateY)
            {
                // Flip button pressed. flip image.
                frame.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }
            if (frameGray)
            {
                // Grayscale button is pressed. Applying grayscale filter.
                Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
                frame = filter.Apply(frame);
            }
            // Put captured image into scrCapture.
            displayImage.Image = frame;
        }

        // If capture run, stop process, clear PictureBox and change button image.
        private void stopCapture()
        {
            try
            {
                if (captureDevice != null && captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                }
                changeBtnImg();
                displayImage.Image = null;
            }
            catch (Exception ex)
            {
                if (debug)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Form load
        private void mnForm_Load(object sender, EventArgs e)
        {
            fillDeviceList();
        }

        // Form closing
        private void mnForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopCapture();
        }

        // Set active device.
        private void lstDev_SelectedIndexChanged(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(devices[lstDev.SelectedIndex].MonikerString);
        }

        // Device list refresh button
        private void btnDevRefresh_Click(object sender, EventArgs e)
        {
            lstDev.Items.Clear();
            lstDev.Text = null;
            fillDeviceList();
        }

        // Play/Pause button
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (devices.Count == 0)
                {
                    // Device list is empty.
                    throw new Exception("No devices found!");
                }
                else if (lstDev.SelectedItem == null)
                {
                    // Device not select in ListBox.
                    throw new Exception("Device not select!");
                }
                else if (captureDevice.IsRunning)
                {
                    // Pause.
                    captureDevice.Stop();
                }
                else
                {
                    // Play video and subscribe to event.
                    captureDevice.NewFrame += CaptureDevice_NewFrame;
                    captureDevice.Start();
                }
                changeBtnImg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Stop button
        private void btnStop_Click(object sender, EventArgs e)
        {
            stopCapture();
        }

        // Rotate X button
        private void btnRotateX_Click(object sender, EventArgs e)
        {
            frameRotateX = frameRotateX ? false : true;
            btnBG(sender as ToolStripButton, frameRotateX);
        }

        // Rotate Y button
        private void btnRotateY_Click(object sender, EventArgs e)
        {
            frameRotateY = frameRotateY ? false : true;
            btnBG(sender as ToolStripButton, frameRotateY);
        }

        // Grayscale button
        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            frameGray = frameGray ? false : true;
            btnBG(sender as ToolStripButton, frameGray);
        }

        // Face detection button
        private void btnFace_Click(object sender, EventArgs e)
        {
            faceDetection = faceDetection ? false : true;
            btnBG(sender as ToolStripButton, faceDetection);
        }

        // Screenshot button
        private void btnScrShot_Click(object sender, EventArgs e)
        {
            try
            {
                // Get clone of current captured image.
                Image srcScreenFile = (Bitmap)displayImage.Image.Clone();
                // Open SaveDialog.
                SaveFileDialog saveFileDlg = new SaveFileDialog();
                // Set default filename and extension.
                saveFileDlg.FileName = DateTime.Now.ToString("MM_dd_yyyy") + "_screenshot";
                saveFileDlg.DefaultExt = ".png";
                // Set file extension filter.
                saveFileDlg.Filter = "PNG|*.png";
                if (saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    // Save image to selected file.
                    srcScreenFile.Save(saveFileDlg.FileName, ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                if (debug)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Exit from application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
