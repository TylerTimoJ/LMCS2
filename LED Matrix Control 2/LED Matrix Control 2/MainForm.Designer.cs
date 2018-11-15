namespace LED_Matrix_Control_2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connectToCOMPort = new System.Windows.Forms.Button();
            this.matrixContainer = new System.Windows.Forms.Panel();
            this.ModeTabControl = new System.Windows.Forms.TabControl();
            this.tab1Settings = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.showPreviewCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.loadPixelOrder = new System.Windows.Forms.Button();
            this.resetPixelOrder = new System.Windows.Forms.Button();
            this.savePixelOrder = new System.Windows.Forms.Button();
            this.editPixelOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pixlsYUpDown = new System.Windows.Forms.NumericUpDown();
            this.pixlsXUpDown = new System.Windows.Forms.NumericUpDown();
            this.buildBoxes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refreshCOMPorts = new System.Windows.Forms.Button();
            this.disconnectFromCOMPort = new System.Windows.Forms.Button();
            this.portsList = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.brightnessUD = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.blueWB = new System.Windows.Forms.NumericUpDown();
            this.greenWB = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.redWB = new System.Windows.Forms.NumericUpDown();
            this.tab2Draw = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.color2Button = new System.Windows.Forms.Button();
            this.color1Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ccb10 = new System.Windows.Forms.Button();
            this.ccb9 = new System.Windows.Forms.Button();
            this.ccb8 = new System.Windows.Forms.Button();
            this.cb6 = new System.Windows.Forms.Button();
            this.ccb7 = new System.Windows.Forms.Button();
            this.ccb6 = new System.Windows.Forms.Button();
            this.ccb5 = new System.Windows.Forms.Button();
            this.ccb4 = new System.Windows.Forms.Button();
            this.ccb3 = new System.Windows.Forms.Button();
            this.ccb2 = new System.Windows.Forms.Button();
            this.ccb1 = new System.Windows.Forms.Button();
            this.cb20 = new System.Windows.Forms.Button();
            this.cb19 = new System.Windows.Forms.Button();
            this.cb18 = new System.Windows.Forms.Button();
            this.cb17 = new System.Windows.Forms.Button();
            this.cb16 = new System.Windows.Forms.Button();
            this.cb15 = new System.Windows.Forms.Button();
            this.cb14 = new System.Windows.Forms.Button();
            this.cb13 = new System.Windows.Forms.Button();
            this.cb12 = new System.Windows.Forms.Button();
            this.cb11 = new System.Windows.Forms.Button();
            this.cb10 = new System.Windows.Forms.Button();
            this.cb9 = new System.Windows.Forms.Button();
            this.cb8 = new System.Windows.Forms.Button();
            this.cb7 = new System.Windows.Forms.Button();
            this.cb5 = new System.Windows.Forms.Button();
            this.cb4 = new System.Windows.Forms.Button();
            this.cb3 = new System.Windows.Forms.Button();
            this.cb2 = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.Button();
            this.clearButton1 = new System.Windows.Forms.Button();
            this.tab3Image = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.InterpolationModeDropDown1 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.stopScreenCap = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.screenSelection = new System.Windows.Forms.ComboBox();
            this.startScreenCap = new System.Windows.Forms.Button();
            this.animationGroup = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.animationPlayMode = new System.Windows.Forms.ComboBox();
            this.stopAnimation = new System.Windows.Forms.Button();
            this.startAnimation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.scaleSettingGroup = new System.Windows.Forms.GroupBox();
            this.croppedAreaHLabel = new System.Windows.Forms.Label();
            this.croppedAreaWLabel = new System.Windows.Forms.Label();
            this.lockSizeToggle = new System.Windows.Forms.CheckBox();
            this.scaleEndYUD = new System.Windows.Forms.NumericUpDown();
            this.scaleEndXUD = new System.Windows.Forms.NumericUpDown();
            this.scaleStartYUD = new System.Windows.Forms.NumericUpDown();
            this.scaleStartXUD = new System.Windows.Forms.NumericUpDown();
            this.setScaleButton = new System.Windows.Forms.Button();
            this.scaleEndY = new System.Windows.Forms.TrackBar();
            this.scaleEndX = new System.Windows.Forms.TrackBar();
            this.scaleStartY = new System.Windows.Forms.TrackBar();
            this.scaleStartX = new System.Windows.Forms.TrackBar();
            this.resetScaleButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imageSelectButton = new System.Windows.Forms.Button();
            this.tab4Audio = new System.Windows.Forms.TabPage();
            this.OpenImageFile = new System.Windows.Forms.OpenFileDialog();
            this.animTimer = new System.Windows.Forms.Timer(this.components);
            this.screenCapTimer = new System.Windows.Forms.Timer(this.components);
            this.statusBar = new System.Windows.Forms.Label();
            this.drawColorPicker = new System.Windows.Forms.ColorDialog();
            this.ModeTabControl.SuspendLayout();
            this.tab1Settings.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixlsYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixlsXUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueWB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenWB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redWB)).BeginInit();
            this.tab2Draw.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab3Image.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.animationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.scaleSettingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndYUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndXUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartYUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartXUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartX)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectToCOMPort
            // 
            this.connectToCOMPort.Location = new System.Drawing.Point(6, 46);
            this.connectToCOMPort.Name = "connectToCOMPort";
            this.connectToCOMPort.Size = new System.Drawing.Size(128, 23);
            this.connectToCOMPort.TabIndex = 0;
            this.connectToCOMPort.Text = "Connect";
            this.connectToCOMPort.UseVisualStyleBackColor = true;
            this.connectToCOMPort.Click += new System.EventHandler(this.connectToCOMPort_Click);
            // 
            // matrixContainer
            // 
            this.matrixContainer.AutoSize = true;
            this.matrixContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matrixContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matrixContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.matrixContainer.Location = new System.Drawing.Point(517, 6);
            this.matrixContainer.Margin = new System.Windows.Forms.Padding(0);
            this.matrixContainer.MinimumSize = new System.Drawing.Size(10, 646);
            this.matrixContainer.Name = "matrixContainer";
            this.matrixContainer.Size = new System.Drawing.Size(10, 646);
            this.matrixContainer.TabIndex = 4;
            this.matrixContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawMouseMove);
            this.matrixContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawMouseMove);
            // 
            // ModeTabControl
            // 
            this.ModeTabControl.Controls.Add(this.tab1Settings);
            this.ModeTabControl.Controls.Add(this.tab2Draw);
            this.ModeTabControl.Controls.Add(this.tab3Image);
            this.ModeTabControl.Controls.Add(this.tab4Audio);
            this.ModeTabControl.Location = new System.Drawing.Point(3, 3);
            this.ModeTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.ModeTabControl.Name = "ModeTabControl";
            this.ModeTabControl.Padding = new System.Drawing.Point(3, 3);
            this.ModeTabControl.SelectedIndex = 0;
            this.ModeTabControl.Size = new System.Drawing.Size(512, 649);
            this.ModeTabControl.TabIndex = 5;
            this.ModeTabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab1Settings
            // 
            this.tab1Settings.Controls.Add(this.groupBox8);
            this.tab1Settings.Controls.Add(this.groupBox5);
            this.tab1Settings.Location = new System.Drawing.Point(4, 22);
            this.tab1Settings.Name = "tab1Settings";
            this.tab1Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab1Settings.Size = new System.Drawing.Size(504, 623);
            this.tab1Settings.TabIndex = 0;
            this.tab1Settings.Text = "Settings";
            this.tab1Settings.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.groupBox2);
            this.groupBox8.Controls.Add(this.groupBox1);
            this.groupBox8.Location = new System.Drawing.Point(7, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(491, 188);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Setup";
            // 
            // showPreviewCheckBox
            // 
            this.showPreviewCheckBox.AutoSize = true;
            this.showPreviewCheckBox.Location = new System.Drawing.Point(8, 129);
            this.showPreviewCheckBox.Name = "showPreviewCheckBox";
            this.showPreviewCheckBox.Size = new System.Drawing.Size(94, 17);
            this.showPreviewCheckBox.TabIndex = 8;
            this.showPreviewCheckBox.Text = "Show Preivew";
            this.showPreviewCheckBox.UseVisualStyleBackColor = true;
            this.showPreviewCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.AutoSize = true;
            this.groupBox9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox9.Controls.Add(this.loadPixelOrder);
            this.groupBox9.Controls.Add(this.resetPixelOrder);
            this.groupBox9.Controls.Add(this.savePixelOrder);
            this.groupBox9.Controls.Add(this.editPixelOrder);
            this.groupBox9.Location = new System.Drawing.Point(279, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(87, 148);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "3. Pixel Order";
            // 
            // loadPixelOrder
            // 
            this.loadPixelOrder.Location = new System.Drawing.Point(6, 48);
            this.loadPixelOrder.Name = "loadPixelOrder";
            this.loadPixelOrder.Size = new System.Drawing.Size(75, 23);
            this.loadPixelOrder.TabIndex = 3;
            this.loadPixelOrder.Text = "Load";
            this.loadPixelOrder.UseVisualStyleBackColor = true;
            this.loadPixelOrder.Click += new System.EventHandler(this.loadPixelOrder_Click);
            // 
            // resetPixelOrder
            // 
            this.resetPixelOrder.Enabled = false;
            this.resetPixelOrder.Location = new System.Drawing.Point(6, 106);
            this.resetPixelOrder.Name = "resetPixelOrder";
            this.resetPixelOrder.Size = new System.Drawing.Size(75, 23);
            this.resetPixelOrder.TabIndex = 2;
            this.resetPixelOrder.Text = "Reset";
            this.resetPixelOrder.UseVisualStyleBackColor = true;
            this.resetPixelOrder.Click += new System.EventHandler(this.resetPixelOrder_Click);
            // 
            // savePixelOrder
            // 
            this.savePixelOrder.Enabled = false;
            this.savePixelOrder.Location = new System.Drawing.Point(6, 77);
            this.savePixelOrder.Name = "savePixelOrder";
            this.savePixelOrder.Size = new System.Drawing.Size(75, 23);
            this.savePixelOrder.TabIndex = 1;
            this.savePixelOrder.Text = "Save";
            this.savePixelOrder.UseVisualStyleBackColor = true;
            this.savePixelOrder.Click += new System.EventHandler(this.savePixelOrder_Click);
            // 
            // editPixelOrder
            // 
            this.editPixelOrder.Location = new System.Drawing.Point(6, 19);
            this.editPixelOrder.Name = "editPixelOrder";
            this.editPixelOrder.Size = new System.Drawing.Size(75, 23);
            this.editPixelOrder.TabIndex = 0;
            this.editPixelOrder.Text = "Create New";
            this.editPixelOrder.UseVisualStyleBackColor = true;
            this.editPixelOrder.Click += new System.EventHandler(this.editPixelOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.pixlsYUpDown);
            this.groupBox2.Controls.Add(this.pixlsXUpDown);
            this.groupBox2.Controls.Add(this.buildBoxes);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 117);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1. Matrix Dimensions";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Height";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Width";
            // 
            // pixlsYUpDown
            // 
            this.pixlsYUpDown.Location = new System.Drawing.Point(56, 45);
            this.pixlsYUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.pixlsYUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.pixlsYUpDown.Name = "pixlsYUpDown";
            this.pixlsYUpDown.Size = new System.Drawing.Size(59, 20);
            this.pixlsYUpDown.TabIndex = 5;
            this.pixlsYUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // pixlsXUpDown
            // 
            this.pixlsXUpDown.Location = new System.Drawing.Point(56, 19);
            this.pixlsXUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.pixlsXUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.pixlsXUpDown.Name = "pixlsXUpDown";
            this.pixlsXUpDown.Size = new System.Drawing.Size(59, 20);
            this.pixlsXUpDown.TabIndex = 4;
            this.pixlsXUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buildBoxes
            // 
            this.buildBoxes.Location = new System.Drawing.Point(6, 75);
            this.buildBoxes.Name = "buildBoxes";
            this.buildBoxes.Size = new System.Drawing.Size(109, 23);
            this.buildBoxes.TabIndex = 3;
            this.buildBoxes.Text = "Set Dimensions";
            this.buildBoxes.UseVisualStyleBackColor = true;
            this.buildBoxes.Click += new System.EventHandler(this.buildBoxes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.refreshCOMPorts);
            this.groupBox1.Controls.Add(this.disconnectFromCOMPort);
            this.groupBox1.Controls.Add(this.portsList);
            this.groupBox1.Controls.Add(this.connectToCOMPort);
            this.groupBox1.Location = new System.Drawing.Point(133, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 146);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. Serial Connection";
            // 
            // refreshCOMPorts
            // 
            this.refreshCOMPorts.Location = new System.Drawing.Point(6, 104);
            this.refreshCOMPorts.Name = "refreshCOMPorts";
            this.refreshCOMPorts.Size = new System.Drawing.Size(128, 23);
            this.refreshCOMPorts.TabIndex = 6;
            this.refreshCOMPorts.Text = "Refresh";
            this.refreshCOMPorts.UseVisualStyleBackColor = true;
            this.refreshCOMPorts.Click += new System.EventHandler(this.refreshCOMPorts_Click);
            // 
            // disconnectFromCOMPort
            // 
            this.disconnectFromCOMPort.Location = new System.Drawing.Point(6, 75);
            this.disconnectFromCOMPort.Name = "disconnectFromCOMPort";
            this.disconnectFromCOMPort.Size = new System.Drawing.Size(128, 23);
            this.disconnectFromCOMPort.TabIndex = 5;
            this.disconnectFromCOMPort.Text = "Disconnect";
            this.disconnectFromCOMPort.UseVisualStyleBackColor = true;
            this.disconnectFromCOMPort.Click += new System.EventHandler(this.disconnectFromCOMPort_Click);
            // 
            // portsList
            // 
            this.portsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portsList.FormattingEnabled = true;
            this.portsList.Location = new System.Drawing.Point(6, 19);
            this.portsList.Name = "portsList";
            this.portsList.Size = new System.Drawing.Size(128, 21);
            this.portsList.TabIndex = 4;
            this.portsList.SelectedIndexChanged += new System.EventHandler(this.disconnectFromCOMPort_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.brightnessUD);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.blueWB);
            this.groupBox5.Controls.Add(this.greenWB);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.redWB);
            this.groupBox5.Location = new System.Drawing.Point(7, 201);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(127, 136);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Color Adjustment";
            // 
            // brightnessUD
            // 
            this.brightnessUD.Location = new System.Drawing.Point(68, 97);
            this.brightnessUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.brightnessUD.Name = "brightnessUD";
            this.brightnessUD.Size = new System.Drawing.Size(53, 20);
            this.brightnessUD.TabIndex = 8;
            this.brightnessUD.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.brightnessUD.ValueChanged += new System.EventHandler(this.brightnessUD_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Brightness";
            // 
            // blueWB
            // 
            this.blueWB.Location = new System.Drawing.Point(68, 71);
            this.blueWB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueWB.Name = "blueWB";
            this.blueWB.Size = new System.Drawing.Size(53, 20);
            this.blueWB.TabIndex = 5;
            this.blueWB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueWB.ValueChanged += new System.EventHandler(this.WBValueChanged);
            // 
            // greenWB
            // 
            this.greenWB.Location = new System.Drawing.Point(68, 45);
            this.greenWB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenWB.Name = "greenWB";
            this.greenWB.Size = new System.Drawing.Size(53, 20);
            this.greenWB.TabIndex = 4;
            this.greenWB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenWB.ValueChanged += new System.EventHandler(this.WBValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Blue";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Green";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Red";
            // 
            // redWB
            // 
            this.redWB.Location = new System.Drawing.Point(68, 19);
            this.redWB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redWB.Name = "redWB";
            this.redWB.Size = new System.Drawing.Size(53, 20);
            this.redWB.TabIndex = 0;
            this.redWB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redWB.ValueChanged += new System.EventHandler(this.WBValueChanged);
            // 
            // tab2Draw
            // 
            this.tab2Draw.Controls.Add(this.groupBox10);
            this.tab2Draw.Location = new System.Drawing.Point(4, 22);
            this.tab2Draw.Name = "tab2Draw";
            this.tab2Draw.Padding = new System.Windows.Forms.Padding(3);
            this.tab2Draw.Size = new System.Drawing.Size(504, 623);
            this.tab2Draw.TabIndex = 1;
            this.tab2Draw.Text = "Drawing";
            this.tab2Draw.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.AutoSize = true;
            this.groupBox10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox10.Controls.Add(this.panel2);
            this.groupBox10.Controls.Add(this.clearButton1);
            this.groupBox10.Controls.Add(this.panel1);
            this.groupBox10.Location = new System.Drawing.Point(7, 7);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(374, 152);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Pen Settings";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.color2Button);
            this.panel2.Controls.Add(this.color1Button);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 78);
            this.panel2.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(49, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 30);
            this.label12.TabIndex = 41;
            this.label12.Text = "Color\r\n2\r\n";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // color2Button
            // 
            this.color2Button.BackColor = System.Drawing.Color.Black;
            this.color2Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.color2Button.Location = new System.Drawing.Point(49, 3);
            this.color2Button.Name = "color2Button";
            this.color2Button.Padding = new System.Windows.Forms.Padding(3);
            this.color2Button.Size = new System.Drawing.Size(40, 40);
            this.color2Button.TabIndex = 40;
            this.color2Button.UseVisualStyleBackColor = false;
            this.color2Button.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // color1Button
            // 
            this.color1Button.BackColor = System.Drawing.Color.White;
            this.color1Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.color1Button.Location = new System.Drawing.Point(3, 3);
            this.color1Button.Name = "color1Button";
            this.color1Button.Padding = new System.Windows.Forms.Padding(3);
            this.color1Button.Size = new System.Drawing.Size(40, 40);
            this.color1Button.TabIndex = 39;
            this.color1Button.UseVisualStyleBackColor = false;
            this.color1Button.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color\r\n1\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.ccb10);
            this.panel1.Controls.Add(this.ccb9);
            this.panel1.Controls.Add(this.ccb8);
            this.panel1.Controls.Add(this.cb6);
            this.panel1.Controls.Add(this.ccb7);
            this.panel1.Controls.Add(this.ccb6);
            this.panel1.Controls.Add(this.ccb5);
            this.panel1.Controls.Add(this.ccb4);
            this.panel1.Controls.Add(this.ccb3);
            this.panel1.Controls.Add(this.ccb2);
            this.panel1.Controls.Add(this.ccb1);
            this.panel1.Controls.Add(this.cb20);
            this.panel1.Controls.Add(this.cb19);
            this.panel1.Controls.Add(this.cb18);
            this.panel1.Controls.Add(this.cb17);
            this.panel1.Controls.Add(this.cb16);
            this.panel1.Controls.Add(this.cb15);
            this.panel1.Controls.Add(this.cb14);
            this.panel1.Controls.Add(this.cb13);
            this.panel1.Controls.Add(this.cb12);
            this.panel1.Controls.Add(this.cb11);
            this.panel1.Controls.Add(this.cb10);
            this.panel1.Controls.Add(this.cb9);
            this.panel1.Controls.Add(this.cb8);
            this.panel1.Controls.Add(this.cb7);
            this.panel1.Controls.Add(this.cb5);
            this.panel1.Controls.Add(this.cb4);
            this.panel1.Controls.Add(this.cb3);
            this.panel1.Controls.Add(this.cb2);
            this.panel1.Controls.Add(this.cb1);
            this.panel1.Location = new System.Drawing.Point(115, 17);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(253, 78);
            this.panel1.TabIndex = 9;
            // 
            // ccb10
            // 
            this.ccb10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccb10.Location = new System.Drawing.Point(228, 53);
            this.ccb10.Margin = new System.Windows.Forms.Padding(1);
            this.ccb10.Name = "ccb10";
            this.ccb10.Size = new System.Drawing.Size(23, 23);
            this.ccb10.TabIndex = 37;
            this.ccb10.UseVisualStyleBackColor = true;
            this.ccb10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // ccb9
            // 
            this.ccb9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccb9.Location = new System.Drawing.Point(203, 53);
            this.ccb9.Margin = new System.Windows.Forms.Padding(1);
            this.ccb9.Name = "ccb9";
            this.ccb9.Size = new System.Drawing.Size(23, 23);
            this.ccb9.TabIndex = 36;
            this.ccb9.UseVisualStyleBackColor = true;
            this.ccb9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // ccb8
            // 
            this.ccb8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccb8.Location = new System.Drawing.Point(178, 53);
            this.ccb8.Margin = new System.Windows.Forms.Padding(1);
            this.ccb8.Name = "ccb8";
            this.ccb8.Size = new System.Drawing.Size(23, 23);
            this.ccb8.TabIndex = 35;
            this.ccb8.UseVisualStyleBackColor = true;
            this.ccb8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb6
            // 
            this.cb6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.cb6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb6.Location = new System.Drawing.Point(128, 3);
            this.cb6.Margin = new System.Windows.Forms.Padding(1);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(23, 23);
            this.cb6.TabIndex = 15;
            this.cb6.UseVisualStyleBackColor = false;
            this.cb6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // ccb7
            // 
            this.ccb7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccb7.Location = new System.Drawing.Point(153, 53);
            this.ccb7.Margin = new System.Windows.Forms.Padding(1);
            this.ccb7.Name = "ccb7";
            this.ccb7.Size = new System.Drawing.Size(23, 23);
            this.ccb7.TabIndex = 34;
            this.ccb7.UseVisualStyleBackColor = true;
            this.ccb7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // ccb6
            // 
            this.ccb6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccb6.Location = new System.Drawing.Point(128, 53);
            this.ccb6.Margin = new System.Windows.Forms.Padding(1);
            this.ccb6.Name = "ccb6";
            this.ccb6.Size = new System.Drawing.Size(23, 23);
            this.ccb6.TabIndex = 33;
            this.ccb6.UseVisualStyleBackColor = true;
            this.ccb6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // ccb5
            // 
            this.ccb5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccb5.Location = new System.Drawing.Point(103, 53);
            this.ccb5.Margin = new System.Windows.Forms.Padding(1);
            this.ccb5.Name = "ccb5";
            this.ccb5.Size = new System.Drawing.Size(23, 23);
            this.ccb5.TabIndex = 32;
            this.ccb5.UseVisualStyleBackColor = true;
            this.ccb5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // ccb4
            // 
            this.ccb4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccb4.Location = new System.Drawing.Point(78, 53);
            this.ccb4.Margin = new System.Windows.Forms.Padding(1);
            this.ccb4.Name = "ccb4";
            this.ccb4.Size = new System.Drawing.Size(23, 23);
            this.ccb4.TabIndex = 31;
            this.ccb4.UseVisualStyleBackColor = true;
            this.ccb4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // ccb3
            // 
            this.ccb3.BackColor = System.Drawing.Color.Transparent;
            this.ccb3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccb3.Location = new System.Drawing.Point(53, 53);
            this.ccb3.Margin = new System.Windows.Forms.Padding(1);
            this.ccb3.Name = "ccb3";
            this.ccb3.Size = new System.Drawing.Size(23, 23);
            this.ccb3.TabIndex = 30;
            this.ccb3.UseVisualStyleBackColor = false;
            this.ccb3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // ccb2
            // 
            this.ccb2.BackColor = System.Drawing.Color.Transparent;
            this.ccb2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccb2.Location = new System.Drawing.Point(28, 53);
            this.ccb2.Margin = new System.Windows.Forms.Padding(1);
            this.ccb2.Name = "ccb2";
            this.ccb2.Size = new System.Drawing.Size(23, 23);
            this.ccb2.TabIndex = 29;
            this.ccb2.UseVisualStyleBackColor = false;
            this.ccb2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // ccb1
            // 
            this.ccb1.BackColor = System.Drawing.Color.Transparent;
            this.ccb1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccb1.Location = new System.Drawing.Point(3, 53);
            this.ccb1.Margin = new System.Windows.Forms.Padding(1);
            this.ccb1.Name = "ccb1";
            this.ccb1.Size = new System.Drawing.Size(23, 23);
            this.ccb1.TabIndex = 28;
            this.ccb1.UseVisualStyleBackColor = false;
            this.ccb1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb20
            // 
            this.cb20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.cb20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb20.Location = new System.Drawing.Point(228, 28);
            this.cb20.Margin = new System.Windows.Forms.Padding(1);
            this.cb20.Name = "cb20";
            this.cb20.Size = new System.Drawing.Size(23, 23);
            this.cb20.TabIndex = 27;
            this.cb20.UseVisualStyleBackColor = false;
            this.cb20.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb19
            // 
            this.cb19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.cb19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb19.Location = new System.Drawing.Point(203, 28);
            this.cb19.Margin = new System.Windows.Forms.Padding(1);
            this.cb19.Name = "cb19";
            this.cb19.Size = new System.Drawing.Size(23, 23);
            this.cb19.TabIndex = 26;
            this.cb19.UseVisualStyleBackColor = false;
            this.cb19.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb18
            // 
            this.cb18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.cb18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb18.Location = new System.Drawing.Point(178, 28);
            this.cb18.Margin = new System.Windows.Forms.Padding(1);
            this.cb18.Name = "cb18";
            this.cb18.Size = new System.Drawing.Size(23, 23);
            this.cb18.TabIndex = 25;
            this.cb18.UseVisualStyleBackColor = false;
            this.cb18.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb17
            // 
            this.cb17.BackColor = System.Drawing.Color.YellowGreen;
            this.cb17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb17.Location = new System.Drawing.Point(153, 28);
            this.cb17.Margin = new System.Windows.Forms.Padding(1);
            this.cb17.Name = "cb17";
            this.cb17.Size = new System.Drawing.Size(23, 23);
            this.cb17.TabIndex = 24;
            this.cb17.UseVisualStyleBackColor = false;
            this.cb17.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb16
            // 
            this.cb16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(228)))), ((int)(((byte)(176)))));
            this.cb16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb16.Location = new System.Drawing.Point(128, 28);
            this.cb16.Margin = new System.Windows.Forms.Padding(1);
            this.cb16.Name = "cb16";
            this.cb16.Size = new System.Drawing.Size(23, 23);
            this.cb16.TabIndex = 23;
            this.cb16.UseVisualStyleBackColor = false;
            this.cb16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb15
            // 
            this.cb15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(14)))));
            this.cb15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb15.Location = new System.Drawing.Point(103, 28);
            this.cb15.Margin = new System.Windows.Forms.Padding(1);
            this.cb15.Name = "cb15";
            this.cb15.Size = new System.Drawing.Size(23, 23);
            this.cb15.TabIndex = 22;
            this.cb15.UseVisualStyleBackColor = false;
            this.cb15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb14
            // 
            this.cb14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(201)))));
            this.cb14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb14.Location = new System.Drawing.Point(78, 28);
            this.cb14.Margin = new System.Windows.Forms.Padding(1);
            this.cb14.Name = "cb14";
            this.cb14.Size = new System.Drawing.Size(23, 23);
            this.cb14.TabIndex = 21;
            this.cb14.UseVisualStyleBackColor = false;
            this.cb14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb13
            // 
            this.cb13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(122)))), ((int)(((byte)(87)))));
            this.cb13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb13.Location = new System.Drawing.Point(53, 28);
            this.cb13.Margin = new System.Windows.Forms.Padding(1);
            this.cb13.Name = "cb13";
            this.cb13.Size = new System.Drawing.Size(23, 23);
            this.cb13.TabIndex = 20;
            this.cb13.UseVisualStyleBackColor = false;
            this.cb13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb12
            // 
            this.cb12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.cb12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb12.Location = new System.Drawing.Point(28, 28);
            this.cb12.Margin = new System.Windows.Forms.Padding(1);
            this.cb12.Name = "cb12";
            this.cb12.Size = new System.Drawing.Size(23, 23);
            this.cb12.TabIndex = 19;
            this.cb12.UseVisualStyleBackColor = false;
            this.cb12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb11
            // 
            this.cb11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb11.Location = new System.Drawing.Point(3, 28);
            this.cb11.Margin = new System.Windows.Forms.Padding(1);
            this.cb11.Name = "cb11";
            this.cb11.Size = new System.Drawing.Size(23, 23);
            this.cb11.TabIndex = 18;
            this.cb11.UseVisualStyleBackColor = true;
            this.cb11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb10
            // 
            this.cb10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.cb10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb10.Location = new System.Drawing.Point(228, 3);
            this.cb10.Margin = new System.Windows.Forms.Padding(1);
            this.cb10.Name = "cb10";
            this.cb10.Size = new System.Drawing.Size(23, 23);
            this.cb10.TabIndex = 17;
            this.cb10.UseVisualStyleBackColor = false;
            this.cb10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb9
            // 
            this.cb9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.cb9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb9.Location = new System.Drawing.Point(203, 3);
            this.cb9.Margin = new System.Windows.Forms.Padding(1);
            this.cb9.Name = "cb9";
            this.cb9.Size = new System.Drawing.Size(23, 23);
            this.cb9.TabIndex = 16;
            this.cb9.UseVisualStyleBackColor = false;
            this.cb9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb8
            // 
            this.cb8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.cb8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb8.Location = new System.Drawing.Point(178, 3);
            this.cb8.Margin = new System.Windows.Forms.Padding(1);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(23, 23);
            this.cb8.TabIndex = 14;
            this.cb8.UseVisualStyleBackColor = false;
            this.cb8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb7
            // 
            this.cb7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.cb7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb7.Location = new System.Drawing.Point(153, 3);
            this.cb7.Margin = new System.Windows.Forms.Padding(1);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(23, 23);
            this.cb7.TabIndex = 13;
            this.cb7.UseVisualStyleBackColor = false;
            this.cb7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb5
            // 
            this.cb5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(39)))));
            this.cb5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb5.Location = new System.Drawing.Point(103, 3);
            this.cb5.Margin = new System.Windows.Forms.Padding(1);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(23, 23);
            this.cb5.TabIndex = 12;
            this.cb5.UseVisualStyleBackColor = false;
            this.cb5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb4
            // 
            this.cb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.cb4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb4.Location = new System.Drawing.Point(78, 3);
            this.cb4.Margin = new System.Windows.Forms.Padding(1);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(23, 23);
            this.cb4.TabIndex = 11;
            this.cb4.UseVisualStyleBackColor = false;
            this.cb4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb3
            // 
            this.cb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.cb3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb3.Location = new System.Drawing.Point(53, 3);
            this.cb3.Margin = new System.Windows.Forms.Padding(1);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(23, 23);
            this.cb3.TabIndex = 10;
            this.cb3.UseVisualStyleBackColor = false;
            this.cb3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb2
            // 
            this.cb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.cb2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb2.Location = new System.Drawing.Point(28, 3);
            this.cb2.Margin = new System.Windows.Forms.Padding(1);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(23, 23);
            this.cb2.TabIndex = 9;
            this.cb2.UseVisualStyleBackColor = false;
            this.cb2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // cb1
            // 
            this.cb1.BackColor = System.Drawing.Color.Black;
            this.cb1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb1.Location = new System.Drawing.Point(3, 3);
            this.cb1.Margin = new System.Windows.Forms.Padding(1);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(23, 23);
            this.cb1.TabIndex = 8;
            this.cb1.UseVisualStyleBackColor = false;
            this.cb1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPaletteUp);
            // 
            // clearButton1
            // 
            this.clearButton1.Location = new System.Drawing.Point(6, 110);
            this.clearButton1.Name = "clearButton1";
            this.clearButton1.Size = new System.Drawing.Size(75, 23);
            this.clearButton1.TabIndex = 7;
            this.clearButton1.Text = "Clear Frame";
            this.clearButton1.UseVisualStyleBackColor = true;
            this.clearButton1.Click += new System.EventHandler(this.clearFrame_Click);
            // 
            // tab3Image
            // 
            this.tab3Image.Controls.Add(this.showPreviewCheckBox);
            this.tab3Image.Controls.Add(this.groupBox7);
            this.tab3Image.Controls.Add(this.groupBox6);
            this.tab3Image.Controls.Add(this.animationGroup);
            this.tab3Image.Controls.Add(this.scaleSettingGroup);
            this.tab3Image.Controls.Add(this.groupBox4);
            this.tab3Image.Controls.Add(this.groupBox3);
            this.tab3Image.Location = new System.Drawing.Point(4, 22);
            this.tab3Image.Name = "tab3Image";
            this.tab3Image.Size = new System.Drawing.Size(504, 623);
            this.tab3Image.TabIndex = 2;
            this.tab3Image.Text = "Imaging";
            this.tab3Image.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSize = true;
            this.groupBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox7.Controls.Add(this.InterpolationModeDropDown1);
            this.groupBox7.Location = new System.Drawing.Point(3, 70);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(122, 56);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Interpolation Mode";
            // 
            // InterpolationModeDropDown1
            // 
            this.InterpolationModeDropDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InterpolationModeDropDown1.FormattingEnabled = true;
            this.InterpolationModeDropDown1.ItemHeight = 13;
            this.InterpolationModeDropDown1.Items.AddRange(new object[] {
            "Nearest Neighbor",
            "Low",
            "Medium",
            "High"});
            this.InterpolationModeDropDown1.Location = new System.Drawing.Point(6, 16);
            this.InterpolationModeDropDown1.MaximumSize = new System.Drawing.Size(400, 0);
            this.InterpolationModeDropDown1.Name = "InterpolationModeDropDown1";
            this.InterpolationModeDropDown1.Size = new System.Drawing.Size(110, 21);
            this.InterpolationModeDropDown1.TabIndex = 2;
            this.InterpolationModeDropDown1.SelectedIndexChanged += new System.EventHandler(this.InterpolationModeDropDown1_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox6.Controls.Add(this.stopScreenCap);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.screenSelection);
            this.groupBox6.Controls.Add(this.startScreenCap);
            this.groupBox6.Location = new System.Drawing.Point(355, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(140, 117);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Screen Capture";
            // 
            // stopScreenCap
            // 
            this.stopScreenCap.Location = new System.Drawing.Point(6, 48);
            this.stopScreenCap.Name = "stopScreenCap";
            this.stopScreenCap.Size = new System.Drawing.Size(128, 23);
            this.stopScreenCap.TabIndex = 9;
            this.stopScreenCap.Text = "Stop Capture";
            this.stopScreenCap.UseVisualStyleBackColor = true;
            this.stopScreenCap.Click += new System.EventHandler(this.stopScreenCap_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Source";
            // 
            // screenSelection
            // 
            this.screenSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screenSelection.FormattingEnabled = true;
            this.screenSelection.ItemHeight = 13;
            this.screenSelection.Location = new System.Drawing.Point(53, 77);
            this.screenSelection.MaximumSize = new System.Drawing.Size(400, 0);
            this.screenSelection.Name = "screenSelection";
            this.screenSelection.Size = new System.Drawing.Size(81, 21);
            this.screenSelection.TabIndex = 8;
            // 
            // startScreenCap
            // 
            this.startScreenCap.Location = new System.Drawing.Point(6, 19);
            this.startScreenCap.Name = "startScreenCap";
            this.startScreenCap.Size = new System.Drawing.Size(128, 23);
            this.startScreenCap.TabIndex = 0;
            this.startScreenCap.Text = "Start Capture";
            this.startScreenCap.UseVisualStyleBackColor = true;
            this.startScreenCap.Click += new System.EventHandler(this.startScreenCap_Click);
            // 
            // animationGroup
            // 
            this.animationGroup.AutoSize = true;
            this.animationGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.animationGroup.Controls.Add(this.label7);
            this.animationGroup.Controls.Add(this.numericUpDown1);
            this.animationGroup.Controls.Add(this.animationPlayMode);
            this.animationGroup.Controls.Add(this.stopAnimation);
            this.animationGroup.Controls.Add(this.startAnimation);
            this.animationGroup.Controls.Add(this.label6);
            this.animationGroup.Enabled = false;
            this.animationGroup.Location = new System.Drawing.Point(131, 3);
            this.animationGroup.Name = "animationGroup";
            this.animationGroup.Size = new System.Drawing.Size(218, 88);
            this.animationGroup.TabIndex = 9;
            this.animationGroup.TabStop = false;
            this.animationGroup.Text = "Animation Controls";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mode";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(145, 48);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // animationPlayMode
            // 
            this.animationPlayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animationPlayMode.FormattingEnabled = true;
            this.animationPlayMode.Items.AddRange(new object[] {
            "Loop",
            "Bounce",
            "Reverse"});
            this.animationPlayMode.Location = new System.Drawing.Point(46, 48);
            this.animationPlayMode.Name = "animationPlayMode";
            this.animationPlayMode.Size = new System.Drawing.Size(60, 21);
            this.animationPlayMode.TabIndex = 4;
            this.animationPlayMode.SelectedIndexChanged += new System.EventHandler(this.animationPlayMode_SelectedIndexChanged);
            // 
            // stopAnimation
            // 
            this.stopAnimation.Location = new System.Drawing.Point(112, 19);
            this.stopAnimation.Name = "stopAnimation";
            this.stopAnimation.Size = new System.Drawing.Size(100, 23);
            this.stopAnimation.TabIndex = 2;
            this.stopAnimation.Text = "Stop";
            this.stopAnimation.UseVisualStyleBackColor = true;
            this.stopAnimation.Click += new System.EventHandler(this.stopAnimation_Click);
            // 
            // startAnimation
            // 
            this.startAnimation.Location = new System.Drawing.Point(6, 19);
            this.startAnimation.Name = "startAnimation";
            this.startAnimation.Size = new System.Drawing.Size(100, 23);
            this.startAnimation.TabIndex = 1;
            this.startAnimation.Text = "Start";
            this.startAnimation.UseVisualStyleBackColor = true;
            this.startAnimation.Click += new System.EventHandler(this.startAnimation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "FPS";
            // 
            // scaleSettingGroup
            // 
            this.scaleSettingGroup.AutoSize = true;
            this.scaleSettingGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scaleSettingGroup.Controls.Add(this.croppedAreaHLabel);
            this.scaleSettingGroup.Controls.Add(this.croppedAreaWLabel);
            this.scaleSettingGroup.Controls.Add(this.lockSizeToggle);
            this.scaleSettingGroup.Controls.Add(this.scaleEndYUD);
            this.scaleSettingGroup.Controls.Add(this.scaleEndXUD);
            this.scaleSettingGroup.Controls.Add(this.scaleStartYUD);
            this.scaleSettingGroup.Controls.Add(this.scaleStartXUD);
            this.scaleSettingGroup.Controls.Add(this.setScaleButton);
            this.scaleSettingGroup.Controls.Add(this.scaleEndY);
            this.scaleSettingGroup.Controls.Add(this.scaleEndX);
            this.scaleSettingGroup.Controls.Add(this.scaleStartY);
            this.scaleSettingGroup.Controls.Add(this.scaleStartX);
            this.scaleSettingGroup.Controls.Add(this.resetScaleButton);
            this.scaleSettingGroup.Controls.Add(this.label5);
            this.scaleSettingGroup.Controls.Add(this.label4);
            this.scaleSettingGroup.Controls.Add(this.label3);
            this.scaleSettingGroup.Controls.Add(this.label2);
            this.scaleSettingGroup.Enabled = false;
            this.scaleSettingGroup.Location = new System.Drawing.Point(4, 152);
            this.scaleSettingGroup.Name = "scaleSettingGroup";
            this.scaleSettingGroup.Size = new System.Drawing.Size(491, 137);
            this.scaleSettingGroup.TabIndex = 8;
            this.scaleSettingGroup.TabStop = false;
            this.scaleSettingGroup.Text = "Scale Settings";
            // 
            // croppedAreaHLabel
            // 
            this.croppedAreaHLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.croppedAreaHLabel.AutoSize = true;
            this.croppedAreaHLabel.Location = new System.Drawing.Point(405, 105);
            this.croppedAreaHLabel.Name = "croppedAreaHLabel";
            this.croppedAreaHLabel.Size = new System.Drawing.Size(44, 13);
            this.croppedAreaHLabel.TabIndex = 25;
            this.croppedAreaHLabel.Text = "Height: ";
            // 
            // croppedAreaWLabel
            // 
            this.croppedAreaWLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.croppedAreaWLabel.AutoSize = true;
            this.croppedAreaWLabel.Location = new System.Drawing.Point(408, 92);
            this.croppedAreaWLabel.Name = "croppedAreaWLabel";
            this.croppedAreaWLabel.Size = new System.Drawing.Size(41, 13);
            this.croppedAreaWLabel.TabIndex = 24;
            this.croppedAreaWLabel.Text = "Width: ";
            // 
            // lockSizeToggle
            // 
            this.lockSizeToggle.AutoSize = true;
            this.lockSizeToggle.Location = new System.Drawing.Point(412, 73);
            this.lockSizeToggle.Name = "lockSizeToggle";
            this.lockSizeToggle.Size = new System.Drawing.Size(73, 17);
            this.lockSizeToggle.TabIndex = 22;
            this.lockSizeToggle.Text = "Lock Size";
            this.lockSizeToggle.UseVisualStyleBackColor = true;
            this.lockSizeToggle.CheckedChanged += new System.EventHandler(this.lockSizeToggle_CheckedChanged);
            // 
            // scaleEndYUD
            // 
            this.scaleEndYUD.Location = new System.Drawing.Point(346, 97);
            this.scaleEndYUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.scaleEndYUD.Name = "scaleEndYUD";
            this.scaleEndYUD.Size = new System.Drawing.Size(59, 20);
            this.scaleEndYUD.TabIndex = 21;
            this.scaleEndYUD.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // scaleEndXUD
            // 
            this.scaleEndXUD.Location = new System.Drawing.Point(346, 71);
            this.scaleEndXUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.scaleEndXUD.Name = "scaleEndXUD";
            this.scaleEndXUD.Size = new System.Drawing.Size(59, 20);
            this.scaleEndXUD.TabIndex = 20;
            this.scaleEndXUD.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // scaleStartYUD
            // 
            this.scaleStartYUD.Location = new System.Drawing.Point(346, 45);
            this.scaleStartYUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.scaleStartYUD.Name = "scaleStartYUD";
            this.scaleStartYUD.Size = new System.Drawing.Size(59, 20);
            this.scaleStartYUD.TabIndex = 19;
            this.scaleStartYUD.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // scaleStartXUD
            // 
            this.scaleStartXUD.Location = new System.Drawing.Point(346, 19);
            this.scaleStartXUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.scaleStartXUD.Name = "scaleStartXUD";
            this.scaleStartXUD.Size = new System.Drawing.Size(59, 20);
            this.scaleStartXUD.TabIndex = 18;
            this.scaleStartXUD.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // setScaleButton
            // 
            this.setScaleButton.Location = new System.Drawing.Point(411, 17);
            this.setScaleButton.Name = "setScaleButton";
            this.setScaleButton.Size = new System.Drawing.Size(74, 23);
            this.setScaleButton.TabIndex = 17;
            this.setScaleButton.Text = "Set";
            this.setScaleButton.UseVisualStyleBackColor = true;
            this.setScaleButton.Click += new System.EventHandler(this.ChooseRefreshEvent);
            // 
            // scaleEndY
            // 
            this.scaleEndY.AutoSize = false;
            this.scaleEndY.LargeChange = 8;
            this.scaleEndY.Location = new System.Drawing.Point(53, 98);
            this.scaleEndY.Maximum = 100000;
            this.scaleEndY.Name = "scaleEndY";
            this.scaleEndY.Size = new System.Drawing.Size(288, 20);
            this.scaleEndY.TabIndex = 12;
            this.scaleEndY.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // scaleEndX
            // 
            this.scaleEndX.AutoSize = false;
            this.scaleEndX.LargeChange = 8;
            this.scaleEndX.Location = new System.Drawing.Point(53, 72);
            this.scaleEndX.Maximum = 100000;
            this.scaleEndX.Name = "scaleEndX";
            this.scaleEndX.Size = new System.Drawing.Size(288, 20);
            this.scaleEndX.TabIndex = 11;
            this.scaleEndX.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // scaleStartY
            // 
            this.scaleStartY.AutoSize = false;
            this.scaleStartY.LargeChange = 8;
            this.scaleStartY.Location = new System.Drawing.Point(53, 45);
            this.scaleStartY.Maximum = 100000;
            this.scaleStartY.Name = "scaleStartY";
            this.scaleStartY.Size = new System.Drawing.Size(288, 20);
            this.scaleStartY.TabIndex = 10;
            this.scaleStartY.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // scaleStartX
            // 
            this.scaleStartX.AutoSize = false;
            this.scaleStartX.LargeChange = 8;
            this.scaleStartX.Location = new System.Drawing.Point(53, 19);
            this.scaleStartX.Maximum = 100000;
            this.scaleStartX.Name = "scaleStartX";
            this.scaleStartX.Size = new System.Drawing.Size(288, 20);
            this.scaleStartX.TabIndex = 9;
            this.scaleStartX.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // resetScaleButton
            // 
            this.resetScaleButton.Location = new System.Drawing.Point(411, 45);
            this.resetScaleButton.Name = "resetScaleButton";
            this.resetScaleButton.Size = new System.Drawing.Size(74, 23);
            this.resetScaleButton.TabIndex = 8;
            this.resetScaleButton.Text = "Reset";
            this.resetScaleButton.UseVisualStyleBackColor = true;
            this.resetScaleButton.Click += new System.EventHandler(this.resetScaleButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "End Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "End X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start X";
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.imagePictureBox);
            this.groupBox4.Location = new System.Drawing.Point(4, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(497, 338);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image Preview";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Location = new System.Drawing.Point(4, 19);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(489, 302);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 1;
            this.imagePictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.imageSelectButton);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 61);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Import Image/Gif";
            // 
            // imageSelectButton
            // 
            this.imageSelectButton.Location = new System.Drawing.Point(6, 19);
            this.imageSelectButton.Name = "imageSelectButton";
            this.imageSelectButton.Size = new System.Drawing.Size(110, 23);
            this.imageSelectButton.TabIndex = 0;
            this.imageSelectButton.Text = "Select Image / Gif";
            this.imageSelectButton.UseVisualStyleBackColor = true;
            this.imageSelectButton.Click += new System.EventHandler(this.stillImageSelectButton_Click);
            // 
            // tab4Audio
            // 
            this.tab4Audio.Location = new System.Drawing.Point(4, 22);
            this.tab4Audio.Name = "tab4Audio";
            this.tab4Audio.Size = new System.Drawing.Size(504, 623);
            this.tab4Audio.TabIndex = 3;
            this.tab4Audio.Text = "Audio";
            this.tab4Audio.UseVisualStyleBackColor = true;
            // 
            // OpenImageFile
            // 
            this.OpenImageFile.FileName = "openFileDialog1";
            this.OpenImageFile.Filter = "Image files (*.jpg,*.jpeg,*.png,*.bmp,*.gif) |*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // animTimer
            // 
            this.animTimer.Interval = 33;
            this.animTimer.Tick += new System.EventHandler(this.animTimer_Tick);
            // 
            // screenCapTimer
            // 
            this.screenCapTimer.Interval = 1;
            this.screenCapTimer.Tick += new System.EventHandler(this.screenCapTimer_Tick);
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = true;
            this.statusBar.Location = new System.Drawing.Point(6, 652);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(169, 13);
            this.statusBar.TabIndex = 6;
            this.statusBar.Text = "Connected on: COM 6,  FPS: 30,  ";
            // 
            // drawColorPicker
            // 
            this.drawColorPicker.Color = System.Drawing.Color.White;
            this.drawColorPicker.FullOpen = true;
            this.drawColorPicker.ShowHelp = true;
            this.drawColorPicker.SolidColorOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.ModeTabControl);
            this.Controls.Add(this.matrixContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "LED Matrix Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ModeTabControl.ResumeLayout(false);
            this.tab1Settings.ResumeLayout(false);
            this.tab1Settings.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixlsYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixlsXUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueWB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenWB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redWB)).EndInit();
            this.tab2Draw.ResumeLayout(false);
            this.tab2Draw.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tab3Image.ResumeLayout(false);
            this.tab3Image.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.animationGroup.ResumeLayout(false);
            this.animationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.scaleSettingGroup.ResumeLayout(false);
            this.scaleSettingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndYUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndXUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartYUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartXUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectToCOMPort;
        private System.Windows.Forms.TabControl ModeTabControl;
        private System.Windows.Forms.TabPage tab1Settings;
        private System.Windows.Forms.TabPage tab2Draw;
        private System.Windows.Forms.TabPage tab3Image;
        public System.Windows.Forms.Panel matrixContainer;
        private System.Windows.Forms.Button buildBoxes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button disconnectFromCOMPort;
        private System.Windows.Forms.ComboBox portsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown pixlsXUpDown;
        private System.Windows.Forms.NumericUpDown pixlsYUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button imageSelectButton;
        private System.Windows.Forms.OpenFileDialog OpenImageFile;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.ComboBox InterpolationModeDropDown1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button clearButton1;
        private System.Windows.Forms.GroupBox scaleSettingGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetScaleButton;
        private System.Windows.Forms.TrackBar scaleStartX;
        private System.Windows.Forms.TrackBar scaleEndY;
        private System.Windows.Forms.TrackBar scaleEndX;
        private System.Windows.Forms.TrackBar scaleStartY;
        private System.Windows.Forms.Button setScaleButton;
        private System.Windows.Forms.NumericUpDown scaleStartXUD;
        private System.Windows.Forms.NumericUpDown scaleEndYUD;
        private System.Windows.Forms.NumericUpDown scaleEndXUD;
        private System.Windows.Forms.NumericUpDown scaleStartYUD;
        private System.Windows.Forms.CheckBox lockSizeToggle;
        private System.Windows.Forms.Label croppedAreaWLabel;
        private System.Windows.Forms.Label croppedAreaHLabel;
        private System.Windows.Forms.GroupBox animationGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox animationPlayMode;
        private System.Windows.Forms.Button stopAnimation;
        private System.Windows.Forms.Button startAnimation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer animTimer;
        private System.Windows.Forms.Button refreshCOMPorts;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown blueWB;
        private System.Windows.Forms.NumericUpDown greenWB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown redWB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Timer screenCapTimer;
        private System.Windows.Forms.Button startScreenCap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox screenSelection;
        public System.Windows.Forms.Label statusBar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TabPage tab4Audio;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button editPixelOrder;
        private System.Windows.Forms.Button savePixelOrder;
        private System.Windows.Forms.Button resetPixelOrder;
        private System.Windows.Forms.Button stopScreenCap;
        private System.Windows.Forms.ColorDialog drawColorPicker;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown brightnessUD;
        private System.Windows.Forms.Button loadPixelOrder;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ccb10;
        private System.Windows.Forms.Button ccb9;
        private System.Windows.Forms.Button ccb8;
        private System.Windows.Forms.Button ccb7;
        private System.Windows.Forms.Button ccb6;
        private System.Windows.Forms.Button ccb5;
        private System.Windows.Forms.Button ccb4;
        private System.Windows.Forms.Button ccb3;
        private System.Windows.Forms.Button ccb2;
        private System.Windows.Forms.Button ccb1;
        private System.Windows.Forms.Button cb20;
        private System.Windows.Forms.Button cb19;
        private System.Windows.Forms.Button cb18;
        private System.Windows.Forms.Button cb17;
        private System.Windows.Forms.Button cb16;
        private System.Windows.Forms.Button cb15;
        private System.Windows.Forms.Button cb14;
        private System.Windows.Forms.Button cb13;
        private System.Windows.Forms.Button cb12;
        private System.Windows.Forms.Button cb11;
        private System.Windows.Forms.Button cb10;
        private System.Windows.Forms.Button cb9;
        private System.Windows.Forms.Button cb8;
        private System.Windows.Forms.Button cb7;
        private System.Windows.Forms.Button cb5;
        private System.Windows.Forms.Button cb4;
        private System.Windows.Forms.Button cb3;
        private System.Windows.Forms.Button cb2;
        private System.Windows.Forms.Button cb1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button color2Button;
        private System.Windows.Forms.Button color1Button;
        private System.Windows.Forms.Button cb6;
        private System.Windows.Forms.CheckBox showPreviewCheckBox;
    }
}

