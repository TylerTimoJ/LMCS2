using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace LED_Matrix_Control_2
{
    public class GifLoadParameters
    {
        public string path { get; set; }
        public Bitmap[] workingBitmaps { get; set; }
    }


    public class UpdatePreviewParameters
    {
        public Bitmap currentPreviewBitmap { get; set; }
        public int startX { get; set; }
        public int startY { get; set; }
        public int endX { get; set; }
        public int endY { get; set; }

        public int fullImageWidth { get; set; }
        public int fullImageHeight { get; set; }
    }

    public class DrawObject
    {
        public bool draw { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public byte[] color { get; set; }
    
    }
}
