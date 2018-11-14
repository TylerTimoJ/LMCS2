using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace LED_Matrix_Control_2
{
    public class ImageProcessor
    {
        MainForm form;

        public Bitmap[] workingBitmaps;
        public Bitmap[] previewBitmaps;
        public byte[][] imageFrames;
        BitmapProcessor bp;
        public enum imType { still, gif, screen };
        public imType ImgType;
        public bool anyImageLoaded = false;

        BackgroundWorker gifLoader;


        public ImageProcessor()
        {
            form = (MainForm)Application.OpenForms[0];
            bp = new BitmapProcessor();
            gifLoader = new BackgroundWorker();
            gifLoader.DoWork += LoadGifAsync;
            gifLoader.RunWorkerCompleted += LoadGifAsyncComplete;
        }


        public void LoadStillFromDisk(string path)
        {
            DisposeGarbage();
            previewBitmaps = new Bitmap[1];
            workingBitmaps = new Bitmap[1] { new Bitmap(path) };
            ImgType = imType.still;
            anyImageLoaded = true;
        }


        public void LoadGifFromDisk(string path)
        {
            DisposeGarbage();

            GifLoadParameters data = new GifLoadParameters();
            data.path = path;

            gifLoader.RunWorkerAsync(data);

        }


        void LoadGifAsync(object sender, DoWorkEventArgs e)
        {
            GifLoadParameters data = e.Argument as GifLoadParameters;

            using (Image gifImg = Image.FromFile(data.path))
            {
                FrameDimension fd = new FrameDimension(gifImg.FrameDimensionsList[0]);
                int FrameCount = gifImg.GetFrameCount(fd);
                
                Bitmap[] workingBitm = new Bitmap[FrameCount];

                for (int i = 0; i < FrameCount; i++)
                {
                    gifImg.SelectActiveFrame(fd, i);
                    workingBitm[i] = (Bitmap)gifImg.Clone();
                }
                data.workingBitmaps = workingBitm;
                e.Result = data;
            }
        }


        void LoadGifAsyncComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            GifLoadParameters data = e.Result as GifLoadParameters;
            workingBitmaps = new Bitmap[data.workingBitmaps.Length];
            workingBitmaps = data.workingBitmaps;
            previewBitmaps = new Bitmap[workingBitmaps.Length];
            ImgType = imType.gif;
            anyImageLoaded = true;
            form.LoadGifComplete();
        }


        public void GeneratePreviewBitmaps(int width, int height)
        {
            for (int i = 0; i < workingBitmaps.Length; i++)
            {
                previewBitmaps[i] = bp.ScaleToFitPB(workingBitmaps[i], width, height);
            }
        }


        public void DownSampleImages(int width, int height, InterpolationMode mode, Rectangle dimensions)
        {
            imageFrames = new byte[workingBitmaps.Length][];

            for (int i = 0; i < workingBitmaps.Length; i++)
            {
                imageFrames[i] = bp.ProcessImage(workingBitmaps[i], width, height, mode, dimensions);
            }
        }


        private void DisposeGarbage()
        {
            if (workingBitmaps != null)
                foreach (Bitmap b in workingBitmaps)
                    b.Dispose();
            if (previewBitmaps != null)
                foreach (Bitmap b in previewBitmaps)
                    b.Dispose();
        }


        public void CaptureScreen(Rectangle captureArea)
        {
            DisposeGarbage();
            previewBitmaps = new Bitmap[1];
            workingBitmaps = new Bitmap[1];
            workingBitmaps[0] = bp.ScreenToBitmap(captureArea);
            ImgType = imType.screen;
            anyImageLoaded = true;
        }
    }
}
