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
            try
            {

                connectedPort = new SerialPort(port);
                connectedPort.RtsEnable = true; //needed for power!

                connectedPort.BaudRate = 256;

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

                /*
                for (int i = 0; i < rawFrameData.Length; i++)
                {
                    data[2] = (byte)(rawFrameData[byteOrder[i]][2] * WhiteBalance[0]);
                    data[1] = (byte)(rawFrameData[byteOrder[i]][1] * WhiteBalance[1]);
                    data[0] = (byte)(rawFrameData[byteOrder[i]][0] * WhiteBalance[2]);

                    connectedPort.Write(data, 0, 3);
                }
                */
            }
        }
        public void ClearFrame()
        {
            if (PortOK())
                connectedPort.Write(new byte[] { 1 }, 0, 1);
        }

        bool PortOK()
        {
            return connectedPort != null && connectedPort.IsOpen ? true : false;
        }

    }
}
