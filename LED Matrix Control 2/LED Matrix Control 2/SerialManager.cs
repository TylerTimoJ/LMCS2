using System;
using System.Linq;
using System.Management;
using System.IO.Ports;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace LED_Matrix_Control_2
{
    public class SerialManager
    {
        public float[] WhiteBalance = new float[] { 1f, 1f, 1f };
        SerialPort connectedPort;
        public int[] frameByteOrder;
        public int[] pixelByteOrder;
        public bool deviceReady = true;

        MainForm form;

        public SerialManager()
        {
            form = (MainForm)Application.OpenForms[0];
        }

        public string[] ListCOMPorts()
        {
            string[] portnames = SerialPort.GetPortNames();
            return portnames;
        }


        public void ConnectToCOMPort(string port)
        {
            if (!PortOK())
                try
                {

                    connectedPort = new SerialPort(port);

                    connectedPort.BaudRate = 1000000;

                    connectedPort.Parity = Parity.None;

                    connectedPort.DataBits = 8;

                    connectedPort.Handshake = Handshake.None;

                    connectedPort.DataReceived += ConnectedPort_DataReceived;

                    connectedPort.Open();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Cannot connect to COM Port \n" + e.Message);
                }
        }

        private void ConnectedPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
                deviceReady = connectedPort.BaseStream.ReadByte() == 16 ? true : false;
        }

        public void DisconnectCOMPort()
        {
            if (PortOK())
            {
                connectedPort.Close();
                connectedPort.Dispose();

            }
        }


        public void SendFrame(byte[] rawFrameData)
        {
            if (PortOK())
            {
                deviceReady = false;
                byte[] data = new byte[rawFrameData.Length+1];
                data[0] = 2;
                int orderIndex = 0;
                for (int i = 1; i < rawFrameData.Length+1; i += 3)
                {
                    data[i+2] = (byte)(rawFrameData[frameByteOrder[orderIndex] * 3] * WhiteBalance[0]);
                    data[i + 1] = (byte)(rawFrameData[frameByteOrder[orderIndex] * 3 + 1] * WhiteBalance[1]);
                    data[i] = (byte)(rawFrameData[frameByteOrder[orderIndex] * 3 + 2] * WhiteBalance[2]);
                    orderIndex++;
                }
                connectedPort.BaseStream.WriteAsync(data, 0, rawFrameData.Length+1);
            }
        }


        public void SendPixel(int x, int y, byte[] data)
        {
            if (PortOK())
            {
                deviceReady = false;
                byte[] pixelData = new byte[6];
                pixelData[0] = 0;


                int w = form.pixlx;
                int h = form.pixly;

                int rawIndex = (y * w) + x;
                int orderedIndex = pixelByteOrder[rawIndex];

               // orderedIndex
                //int orderedIndex = rawIndex;

                int newX = orderedIndex % w;
                int newY = orderedIndex / w;


                
                pixelData[1] = (byte)newX;
                pixelData[2] = (byte)newY;

               // pixelData[1] = (byte)x;
               // pixelData[2] = (byte)y;


                pixelData[3] = (byte)(data[0] * WhiteBalance[0]);
                pixelData[4] = (byte)(data[1] * WhiteBalance[1]);
                pixelData[5] = (byte)(data[2] * WhiteBalance[2]);


                //connectedPort.BaseStream.Write(new byte[] { 0 }, 0, 1);

                connectedPort.BaseStream.Write(pixelData, 0, 6);
            }
        }


        public void ClearFrame()
        {
            if (PortOK())
                connectedPort.BaseStream.WriteAsync(new byte[] { 1 }, 0, 1);
        }


        public void UpdateBrightness(byte brightness)
        {
            if (PortOK())
                connectedPort.BaseStream.WriteAsync(new byte[] { 3, brightness }, 0, 2);

        }


        bool PortOK()
        {
            return connectedPort != null && connectedPort.IsOpen && deviceReady;
        }

    }
}
