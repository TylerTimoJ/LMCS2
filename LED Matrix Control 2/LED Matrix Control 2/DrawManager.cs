using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LED_Matrix_Control_2
{
    class DrawManager
    {
        MainForm form;

        Point previousLoc;
        byte[] pixelData;
        public Color drawColor;


        public DrawManager()
        {
            form = (MainForm)Application.OpenForms[0];
            previousLoc.X = -1;
            previousLoc.Y = -1;
            drawColor = Color.Black;
        }



        public DrawObject DrawPixel(MouseEventArgs e)
        {
            DrawObject data = new DrawObject();

            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                int x = (int)(form.pixlx * ((float)e.Location.X / (float)(form.matrixContainer.Width - 6)));
                int y = (int)(form.pixly * ((float)e.Location.Y / (float)(form.matrixContainer.Height - 6)));

                x = x >= form.pixlx ? form.pixlx - 1 : x; // don't let the size be bigger than the pixels accross
                y = y >= form.pixly ? form.pixly - 1 : y;

                x = x < 0 ? 0 : x; // don't let the size be smaller than 0
                y = y < 0 ? 0 : y;

                if (y != previousLoc.Y || x != previousLoc.X)
                {
                    pixelData = e.Button == MouseButtons.Left ? new byte[3] { drawColor.R, drawColor.G, drawColor.B } : new byte[3] { 0, 0, 0 };

                    data.draw = true;
                    data.x = x;
                    data.y = y;
                    data.color = pixelData;


                    previousLoc.Y = y;
                    previousLoc.X = x;
                }
            }
            return data;
        }
    }
}
