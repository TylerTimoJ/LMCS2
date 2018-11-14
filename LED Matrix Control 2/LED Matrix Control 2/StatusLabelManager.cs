using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_Matrix_Control_2
{
    public class StatusLabelManager
    {
        MainForm form;

        string statusLabel;
        string s_port = "Disconnected";
        string s_pixelOrder = "No Pixel Order";



        public StatusLabelManager()
        {
            form = (MainForm)Application.OpenForms[0];  //get reference to main form, this will always work because mainform will calls this class setup.
        }


        public void ConnectionStatus(bool connected, string port = "")
        {
            if (connected)
            {
                s_port = "Connected on: " + port;
            }
            else
            {
                s_port = "COM Disconnected";
            }
            PushLabel();
        }


        public void PixelOrderStatus(bool orderLoaded, int width = 0, int height = 0)
        {
            if (orderLoaded)
            {
                s_pixelOrder = "Pixel Order Loaded " + "(" + width + "," + height + ")";
            }
            else
            {
                s_pixelOrder = "Pixel Order NOT Loaded";
            }
            PushLabel();
        }


        void PushLabel()
        {
            statusLabel = "";
            statusLabel += s_port;
            statusLabel += ",  ";
            statusLabel += s_pixelOrder;

            form.statusBar.Text = statusLabel;
        }

    }
}
