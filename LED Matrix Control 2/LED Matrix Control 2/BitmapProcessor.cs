using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace LED_Matrix_Control_2
{
    public class BitmapProcessor
    {
        public byte[] ProcessImage(Bitmap image, int width, int height, InterpolationMode mode, Rectangle dimensions)
        {
            Bitmap workingBitmap = CropImage(image, dimensions);
            Bitmap DownSampBit = DownsampleBitmap(workingBitmap, width, height, mode);
            byte[] bitmapBytes = BitmapToByteArray(DownSampBit);

            DownSampBit.Dispose();
            workingBitmap.Dispose();
            return bitmapBytes;
        }


        Bitmap CropImage(Bitmap img, Rectangle cropArea)
        {
            Bitmap bmp = new Bitmap(cropArea.Width, cropArea.Height);
            using (Graphics gph = Graphics.FromImage(bmp))
            {
                
                gph.DrawImage(img, new Rectangle(0, 0, cropArea.Width, cropArea.Height), cropArea, GraphicsUnit.Pixel);
            }
            return bmp;
        }


        private byte[] BitmapToByteArray(Bitmap bitmap)
        {
            BitmapData bmpdata = null;
            bmpdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            int numbytes = bmpdata.Stride * bitmap.Height;
            byte[] bytedata = new byte[numbytes];
            IntPtr ptr = bmpdata.Scan0;
            Marshal.Copy(ptr, bytedata, 0, numbytes);
            bitmap.UnlockBits(bmpdata);
            return bytedata;
        }


        private Bitmap DownsampleBitmap(Bitmap b, int width, int height, InterpolationMode mode)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.SmoothingMode = SmoothingMode.None;
                g.InterpolationMode = mode;
                g.DrawImage(b, 0, 0, width, height);
            }
            return result;
        }


        public Bitmap ImagePreviewHandler(Bitmap b, int x, int y, int endX, int endY)
        {
            Bitmap processedBitmap = b.Clone(new Rectangle(0, 0, b.Width, b.Height), PixelFormat.DontCare);
            
            using (Graphics g = Graphics.FromImage(processedBitmap))
            {
                g.SmoothingMode = SmoothingMode.None;
                g.DrawRectangle(new Pen(Brushes.HotPink, (b.Width/150)), new Rectangle(x, y, endX - x, endY - y));
            }
            return processedBitmap;
        }


        public Bitmap ScaleToFitPB(Bitmap source, int pbWidth, int pbHeight)
        {
            Bitmap workingBit = source.Clone(new Rectangle(0, 0, source.Width, source.Height), PixelFormat.DontCare);
            Bitmap returnBit;
            if ((float)source.Width / (float)source.Height < (float)pbWidth / (float)pbHeight)
                returnBit = new Bitmap(workingBit, (int)(((float)source.Width / (float)source.Height) * pbHeight), pbHeight);

            else if ((float)source.Width / (float)source.Height > (float)pbWidth / (float)pbHeight)
                returnBit = new Bitmap(workingBit, pbWidth, (int)(((float)source.Height / (float)source.Width) * pbWidth));

            else
                returnBit = new Bitmap(workingBit, pbWidth, pbHeight);

            workingBit.Dispose();
            return returnBit;
        }


        public Bitmap ScreenToBitmap(Rectangle captureArea)
        {
            Bitmap screenBitmap = new Bitmap(captureArea.Width, captureArea.Height, PixelFormat.Format24bppRgb);

                using (Graphics captureGraphics = Graphics.FromImage(screenBitmap))
                {
                    captureGraphics.CopyFromScreen(captureArea.Left, captureArea.Top, 0, 0, captureArea.Size);
                }
            return screenBitmap;
        }
    }
}
