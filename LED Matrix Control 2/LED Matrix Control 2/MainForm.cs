using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace LED_Matrix_Control_2
{
    public partial class MainForm : Form
    {
        //create variables for each class
        BitmapProcessor bp;
        public SerialManager sm;
        public PictureBoxBuilder pb;
        ImageProcessor im;
        StatusLabelManager slm;
        DrawManager dm;
        //initialize local variables
        public int pixlx = 16, pixly = 16;
        int scaleWidth, scaleHeight;
        int animIndex = 0;
        string animationMode = "Loop";
        string selectedInterpMode = "Nearest Neighbor";
        bool showPreview = true;
        Rectangle dimensions;


        public MainForm()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pixlsXUpDown.Value = pixlx = Properties.Settings.Default.pixelsX; //load matrix width and height
            pixlsYUpDown.Value = pixly = Properties.Settings.Default.pixelsY;

            //create class objects
            bp = new BitmapProcessor();
            sm = new SerialManager();
            pb = new PictureBoxBuilder(pixlx, pixly);
            im = new ImageProcessor();
            slm = new StatusLabelManager();
            dm = new DrawManager();


            PortListToComboBox(); //list COM Ports

            pb.CreateBoxes(pixlx, pixly); //create matrix pictureboxes with loaded width and height

            InterpolationModeDropDown1.Text = InterpolationModeDropDown1.Items[0].ToString(); //setup interpolationMode
            animationPlayMode.Text = animationPlayMode.Items[0].ToString(); //setup animation mode

            //load white balance & brightness settings
            redWB.Value = Properties.Settings.Default.wbRed;
            greenWB.Value = Properties.Settings.Default.wbGreen;
            blueWB.Value = Properties.Settings.Default.wbBlue;
            brightnessUD.Value = Properties.Settings.Default.brightness;


            //load pixel order settings
            LoadOrderFromDisk(Properties.Settings.Default.previousPixelOrderFile, true);


            //load Screens to dropdown
            foreach (Screen sc in Screen.AllScreens)
            {
                screenSelection.Items.Add(sc.DeviceName);
            }
            screenSelection.Text = Screen.AllScreens[0].DeviceName;

            //reference custom buttons
            customButtons = new Button[10] { ccb1, ccb2, ccb3, ccb4, ccb5, ccb6, ccb7, ccb8, ccb9, ccb10 };
        }

        //connect to which ever COM port is selected in drop down
        private void connectToCOMPort_Click(object sender, EventArgs e)
        {
            sm.ConnectToCOMPort(portsList.Text); //try to connect to COM port
            slm.ConnectionStatus(true, portsList.Text); //update label
        }


        //disconnect from port and stop
        private void disconnectFromCOMPort_Click(object sender, EventArgs e)
        {
            sm.DisconnectCOMPort();
            StopAnimationTick();
            slm.ConnectionStatus(false); //update label
        }

        // refresh COM port list
        private void refreshCOMPorts_Click(object sender, EventArgs e)
        {
            PortListToComboBox();
        }

        //list each COM port in combobox
        private void PortListToComboBox()
        {
            portsList.Items.Clear();
            foreach (string port in sm.ListCOMPorts())
            {
                portsList.Items.Add(port);
                Debug.WriteLine(port);
            }
            if (portsList.Items.Count > 0)
                portsList.Text = portsList.Items[0].ToString();
        }


        private void WBValueChanged(object sender, EventArgs e)
        {
            float[] wb = new float[3] { (float)redWB.Value / 255f, (float)greenWB.Value / 255f, (float)blueWB.Value / 255f };

            sm.WhiteBalance = wb;

            Properties.Settings.Default.wbRed = (int)redWB.Value;
            Properties.Settings.Default.wbGreen = (int)greenWB.Value;
            Properties.Settings.Default.wbBlue = (int)blueWB.Value;
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save(); //save settings to settings file
            StopAnimationTick(); //stop animation from playing
            sm.ClearFrame(); //clear matrix
            sm.DisconnectCOMPort(); //disconnect and free up COM port
        }


        private void editPixelOrder_Click(object sender, EventArgs e)
        {
            pb.Edit();
            resetPixelOrder.Enabled = savePixelOrder.Enabled = true;
        }


        private void savePixelOrder_Click(object sender, EventArgs e)
        {
            pb.SaveOrder();
        }


        private void resetPixelOrder_Click(object sender, EventArgs e)
        {
            pb.ResetOrder();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ModeTabControl.SelectedIndex)
            {
                case 0: //settings
                case 2: //imaging
                case 3: //audio
                    pb.ChangeDrawEnable(false);
                    break;

                case 1: //drawing
                        //   matrixContainer.Cursor = ;
                    Debug.WriteLine("test for github");
                    pb.ChangeDrawEnable(true);
                    break;
            }
        }

        private void loadPixelOrder_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            of.Title = "Load Pixel Order";
            of.Filter = "Pixel Order|*.pxlod";
            of.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            of.ShowDialog();
            LoadOrderFromDisk(of.FileName);

        }

        void LoadOrderFromDisk(string path, bool firstLoad = false)
        {
            if (path != "") //if the previous order file is still there, or even exists
            {
                string[] orderFromFile = File.ReadAllLines(path); //read file into string array
                int[] orderArray = Array.ConvertAll(orderFromFile, s => int.Parse(s)); //parse into an integer array
                if (orderArray.Length == pixlx * pixly)
                {
                    sm.frameByteOrder = orderArray; //set the serial manager's pixel order
                    int[] pixelOrder = new int[orderArray.Length];
                    for (int i = 0; i < orderArray.Length; i++)
                    {
                        //  int keyIndex = Array.FindIndex(words, w => w.IsKey);
                        pixelOrder[i] = Array.IndexOf(orderArray, i);
                    }
                    sm.pixelByteOrder = pixelOrder;
                    slm.PixelOrderStatus(true, pixlx, pixly); //update label
                    Properties.Settings.Default.previousPixelOrderFile = path;
                    pb.DoneEditing();
                }
                else
                {
                    if (firstLoad)
                        slm.PixelOrderStatus(false);
                    else
                        MessageBox.Show("Pixel order does not match matrix size");
                }
            }
            else
                slm.PixelOrderStatus(false); //update label
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            showPreview = showPreviewCheckBox.Checked;
        }


        private void brightnessUD_ValueChanged(object sender, EventArgs e)
        {
            sm.UpdateBrightness((byte)brightnessUD.Value);
            Properties.Settings.Default.brightness = (int)brightnessUD.Value;
        }


        private void buildBoxes_Click(object sender, EventArgs e)
        {
            pixlx = (int)pixlsXUpDown.Value;
            pixly = (int)pixlsYUpDown.Value;
            Properties.Settings.Default.pixelsX = pixlx;
            Properties.Settings.Default.pixelsY = pixly;
            pb.CreateBoxes(pixlx, pixly);
        }

    }
}
