namespace WiiTracker
{
    partial class WiiTrackerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WiiTrackerForm));
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.niMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nudFrequency = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lvMain = new System.Windows.Forms.ListView();
            this.chSiteName = new System.Windows.Forms.ColumnHeader();
            this.chURL = new System.Windows.Forms.ColumnHeader();
            this.chSearchText = new System.Windows.Forms.ColumnHeader();
            this.chInvertLogic = new System.Windows.Forms.ColumnHeader();
            this.cmSitesList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpEmail = new System.Windows.Forms.TabPage();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSmtpPassword = new System.Windows.Forms.TextBox();
            this.tbSmtpUsername = new System.Windows.Forms.TextBox();
            this.tbSmtpServer = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCallerIDName = new System.Windows.Forms.TextBox();
            this.tbNumberFrom = new System.Windows.Forms.TextBox();
            this.tbNumberToDial = new System.Windows.Forms.TextBox();
            this.tpSMS = new System.Windows.Forms.TabPage();
            this.cmbCarriers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSmsPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmSMSAttributes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tpTracker = new System.Windows.Forms.TabPage();
            this.tpLogging = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.lvLogging = new System.Windows.Forms.ListView();
            this.chEntryType = new System.Windows.Forms.ColumnHeader();
            this.chEntry = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).BeginInit();
            this.cmSitesList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpEmail.SuspendLayout();
            this.tbTelephone.SuspendLayout();
            this.tpSMS.SuspendLayout();
            this.cmSMSAttributes.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tpTracker.SuspendLayout();
            this.tpLogging.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 10000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // niMain
            // 
            this.niMain.ContextMenuStrip = this.contextMenuStrip1;
            this.niMain.Icon = ((System.Drawing.Icon)(resources.GetObject("niMain.Icon")));
            this.niMain.Text = "Wii Tracker";
            this.niMain.Visible = true;
            this.niMain.DoubleClick += new System.EventHandler(this.niMain_DoubleClick);
            this.niMain.BalloonTipClicked += new System.EventHandler(this.niMain_BalloonTipClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 54);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // nudFrequency
            // 
            this.nudFrequency.Location = new System.Drawing.Point(9, 242);
            this.nudFrequency.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudFrequency.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudFrequency.Name = "nudFrequency";
            this.nudFrequency.Size = new System.Drawing.Size(120, 20);
            this.nudFrequency.TabIndex = 5;
            this.nudFrequency.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 517);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(89, 517);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lvMain
            // 
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSiteName,
            this.chURL,
            this.chSearchText,
            this.chInvertLogic});
            this.lvMain.ContextMenuStrip = this.cmSitesList;
            this.lvMain.FullRowSelect = true;
            this.lvMain.GridLines = true;
            this.lvMain.Location = new System.Drawing.Point(0, 2);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(607, 221);
            this.lvMain.TabIndex = 9;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.DoubleClick += new System.EventHandler(this.lvMain_DoubleClick);
            // 
            // chSiteName
            // 
            this.chSiteName.Text = "Site Name";
            this.chSiteName.Width = 92;
            // 
            // chURL
            // 
            this.chURL.Text = "URL";
            this.chURL.Width = 210;
            // 
            // chSearchText
            // 
            this.chSearchText.Text = "Search String";
            this.chSearchText.Width = 211;
            // 
            // chInvertLogic
            // 
            this.chInvertLogic.Text = "Invert Logic";
            this.chInvertLogic.Width = 88;
            // 
            // cmSitesList
            // 
            this.cmSitesList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSiteToolStripMenuItem,
            this.toolStripSeparator3,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmSitesList.Name = "cmSitesList";
            this.cmSitesList.Size = new System.Drawing.Size(129, 76);
            this.cmSitesList.Opening += new System.ComponentModel.CancelEventHandler(this.cmSitesList_Opening);
            // 
            // newSiteToolStripMenuItem
            // 
            this.newSiteToolStripMenuItem.Name = "newSiteToolStripMenuItem";
            this.newSiteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.newSiteToolStripMenuItem.Text = "New Site...";
            this.newSiteToolStripMenuItem.Click += new System.EventHandler(this.newSiteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(125, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteToolStripMenuItem.Text = "Delete...";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcMain);
            this.groupBox1.Location = new System.Drawing.Point(9, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 180);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notification";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpEmail);
            this.tcMain.Controls.Add(this.tbTelephone);
            this.tcMain.Controls.Add(this.tpSMS);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(3, 16);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(587, 161);
            this.tcMain.TabIndex = 0;
            // 
            // tpEmail
            // 
            this.tpEmail.Controls.Add(this.tbPort);
            this.tpEmail.Controls.Add(this.label9);
            this.tpEmail.Controls.Add(this.tbSmtpPassword);
            this.tpEmail.Controls.Add(this.tbSmtpUsername);
            this.tpEmail.Controls.Add(this.tbSmtpServer);
            this.tpEmail.Controls.Add(this.tbEmail);
            this.tpEmail.Controls.Add(this.label8);
            this.tpEmail.Controls.Add(this.label7);
            this.tpEmail.Controls.Add(this.label6);
            this.tpEmail.Controls.Add(this.label5);
            this.tpEmail.Location = new System.Drawing.Point(4, 22);
            this.tpEmail.Name = "tpEmail";
            this.tpEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmail.Size = new System.Drawing.Size(579, 135);
            this.tpEmail.TabIndex = 0;
            this.tpEmail.Text = "Email";
            this.tpEmail.UseVisualStyleBackColor = true;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(271, 32);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(78, 20);
            this.tbPort.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Port:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSmtpPassword
            // 
            this.tbSmtpPassword.Location = new System.Drawing.Point(109, 83);
            this.tbSmtpPassword.Name = "tbSmtpPassword";
            this.tbSmtpPassword.PasswordChar = '*';
            this.tbSmtpPassword.Size = new System.Drawing.Size(239, 20);
            this.tbSmtpPassword.TabIndex = 7;
            // 
            // tbSmtpUsername
            // 
            this.tbSmtpUsername.Location = new System.Drawing.Point(110, 58);
            this.tbSmtpUsername.Name = "tbSmtpUsername";
            this.tbSmtpUsername.Size = new System.Drawing.Size(239, 20);
            this.tbSmtpUsername.TabIndex = 6;
            // 
            // tbSmtpServer
            // 
            this.tbSmtpServer.Location = new System.Drawing.Point(109, 32);
            this.tbSmtpServer.Name = "tbSmtpServer";
            this.tbSmtpServer.Size = new System.Drawing.Size(121, 20);
            this.tbSmtpServer.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(109, 6);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(239, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "SMTP Password:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "SMTP Username:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "SMTP Server:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email Address:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Controls.Add(this.label4);
            this.tbTelephone.Controls.Add(this.label2);
            this.tbTelephone.Controls.Add(this.label1);
            this.tbTelephone.Controls.Add(this.tbCallerIDName);
            this.tbTelephone.Controls.Add(this.tbNumberFrom);
            this.tbTelephone.Controls.Add(this.tbNumberToDial);
            this.tbTelephone.Location = new System.Drawing.Point(4, 22);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Padding = new System.Windows.Forms.Padding(3);
            this.tbTelephone.Size = new System.Drawing.Size(579, 135);
            this.tbTelephone.TabIndex = 1;
            this.tbTelephone.Text = "Telephone";
            this.tbTelephone.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Caller ID Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number from (Caller ID):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number to dial:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCallerIDName
            // 
            this.tbCallerIDName.Location = new System.Drawing.Point(157, 71);
            this.tbCallerIDName.Name = "tbCallerIDName";
            this.tbCallerIDName.Size = new System.Drawing.Size(220, 20);
            this.tbCallerIDName.TabIndex = 2;
            // 
            // tbNumberFrom
            // 
            this.tbNumberFrom.Location = new System.Drawing.Point(157, 45);
            this.tbNumberFrom.Name = "tbNumberFrom";
            this.tbNumberFrom.Size = new System.Drawing.Size(220, 20);
            this.tbNumberFrom.TabIndex = 1;
            // 
            // tbNumberToDial
            // 
            this.tbNumberToDial.Location = new System.Drawing.Point(157, 19);
            this.tbNumberToDial.Name = "tbNumberToDial";
            this.tbNumberToDial.Size = new System.Drawing.Size(220, 20);
            this.tbNumberToDial.TabIndex = 0;
            // 
            // tpSMS
            // 
            this.tpSMS.Controls.Add(this.cmbCarriers);
            this.tpSMS.Controls.Add(this.label3);
            this.tpSMS.Controls.Add(this.tbSmsPhone);
            this.tpSMS.Controls.Add(this.label10);
            this.tpSMS.Location = new System.Drawing.Point(4, 22);
            this.tpSMS.Name = "tpSMS";
            this.tpSMS.Padding = new System.Windows.Forms.Padding(3);
            this.tpSMS.Size = new System.Drawing.Size(579, 135);
            this.tpSMS.TabIndex = 2;
            this.tpSMS.Text = "SMS";
            this.tpSMS.UseVisualStyleBackColor = true;
            // 
            // cmbCarriers
            // 
            this.cmbCarriers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarriers.FormattingEnabled = true;
            this.cmbCarriers.Location = new System.Drawing.Point(23, 72);
            this.cmbCarriers.Name = "cmbCarriers";
            this.cmbCarriers.Size = new System.Drawing.Size(205, 21);
            this.cmbCarriers.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carrier:";
            // 
            // tbSmsPhone
            // 
            this.tbSmsPhone.Location = new System.Drawing.Point(23, 33);
            this.tbSmsPhone.Name = "tbSmsPhone";
            this.tbSmsPhone.Size = new System.Drawing.Size(157, 20);
            this.tbSmsPhone.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Phone Number:";
            // 
            // cmSMSAttributes
            // 
            this.cmSMSAttributes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1});
            this.cmSMSAttributes.Name = "cmSMSAttributes";
            this.cmSMSAttributes.Size = new System.Drawing.Size(106, 26);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(542, 517);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Check frequency (in milliseconds):";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tpTracker);
            this.tabControl3.Controls.Add(this.tpLogging);
            this.tabControl3.Location = new System.Drawing.Point(8, 27);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(616, 484);
            this.tabControl3.TabIndex = 12;
            // 
            // tpTracker
            // 
            this.tpTracker.Controls.Add(this.label11);
            this.tpTracker.Controls.Add(this.nudFrequency);
            this.tpTracker.Controls.Add(this.lvMain);
            this.tpTracker.Controls.Add(this.groupBox1);
            this.tpTracker.Location = new System.Drawing.Point(4, 22);
            this.tpTracker.Name = "tpTracker";
            this.tpTracker.Padding = new System.Windows.Forms.Padding(3);
            this.tpTracker.Size = new System.Drawing.Size(608, 458);
            this.tpTracker.TabIndex = 0;
            this.tpTracker.Text = "Tracker";
            this.tpTracker.UseVisualStyleBackColor = true;
            // 
            // tpLogging
            // 
            this.tpLogging.Controls.Add(this.lblStatus);
            this.tpLogging.Controls.Add(this.btnClearLog);
            this.tpLogging.Controls.Add(this.lvLogging);
            this.tpLogging.Location = new System.Drawing.Point(4, 22);
            this.tpLogging.Name = "tpLogging";
            this.tpLogging.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogging.Size = new System.Drawing.Size(608, 458);
            this.tpLogging.TabIndex = 1;
            this.tpLogging.Text = "Logging/Status";
            this.tpLogging.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 364);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(5);
            this.lblStatus.Size = new System.Drawing.Size(602, 56);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status: Idle";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(6, 428);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // lvLogging
            // 
            this.lvLogging.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEntryType,
            this.chEntry});
            this.lvLogging.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvLogging.FullRowSelect = true;
            this.lvLogging.GridLines = true;
            this.lvLogging.Location = new System.Drawing.Point(3, 3);
            this.lvLogging.Name = "lvLogging";
            this.lvLogging.Size = new System.Drawing.Size(602, 361);
            this.lvLogging.TabIndex = 0;
            this.lvLogging.UseCompatibleStateImageBehavior = false;
            this.lvLogging.View = System.Windows.Forms.View.Details;
            this.lvLogging.DoubleClick += new System.EventHandler(this.lvLogging_DoubleClick);
            // 
            // chEntryType
            // 
            this.chEntryType.Text = "Date";
            this.chEntryType.Width = 165;
            // 
            // chEntry
            // 
            this.chEntry.Text = "Message";
            this.chEntry.Width = 361;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sitesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "msMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveConfig,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.sitesToolStripMenuItem.Text = "Sites";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.addToolStripMenuItem.Text = "Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // tsmiSaveConfig
            // 
            this.tsmiSaveConfig.Name = "tsmiSaveConfig";
            this.tsmiSaveConfig.Size = new System.Drawing.Size(166, 22);
            this.tsmiSaveConfig.Text = "Save Configuration";
            this.tsmiSaveConfig.Click += new System.EventHandler(this.tsmiSaveConfig_Click);
            // 
            // WiiTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 548);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "WiiTrackerForm";
            this.Text = "Wii Tracker 2006";
            this.Load += new System.EventHandler(this.WiiTrackerForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).EndInit();
            this.cmSitesList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpEmail.ResumeLayout(false);
            this.tpEmail.PerformLayout();
            this.tbTelephone.ResumeLayout(false);
            this.tbTelephone.PerformLayout();
            this.tpSMS.ResumeLayout(false);
            this.tpSMS.PerformLayout();
            this.cmSMSAttributes.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tpTracker.ResumeLayout(false);
            this.tpTracker.PerformLayout();
            this.tpLogging.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.NotifyIcon niMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudFrequency;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ColumnHeader chURL;
        private System.Windows.Forms.ColumnHeader chSearchText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpEmail;
        private System.Windows.Forms.TabPage tbTelephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCallerIDName;
        private System.Windows.Forms.TextBox tbNumberFrom;
        private System.Windows.Forms.TextBox tbNumberToDial;
        private System.Windows.Forms.TextBox tbSmtpPassword;
        private System.Windows.Forms.TextBox tbSmtpUsername;
        private System.Windows.Forms.TextBox tbSmtpServer;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tpSMS;
        private System.Windows.Forms.TextBox tbSmsPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader chSiteName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tpTracker;
        private System.Windows.Forms.TabPage tpLogging;
        private System.Windows.Forms.ListView lvLogging;
        private System.Windows.Forms.ColumnHeader chEntryType;
        private System.Windows.Forms.ColumnHeader chEntry;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.ComboBox cmbCarriers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ColumnHeader chInvertLogic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip cmSitesList;
        private System.Windows.Forms.ToolStripMenuItem newSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip cmSMSAttributes;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

