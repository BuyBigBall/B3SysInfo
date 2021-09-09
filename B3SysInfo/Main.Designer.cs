namespace loading_screen
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
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("System Information", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Power Config Value", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem61 = new System.Windows.Forms.ListViewItem(new string[] {
            "Host Name",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem62 = new System.Windows.Forms.ListViewItem(new string[] {
            "System Model",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem63 = new System.Windows.Forms.ListViewItem(new string[] {
            "Serial Number",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem64 = new System.Windows.Forms.ListViewItem(new string[] {
            "IP Address",
            "3"}, -1);
            System.Windows.Forms.ListViewItem listViewItem65 = new System.Windows.Forms.ListViewItem(new string[] {
            "DNS Address",
            "4"}, -1);
            System.Windows.Forms.ListViewItem listViewItem66 = new System.Windows.Forms.ListViewItem(new string[] {
            "Static",
            "5"}, -1);
            System.Windows.Forms.ListViewItem listViewItem67 = new System.Windows.Forms.ListViewItem(new string[] {
            "NS Lookup Hostname",
            "6"}, -1);
            System.Windows.Forms.ListViewItem listViewItem68 = new System.Windows.Forms.ListViewItem(new string[] {
            "Time Zone",
            "7"}, -1);
            System.Windows.Forms.ListViewItem listViewItem69 = new System.Windows.Forms.ListViewItem(new string[] {
            "CPU Information",
            "8"}, -1);
            System.Windows.Forms.ListViewItem listViewItem70 = new System.Windows.Forms.ListViewItem(new string[] {
            "Disk Storage information",
            "9"}, -1);
            System.Windows.Forms.ListViewItem listViewItem71 = new System.Windows.Forms.ListViewItem(new string[] {
            "RAM information",
            "10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem72 = new System.Windows.Forms.ListViewItem(new string[] {
            "Display Resolution",
            "11"}, -1);
            System.Windows.Forms.ListViewItem listViewItem73 = new System.Windows.Forms.ListViewItem(new string[] {
            "1) Sleep After AC Power Value",
            "12"}, -1);
            System.Windows.Forms.ListViewItem listViewItem74 = new System.Windows.Forms.ListViewItem(new string[] {
            "2) Turn off display after AC Power Value",
            "13"}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem75 = new System.Windows.Forms.ListViewItem(new string[] {
            "asdfsdfds",
            "dsfdsfds"}, -1);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSystemInfo = new System.Windows.Forms.TabPage();
            this.lstDisplayHardware = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabCertificateInfo = new System.Windows.Forms.TabPage();
            this.listViewCertificate = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.txtAutoLoginPassword = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAutoLoginUserName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAutoLoginEnable = new System.Windows.Forms.Button();
            this.btnAutoLoginDisable = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnEnableScreenSaver = new System.Windows.Forms.Button();
            this.btnDisableScreenSaver = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnChangeTimeZone = new System.Windows.Forms.Button();
            this.lblCurrentTimeZone = new System.Windows.Forms.Label();
            this.cmbTimeZone = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnGetPrograms = new System.Windows.Forms.Button();
            this.listViewPrograms = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPortQueryValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckPort = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChangeTurnoffAfter = new System.Windows.Forms.Button();
            this.textBoxTurnoffAfter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeSleepAfter = new System.Windows.Forms.Button();
            this.textBoxSleepAfter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSystemInfo.SuspendLayout();
            this.tabCertificateInfo.SuspendLayout();
            this.tabConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabSystemInfo);
            this.tabControl1.Controls.Add(this.tabCertificateInfo);
            this.tabControl1.Controls.Add(this.tabConfiguration);
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 21);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 490);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabSystemInfo
            // 
            this.tabSystemInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.tabSystemInfo.Controls.Add(this.lstDisplayHardware);
            this.tabSystemInfo.Location = new System.Drawing.Point(4, 25);
            this.tabSystemInfo.Name = "tabSystemInfo";
            this.tabSystemInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystemInfo.Size = new System.Drawing.Size(758, 461);
            this.tabSystemInfo.TabIndex = 0;
            this.tabSystemInfo.Text = "System Information";
            // 
            // lstDisplayHardware
            // 
            this.lstDisplayHardware.BackColor = System.Drawing.Color.Gainsboro;
            this.lstDisplayHardware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstDisplayHardware.FullRowSelect = true;
            this.lstDisplayHardware.GridLines = true;
            listViewGroup13.Header = "System Information";
            listViewGroup13.Name = "ListViewGroupSystemInfo";
            listViewGroup14.Header = "Power Config Value";
            listViewGroup14.Name = "listGroupPowerConfig";
            this.lstDisplayHardware.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup13,
            listViewGroup14});
            this.lstDisplayHardware.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstDisplayHardware.HideSelection = false;
            listViewItem61.Group = listViewGroup13;
            listViewItem62.Group = listViewGroup13;
            listViewItem63.Group = listViewGroup13;
            listViewItem64.Group = listViewGroup13;
            listViewItem65.Group = listViewGroup13;
            listViewItem66.Group = listViewGroup13;
            listViewItem67.Group = listViewGroup13;
            listViewItem68.Group = listViewGroup13;
            listViewItem69.Group = listViewGroup13;
            listViewItem70.Group = listViewGroup13;
            listViewItem71.Group = listViewGroup13;
            listViewItem72.Group = listViewGroup13;
            listViewItem73.Group = listViewGroup14;
            listViewItem74.Group = listViewGroup14;
            this.lstDisplayHardware.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem61,
            listViewItem62,
            listViewItem63,
            listViewItem64,
            listViewItem65,
            listViewItem66,
            listViewItem67,
            listViewItem68,
            listViewItem69,
            listViewItem70,
            listViewItem71,
            listViewItem72,
            listViewItem73,
            listViewItem74});
            this.lstDisplayHardware.Location = new System.Drawing.Point(0, 0);
            this.lstDisplayHardware.Name = "lstDisplayHardware";
            this.lstDisplayHardware.Size = new System.Drawing.Size(758, 461);
            this.lstDisplayHardware.TabIndex = 1;
            this.lstDisplayHardware.UseCompatibleStateImageBehavior = false;
            this.lstDisplayHardware.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 381;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 365;
            // 
            // tabCertificateInfo
            // 
            this.tabCertificateInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.tabCertificateInfo.Controls.Add(this.listViewCertificate);
            this.tabCertificateInfo.Location = new System.Drawing.Point(4, 25);
            this.tabCertificateInfo.Name = "tabCertificateInfo";
            this.tabCertificateInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCertificateInfo.Size = new System.Drawing.Size(758, 461);
            this.tabCertificateInfo.TabIndex = 1;
            this.tabCertificateInfo.Text = "Certificate Information";
            // 
            // listViewCertificate
            // 
            this.listViewCertificate.BackColor = System.Drawing.Color.Gainsboro;
            this.listViewCertificate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCertificate.FullRowSelect = true;
            listViewGroup15.Header = "ListViewGroup";
            listViewGroup15.Name = "listViewGroup1";
            this.listViewCertificate.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup15});
            this.listViewCertificate.HideSelection = false;
            listViewItem75.Group = listViewGroup15;
            this.listViewCertificate.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem75});
            this.listViewCertificate.Location = new System.Drawing.Point(0, 0);
            this.listViewCertificate.Name = "listViewCertificate";
            this.listViewCertificate.Size = new System.Drawing.Size(758, 461);
            this.listViewCertificate.TabIndex = 0;
            this.listViewCertificate.UseCompatibleStateImageBehavior = false;
            this.listViewCertificate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 609;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.BackColor = System.Drawing.Color.Gainsboro;
            this.tabConfiguration.Controls.Add(this.txtAutoLoginPassword);
            this.tabConfiguration.Controls.Add(this.label19);
            this.tabConfiguration.Controls.Add(this.txtAutoLoginUserName);
            this.tabConfiguration.Controls.Add(this.label18);
            this.tabConfiguration.Controls.Add(this.btnAutoLoginEnable);
            this.tabConfiguration.Controls.Add(this.btnAutoLoginDisable);
            this.tabConfiguration.Controls.Add(this.label17);
            this.tabConfiguration.Controls.Add(this.btnEnableScreenSaver);
            this.tabConfiguration.Controls.Add(this.btnDisableScreenSaver);
            this.tabConfiguration.Controls.Add(this.label16);
            this.tabConfiguration.Controls.Add(this.btnChangeTimeZone);
            this.tabConfiguration.Controls.Add(this.lblCurrentTimeZone);
            this.tabConfiguration.Controls.Add(this.cmbTimeZone);
            this.tabConfiguration.Controls.Add(this.label15);
            this.tabConfiguration.Controls.Add(this.label14);
            this.tabConfiguration.Controls.Add(this.btnUninstall);
            this.tabConfiguration.Controls.Add(this.btnGetPrograms);
            this.tabConfiguration.Controls.Add(this.listViewPrograms);
            this.tabConfiguration.Controls.Add(this.textBoxPort);
            this.tabConfiguration.Controls.Add(this.labelPortQueryValue);
            this.tabConfiguration.Controls.Add(this.label4);
            this.tabConfiguration.Controls.Add(this.btnCheckPort);
            this.tabConfiguration.Controls.Add(this.textBoxAddress);
            this.tabConfiguration.Controls.Add(this.label5);
            this.tabConfiguration.Controls.Add(this.label6);
            this.tabConfiguration.Controls.Add(this.btnChangeTurnoffAfter);
            this.tabConfiguration.Controls.Add(this.textBoxTurnoffAfter);
            this.tabConfiguration.Controls.Add(this.label3);
            this.tabConfiguration.Controls.Add(this.btnChangeSleepAfter);
            this.tabConfiguration.Controls.Add(this.textBoxSleepAfter);
            this.tabConfiguration.Controls.Add(this.label2);
            this.tabConfiguration.Controls.Add(this.label1);
            this.tabConfiguration.Location = new System.Drawing.Point(4, 25);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Size = new System.Drawing.Size(758, 461);
            this.tabConfiguration.TabIndex = 2;
            this.tabConfiguration.Text = "Configuration";
            // 
            // txtAutoLoginPassword
            // 
            this.txtAutoLoginPassword.Location = new System.Drawing.Point(391, 390);
            this.txtAutoLoginPassword.Name = "txtAutoLoginPassword";
            this.txtAutoLoginPassword.Size = new System.Drawing.Size(100, 20);
            this.txtAutoLoginPassword.TabIndex = 30;
            this.txtAutoLoginPassword.UseSystemPasswordChar = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(325, 393);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Password";
            // 
            // txtAutoLoginUserName
            // 
            this.txtAutoLoginUserName.Location = new System.Drawing.Point(204, 390);
            this.txtAutoLoginUserName.Name = "txtAutoLoginUserName";
            this.txtAutoLoginUserName.Size = new System.Drawing.Size(100, 20);
            this.txtAutoLoginUserName.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(138, 393);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "User Name";
            // 
            // btnAutoLoginEnable
            // 
            this.btnAutoLoginEnable.Location = new System.Drawing.Point(502, 387);
            this.btnAutoLoginEnable.Name = "btnAutoLoginEnable";
            this.btnAutoLoginEnable.Size = new System.Drawing.Size(75, 23);
            this.btnAutoLoginEnable.TabIndex = 26;
            this.btnAutoLoginEnable.Text = "Enable";
            this.btnAutoLoginEnable.UseVisualStyleBackColor = true;
            this.btnAutoLoginEnable.Click += new System.EventHandler(this.btnAutoLoginEnable_Click);
            // 
            // btnAutoLoginDisable
            // 
            this.btnAutoLoginDisable.Location = new System.Drawing.Point(588, 387);
            this.btnAutoLoginDisable.Name = "btnAutoLoginDisable";
            this.btnAutoLoginDisable.Size = new System.Drawing.Size(75, 23);
            this.btnAutoLoginDisable.TabIndex = 25;
            this.btnAutoLoginDisable.Text = "Disable";
            this.btnAutoLoginDisable.UseVisualStyleBackColor = true;
            this.btnAutoLoginDisable.Click += new System.EventHandler(this.btnAutoLoginDisable_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(36, 388);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 20);
            this.label17.TabIndex = 24;
            this.label17.Text = "Auto Login";
            // 
            // btnEnableScreenSaver
            // 
            this.btnEnableScreenSaver.Location = new System.Drawing.Point(226, 346);
            this.btnEnableScreenSaver.Name = "btnEnableScreenSaver";
            this.btnEnableScreenSaver.Size = new System.Drawing.Size(75, 23);
            this.btnEnableScreenSaver.TabIndex = 23;
            this.btnEnableScreenSaver.Text = "Enable";
            this.btnEnableScreenSaver.UseVisualStyleBackColor = true;
            this.btnEnableScreenSaver.Click += new System.EventHandler(this.btnEnableScreenSaver_Click);
            // 
            // btnDisableScreenSaver
            // 
            this.btnDisableScreenSaver.Location = new System.Drawing.Point(312, 346);
            this.btnDisableScreenSaver.Name = "btnDisableScreenSaver";
            this.btnDisableScreenSaver.Size = new System.Drawing.Size(75, 23);
            this.btnDisableScreenSaver.TabIndex = 22;
            this.btnDisableScreenSaver.Text = "Disable";
            this.btnDisableScreenSaver.UseVisualStyleBackColor = true;
            this.btnDisableScreenSaver.Click += new System.EventHandler(this.btnDisableScreenSaver_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(36, 349);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Screen Saver";
            // 
            // btnChangeTimeZone
            // 
            this.btnChangeTimeZone.Location = new System.Drawing.Point(521, 316);
            this.btnChangeTimeZone.Name = "btnChangeTimeZone";
            this.btnChangeTimeZone.Size = new System.Drawing.Size(75, 23);
            this.btnChangeTimeZone.TabIndex = 20;
            this.btnChangeTimeZone.Text = "Change";
            this.btnChangeTimeZone.UseVisualStyleBackColor = true;
            this.btnChangeTimeZone.Click += new System.EventHandler(this.btnChangeTimeZone_Click);
            // 
            // lblCurrentTimeZone
            // 
            this.lblCurrentTimeZone.AutoSize = true;
            this.lblCurrentTimeZone.Location = new System.Drawing.Point(148, 321);
            this.lblCurrentTimeZone.Name = "lblCurrentTimeZone";
            this.lblCurrentTimeZone.Size = new System.Drawing.Size(109, 13);
            this.lblCurrentTimeZone.TabIndex = 19;
            this.lblCurrentTimeZone.Text = "Tokyo Standard Time";
            // 
            // cmbTimeZone
            // 
            this.cmbTimeZone.FormattingEnabled = true;
            this.cmbTimeZone.Location = new System.Drawing.Point(312, 317);
            this.cmbTimeZone.Name = "cmbTimeZone";
            this.cmbTimeZone.Size = new System.Drawing.Size(195, 21);
            this.cmbTimeZone.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(35, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Time Zone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Programs";
            // 
            // btnUninstall
            // 
            this.btnUninstall.Location = new System.Drawing.Point(666, 217);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(75, 23);
            this.btnUninstall.TabIndex = 15;
            this.btnUninstall.Text = "Uninstall";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnGetPrograms
            // 
            this.btnGetPrograms.Location = new System.Drawing.Point(666, 188);
            this.btnGetPrograms.Name = "btnGetPrograms";
            this.btnGetPrograms.Size = new System.Drawing.Size(75, 23);
            this.btnGetPrograms.TabIndex = 14;
            this.btnGetPrograms.Text = "Get";
            this.btnGetPrograms.UseVisualStyleBackColor = true;
            this.btnGetPrograms.Click += new System.EventHandler(this.btnGetPrograms_Click);
            // 
            // listViewPrograms
            // 
            this.listViewPrograms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.listViewPrograms.FullRowSelect = true;
            this.listViewPrograms.HideSelection = false;
            this.listViewPrograms.Location = new System.Drawing.Point(61, 188);
            this.listViewPrograms.Name = "listViewPrograms";
            this.listViewPrograms.Size = new System.Drawing.Size(602, 117);
            this.listViewPrograms.TabIndex = 13;
            this.listViewPrograms.UseCompatibleStateImageBehavior = false;
            this.listViewPrograms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Programs";
            this.columnHeader5.Width = 584;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(513, 135);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(67, 20);
            this.textBoxPort.TabIndex = 10;
            this.textBoxPort.Text = "443";
            // 
            // labelPortQueryValue
            // 
            this.labelPortQueryValue.AutoSize = true;
            this.labelPortQueryValue.Location = new System.Drawing.Point(625, 139);
            this.labelPortQueryValue.Name = "labelPortQueryValue";
            this.labelPortQueryValue.Size = new System.Drawing.Size(0, 13);
            this.labelPortQueryValue.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "value:";
            // 
            // btnCheckPort
            // 
            this.btnCheckPort.Location = new System.Drawing.Point(666, 134);
            this.btnCheckPort.Name = "btnCheckPort";
            this.btnCheckPort.Size = new System.Drawing.Size(75, 23);
            this.btnCheckPort.TabIndex = 10;
            this.btnCheckPort.Text = "Check";
            this.btnCheckPort.UseVisualStyleBackColor = true;
            this.btnCheckPort.Click += new System.EventHandler(this.btnCheckPort_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(328, 135);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(179, 20);
            this.textBoxAddress.TabIndex = 9;
            this.textBoxAddress.Text = "www.google.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "If listening, value: true, if denied, value: false";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Port Query";
            // 
            // btnChangeTurnoffAfter
            // 
            this.btnChangeTurnoffAfter.Location = new System.Drawing.Point(432, 69);
            this.btnChangeTurnoffAfter.Name = "btnChangeTurnoffAfter";
            this.btnChangeTurnoffAfter.Size = new System.Drawing.Size(75, 23);
            this.btnChangeTurnoffAfter.TabIndex = 6;
            this.btnChangeTurnoffAfter.Text = "Change";
            this.btnChangeTurnoffAfter.UseVisualStyleBackColor = true;
            this.btnChangeTurnoffAfter.Click += new System.EventHandler(this.btnChangeTurnoffAfter_Click);
            // 
            // textBoxTurnoffAfter
            // 
            this.textBoxTurnoffAfter.Location = new System.Drawing.Point(310, 71);
            this.textBoxTurnoffAfter.Name = "textBoxTurnoffAfter";
            this.textBoxTurnoffAfter.Size = new System.Drawing.Size(100, 20);
            this.textBoxTurnoffAfter.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "2) Turn off display after AC Power Value";
            // 
            // btnChangeSleepAfter
            // 
            this.btnChangeSleepAfter.Location = new System.Drawing.Point(432, 40);
            this.btnChangeSleepAfter.Name = "btnChangeSleepAfter";
            this.btnChangeSleepAfter.Size = new System.Drawing.Size(75, 23);
            this.btnChangeSleepAfter.TabIndex = 3;
            this.btnChangeSleepAfter.Text = "Change";
            this.btnChangeSleepAfter.UseVisualStyleBackColor = true;
            this.btnChangeSleepAfter.Click += new System.EventHandler(this.btnChangeSleepAfter_Click);
            // 
            // textBoxSleepAfter
            // 
            this.textBoxSleepAfter.Location = new System.Drawing.Point(310, 42);
            this.textBoxSleepAfter.Name = "textBoxSleepAfter";
            this.textBoxSleepAfter.Size = new System.Drawing.Size(100, 20);
            this.textBoxSleepAfter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "1) Sleep After AC Power Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Power Config Value";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 488);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Board";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSystemInfo.ResumeLayout(false);
            this.tabCertificateInfo.ResumeLayout(false);
            this.tabConfiguration.ResumeLayout(false);
            this.tabConfiguration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSystemInfo;
        private System.Windows.Forms.TabPage tabCertificateInfo;
        private System.Windows.Forms.TabPage tabConfiguration;
        private System.Windows.Forms.ListView lstDisplayHardware;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewCertificate;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangeSleepAfter;
        private System.Windows.Forms.TextBox textBoxSleepAfter;
        private System.Windows.Forms.Button btnChangeTurnoffAfter;
        private System.Windows.Forms.TextBox textBoxTurnoffAfter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckPort;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPortQueryValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.ListView listViewPrograms;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnGetPrograms;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbTimeZone;
        private System.Windows.Forms.Button btnChangeTimeZone;
        private System.Windows.Forms.Label lblCurrentTimeZone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDisableScreenSaver;
        private System.Windows.Forms.Button btnEnableScreenSaver;
        private System.Windows.Forms.Button btnAutoLoginEnable;
        private System.Windows.Forms.Button btnAutoLoginDisable;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAutoLoginPassword;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAutoLoginUserName;
    }
}