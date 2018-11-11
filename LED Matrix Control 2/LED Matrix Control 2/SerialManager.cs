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
        public int[] byteOrder;

        public string[] ListCOMPorts()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort"))
            {
                string[] portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                var tList = (from n in portnames join p in ports on n equals p["DeviceID"].ToString() select n + " - " + p["Caption"]).ToList();
                tList.ForEach(Console.WriteLine);
                return tList.ToArray();

            }
        }


        public void ConnectToCOMPort(string port)
        {
            if(!PortOK())
            try
            {

                connectedPort = new SerialPort(port);

                connectedPort.BaudRate = 256000;

                connectedPort.Parity = Parity.None;

                connectedPort.DataBits = 8;

                connectedPort.Handshake = Handshake.None;

                connectedPort.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Cannot connect to COM Port \n" + e.Message);
            }
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

                byte[] data = new byte[rawFrameData.Length];
                int orderIndex = 0;
                for (int i = 0; i < rawFrameData.Length; i += 3)
                {
                    data[i] = rawFrameData[byteOrder[orderIndex] * 3];
                    data[i + 1] = rawFrameData[byteOrder[orderIndex] * 3 + 1];
                    data[i + 2] = rawFrameData[byteOrder[orderIndex] * 3 + 2];
                    orderIndex++;
                }

                connectedPort.BaseStream.Write(new byte[] { 2 }, 0, 1);

                connectedPort.BaseStream.WriteAsync(data, 0, rawFrameData.Length);
            }
        }


        public void SendPixel(int x, int y, byte[] data)
        {
            if (PortOK())
            {
                byte[] pixelData = new byte[5];

                int rawIndex = x * 16 + y;
                int orderedIndex = byteOrder[rawIndex];

                int newY = orderedIndex / 16;
                int newX = orderedIndex % 16;

                pixelData[0] = (byte)newX;
                pixelData[1] = (byte)newY;


                pixelData[2] = data[0];
                pixelData[3] = data[1];
                pixelData[4] = data[2];


                connectedPort.BaseStream.Write(new byte[] { 0 }, 0, 1);

                connectedPort.BaseStream.Write(pixelData, 0, 5);
            }
        }


        public void ClearFrame()
        {
            if (PortOK())
                connectedPort.Write(new byte[] { 1 }, 0, 1);
        }


        bool PortOK()
        {
            return connectedPort != null && connectedPort.IsOpen;
        }

    }
}
