namespace OTMDataSerial
{
	partial class FormOTMData
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOTMData));
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			btConnect = new Button();
			lblCOM = new Label();
			panel1 = new Panel();
			lblCurrentSample = new Label();
			lblCurrentCount = new Label();
			btResetRowCount = new Button();
			gBoxOption = new GroupBox();
			lblFileType = new Label();
			rbtExcel = new RadioButton();
			chbAddTime = new CheckBox();
			rbtXml = new RadioButton();
			cbxRowCount = new ComboBox();
			lblRowCount = new Label();
			cbxDataBit = new ComboBox();
			lblDataBit = new Label();
			cbxStopBit = new ComboBox();
			btDisconnect = new Button();
			btRefresh = new Button();
			lblStopBit = new Label();
			cbxParity = new ComboBox();
			lblParity = new Label();
			cbxBaudrate = new ComboBox();
			lblBaudrate = new Label();
			cbxCOM = new ComboBox();
			lblStatusContent = new Label();
			lblStatus = new Label();
			picLogo = new PictureBox();
			btSelectFolder = new Button();
			panel2 = new Panel();
			btSave = new Button();
			lblPath = new Label();
			lblWarning = new Label();
			lblWarning2 = new Label();
			panel3 = new Panel();
			notifyIcon = new NotifyIcon(components);
			panel1.SuspendLayout();
			gBoxOption.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// btConnect
			// 
			btConnect.Location = new Point(224, 11);
			btConnect.Name = "btConnect";
			btConnect.Size = new Size(91, 41);
			btConnect.TabIndex = 0;
			btConnect.Text = "Connect";
			btConnect.UseVisualStyleBackColor = true;
			btConnect.Click += btConnect_Click;
			// 
			// lblCOM
			// 
			lblCOM.AutoSize = true;
			lblCOM.Location = new Point(3, 3);
			lblCOM.Name = "lblCOM";
			lblCOM.Size = new Size(35, 15);
			lblCOM.TabIndex = 2;
			lblCOM.Text = "COM";
			// 
			// panel1
			// 
			panel1.Controls.Add(lblCurrentSample);
			panel1.Controls.Add(lblCurrentCount);
			panel1.Controls.Add(btResetRowCount);
			panel1.Controls.Add(gBoxOption);
			panel1.Controls.Add(cbxDataBit);
			panel1.Controls.Add(lblDataBit);
			panel1.Controls.Add(cbxStopBit);
			panel1.Controls.Add(btDisconnect);
			panel1.Controls.Add(btRefresh);
			panel1.Controls.Add(btConnect);
			panel1.Controls.Add(lblStopBit);
			panel1.Controls.Add(cbxParity);
			panel1.Controls.Add(lblParity);
			panel1.Controls.Add(cbxBaudrate);
			panel1.Controls.Add(lblBaudrate);
			panel1.Controls.Add(cbxCOM);
			panel1.Controls.Add(lblStatusContent);
			panel1.Controls.Add(lblStatus);
			panel1.Controls.Add(lblCOM);
			panel1.Location = new Point(14, 41);
			panel1.Name = "panel1";
			panel1.Size = new Size(326, 348);
			panel1.TabIndex = 4;
			// 
			// lblCurrentSample
			// 
			lblCurrentSample.AutoSize = true;
			lblCurrentSample.Location = new Point(256, 280);
			lblCurrentSample.Name = "lblCurrentSample";
			lblCurrentSample.Size = new Size(68, 15);
			lblCurrentSample.TabIndex = 11;
			lblCurrentSample.Text = "Sample No.";
			// 
			// lblCurrentCount
			// 
			lblCurrentCount.AutoSize = true;
			lblCurrentCount.Location = new Point(273, 296);
			lblCurrentCount.Name = "lblCurrentCount";
			lblCurrentCount.Size = new Size(29, 15);
			lblCurrentCount.TabIndex = 10;
			lblCurrentCount.Text = "N/A";
			// 
			// btResetRowCount
			// 
			btResetRowCount.Location = new Point(164, 285);
			btResetRowCount.Name = "btResetRowCount";
			btResetRowCount.Size = new Size(86, 27);
			btResetRowCount.TabIndex = 9;
			btResetRowCount.Text = "Reset Count";
			btResetRowCount.UseVisualStyleBackColor = true;
			btResetRowCount.Click += btResetRowCount_Click;
			// 
			// gBoxOption
			// 
			gBoxOption.Controls.Add(lblFileType);
			gBoxOption.Controls.Add(rbtExcel);
			gBoxOption.Controls.Add(chbAddTime);
			gBoxOption.Controls.Add(rbtXml);
			gBoxOption.Controls.Add(cbxRowCount);
			gBoxOption.Controls.Add(lblRowCount);
			gBoxOption.Location = new Point(164, 128);
			gBoxOption.Name = "gBoxOption";
			gBoxOption.Size = new Size(159, 151);
			gBoxOption.TabIndex = 8;
			gBoxOption.TabStop = false;
			gBoxOption.Text = "Option";
			// 
			// lblFileType
			// 
			lblFileType.AutoSize = true;
			lblFileType.Location = new Point(6, 22);
			lblFileType.Name = "lblFileType";
			lblFileType.Size = new Size(52, 15);
			lblFileType.TabIndex = 8;
			lblFileType.Text = "File Type";
			// 
			// rbtExcel
			// 
			rbtExcel.AutoSize = true;
			rbtExcel.Checked = true;
			rbtExcel.Location = new Point(71, 22);
			rbtExcel.Name = "rbtExcel";
			rbtExcel.Size = new Size(52, 19);
			rbtExcel.TabIndex = 7;
			rbtExcel.TabStop = true;
			rbtExcel.Text = "excel";
			rbtExcel.UseVisualStyleBackColor = true;
			rbtExcel.CheckedChanged += rbtExcel_CheckedChanged;
			// 
			// chbAddTime
			// 
			chbAddTime.AutoSize = true;
			chbAddTime.Checked = true;
			chbAddTime.CheckState = CheckState.Checked;
			chbAddTime.Location = new Point(6, 73);
			chbAddTime.Name = "chbAddTime";
			chbAddTime.Size = new Size(110, 19);
			chbAddTime.TabIndex = 7;
			chbAddTime.Text = "Add Timestamp";
			chbAddTime.UseVisualStyleBackColor = true;
			// 
			// rbtXml
			// 
			rbtXml.AutoSize = true;
			rbtXml.Location = new Point(71, 39);
			rbtXml.Name = "rbtXml";
			rbtXml.Size = new Size(45, 19);
			rbtXml.TabIndex = 7;
			rbtXml.Text = "xml";
			rbtXml.UseVisualStyleBackColor = true;
			rbtXml.CheckedChanged += rbtXml_CheckedChanged;
			// 
			// cbxRowCount
			// 
			cbxRowCount.FormattingEnabled = true;
			cbxRowCount.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40" });
			cbxRowCount.Location = new Point(3, 120);
			cbxRowCount.Name = "cbxRowCount";
			cbxRowCount.Size = new Size(89, 23);
			cbxRowCount.TabIndex = 3;
			// 
			// lblRowCount
			// 
			lblRowCount.AutoSize = true;
			lblRowCount.Location = new Point(1, 102);
			lblRowCount.Name = "lblRowCount";
			lblRowCount.Size = new Size(95, 15);
			lblRowCount.TabIndex = 2;
			lblRowCount.Text = "Sample Quantity";
			// 
			// cbxDataBit
			// 
			cbxDataBit.FormattingEnabled = true;
			cbxDataBit.Items.AddRange(new object[] { "5", "6", "7", "8" });
			cbxDataBit.Location = new Point(2, 128);
			cbxDataBit.Name = "cbxDataBit";
			cbxDataBit.Size = new Size(121, 23);
			cbxDataBit.TabIndex = 5;
			// 
			// lblDataBit
			// 
			lblDataBit.AutoSize = true;
			lblDataBit.Location = new Point(2, 110);
			lblDataBit.Name = "lblDataBit";
			lblDataBit.Size = new Size(48, 15);
			lblDataBit.TabIndex = 4;
			lblDataBit.Text = "Data Bit";
			// 
			// cbxStopBit
			// 
			cbxStopBit.FormattingEnabled = true;
			cbxStopBit.Items.AddRange(new object[] { "0", "1", "1.5", "2" });
			cbxStopBit.Location = new Point(3, 240);
			cbxStopBit.Name = "cbxStopBit";
			cbxStopBit.Size = new Size(121, 23);
			cbxStopBit.TabIndex = 3;
			// 
			// btDisconnect
			// 
			btDisconnect.Location = new Point(224, 66);
			btDisconnect.Name = "btDisconnect";
			btDisconnect.Size = new Size(91, 41);
			btDisconnect.TabIndex = 0;
			btDisconnect.Text = "Disconnect";
			btDisconnect.UseVisualStyleBackColor = true;
			btDisconnect.Click += btDisconnect_Click;
			// 
			// btRefresh
			// 
			btRefresh.Location = new Point(130, 21);
			btRefresh.Name = "btRefresh";
			btRefresh.Size = new Size(27, 23);
			btRefresh.TabIndex = 0;
			btRefresh.Text = "↻";
			btRefresh.UseVisualStyleBackColor = true;
			btRefresh.Click += btRefresh_Click;
			// 
			// lblStopBit
			// 
			lblStopBit.AutoSize = true;
			lblStopBit.Location = new Point(3, 222);
			lblStopBit.Name = "lblStopBit";
			lblStopBit.Size = new Size(48, 15);
			lblStopBit.TabIndex = 2;
			lblStopBit.Text = "Stop Bit";
			// 
			// cbxParity
			// 
			cbxParity.FormattingEnabled = true;
			cbxParity.Items.AddRange(new object[] { "None", "Odd", "Even", "Mark", "Space" });
			cbxParity.Location = new Point(3, 181);
			cbxParity.Name = "cbxParity";
			cbxParity.Size = new Size(121, 23);
			cbxParity.TabIndex = 3;
			// 
			// lblParity
			// 
			lblParity.AutoSize = true;
			lblParity.Location = new Point(3, 163);
			lblParity.Name = "lblParity";
			lblParity.Size = new Size(37, 15);
			lblParity.TabIndex = 2;
			lblParity.Text = "Parity";
			// 
			// cbxBaudrate
			// 
			cbxBaudrate.FormattingEnabled = true;
			cbxBaudrate.Items.AddRange(new object[] { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "128000", "256000 " });
			cbxBaudrate.Location = new Point(3, 72);
			cbxBaudrate.Name = "cbxBaudrate";
			cbxBaudrate.Size = new Size(121, 23);
			cbxBaudrate.TabIndex = 3;
			// 
			// lblBaudrate
			// 
			lblBaudrate.AutoSize = true;
			lblBaudrate.Location = new Point(3, 54);
			lblBaudrate.Name = "lblBaudrate";
			lblBaudrate.Size = new Size(54, 15);
			lblBaudrate.TabIndex = 2;
			lblBaudrate.Text = "Baudrate";
			// 
			// cbxCOM
			// 
			cbxCOM.FormattingEnabled = true;
			cbxCOM.Location = new Point(3, 21);
			cbxCOM.Name = "cbxCOM";
			cbxCOM.Size = new Size(121, 23);
			cbxCOM.TabIndex = 3;
			// 
			// lblStatusContent
			// 
			lblStatusContent.AutoSize = true;
			lblStatusContent.Location = new Point(4, 314);
			lblStatusContent.Name = "lblStatusContent";
			lblStatusContent.Size = new Size(88, 15);
			lblStatusContent.TabIndex = 2;
			lblStatusContent.Text = "Please Connect";
			// 
			// lblStatus
			// 
			lblStatus.AutoSize = true;
			lblStatus.Location = new Point(3, 300);
			lblStatus.Name = "lblStatus";
			lblStatus.Size = new Size(42, 15);
			lblStatus.TabIndex = 2;
			lblStatus.Text = "Status:";
			// 
			// picLogo
			// 
			picLogo.Enabled = false;
			picLogo.Image = AirGauge_OTM.Properties.Resources.LOGO_OT_MOTOR_REMOVED_BG;
			picLogo.Location = new Point(271, 0);
			picLogo.Name = "picLogo";
			picLogo.Size = new Size(52, 46);
			picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			picLogo.TabIndex = 9;
			picLogo.TabStop = false;
			// 
			// btSelectFolder
			// 
			btSelectFolder.Location = new Point(4, 12);
			btSelectFolder.Name = "btSelectFolder";
			btSelectFolder.Size = new Size(88, 23);
			btSelectFolder.TabIndex = 5;
			btSelectFolder.Text = "Select Folder";
			btSelectFolder.UseVisualStyleBackColor = true;
			btSelectFolder.Click += btSelectFolder_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(btSave);
			panel2.Controls.Add(picLogo);
			panel2.Controls.Add(lblPath);
			panel2.Controls.Add(btSelectFolder);
			panel2.Location = new Point(14, 395);
			panel2.Name = "panel2";
			panel2.Size = new Size(326, 83);
			panel2.TabIndex = 6;
			// 
			// btSave
			// 
			btSave.Location = new Point(271, 52);
			btSave.Name = "btSave";
			btSave.Size = new Size(51, 23);
			btSave.TabIndex = 10;
			btSave.Text = "Save";
			btSave.UseVisualStyleBackColor = true;
			btSave.Click += button1_Click;
			// 
			// lblPath
			// 
			lblPath.AutoSize = true;
			lblPath.Location = new Point(4, 47);
			lblPath.Name = "lblPath";
			lblPath.Size = new Size(23, 15);
			lblPath.TabIndex = 6;
			lblPath.Text = "D:\\";
			// 
			// lblWarning
			// 
			lblWarning.AutoSize = true;
			lblWarning.ForeColor = Color.Red;
			lblWarning.Location = new Point(6, 3);
			lblWarning.Name = "lblWarning";
			lblWarning.Size = new Size(277, 15);
			lblWarning.TabIndex = 2;
			lblWarning.Text = "DO NOT TURN OFF - COLLECTING AIRGAUGE DATA";
			// 
			// lblWarning2
			// 
			lblWarning2.AutoSize = true;
			lblWarning2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
			lblWarning2.ForeColor = Color.Red;
			lblWarning2.Location = new Point(6, 22);
			lblWarning2.Name = "lblWarning2";
			lblWarning2.Size = new Size(316, 15);
			lblWarning2.TabIndex = 2;
			lblWarning2.Text = "KHÔNG ĐƯỢC TẮT - CHƯƠNG TRÌNH DỮ LIỆU AIRGAUGE";
			// 
			// panel3
			// 
			panel3.Controls.Add(lblWarning);
			panel3.Controls.Add(lblWarning2);
			panel3.Location = new Point(14, 2);
			panel3.Name = "panel3";
			panel3.Size = new Size(326, 39);
			panel3.TabIndex = 7;
			// 
			// notifyIcon
			// 
			notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
			notifyIcon.Text = "AirGageOTM";
			notifyIcon.Visible = true;
			notifyIcon.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
			// 
			// FormOTMData
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(355, 489);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "FormOTMData";
			Text = "Air Gauge OTM";
			Load += FormOTMData_Load;
			Resize += FormOTMData_Resize;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			gBoxOption.ResumeLayout(false);
			gBoxOption.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Button btConnect;
		private Label lblCOM;
		private Panel panel1;
		private ComboBox cbxStopBit;
		private Button btDisconnect;
		private Label lblStopBit;
		private ComboBox cbxParity;
		private Label lblParity;
		private ComboBox cbxBaudrate;
		private Label lblBaudrate;
		private ComboBox cbxCOM;
		private Label lblStatus;
		private Button btRefresh;
		private ComboBox cbxDataBit;
		public Label lblDataBit;
		private Label lblStatusContent;
		private Button btSelectFolder;
		private Panel panel2;
		private Label lblPath;
		private CheckBox chbAddTime;
		private RadioButton rbtExcel;
		private RadioButton rbtXml;
		private GroupBox gBoxOption;
		private Label lblFileType;
		private Label lblWarning;
		private Label lblWarning2;
		private Panel panel3;
		private PictureBox picLogo;
		private Label lblRowCount;
		private ComboBox cbxRowCount;
		private Button btResetRowCount;
		private Label lblCurrentCount;
		private Label lblCurrentSample;
		private Button btSave;
		private NotifyIcon notifyIcon;
	}
}