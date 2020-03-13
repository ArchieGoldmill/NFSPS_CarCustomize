namespace CarCustomize
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.connectBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.CopyBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.PasteBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lockunlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SettingsBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.carLocationUpdateTimer = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.gameStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.currentCarName = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.BodyTab = new System.Windows.Forms.TabPage();
			this.ExhaustEditBtn = new System.Windows.Forms.Button();
			this.LicensePlate = new System.Windows.Forms.ComboBox();
			this.asdase1231 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.CarMode = new System.Windows.Forms.ComboBox();
			this.HoodEditBtn = new System.Windows.Forms.Button();
			this.SpoilerEditBtn = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.DoorFrontLeft = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.DoorFrontRight = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.DoorRearRight = new System.Windows.Forms.ComboBox();
			this.DoorRearLeft = new System.Windows.Forms.ComboBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.SeatLeft = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.SeatRight = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.FenderLeft = new System.Windows.Forms.ComboBox();
			this.labelfl = new System.Windows.Forms.Label();
			this.FenderRight = new System.Windows.Forms.ComboBox();
			this.labelfr = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.SkirtsEditBtn = new System.Windows.Forms.Button();
			this.SkirtLeft = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.SkirtRight = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BumperRearEditBtn = new System.Windows.Forms.Button();
			this.BumperFrontEditBtn = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.BumperFrontExtra = new System.Windows.Forms.ComboBox();
			this.BumperRearExtra = new System.Windows.Forms.ComboBox();
			this.BumperFront = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.BumperRear = new System.Windows.Forms.ComboBox();
			this.Exhaust = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.RollCage = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.Spoiler = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.Hood = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Body = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.StaticLivery = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.moveDecalsUp = new System.Windows.Forms.Button();
			this.moveDecalsDown = new System.Windows.Forms.Button();
			this.moveVinylsUp = new System.Windows.Forms.Button();
			this.moveVinylsDown = new System.Windows.Forms.Button();
			this.duplicateDecalBtn = new System.Windows.Forms.Button();
			this.addDecalBtn = new System.Windows.Forms.Button();
			this.deleteDecalBtn = new System.Windows.Forms.Button();
			this.deleteVinylBtn = new System.Windows.Forms.Button();
			this.addVinylBtn = new System.Windows.Forms.Button();
			this.duplicateVinylBtn = new System.Windows.Forms.Button();
			this.moveToDecalsBtn = new System.Windows.Forms.Button();
			this.moveToVinylsBtn = new System.Windows.Forms.Button();
			this.decalsGrid = new System.Windows.Forms.DataGridView();
			this.vinylsGrid = new System.Windows.Forms.DataGridView();
			this.label18 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.carDataModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.Engine = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.Drivetrain = new System.Windows.Forms.ComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.Turbo = new System.Windows.Forms.ComboBox();
			this.label23 = new System.Windows.Forms.Label();
			this.Suspension = new System.Windows.Forms.ComboBox();
			this.label24 = new System.Windows.Forms.Label();
			this.Brakes = new System.Windows.Forms.ComboBox();
			this.label25 = new System.Windows.Forms.Label();
			this.Nos = new System.Windows.Forms.ComboBox();
			this.label29 = new System.Windows.Forms.Label();
			this.Tires = new System.Windows.Forms.ComboBox();
			this.label30 = new System.Windows.Forms.Label();
			this.menuStrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.BodyTab.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.decalsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vinylsGrid)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.carDataModelBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectBtn,
            this.CopyBtn,
            this.PasteBtn,
            this.toolsToolStripMenuItem,
            this.SettingsBtn,
            this.AboutBtn});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip.Size = new System.Drawing.Size(559, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitBtn});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
			// 
			// ExitBtn
			// 
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(103, 22);
			this.ExitBtn.Text = "Exit";
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// connectBtn
			// 
			this.connectBtn.Name = "connectBtn";
			this.connectBtn.Size = new System.Drawing.Size(64, 20);
			this.connectBtn.Text = "Connect";
			this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
			// 
			// CopyBtn
			// 
			this.CopyBtn.Name = "CopyBtn";
			this.CopyBtn.Size = new System.Drawing.Size(53, 20);
			this.CopyBtn.Text = "  Copy";
			this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
			// 
			// PasteBtn
			// 
			this.PasteBtn.Enabled = false;
			this.PasteBtn.Name = "PasteBtn";
			this.PasteBtn.Size = new System.Drawing.Size(53, 20);
			this.PasteBtn.Text = "Paste  ";
			this.PasteBtn.Click += new System.EventHandler(this.PasteBtn_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockunlockToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// lockunlockToolStripMenuItem
			// 
			this.lockunlockToolStripMenuItem.Name = "lockunlockToolStripMenuItem";
			this.lockunlockToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.lockunlockToolStripMenuItem.Text = "Lock/unlock";
			this.lockunlockToolStripMenuItem.Click += new System.EventHandler(this.lockunlockToolStripMenuItem_Click);
			// 
			// SettingsBtn
			// 
			this.SettingsBtn.Name = "SettingsBtn";
			this.SettingsBtn.Size = new System.Drawing.Size(61, 20);
			this.SettingsBtn.Text = "Settings";
			this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
			// 
			// AboutBtn
			// 
			this.AboutBtn.Name = "AboutBtn";
			this.AboutBtn.Size = new System.Drawing.Size(52, 20);
			this.AboutBtn.Text = "About";
			this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
			// 
			// carLocationUpdateTimer
			// 
			this.carLocationUpdateTimer.Tick += new System.EventHandler(this.carLocationUpdateTimer_Tick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameStatus,
            this.currentCarName,
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 452);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
			this.statusStrip1.Size = new System.Drawing.Size(559, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// gameStatus
			// 
			this.gameStatus.Name = "gameStatus";
			this.gameStatus.Size = new System.Drawing.Size(39, 17);
			this.gameStatus.Text = "Status";
			// 
			// currentCarName
			// 
			this.currentCarName.Name = "currentCarName";
			this.currentCarName.Size = new System.Drawing.Size(66, 17);
			this.currentCarName.Text = "Current car";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(443, 17);
			this.toolStripStatusLabel1.Spring = true;
			// 
			// BodyTab
			// 
			this.BodyTab.Controls.Add(this.ExhaustEditBtn);
			this.BodyTab.Controls.Add(this.LicensePlate);
			this.BodyTab.Controls.Add(this.asdase1231);
			this.BodyTab.Controls.Add(this.label20);
			this.BodyTab.Controls.Add(this.CarMode);
			this.BodyTab.Controls.Add(this.HoodEditBtn);
			this.BodyTab.Controls.Add(this.SpoilerEditBtn);
			this.BodyTab.Controls.Add(this.groupBox5);
			this.BodyTab.Controls.Add(this.groupBox4);
			this.BodyTab.Controls.Add(this.groupBox3);
			this.BodyTab.Controls.Add(this.groupBox2);
			this.BodyTab.Controls.Add(this.groupBox1);
			this.BodyTab.Controls.Add(this.Exhaust);
			this.BodyTab.Controls.Add(this.label12);
			this.BodyTab.Controls.Add(this.RollCage);
			this.BodyTab.Controls.Add(this.label11);
			this.BodyTab.Controls.Add(this.Spoiler);
			this.BodyTab.Controls.Add(this.label10);
			this.BodyTab.Controls.Add(this.Hood);
			this.BodyTab.Controls.Add(this.label7);
			this.BodyTab.Controls.Add(this.Body);
			this.BodyTab.Controls.Add(this.label3);
			this.BodyTab.Location = new System.Drawing.Point(4, 22);
			this.BodyTab.Margin = new System.Windows.Forms.Padding(2);
			this.BodyTab.Name = "BodyTab";
			this.BodyTab.Padding = new System.Windows.Forms.Padding(2);
			this.BodyTab.Size = new System.Drawing.Size(551, 401);
			this.BodyTab.TabIndex = 0;
			this.BodyTab.Text = "Car parts";
			this.BodyTab.UseVisualStyleBackColor = true;
			// 
			// ExhaustEditBtn
			// 
			this.ExhaustEditBtn.Location = new System.Drawing.Point(455, 207);
			this.ExhaustEditBtn.Margin = new System.Windows.Forms.Padding(2);
			this.ExhaustEditBtn.Name = "ExhaustEditBtn";
			this.ExhaustEditBtn.Size = new System.Drawing.Size(22, 19);
			this.ExhaustEditBtn.TabIndex = 48;
			this.ExhaustEditBtn.Text = "...";
			this.ExhaustEditBtn.UseVisualStyleBackColor = true;
			this.ExhaustEditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// LicensePlate
			// 
			this.LicensePlate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LicensePlate.FormattingEnabled = true;
			this.LicensePlate.Location = new System.Drawing.Point(373, 274);
			this.LicensePlate.Margin = new System.Windows.Forms.Padding(2);
			this.LicensePlate.Name = "LicensePlate";
			this.LicensePlate.Size = new System.Drawing.Size(76, 21);
			this.LicensePlate.TabIndex = 47;
			// 
			// asdase1231
			// 
			this.asdase1231.AutoSize = true;
			this.asdase1231.Location = new System.Drawing.Point(299, 276);
			this.asdase1231.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.asdase1231.Name = "asdase1231";
			this.asdase1231.Size = new System.Drawing.Size(70, 13);
			this.asdase1231.TabIndex = 46;
			this.asdase1231.Text = "License plate";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(399, 13);
			this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(52, 13);
			this.label20.TabIndex = 45;
			this.label20.Text = "Car mode";
			// 
			// CarMode
			// 
			this.CarMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CarMode.FormattingEnabled = true;
			this.CarMode.Location = new System.Drawing.Point(455, 13);
			this.CarMode.Margin = new System.Windows.Forms.Padding(2);
			this.CarMode.Name = "CarMode";
			this.CarMode.Size = new System.Drawing.Size(76, 21);
			this.CarMode.TabIndex = 43;
			this.CarMode.SelectedValueChanged += new System.EventHandler(this.CarMode_SelectedValueChanged);
			this.CarMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CarMode_MouseDown);
			// 
			// HoodEditBtn
			// 
			this.HoodEditBtn.Location = new System.Drawing.Point(455, 241);
			this.HoodEditBtn.Margin = new System.Windows.Forms.Padding(2);
			this.HoodEditBtn.Name = "HoodEditBtn";
			this.HoodEditBtn.Size = new System.Drawing.Size(22, 19);
			this.HoodEditBtn.TabIndex = 44;
			this.HoodEditBtn.Text = "...";
			this.HoodEditBtn.UseVisualStyleBackColor = true;
			this.HoodEditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// SpoilerEditBtn
			// 
			this.SpoilerEditBtn.Location = new System.Drawing.Point(455, 133);
			this.SpoilerEditBtn.Margin = new System.Windows.Forms.Padding(2);
			this.SpoilerEditBtn.Name = "SpoilerEditBtn";
			this.SpoilerEditBtn.Size = new System.Drawing.Size(22, 19);
			this.SpoilerEditBtn.TabIndex = 43;
			this.SpoilerEditBtn.Text = "...";
			this.SpoilerEditBtn.UseVisualStyleBackColor = true;
			this.SpoilerEditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label14);
			this.groupBox5.Controls.Add(this.label17);
			this.groupBox5.Controls.Add(this.DoorFrontLeft);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.DoorFrontRight);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.DoorRearRight);
			this.groupBox5.Controls.Add(this.DoorRearLeft);
			this.groupBox5.Location = new System.Drawing.Point(332, 40);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox5.Size = new System.Drawing.Size(212, 76);
			this.groupBox5.TabIndex = 40;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Doors";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(11, 52);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(25, 13);
			this.label14.TabIndex = 36;
			this.label14.Text = "rear";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(9, 28);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(28, 13);
			this.label17.TabIndex = 32;
			this.label17.Text = "front";
			// 
			// DoorFrontLeft
			// 
			this.DoorFrontLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DoorFrontLeft.FormattingEnabled = true;
			this.DoorFrontLeft.Location = new System.Drawing.Point(41, 25);
			this.DoorFrontLeft.Margin = new System.Windows.Forms.Padding(2);
			this.DoorFrontLeft.Name = "DoorFrontLeft";
			this.DoorFrontLeft.Size = new System.Drawing.Size(76, 21);
			this.DoorFrontLeft.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(64, 9);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(21, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "left";
			// 
			// DoorFrontRight
			// 
			this.DoorFrontRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DoorFrontRight.FormattingEnabled = true;
			this.DoorFrontRight.Location = new System.Drawing.Point(124, 25);
			this.DoorFrontRight.Margin = new System.Windows.Forms.Padding(2);
			this.DoorFrontRight.Name = "DoorFrontRight";
			this.DoorFrontRight.Size = new System.Drawing.Size(76, 21);
			this.DoorFrontRight.TabIndex = 31;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(151, 9);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 13);
			this.label5.TabIndex = 30;
			this.label5.Text = "right";
			// 
			// DoorRearRight
			// 
			this.DoorRearRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DoorRearRight.FormattingEnabled = true;
			this.DoorRearRight.Location = new System.Drawing.Point(124, 50);
			this.DoorRearRight.Margin = new System.Windows.Forms.Padding(2);
			this.DoorRearRight.Name = "DoorRearRight";
			this.DoorRearRight.Size = new System.Drawing.Size(76, 21);
			this.DoorRearRight.TabIndex = 35;
			// 
			// DoorRearLeft
			// 
			this.DoorRearLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DoorRearLeft.FormattingEnabled = true;
			this.DoorRearLeft.Location = new System.Drawing.Point(41, 50);
			this.DoorRearLeft.Margin = new System.Windows.Forms.Padding(2);
			this.DoorRearLeft.Name = "DoorRearLeft";
			this.DoorRearLeft.Size = new System.Drawing.Size(76, 21);
			this.DoorRearLeft.TabIndex = 33;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.SeatLeft);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.SeatRight);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Location = new System.Drawing.Point(6, 224);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox4.Size = new System.Drawing.Size(275, 51);
			this.groupBox4.TabIndex = 39;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Seats";
			// 
			// SeatLeft
			// 
			this.SeatLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SeatLeft.FormattingEnabled = true;
			this.SeatLeft.Location = new System.Drawing.Point(43, 17);
			this.SeatLeft.Margin = new System.Windows.Forms.Padding(2);
			this.SeatLeft.Name = "SeatLeft";
			this.SeatLeft.Size = new System.Drawing.Size(76, 21);
			this.SeatLeft.TabIndex = 17;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(16, 20);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(21, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "left";
			// 
			// SeatRight
			// 
			this.SeatRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SeatRight.FormattingEnabled = true;
			this.SeatRight.Location = new System.Drawing.Point(157, 17);
			this.SeatRight.Margin = new System.Windows.Forms.Padding(2);
			this.SeatRight.Name = "SeatRight";
			this.SeatRight.Size = new System.Drawing.Size(76, 21);
			this.SeatRight.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(125, 20);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(27, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "right";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.FenderLeft);
			this.groupBox3.Controls.Add(this.labelfl);
			this.groupBox3.Controls.Add(this.FenderRight);
			this.groupBox3.Controls.Add(this.labelfr);
			this.groupBox3.Location = new System.Drawing.Point(6, 171);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new System.Drawing.Size(275, 49);
			this.groupBox3.TabIndex = 38;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Fenders";
			// 
			// FenderLeft
			// 
			this.FenderLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FenderLeft.FormattingEnabled = true;
			this.FenderLeft.Location = new System.Drawing.Point(43, 17);
			this.FenderLeft.Margin = new System.Windows.Forms.Padding(2);
			this.FenderLeft.Name = "FenderLeft";
			this.FenderLeft.Size = new System.Drawing.Size(76, 21);
			this.FenderLeft.TabIndex = 11;
			// 
			// labelfl
			// 
			this.labelfl.AutoSize = true;
			this.labelfl.Location = new System.Drawing.Point(18, 20);
			this.labelfl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelfl.Name = "labelfl";
			this.labelfl.Size = new System.Drawing.Size(21, 13);
			this.labelfl.TabIndex = 10;
			this.labelfl.Text = "left";
			// 
			// FenderRight
			// 
			this.FenderRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FenderRight.FormattingEnabled = true;
			this.FenderRight.Location = new System.Drawing.Point(157, 17);
			this.FenderRight.Margin = new System.Windows.Forms.Padding(2);
			this.FenderRight.Name = "FenderRight";
			this.FenderRight.Size = new System.Drawing.Size(76, 21);
			this.FenderRight.TabIndex = 29;
			// 
			// labelfr
			// 
			this.labelfr.AutoSize = true;
			this.labelfr.Location = new System.Drawing.Point(125, 20);
			this.labelfr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelfr.Name = "labelfr";
			this.labelfr.Size = new System.Drawing.Size(27, 13);
			this.labelfr.TabIndex = 28;
			this.labelfr.Text = "right";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.SkirtsEditBtn);
			this.groupBox2.Controls.Add(this.SkirtLeft);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.SkirtRight);
			this.groupBox2.Location = new System.Drawing.Point(6, 116);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(275, 50);
			this.groupBox2.TabIndex = 37;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Skirts";
			// 
			// SkirtsEditBtn
			// 
			this.SkirtsEditBtn.Location = new System.Drawing.Point(248, 17);
			this.SkirtsEditBtn.Margin = new System.Windows.Forms.Padding(2);
			this.SkirtsEditBtn.Name = "SkirtsEditBtn";
			this.SkirtsEditBtn.Size = new System.Drawing.Size(22, 19);
			this.SkirtsEditBtn.TabIndex = 42;
			this.SkirtsEditBtn.Text = "...";
			this.SkirtsEditBtn.UseVisualStyleBackColor = true;
			this.SkirtsEditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// SkirtLeft
			// 
			this.SkirtLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SkirtLeft.FormattingEnabled = true;
			this.SkirtLeft.Location = new System.Drawing.Point(43, 17);
			this.SkirtLeft.Margin = new System.Windows.Forms.Padding(2);
			this.SkirtLeft.Name = "SkirtLeft";
			this.SkirtLeft.Size = new System.Drawing.Size(76, 21);
			this.SkirtLeft.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 20);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(21, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "left";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(125, 20);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(27, 13);
			this.label13.TabIndex = 26;
			this.label13.Text = "right";
			// 
			// SkirtRight
			// 
			this.SkirtRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SkirtRight.FormattingEnabled = true;
			this.SkirtRight.Location = new System.Drawing.Point(157, 17);
			this.SkirtRight.Margin = new System.Windows.Forms.Padding(2);
			this.SkirtRight.Name = "SkirtRight";
			this.SkirtRight.Size = new System.Drawing.Size(76, 21);
			this.SkirtRight.TabIndex = 27;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BumperRearEditBtn);
			this.groupBox1.Controls.Add(this.BumperFrontEditBtn);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.BumperFrontExtra);
			this.groupBox1.Controls.Add(this.BumperRearExtra);
			this.groupBox1.Controls.Add(this.BumperFront);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.BumperRear);
			this.groupBox1.Location = new System.Drawing.Point(6, 40);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(275, 72);
			this.groupBox1.TabIndex = 36;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bumpers";
			// 
			// BumperRearEditBtn
			// 
			this.BumperRearEditBtn.Location = new System.Drawing.Point(248, 42);
			this.BumperRearEditBtn.Margin = new System.Windows.Forms.Padding(2);
			this.BumperRearEditBtn.Name = "BumperRearEditBtn";
			this.BumperRearEditBtn.Size = new System.Drawing.Size(22, 19);
			this.BumperRearEditBtn.TabIndex = 42;
			this.BumperRearEditBtn.Text = "...";
			this.BumperRearEditBtn.UseVisualStyleBackColor = true;
			this.BumperRearEditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// BumperFrontEditBtn
			// 
			this.BumperFrontEditBtn.Location = new System.Drawing.Point(248, 18);
			this.BumperFrontEditBtn.Margin = new System.Windows.Forms.Padding(2);
			this.BumperFrontEditBtn.Name = "BumperFrontEditBtn";
			this.BumperFrontEditBtn.Size = new System.Drawing.Size(22, 19);
			this.BumperFrontEditBtn.TabIndex = 41;
			this.BumperFrontEditBtn.Text = "...";
			this.BumperFrontEditBtn.UseVisualStyleBackColor = true;
			this.BumperFrontEditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(123, 31);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(30, 13);
			this.label16.TabIndex = 8;
			this.label16.Text = "extra";
			// 
			// BumperFrontExtra
			// 
			this.BumperFrontExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BumperFrontExtra.FormattingEnabled = true;
			this.BumperFrontExtra.Location = new System.Drawing.Point(157, 17);
			this.BumperFrontExtra.Margin = new System.Windows.Forms.Padding(2);
			this.BumperFrontExtra.Name = "BumperFrontExtra";
			this.BumperFrontExtra.Size = new System.Drawing.Size(76, 21);
			this.BumperFrontExtra.TabIndex = 6;
			// 
			// BumperRearExtra
			// 
			this.BumperRearExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BumperRearExtra.FormattingEnabled = true;
			this.BumperRearExtra.Location = new System.Drawing.Point(157, 41);
			this.BumperRearExtra.Margin = new System.Windows.Forms.Padding(2);
			this.BumperRearExtra.Name = "BumperRearExtra";
			this.BumperRearExtra.Size = new System.Drawing.Size(76, 21);
			this.BumperRearExtra.TabIndex = 7;
			// 
			// BumperFront
			// 
			this.BumperFront.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BumperFront.FormattingEnabled = true;
			this.BumperFront.Location = new System.Drawing.Point(43, 17);
			this.BumperFront.Margin = new System.Windows.Forms.Padding(2);
			this.BumperFront.Name = "BumperFront";
			this.BumperFront.Size = new System.Drawing.Size(76, 21);
			this.BumperFront.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 20);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "front";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 44);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "rear";
			// 
			// BumperRear
			// 
			this.BumperRear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BumperRear.FormattingEnabled = true;
			this.BumperRear.Location = new System.Drawing.Point(43, 41);
			this.BumperRear.Margin = new System.Windows.Forms.Padding(2);
			this.BumperRear.Name = "BumperRear";
			this.BumperRear.Size = new System.Drawing.Size(76, 21);
			this.BumperRear.TabIndex = 5;
			// 
			// Exhaust
			// 
			this.Exhaust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Exhaust.FormattingEnabled = true;
			this.Exhaust.Location = new System.Drawing.Point(373, 207);
			this.Exhaust.Margin = new System.Windows.Forms.Padding(2);
			this.Exhaust.Name = "Exhaust";
			this.Exhaust.Size = new System.Drawing.Size(76, 21);
			this.Exhaust.TabIndex = 25;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(323, 210);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(45, 13);
			this.label12.TabIndex = 24;
			this.label12.Text = "Exhaust";
			// 
			// RollCage
			// 
			this.RollCage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RollCage.FormattingEnabled = true;
			this.RollCage.Location = new System.Drawing.Point(373, 171);
			this.RollCage.Margin = new System.Windows.Forms.Padding(2);
			this.RollCage.Name = "RollCage";
			this.RollCage.Size = new System.Drawing.Size(76, 21);
			this.RollCage.TabIndex = 23;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(317, 173);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(52, 13);
			this.label11.TabIndex = 22;
			this.label11.Text = "Roll cage";
			// 
			// Spoiler
			// 
			this.Spoiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Spoiler.FormattingEnabled = true;
			this.Spoiler.Location = new System.Drawing.Point(373, 133);
			this.Spoiler.Margin = new System.Windows.Forms.Padding(2);
			this.Spoiler.Name = "Spoiler";
			this.Spoiler.Size = new System.Drawing.Size(76, 21);
			this.Spoiler.TabIndex = 21;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(328, 136);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(39, 13);
			this.label10.TabIndex = 20;
			this.label10.Text = "Spoiler";
			// 
			// Hood
			// 
			this.Hood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Hood.FormattingEnabled = true;
			this.Hood.Location = new System.Drawing.Point(373, 241);
			this.Hood.Margin = new System.Windows.Forms.Padding(2);
			this.Hood.Name = "Hood";
			this.Hood.Size = new System.Drawing.Size(76, 21);
			this.Hood.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(337, 244);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(33, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Hood";
			// 
			// Body
			// 
			this.Body.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Body.FormattingEnabled = true;
			this.Body.Location = new System.Drawing.Point(49, 13);
			this.Body.Margin = new System.Windows.Forms.Padding(2);
			this.Body.Name = "Body";
			this.Body.Size = new System.Drawing.Size(76, 21);
			this.Body.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 15);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Body";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.BodyTab);
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Controls.Add(this.tabPage3);
			this.tabControl.Location = new System.Drawing.Point(0, 25);
			this.tabControl.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl.Name = "tabControl";
			this.tabControl.RightToLeftLayout = true;
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(559, 427);
			this.tabControl.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.StaticLivery);
			this.tabPage1.Controls.Add(this.label19);
			this.tabPage1.Controls.Add(this.moveDecalsUp);
			this.tabPage1.Controls.Add(this.moveDecalsDown);
			this.tabPage1.Controls.Add(this.moveVinylsUp);
			this.tabPage1.Controls.Add(this.moveVinylsDown);
			this.tabPage1.Controls.Add(this.duplicateDecalBtn);
			this.tabPage1.Controls.Add(this.addDecalBtn);
			this.tabPage1.Controls.Add(this.deleteDecalBtn);
			this.tabPage1.Controls.Add(this.deleteVinylBtn);
			this.tabPage1.Controls.Add(this.addVinylBtn);
			this.tabPage1.Controls.Add(this.duplicateVinylBtn);
			this.tabPage1.Controls.Add(this.moveToDecalsBtn);
			this.tabPage1.Controls.Add(this.moveToVinylsBtn);
			this.tabPage1.Controls.Add(this.decalsGrid);
			this.tabPage1.Controls.Add(this.vinylsGrid);
			this.tabPage1.Controls.Add(this.label18);
			this.tabPage1.Controls.Add(this.label15);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(551, 401);
			this.tabPage1.TabIndex = 1;
			this.tabPage1.Text = "Livery";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// StaticLivery
			// 
			this.StaticLivery.Location = new System.Drawing.Point(100, 10);
			this.StaticLivery.Margin = new System.Windows.Forms.Padding(2);
			this.StaticLivery.MaxLength = 8;
			this.StaticLivery.Name = "StaticLivery";
			this.StaticLivery.Size = new System.Drawing.Size(76, 20);
			this.StaticLivery.TabIndex = 21;
			this.StaticLivery.Leave += new System.EventHandler(this.StaticLivery_Leave);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(35, 10);
			this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(61, 13);
			this.label19.TabIndex = 20;
			this.label19.Text = "Static livery";
			// 
			// moveDecalsUp
			// 
			this.moveDecalsUp.BackgroundImage = global::CarCustomize.Properties.Resources.arrow_up;
			this.moveDecalsUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.moveDecalsUp.Location = new System.Drawing.Point(500, 46);
			this.moveDecalsUp.Margin = new System.Windows.Forms.Padding(2);
			this.moveDecalsUp.Name = "moveDecalsUp";
			this.moveDecalsUp.Size = new System.Drawing.Size(26, 19);
			this.moveDecalsUp.TabIndex = 19;
			this.moveDecalsUp.UseVisualStyleBackColor = true;
			this.moveDecalsUp.Click += new System.EventHandler(this.moveVinylsUp_Click);
			// 
			// moveDecalsDown
			// 
			this.moveDecalsDown.BackgroundImage = global::CarCustomize.Properties.Resources.arrow_down;
			this.moveDecalsDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.moveDecalsDown.Location = new System.Drawing.Point(500, 348);
			this.moveDecalsDown.Margin = new System.Windows.Forms.Padding(2);
			this.moveDecalsDown.Name = "moveDecalsDown";
			this.moveDecalsDown.Size = new System.Drawing.Size(26, 19);
			this.moveDecalsDown.TabIndex = 18;
			this.moveDecalsDown.UseVisualStyleBackColor = true;
			this.moveDecalsDown.Click += new System.EventHandler(this.moveVinylsDown_Click);
			// 
			// moveVinylsUp
			// 
			this.moveVinylsUp.BackgroundImage = global::CarCustomize.Properties.Resources.arrow_up;
			this.moveVinylsUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.moveVinylsUp.Location = new System.Drawing.Point(8, 46);
			this.moveVinylsUp.Margin = new System.Windows.Forms.Padding(2);
			this.moveVinylsUp.Name = "moveVinylsUp";
			this.moveVinylsUp.Size = new System.Drawing.Size(26, 19);
			this.moveVinylsUp.TabIndex = 17;
			this.moveVinylsUp.UseVisualStyleBackColor = true;
			this.moveVinylsUp.Click += new System.EventHandler(this.moveVinylsUp_Click);
			// 
			// moveVinylsDown
			// 
			this.moveVinylsDown.BackgroundImage = global::CarCustomize.Properties.Resources.arrow_down;
			this.moveVinylsDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.moveVinylsDown.Location = new System.Drawing.Point(8, 348);
			this.moveVinylsDown.Margin = new System.Windows.Forms.Padding(2);
			this.moveVinylsDown.Name = "moveVinylsDown";
			this.moveVinylsDown.Size = new System.Drawing.Size(26, 19);
			this.moveVinylsDown.TabIndex = 16;
			this.moveVinylsDown.UseVisualStyleBackColor = true;
			this.moveVinylsDown.Click += new System.EventHandler(this.moveVinylsDown_Click);
			// 
			// duplicateDecalBtn
			// 
			this.duplicateDecalBtn.Location = new System.Drawing.Point(436, 371);
			this.duplicateDecalBtn.Margin = new System.Windows.Forms.Padding(2);
			this.duplicateDecalBtn.Name = "duplicateDecalBtn";
			this.duplicateDecalBtn.Size = new System.Drawing.Size(59, 22);
			this.duplicateDecalBtn.TabIndex = 15;
			this.duplicateDecalBtn.Text = "Duplicate";
			this.duplicateDecalBtn.UseVisualStyleBackColor = true;
			this.duplicateDecalBtn.Click += new System.EventHandler(this.duplicateVinylBtn_Click);
			// 
			// addDecalBtn
			// 
			this.addDecalBtn.Location = new System.Drawing.Point(307, 371);
			this.addDecalBtn.Margin = new System.Windows.Forms.Padding(2);
			this.addDecalBtn.Name = "addDecalBtn";
			this.addDecalBtn.Size = new System.Drawing.Size(59, 22);
			this.addDecalBtn.TabIndex = 14;
			this.addDecalBtn.Text = "Add";
			this.addDecalBtn.UseVisualStyleBackColor = true;
			this.addDecalBtn.Click += new System.EventHandler(this.addVinylBtn_Click);
			// 
			// deleteDecalBtn
			// 
			this.deleteDecalBtn.Location = new System.Drawing.Point(371, 371);
			this.deleteDecalBtn.Margin = new System.Windows.Forms.Padding(2);
			this.deleteDecalBtn.Name = "deleteDecalBtn";
			this.deleteDecalBtn.Size = new System.Drawing.Size(59, 22);
			this.deleteDecalBtn.TabIndex = 13;
			this.deleteDecalBtn.Text = "Delete";
			this.deleteDecalBtn.UseVisualStyleBackColor = true;
			this.deleteDecalBtn.Click += new System.EventHandler(this.deleteVinylBtn_Click);
			// 
			// deleteVinylBtn
			// 
			this.deleteVinylBtn.Location = new System.Drawing.Point(103, 371);
			this.deleteVinylBtn.Margin = new System.Windows.Forms.Padding(2);
			this.deleteVinylBtn.Name = "deleteVinylBtn";
			this.deleteVinylBtn.Size = new System.Drawing.Size(59, 22);
			this.deleteVinylBtn.TabIndex = 12;
			this.deleteVinylBtn.Text = "Delete";
			this.deleteVinylBtn.UseVisualStyleBackColor = true;
			this.deleteVinylBtn.Click += new System.EventHandler(this.deleteVinylBtn_Click);
			// 
			// addVinylBtn
			// 
			this.addVinylBtn.Location = new System.Drawing.Point(38, 371);
			this.addVinylBtn.Margin = new System.Windows.Forms.Padding(2);
			this.addVinylBtn.Name = "addVinylBtn";
			this.addVinylBtn.Size = new System.Drawing.Size(59, 22);
			this.addVinylBtn.TabIndex = 11;
			this.addVinylBtn.Text = "Add";
			this.addVinylBtn.UseVisualStyleBackColor = true;
			this.addVinylBtn.Click += new System.EventHandler(this.addVinylBtn_Click);
			// 
			// duplicateVinylBtn
			// 
			this.duplicateVinylBtn.Location = new System.Drawing.Point(166, 371);
			this.duplicateVinylBtn.Margin = new System.Windows.Forms.Padding(2);
			this.duplicateVinylBtn.Name = "duplicateVinylBtn";
			this.duplicateVinylBtn.Size = new System.Drawing.Size(59, 22);
			this.duplicateVinylBtn.TabIndex = 9;
			this.duplicateVinylBtn.Text = "Duplicate";
			this.duplicateVinylBtn.UseVisualStyleBackColor = true;
			this.duplicateVinylBtn.Click += new System.EventHandler(this.duplicateVinylBtn_Click);
			// 
			// moveToDecalsBtn
			// 
			this.moveToDecalsBtn.Location = new System.Drawing.Point(249, 207);
			this.moveToDecalsBtn.Margin = new System.Windows.Forms.Padding(2);
			this.moveToDecalsBtn.Name = "moveToDecalsBtn";
			this.moveToDecalsBtn.Size = new System.Drawing.Size(41, 19);
			this.moveToDecalsBtn.TabIndex = 8;
			this.moveToDecalsBtn.Text = ">>";
			this.moveToDecalsBtn.UseVisualStyleBackColor = true;
			this.moveToDecalsBtn.Click += new System.EventHandler(this.moveToDecalsBtn_Click);
			// 
			// moveToVinylsBtn
			// 
			this.moveToVinylsBtn.Location = new System.Drawing.Point(248, 184);
			this.moveToVinylsBtn.Margin = new System.Windows.Forms.Padding(2);
			this.moveToVinylsBtn.Name = "moveToVinylsBtn";
			this.moveToVinylsBtn.Size = new System.Drawing.Size(41, 19);
			this.moveToVinylsBtn.TabIndex = 7;
			this.moveToVinylsBtn.Text = "<<";
			this.moveToVinylsBtn.UseVisualStyleBackColor = true;
			this.moveToVinylsBtn.Click += new System.EventHandler(this.moveToVinylsBtn_Click);
			// 
			// decalsGrid
			// 
			this.decalsGrid.AllowUserToAddRows = false;
			this.decalsGrid.AllowUserToDeleteRows = false;
			this.decalsGrid.AllowUserToResizeColumns = false;
			this.decalsGrid.AllowUserToResizeRows = false;
			this.decalsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.decalsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.decalsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.decalsGrid.ColumnHeadersVisible = false;
			this.decalsGrid.Location = new System.Drawing.Point(307, 46);
			this.decalsGrid.Margin = new System.Windows.Forms.Padding(2);
			this.decalsGrid.Name = "decalsGrid";
			this.decalsGrid.ReadOnly = true;
			this.decalsGrid.RowHeadersVisible = false;
			this.decalsGrid.RowTemplate.Height = 24;
			this.decalsGrid.Size = new System.Drawing.Size(188, 320);
			this.decalsGrid.TabIndex = 6;
			this.decalsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
			this.decalsGrid.SelectionChanged += new System.EventHandler(this.vinylsGrid_SelectionChanged);
			this.decalsGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vinylsGrid_MouseDown);
			// 
			// vinylsGrid
			// 
			this.vinylsGrid.AllowUserToAddRows = false;
			this.vinylsGrid.AllowUserToDeleteRows = false;
			this.vinylsGrid.AllowUserToResizeColumns = false;
			this.vinylsGrid.AllowUserToResizeRows = false;
			this.vinylsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.vinylsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vinylsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vinylsGrid.ColumnHeadersVisible = false;
			this.vinylsGrid.Location = new System.Drawing.Point(38, 46);
			this.vinylsGrid.Margin = new System.Windows.Forms.Padding(2);
			this.vinylsGrid.Name = "vinylsGrid";
			this.vinylsGrid.ReadOnly = true;
			this.vinylsGrid.RowHeadersVisible = false;
			this.vinylsGrid.RowTemplate.Height = 24;
			this.vinylsGrid.Size = new System.Drawing.Size(188, 320);
			this.vinylsGrid.TabIndex = 5;
			this.vinylsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
			this.vinylsGrid.SelectionChanged += new System.EventHandler(this.vinylsGrid_SelectionChanged);
			this.vinylsGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vinylsGrid_MouseDown);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(304, 30);
			this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(43, 13);
			this.label18.TabIndex = 4;
			this.label18.Text = "Decals:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(35, 30);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(37, 13);
			this.label15.TabIndex = 2;
			this.label15.Text = "Vinyls:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.Nos);
			this.tabPage2.Controls.Add(this.label29);
			this.tabPage2.Controls.Add(this.Tires);
			this.tabPage2.Controls.Add(this.label30);
			this.tabPage2.Controls.Add(this.Brakes);
			this.tabPage2.Controls.Add(this.label25);
			this.tabPage2.Controls.Add(this.Suspension);
			this.tabPage2.Controls.Add(this.label24);
			this.tabPage2.Controls.Add(this.Turbo);
			this.tabPage2.Controls.Add(this.label23);
			this.tabPage2.Controls.Add(this.Drivetrain);
			this.tabPage2.Controls.Add(this.label22);
			this.tabPage2.Controls.Add(this.Engine);
			this.tabPage2.Controls.Add(this.label21);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(551, 401);
			this.tabPage2.TabIndex = 2;
			this.tabPage2.Text = "Performance";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(551, 401);
			this.tabPage3.TabIndex = 3;
			this.tabPage3.Text = "Misc parts";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// Engine
			// 
			this.Engine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Engine.FormattingEnabled = true;
			this.Engine.Location = new System.Drawing.Point(87, 19);
			this.Engine.Margin = new System.Windows.Forms.Padding(2);
			this.Engine.Name = "Engine";
			this.Engine.Size = new System.Drawing.Size(76, 21);
			this.Engine.TabIndex = 9;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(43, 22);
			this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(40, 13);
			this.label21.TabIndex = 8;
			this.label21.Text = "Engine";
			// 
			// Drivetrain
			// 
			this.Drivetrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Drivetrain.FormattingEnabled = true;
			this.Drivetrain.Location = new System.Drawing.Point(87, 59);
			this.Drivetrain.Margin = new System.Windows.Forms.Padding(2);
			this.Drivetrain.Name = "Drivetrain";
			this.Drivetrain.Size = new System.Drawing.Size(76, 21);
			this.Drivetrain.TabIndex = 11;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(31, 62);
			this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(52, 13);
			this.label22.TabIndex = 10;
			this.label22.Text = "Drivetrain";
			// 
			// Turbo
			// 
			this.Turbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Turbo.FormattingEnabled = true;
			this.Turbo.Location = new System.Drawing.Point(87, 104);
			this.Turbo.Margin = new System.Windows.Forms.Padding(2);
			this.Turbo.Name = "Turbo";
			this.Turbo.Size = new System.Drawing.Size(76, 21);
			this.Turbo.TabIndex = 13;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(48, 107);
			this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(35, 13);
			this.label23.TabIndex = 12;
			this.label23.Text = "Turbo";
			// 
			// Suspension
			// 
			this.Suspension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Suspension.FormattingEnabled = true;
			this.Suspension.Location = new System.Drawing.Point(87, 157);
			this.Suspension.Margin = new System.Windows.Forms.Padding(2);
			this.Suspension.Name = "Suspension";
			this.Suspension.Size = new System.Drawing.Size(76, 21);
			this.Suspension.TabIndex = 15;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(21, 160);
			this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(62, 13);
			this.label24.TabIndex = 14;
			this.label24.Text = "Suspension";
			// 
			// Brakes
			// 
			this.Brakes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Brakes.FormattingEnabled = true;
			this.Brakes.Location = new System.Drawing.Point(421, 104);
			this.Brakes.Margin = new System.Windows.Forms.Padding(2);
			this.Brakes.Name = "Brakes";
			this.Brakes.Size = new System.Drawing.Size(76, 21);
			this.Brakes.TabIndex = 17;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(377, 107);
			this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(40, 13);
			this.label25.TabIndex = 16;
			this.label25.Text = "Brakes";
			// 
			// Nos
			// 
			this.Nos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Nos.FormattingEnabled = true;
			this.Nos.Location = new System.Drawing.Point(421, 59);
			this.Nos.Margin = new System.Windows.Forms.Padding(2);
			this.Nos.Name = "Nos";
			this.Nos.Size = new System.Drawing.Size(76, 21);
			this.Nos.TabIndex = 21;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(391, 62);
			this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(26, 13);
			this.label29.TabIndex = 20;
			this.label29.Text = "Nos";
			// 
			// Tires
			// 
			this.Tires.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Tires.FormattingEnabled = true;
			this.Tires.Location = new System.Drawing.Point(421, 19);
			this.Tires.Margin = new System.Windows.Forms.Padding(2);
			this.Tires.Name = "Tires";
			this.Tires.Size = new System.Drawing.Size(76, 21);
			this.Tires.TabIndex = 19;
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(387, 22);
			this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(30, 13);
			this.label30.TabIndex = 18;
			this.label30.Text = "Tires";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 474);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Need for Speed: PRO STREET - Car customizer";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.BodyTab.ResumeLayout(false);
			this.BodyTab.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.decalsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vinylsGrid)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.carDataModelBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutBtn;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem ExitBtn;
		private System.Windows.Forms.ToolStripMenuItem SettingsBtn;
		private System.Windows.Forms.Timer carLocationUpdateTimer;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel gameStatus;
		private System.Windows.Forms.ToolStripMenuItem connectBtn;
		private System.Windows.Forms.BindingSource carDataModelBindingSource;
		private System.Windows.Forms.ToolStripStatusLabel currentCarName;
		private System.Windows.Forms.TabPage BodyTab;
		private System.Windows.Forms.ComboBox Exhaust;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox RollCage;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox Spoiler;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox SeatRight;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox SeatLeft;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox Hood;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox DoorFrontLeft;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox FenderLeft;
		private System.Windows.Forms.Label labelfl;
		private System.Windows.Forms.ComboBox SkirtLeft;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox Body;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox BumperRear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox BumperFront;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.ComboBox SkirtRight;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox FenderRight;
		private System.Windows.Forms.Label labelfr;
		private System.Windows.Forms.ComboBox DoorFrontRight;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox DoorRearRight;
		private System.Windows.Forms.ComboBox DoorRearLeft;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox BumperFrontExtra;
		private System.Windows.Forms.ComboBox BumperRearExtra;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ToolStripMenuItem CopyBtn;
		private System.Windows.Forms.ToolStripMenuItem PasteBtn;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.DataGridView vinylsGrid;
		private System.Windows.Forms.DataGridView decalsGrid;
		private System.Windows.Forms.Button moveToDecalsBtn;
		private System.Windows.Forms.Button moveToVinylsBtn;
		private System.Windows.Forms.Button duplicateVinylBtn;
		private System.Windows.Forms.Button deleteVinylBtn;
		private System.Windows.Forms.Button addVinylBtn;
		private System.Windows.Forms.Button deleteDecalBtn;
		private System.Windows.Forms.Button addDecalBtn;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Button duplicateDecalBtn;
		private System.Windows.Forms.Button moveVinylsDown;
		private System.Windows.Forms.Button moveVinylsUp;
		private System.Windows.Forms.Button moveDecalsUp;
		private System.Windows.Forms.Button moveDecalsDown;
		private System.Windows.Forms.Button SkirtsEditBtn;
		private System.Windows.Forms.Button BumperRearEditBtn;
		private System.Windows.Forms.Button BumperFrontEditBtn;
		private System.Windows.Forms.Button SpoilerEditBtn;
		private System.Windows.Forms.Button HoodEditBtn;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lockunlockToolStripMenuItem;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox StaticLivery;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox CarMode;
		private System.Windows.Forms.ComboBox LicensePlate;
		private System.Windows.Forms.Label asdase1231;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ExhaustEditBtn;
		private System.Windows.Forms.ComboBox Engine;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ComboBox Suspension;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.ComboBox Turbo;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.ComboBox Drivetrain;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.ComboBox Nos;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.ComboBox Tires;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.ComboBox Brakes;
		private System.Windows.Forms.Label label25;
	}
}

