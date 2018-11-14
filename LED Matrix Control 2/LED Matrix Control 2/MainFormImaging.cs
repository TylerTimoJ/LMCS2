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

        //open image
        private void stillImageSelectButton_Click(object sender, EventArgs e)
        {
            if (OpenImageFile.ShowDialog() == DialogResult.OK) //if image was selected
            {
                lockSizeToggle.Checked = false; // unlock the scale lock
                StopAnimationTick(); //stop any previously running animation

                if (Path.GetExtension(OpenImageFile.FileName) == ".gif")
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
            animationGroup.Enabled = false; //disable animation control
            im.LoadStillFromDisk(OpenImageFile.FileName); //load image with image processor
            im.GeneratePreviewBitmaps(imagePictureBox.Width, imagePictureBox.Height); //generate the bitmaps for the preivew picturebox

            SetScaleControls(); //update scale sliders & numeric updowns to fit the dimensions of loaded image
            RefreshStill(); //send image to display
            UpdateImagePreview(); //update preview with scaled bitmap
        }


        void RefreshStill()
        {
            im.DownSampleImages(pixlx, pixly, selectMode(), dimensions); //load image data to the imageFrames vaiable in image processor

            sm.SendFrame(im.imageFrames[0]); //send frame data
            if (showPreview)
                pb.FrameToBoxes(im.imageFrames[0]); //update matrix preview
        }


        public void LoadGifFromDisk()
        {
            animationGroup.Enabled = true; //enable animation controls
            StopAnimationTick(); //stop previous animation

            im.LoadGifFromDisk(OpenImageFile.FileName); //load gif from file and split frames into bitmaps
        }

        public void LoadGifComplete()
        {
            im.GeneratePreviewBitmaps(imagePictureBox.Width, imagePictureBox.Height); //generate preivew bitmaps

            SetScaleControls(); //update scale sliders & numeric updowns to fit the dimensions of loaded image
            RefreshGif(); //downsample gif bitmaps and load into image processor's imageFrames array
            UpdateImagePreview(); //update preview with scaled bitmap
        }


        //downsample gif bitmaps and load into image processor's imageFrames array
        public void RefreshGif()
        {
            im.DownSampleImages(pixlx, pixly, selectMode(), dimensions);

            sm.SendFrame(im.imageFrames[animIndex]);
            if (showPreview)
                pb.FrameToBoxes(im.imageFrames[animIndex]);
        }


        void SetupScreenCapture()
        {
            //to do: add support for multiple monitors

            im.CaptureScreen(Screen.AllScreens[0].Bounds); //capture snapshot of the whole screen
            im.GeneratePreviewBitmaps(imagePictureBox.Width, imagePictureBox.Height); //generate a preview bitmap of the entire screen

            SetScaleControls(); //update scale sliders & numeric updowns to fit the dimensions of screen
            CaptureScreen(); //capture screen with set scale dimensions
            UpdateImagePreview(); //update preview with scaled bitmap
        }


        void CaptureScreen()
        {

            Rectangle screenCaptureArea = new Rectangle((int)scaleStartX.Value, (int)scaleStartY.Value, (int)(scaleEndX.Value - scaleStartX.Value), (int)(scaleEndY.Value - scaleStartY.Value)); //get area to capture based on scale settings
            Rectangle screenDimensionSize = new Rectangle(0, 0, screenCaptureArea.Width, screenCaptureArea.Height); //set area of screen to capture

            im.CaptureScreen(screenCaptureArea); //capture snapshot of screen and store it in image processor's varaibles
            im.GeneratePreviewBitmaps(imagePictureBox.Width, imagePictureBox.Height); //generate a preview bitmap of selected area of screen

            im.DownSampleImages(pixlx, pixly, selectMode(), screenDimensionSize); //load screen snapshot into image processor's imageFrames array

            sm.SendFrame(im.imageFrames[0]); //send frame data
            pb.FrameToBoxes(im.imageFrames[0]); //update matrix preview
            UpdateImagePreview(); //update preview picturebox
        }

        //update the scale controls to fit whatever image is loaded
        void SetScaleControls()
        {
            scaleStartX.Value = scaleStartY.Value = 0; //reset starting values
            scaleStartX.Maximum = im.workingBitmaps[0].Width - pixlx; //set maximum to the number of pixels in loaded image minus the number of horizontal pixels of matrix
            scaleStartY.Maximum = im.workingBitmaps[0].Height - pixly; //set maximum to the number of pixels in loaded image minus the number of vertical pixels of matrix
            scaleEndXUD.Maximum = scaleEndX.Maximum = im.workingBitmaps[0].Width;
            scaleEndYUD.Maximum = scaleEndY.Maximum = im.workingBitmaps[0].Height;
            scaleEndXUD.Value = scaleEndX.Value = im.workingBitmaps[0].Width; //make sure user can't exceed the horizontal dimensions of image
            scaleEndYUD.Value = scaleEndY.Value = im.workingBitmaps[0].Height; //make sure user can't exceed the vertical dimensions of image
            scaleSettingGroup.Enabled = true; //enable controls after maximums have been set
        }

        bool animPlayingForward = true; //used for the bounce mode

        private void animTimer_Tick(object sender, EventArgs e)
        {
            animIndex = animIndex < 0 ? 0 : animIndex; //prevent animation index from being less than 0
            animIndex = animIndex >= im.imageFrames.Length ? im.imageFrames.Length-1 : animIndex; //prevent animation index from being bigger than one less than the frame array length
            sm.SendFrame(im.imageFrames[animIndex]); //send frame at animation index;

            //update display at animation index;
            if (showPreview)
            {
                pb.FrameToBoxes(im.imageFrames[animIndex]);
                UpdateImagePreview();
            }

            switch (animationMode) //switch based on selected mode
            {
                //play through each frame forwards
                case "Loop":
                    {
                        animIndex++;
                        if (animIndex >= im.imageFrames.Length)
                            animIndex = 0;
                        animPlayingForward = true;
                        break;
                    }
                //play forward then backward
                case "Bounce":
                    {
                        if (animPlayingForward)
                        {
                            animIndex++;
                            if (animIndex >= im.imageFrames.Length - 1)
                                animPlayingForward = false;
                        }
                        else
                        {
                            animIndex--;
                            if (animIndex <= 0)
                                animPlayingForward = true;
                        }
                        break;
                    }
                //opposite of Loop mode
                case "Reverse":
                    {
                        animIndex--;
                        if (animIndex < 0)
                            animIndex = im.imageFrames.Length - 1;

                        animPlayingForward = false;
                        break;
                    }
            }
        }

        //stop animation from playing
        void StopAnimationTick()
        {
            animTimer.Stop(); //stop timer
            animIndex = 0; //reset index
            animPlayingForward = true; //set animation to play forward
        }


        private void ChooseRefreshEvent(object sender, EventArgs e)
        {
            ChooseRefresh();
        }


        private void InterpolationModeDropDown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedInterpMode = InterpolationModeDropDown1.Text;
            ChooseRefresh();
        }

        //refresh images
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
            if (im.ImgType != ImageProcessor.imType.screen && showPreview && im.anyImageLoaded) //if image is loaded and show preview is true and the screen cap is not lo
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
            else
                imagePictureBox.Image = im.previewBitmaps[0];
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


        private void screenCapTimer_Tick(object sender, EventArgs e)
        {
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

        private void stopScreenCap_Click(object sender, EventArgs e)
        {
            screenCapTimer.Stop();
        }


        private void animationPlayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            animationMode = animationPlayMode.Text;
        }


        InterpolationMode selectMode()
        {
            InterpolationMode interpMode;
            switch (selectedInterpMode)
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
