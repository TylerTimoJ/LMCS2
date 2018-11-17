using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

namespace LED_Matrix_Control_2
{
    public partial class MainForm : Form
    {

        public bool color1Selected, color2Selected;

        Button[] customButtons;
        int ccIndex = 0;


        //send clear frame message over serial
        private void clearFrame_Click(object sender, EventArgs e)
        {
            sm.ClearFrame();
            pb.ClearFrame();
            dm.ClearFrame();
        }


        private void DrawMouseMove(object sender, MouseEventArgs e)
        {
            if (pb.isDrawingMode && sm.deviceReady)
            {
                DrawObject data = dm.DrawPixel(e);
                if (data.draw)
                {
                    sm.SendPixel(data.x, data.y, data.color);
                    pb.SendPixel(data.x, data.y, data.color);
                }
            }
        }


        private void ChooseDrawColor(object sender, EventArgs e)
        {

            //drawColorPreview.BackColor = drawColorPicker.Color;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Name == "color1Button")
            {
                drawColorPicker.ShowDialog();
                dm.drawColor1 = drawColorPicker.Color;
                color1Button.BackColor = dm.drawColor1;
                customButtons[ccIndex].BackColor = dm.drawColor1;
                UpdateColorInfoLabel(dm.drawColor1);
                ccIndex++;
                if (ccIndex == 10)
                    ccIndex = 0;
            }

            else if (b.Name == "color2Button")
            {
                drawColorPicker.ShowDialog();
                dm.drawColor2 = drawColorPicker.Color;
                color2Button.BackColor = dm.drawColor2;
                customButtons[ccIndex].BackColor = dm.drawColor2;
                UpdateColorInfoLabel(dm.drawColor2);
                ccIndex++;
                if (ccIndex == 10)
                    ccIndex = 0;
            }

        }

        private void ColorPaletteUp(object sender, MouseEventArgs e)
        {
            color1Selected = color2Selected = false;
            Button b = (Button)sender;
            if (e.Button == MouseButtons.Left)
            {
                dm.drawColor1 = b.BackColor;
                color1Button.BackColor = dm.drawColor1;
                UpdateColorInfoLabel(dm.drawColor1);
            }
            else if (e.Button == MouseButtons.Right)
            {
                dm.drawColor2 = b.BackColor;
                color2Button.BackColor = dm.drawColor2;
                UpdateColorInfoLabel(dm.drawColor2);
            }
        }

        void UpdateColorInfoLabel(Color col)
        {
            colorInfoLabel.Text = "Color Info: R:" + col.R.ToString("000") + ", G:" + col.G.ToString("000") + ", B:" + col.B.ToString("000");
        }

        private void saveFrameButton_Click(object sender, EventArgs e)
        {

          //  File.WriteAllBytes("Foo.txt", pb.CreateFrameData());
        }
    }
}
