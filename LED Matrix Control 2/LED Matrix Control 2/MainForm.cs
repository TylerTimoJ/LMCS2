using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace LED_Matrix_Control_2
{
    public partial class MainForm : Form
    {

        BitmapProcessor bp;
        public SerialManager sm;
        PictureBoxBuilder pb;
        ImageProcessor im;
        StatusLabelManager slm;
       // AudioManager am;

        public int pixlx = 16, pixly = 16;
        int scaleWidth, scaleHeight;
        int animIndex = 0;

        bool showPreview = true;

        Rectangle dimensions;

        public MainForm() { InitializeComponent(); }


        private void Form1_Load(object sender, EventArgs e)
        {
            bp = new BitmapProcessor();
            sm = new SerialManager();
            pb = new PictureBoxBuilder();
            im = new ImageProcessor();
            slm = new StatusLabelManager();
         //   am = new AudioManager();
            //list COM Ports
            PortListToComboBox();
            //load matrix dimensions
            pixlsXUpDown.Value = pixlx = Properties.Settings.Default.pixelsX;
            pixlsYUpDown.Value = pixly = Properties.Settings.Default.pixelsY;
            //draw matrix
            pb.CreateBoxes(pixlx, pixly);
            //setupinterpolationMode & anim mode
            InterpolationModeDropDown1.Text = InterpolationModeDropDown1.Items[0].ToString();
            animationPlayMode.Text = animationPlayMode.Items[0].ToString();
            //load white balance settings

            redWB.Value = Properties.Settings.Default.wbRed;
            greenWB.Value = Properties.Settings.Default.wbGreen;
            blueWB.Value = Properties.Settings.Default.wbBlue;

            //load pixel order settings
            sm.byteOrder = Properties.Settings.Default.PixelOrder;

            //load Screens
            foreach(Screen sc in Screen.AllScreens)
            {
                screenSelection.Items.Add(sc.DeviceName);
            }
            screenSelection.Text = Screen.AllScreens[0].DeviceName;
            

        }


        private void connectToCOMPort_Click(object sender, EventArgs e) { sm.ConnectToCOMPort(portsList.Text.Split(' ')[0]); }

        private void clearFrame_Click(object sender, EventArgs e) { sm.ClearFrame(); pb.ClearFrame(); }

        private void disconnectFromCOMPort_Click(object sender, EventArgs e)
        {
            sm.DisconnectCOMPort();
            StopAnimationTick();
        }


        private void PortListToComboBox()
        {
            portsList.Items.Clear();
            foreach (string port in sm.ListCOMPorts())
            {
                portsList.Items.Add(port);
                portsList.Text = port;
            }
        }


        private void refreshCOMPorts_Click(object sender, EventArgs e)
        {
            portsList.Items.Clear();
            foreach (string port in sm.ListCOMPorts())
            {
                portsList.Items.Add(port);
            }
            if (portsList.Items.Count > 0)
                portsList.Text = portsList.Items[0].ToString();
        }


        private void stillImageSelectButton_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                lockSizeToggle.Checked = false;
                StopAnimationTick();
                if (Path.GetExtension(OpenFile.FileName) == ".gif")
                {
                    LoadGifFromDisk();
                }
                else
                {
                    LoadStillFromDisk();
                }
            }
        }


        void LoadStillFromDisk()
        {
            animationGroup.Enabled = false;
            im.LoadStillFromDisk(OpenFile.FileName);
            im.GeneratePreviewBitmaps(imagePictureBox.Width, imagePictureBox.Height);

            SetScaleControls();
            RefreshStill();
            UpdateImagePreview();
        }


        void RefreshStill()
        {
            im.DownSampleImages(pixlx, pixly, selectMode(), dimensions);

            sm.SendFrame(im.imageFrames[0]);
            if (showPreview)
                pb.FrameToBoxes(im.imageFrames[0]);
        }


        public void LoadGifFromDisk()
        {
            animationGroup.Enabled = true;
            StopAnimationTick();

            im.LoadGifFromDisk(OpenFile.FileName);
            im.GeneratePreviewBitmaps(imagePictureBox.Width, imagePictureBox.Height);

            SetScaleControls();
            RefreshGif();
            UpdateImagePreview();
        }


        public void RefreshGif()
        {
            im.DownSampleImages(pixlx, pixly, selectMode(), dimensions);

            SendGif();
        }


        void SendGif()
        {

            sm.SendFrame(im.imageFrames[0]);
            if (showPreview)
                pb.FrameToBoxes(im.imageFrames[0]);


        }


        void SetupScreenCapture()
        {
            //add support for multiple monitors

            im.CaptureScreen(Screen.AllScreens[0].Bounds);
            im.GeneratePreviewBitmaps(imagePictureBox.Width, imagePictureBox.Height);

            SetScaleControls();

            CaptureScreen();

            UpdateImagePreview();
        }


        void CaptureScreen()
        {

            Rectangle screenCaptureArea = new Rectangle((int)scaleStartX.Value, (int)scaleStartY.Value, (int)(scaleEndX.Value - scaleStartX.Value), (int)(scaleEndY.Value - scaleStartY.Value));
            Rectangle screenDimensionSize = new Rectangle(0, 0, screenCaptureArea.Width, screenCaptureArea.Height);

            im.CaptureScreen(screenCaptureArea);
            im.GeneratePreviewBitmaps(imagePictureBox.Width, imagePictureBox.Height);

            im.DownSampleImages(pixlx, pixly, selectMode(), screenDimensionSize);

            sm.SendFrame(im.imageFrames[0]);
            pb.FrameToBoxes(im.imageFrames[0]);
            UpdateImagePreview();
        }


        void SetScaleControls()
        {
            scaleStartX.Value = scaleStartY.Value = 0;
            scaleStartX.Maximum = im.workingBitmaps[0].Width - pixlx;
            scaleStartY.Maximum = im.workingBitmaps[0].Height - pixly;
            scaleEndXUD.Value = scaleEndX.Value = scaleEndX.Maximum = im.workingBitmaps[0].Width;
            scaleEndYUD.Value = scaleEndY.Value = scaleEndY.Maximum = im.workingBitmaps[0].Height;
            scaleSettingGroup.Enabled = true;
        }

        bool animPlayingForward;
        private void animTimer_Tick(object sender, EventArgs e)
        {
            sm.SendFrame(im.imageFrames[animIndex]);

            if (showPreview)
            {
                pb.FrameToBoxes(im.imageFrames[animIndex]);
                UpdateImagePreview();
            }
            switch (animationPlayMode.Text)
            {
                case "Loop":
                    {
                        if (animIndex < im.imageFrames.Length - 1)
                            animIndex++;
                        else
                            animIndex = 0;
                        break;
                    }
                case "Bounce":
                    {
                        if (animPlayingForward)
                        {
                            if (animIndex < im.imageFrames.Length - 1)
                            {
                                animIndex++;
                            }
                            else
                            {
                                animIndex = im.imageFrames.Length - 1;
                                animPlayingForward = false;
                            }
                        }
                        else
                        {
                            if (animIndex > 0)
                            {
                                animIndex--;
                            }
                            else
                            {
                                animIndex = 0;
                                animPlayingForward = true;
                            }
                        }
                        break;
                    }
                case "Reverse":
                    {
                        if (animIndex > 0)
                            animIndex--;
                        else
                            animIndex = im.imageFrames.Length - 1;
                        break;
                    }
            }
        }

        void StopAnimationTick()
        {
            animTimer.Stop();
            animIndex = 0;
        }

        private void InterpolationModeDropDown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseRefresh();
        }

        private void setScaleButton_Click(object sender, EventArgs e)
        {
            ChooseRefresh();
        }

        void ChooseRefresh()
        {
            if (im.anyImageLoaded)
            {
                if (im.ImgType == ImageProcessor.imType.still)
                    RefreshStill();
                if (im.ImgType == ImageProcessor.imType.gif)
                    RefreshGif();
                if (im.ImgType == ImageProcessor.imType.screen)
                    CaptureScreen();
            }
        }

        private void scaleStartXUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!lockSizeToggle.Checked)
            {
                if (sender is NumericUpDown)
                {
                    if (scaleEndXUD.Value < scaleStartXUD.Value + pixlx)
                        scaleEndXUD.Value = scaleStartXUD.Value + pixlx;

                    if (scaleEndYUD.Value < scaleStartYUD.Value + pixly)
                        scaleEndYUD.Value = scaleStartYUD.Value + pixly;
                }
                if (sender is TrackBar)
                {
                    if (scaleEndX.Value < scaleStartX.Value + pixlx)
                        scaleEndX.Value = scaleStartX.Value + pixlx;

                    if (scaleEndY.Value < scaleStartY.Value + pixly)
                        scaleEndY.Value = scaleStartY.Value + pixly;
                }
            }
            else
            {
                if (sender is NumericUpDown)
                {
                    if (scaleEndXUD.Value < scaleStartXUD.Value + scaleWidth)
                        scaleEndXUD.Value = scaleStartXUD.Value + scaleWidth;

                    if (scaleEndYUD.Value < scaleStartYUD.Value + scaleHeight)
                        scaleEndYUD.Value = scaleStartYUD.Value + scaleHeight;
                }
                if (sender is TrackBar)
                {
                    if (scaleStartX.Value > im.workingBitmaps[0].Width - scaleWidth)
                        scaleStartX.Value = im.workingBitmaps[0].Width - scaleWidth;
                    if (scaleStartX.Value < scaleEndX.Value - scaleWidth)
                        scaleEndX.Value = scaleStartX.Value + scaleWidth;

                    if (scaleStartY.Value > im.workingBitmaps[0].Height - scaleHeight)
                        scaleStartY.Value = im.workingBitmaps[0].Height - scaleHeight;
                    if (scaleStartY.Value < scaleEndY.Value - scaleHeight)
                        scaleEndY.Value = scaleStartY.Value + scaleHeight;
                }
            }
            if (sender is NumericUpDown)
            {
                scaleStartX.Value = (int)scaleStartXUD.Value;
                scaleStartY.Value = (int)scaleStartYUD.Value;
                scaleEndX.Value = (int)scaleEndXUD.Value;
                scaleEndY.Value = (int)scaleEndYUD.Value;
            }
            if (sender is TrackBar)
            {
                scaleStartXUD.Value = scaleStartX.Value;
                scaleStartYUD.Value = scaleStartY.Value;
                scaleEndXUD.Value = scaleEndX.Value;
                scaleEndYUD.Value = scaleEndY.Value;
            }
            croppedAreaWLabel.Text = "Width:" + (scaleEndX.Value - scaleStartX.Value).ToString("###,##0");
            croppedAreaHLabel.Text = "Height:" + (scaleEndY.Value - scaleStartY.Value).ToString("###,##0");

            dimensions = new Rectangle((int)scaleStartX.Value, (int)scaleStartY.Value, (int)(scaleEndX.Value - scaleStartX.Value), (int)(scaleEndY.Value - scaleStartY.Value));

            UpdateImagePreview();
        }

        void UpdateImagePreview()
        {
            if (im.ImgType != ImageProcessor.imType.screen && showPreview)
            {
                if (im.anyImageLoaded)
                {
                    Bitmap paintedBitmap = im.previewBitmaps[animIndex].Clone(new Rectangle(0, 0, im.previewBitmaps[0].Width, im.previewBitmaps[0].Height), PixelFormat.DontCare);
                    using (Graphics g = Graphics.FromImage(paintedBitmap))
                    {
                        int startPosX = (int)(scaleStartX.Value * ((float)im.previewBitmaps[0].Width / (float)im.workingBitmaps[0].Width));
                        int startPosY = (int)(scaleStartY.Value * ((float)im.previewBitmaps[0].Height / (float)im.workingBitmaps[0].Height));
                        int endPosX = (int)(scaleEndX.Value * ((float)im.previewBitmaps[0].Width / (float)im.workingBitmaps[0].Width));
                        int endPosY = (int)(scaleEndY.Value * ((float)im.previewBitmaps[0].Height / (float)im.workingBitmaps[0].Height));

                        g.DrawRectangle(new Pen(Brushes.HotPink, 1), new Rectangle(startPosX, startPosY, endPosX - startPosX - 1, endPosY - startPosY - 1));
                    }
                    imagePictureBox.Image = paintedBitmap;
                }
            }
            else
            {
                imagePictureBox.Image = im.previewBitmaps[0];
            }
        }

        private void resetScaleButton_Click(object sender, EventArgs e)
        {
            StopAnimationTick();
            lockSizeToggle.Checked = false;
            if (im.ImgType == ImageProcessor.imType.still)
                LoadStillFromDisk();
            if (im.ImgType == ImageProcessor.imType.gif)
            {
                LoadGifFromDisk();
            }
            if (im.ImgType == ImageProcessor.imType.screen)
                SetupScreenCapture();

        }

        private void startAnimation_Click(object sender, EventArgs e)
        {
            if (im.ImgType == ImageProcessor.imType.gif)
                animTimer.Start();
        }

        private void stopAnimation_Click(object sender, EventArgs e)
        {
            animTimer.Stop();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            animTimer.Interval = 1000 / (int)numericUpDown1.Value;
        }

        private void WBValueChanged(object sender, EventArgs e)
        {
            byte[] whiteFrame = new byte[pixlx * pixly];
            for (int i = 0; i < whiteFrame.Length; i++)
            {
                whiteFrame[i] = 255;
            }
            sm.WhiteBalance = new float[] { (float)redWB.Value / 255f, (float)greenWB.Value / 255f, (float)blueWB.Value / 255f, };
            if (!im.anyImageLoaded)
                sm.SendFrame(whiteFrame);

            Properties.Settings.Default.wbRed = (int)redWB.Value;
            Properties.Settings.Default.wbGreen = (int)greenWB.Value;
            Properties.Settings.Default.wbBlue = (int)blueWB.Value;
            Properties.Settings.Default.Save();
        }

        private void screenCapTimer_Tick(object sender, EventArgs e)
        {



            //StopAnimationTick();
            CaptureScreen();

        }

        private void startScreenCap_Click(object sender, EventArgs e)
        {
            SetupScreenCapture();
            screenCapTimer.Start();
        }



        private void lockSizeToggle_CheckedChanged(object sender, EventArgs e)
        {
            scaleEndX.Enabled = scaleEndXUD.Enabled = scaleEndY.Enabled = scaleEndYUD.Enabled = !lockSizeToggle.Checked;
            if (lockSizeToggle.Checked)
            {
                scaleWidth = scaleEndX.Value - scaleStartX.Value;
                scaleHeight = scaleEndY.Value - scaleStartY.Value;
            }
        }

        private void showMatrixPreview_CheckedChanged(object sender, EventArgs e)
        {
            showPreview = matrixContainer.Enabled = showMatrixPreview.Checked;

        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   am.Start();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void editPixelOrder_Click(object sender, EventArgs e)
        {
            pb.Edit();
            resetPixelOrder.Enabled = savePixelOrder.Enabled = true;
        }

        private void savePixelOrder_Click(object sender, EventArgs e)
        {
            pb.SaveOrder();
        }

        private void resetPixelOrder_Click(object sender, EventArgs e)
        {
            pb.ResetOrder();
        }

        private void stopScreenCap_Click(object sender, EventArgs e)
        {
            screenCapTimer.Stop();
        }

        private void buildBoxes_Click(object sender, EventArgs e)
        {
            pixlx = (int)pixlsXUpDown.Value;
            pixly = (int)pixlsYUpDown.Value;
            Properties.Settings.Default.pixelsX = pixlx;
            Properties.Settings.Default.pixelsY = pixly;
            Properties.Settings.Default.Save();
            pb.CreateBoxes(pixlx, pixly);
            //Debug.WriteLine(Application.OpenForms[0].Width);
        }

        InterpolationMode selectMode()
        {
            InterpolationMode interpMode;
            switch (InterpolationModeDropDown1.Text)
            {
                case "Low":
                    interpMode = InterpolationMode.Low;
                    break;
                case "High":
                    interpMode = InterpolationMode.High;
                    break;
                case "Nearest Neighbor":
                    interpMode = InterpolationMode.NearestNeighbor;
                    break;
                case "Medium":
                    interpMode = InterpolationMode.HighQualityBilinear;
                    break;
                default:
                    interpMode = InterpolationMode.High;
                    break;
            }
            return interpMode;
        }
    }
}
