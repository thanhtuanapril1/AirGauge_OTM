using OfficeOpenXml;
using System.Configuration;
using System.IO.Ports;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace OTMDataSerial
{
	public partial class FormOTMData : Form
	{
		Configuration Config;
		ClassSerial classSerial = new ClassSerial();
		SerialPort myPort = new SerialPort();

		string selectedFolderPath;
		bool saveToExcel = true; // Flag to indicate whether to save to Excel
		string data = "";
		string endChar1;
		string endChar2;
		string endChar3;
		int numberRows;
		int rowCounter = 0;
		public FormOTMData()
		{
			InitializeComponent();
			classSerial.RefreshPortList(myPort, cbxCOM);
			try
			{
				// Get the path for the custom configuration file in the %APPDATA% folder
				string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string configPath = Path.Combine(appDataPath, "AirGageOTM", "App.config");

				// Load the configuration settings from the custom configuration file
				if (File.Exists(configPath))
				{
					ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap { ExeConfigFilename = configPath };
					Config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
				}
				else
				{
					lblStatusContent.Text = "Configuration file not found.";
					//Use App.config in Application folder
					Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
				}

			}
			catch (Exception ex)
			{
				lblStatusContent.Text = ex.Message;
			}

		}
		private void FormOTMData_Load(object sender, EventArgs e)
		{
			string comPort = Config.AppSettings.Settings["COMPort"].Value;
			string baudRate = Config.AppSettings.Settings["BaudRate"].Value;
			string dataBit = Config.AppSettings.Settings["DataBit"].Value;
			string parity = Config.AppSettings.Settings["Parity"].Value;
			string stopBits = Config.AppSettings.Settings["StopBits"].Value;
			string fileType = Config.AppSettings.Settings["FileType"].Value;
			string checkBoxAddTime = Config.AppSettings.Settings["AddTime"].Value;
			string path = Config.AppSettings.Settings["Path"].Value;
			numberRows = int.Parse(Config.AppSettings.Settings["RowCount"].Value);
			string warningVisible = Config.AppSettings.Settings["WarningVisible"].Value;
			endChar1 = Config.AppSettings.Settings["EndLineCharacter1"].Value;
			endChar2 = Config.AppSettings.Settings["EndLineCharacter2"].Value;
			endChar3 = Config.AppSettings.Settings["EndLineCharacter3"].Value;

			if (fileType == "excel" || fileType == "Excel")
			{
				saveToExcel = true;
				rbtExcel.Checked = true;
				rbtXml.Checked = false;
			}
			else
			{
				saveToExcel = false;
				rbtExcel.Checked = false;
				rbtXml.Checked = true;
			}

			if (checkBoxAddTime == "true") chbAddTime.Checked = true;
			else chbAddTime.Checked = false;

			if (warningVisible == "true") panel3.Visible = true;
			else panel3.Visible = false;

			cbxCOM.Text = comPort;
			cbxBaudrate.Text = baudRate;
			cbxDataBit.Text = dataBit;
			cbxParity.Text = parity;
			cbxStopBit.Text = stopBits;
			lblPath.Text = path;
			cbxRowCount.Text = numberRows.ToString();

			btConnect_Click(null, null);

			//Hide this Application if set True in App.config
			bool hideApplication = bool.Parse(Config.AppSettings.Settings["HideApp"].Value);
			if (hideApplication)
			{
				this.ShowInTaskbar = false;
				this.Hide();
			}
		}

		private void btRefresh_Click(object sender, EventArgs e)
		{
			classSerial.RefreshPortList(myPort, cbxCOM);
		}

		private void btSelectFolder_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					// Get the selected folder path
					selectedFolderPath = folderBrowserDialog.SelectedPath;

					// Update a label or textbox to display the selected folder
					lblPath.Text = selectedFolderPath;
				}
			}
		}

		private void btDisconnect_Click(object sender, EventArgs e)
		{
			try
			{
				// Unsubscribe from the DataReceived event to stop receiving data
				myPort.DataReceived -= SerialPort_DataReceived;

				myPort.Close();
				myPort.Dispose();

				//Interface
				if (!myPort.IsOpen)
				{
					btConnect.Enabled = true;
					btDisconnect.Enabled = false;
					cbxCOM.Enabled = true;
					cbxBaudrate.Enabled = true;
					cbxDataBit.Enabled = true;
					cbxParity.Enabled = true;
					cbxStopBit.Enabled = true;
					btSelectFolder.Enabled = true;
					chbAddTime.Enabled = true;
					gBoxOption.Enabled = true;
					picLogo.Enabled = true;
					btSave.Enabled = true;


					lblStatusContent.Text = "Disconnected";
				}
			}
			catch (Exception ex)
			{
				lblStatusContent.Text = ex.Message;
			}
		}

		private void btConnect_Click(object sender, EventArgs e)
		{
			try
			{
				// Set up the SerialPort properties
				myPort.PortName = cbxCOM.Text;
				myPort.BaudRate = int.Parse(cbxBaudrate.Text);
				myPort.Parity = cbxParity.Text == "None" ? (Parity)0 :
								cbxParity.Text == "Odd" ? (Parity)1 :
								cbxParity.Text == "Even" ? (Parity)2 :
								cbxParity.Text == "Mark" ? (Parity)3 :
															(Parity)4;
				myPort.StopBits = (StopBits)int.Parse(cbxStopBit.Text == "1.5" ? "3" : cbxStopBit.Text);

				myPort.Open();
				myPort.DiscardInBuffer(); // Clear the input buffer

				if (myPort.IsOpen)
				{

					//Interface
					btConnect.Enabled = false;
					btDisconnect.Enabled = true;
					cbxCOM.Enabled = false;
					cbxBaudrate.Enabled = false;
					cbxDataBit.Enabled = false;
					cbxParity.Enabled = false;
					cbxStopBit.Enabled = false;
					btSelectFolder.Enabled = false;
					chbAddTime.Enabled = false;
					gBoxOption.Enabled = false;
					picLogo.Enabled = false;
					btSave.Enabled = false;

					lblStatusContent.Text = "Connected";
				}
				else { lblStatusContent.Text = "Please connect"; }


				// Subscribe to the DataReceived event
				myPort.DataReceived += SerialPort_DataReceived;
			}
			catch (Exception ex)
			{
				lblStatusContent.Text = ex.Message;
			}
		}

		private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			// Data is received from the serial port
			string receivedData = myPort.ReadExisting();
			data = data + receivedData;
			bool containsEndChar = receivedData.Contains(endChar1)
									|| receivedData.Contains(endChar2)
									|| receivedData.Contains(endChar3);  //from App.config file
																		 //|| receivedData.Contains("\x0A")

			if (containsEndChar)
			{
				// Get the current date
				DateTime currentDate = DateTime.Now;

				// Remove ASCII control characters (STX, ETX,...)
				string pattern = "[\x00\x02\x03\x04\x05\x06\x07\x08\x09\x0A\x0B\x0C\x0D\x0E\x0F]";
				//Clean string data
				data = Regex.Replace(data, pattern, "");
				data = Regex.Replace(data, ":", " ");
				data = Regex.Replace(data, "\\s+", " ");    // Regular expression pattern to match one or more whitespace characters

				Invoke((MethodInvoker)(() => lblStatusContent.Text = data));
				//Add time if needed
				if (chbAddTime.Checked)
				{
					data = currentDate.ToString("yyyy-MM-dd HH:mm:ss") + " " + data;
				}

				string otmDataSaveFolder;
				if (!string.IsNullOrEmpty(selectedFolderPath))
				{
					// Create a folder named "OTM_DataSave" if it doesn't exist
					otmDataSaveFolder = Path.Combine(selectedFolderPath, "OTM_DataSave");
				}
				else
				{
					// Create a folder named "OTM_DataSave" if it doesn't exist
					otmDataSaveFolder = Path.Combine(lblPath.Text, "OTM_DataSave");
				}
				Directory.CreateDirectory(otmDataSaveFolder);

				// Create a filename with the current date's timestamp
				string fileExtension = saveToExcel ? ".xlsx" : ".xml";
				string fileName = "ReceivedData_" + currentDate.ToString("yyyyMMdd") + fileExtension;

				// Combine the folder path and filename to create the full path
				string fullPath = Path.Combine(otmDataSaveFolder, fileName);

				if (rowCounter % numberRows == 0)
				{
					rowCounter = 0;
					if (saveToExcel)
					{
						SaveDataToExcel(fullPath, "");
					}
					else
					{
						AppendDataToXMLFile(fullPath, "");
					}
				}

				if (saveToExcel)
				{
					SaveDataToExcel(fullPath, data);
				}
				else
				{
					AppendDataToXMLFile(fullPath, data);
				}

				rowCounter++;
				Invoke((MethodInvoker)(() => lblCurrentCount.Text = rowCounter.ToString()));
				//Reset received data
				data = "";
			}

		}
		private void SaveDataToExcel(string filePath, string data)
		{
			try
			{
				using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
				{
					var currentDate = DateTime.Now;
					var worksheetName = "Data_" + currentDate.ToString("yyyyMMdd");

					// Check if a worksheet with the same name exists
					var existingWorksheet = package.Workbook.Worksheets.FirstOrDefault(ws => ws.Name == worksheetName);

					// If the worksheet for the current day doesn't exist, create a new one
					if (existingWorksheet == null)
					{
						var worksheet = package.Workbook.Worksheets.Add(worksheetName);

						// Split the data into rows using a line break as the delimiter
						string[] rows = data.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

						// Split each row into columns using both space (' ') and comma (',') as delimiters
						for (int row = 1; row <= rows.Length; row++)
						{
							// Split the row using space (' ') and comma (',') as delimiters
							string[] rowParts = rows[row - 1].Split(new[] { ' ', ',' }, StringSplitOptions.None);

							// Write the row parts into separate columns
							for (int col = 1; col <= rowParts.Length; col++)
							{
								worksheet.Cells[row, col].Value = rowParts[col - 1];
							}
						}
					}
					else
					{
						// Find the first available row in the existing worksheet
						int row = existingWorksheet.Dimension != null ? existingWorksheet.Dimension.End.Row + 1 : 1;

						// Split the data into columns using both space (' ') and comma (',') as delimiters
						string[] columns = data.Split(new[] { ' ', ',' }, StringSplitOptions.None);

						// Write each part of the split data into separate columns
						for (int col = 1; col <= columns.Length; col++)
						{
							existingWorksheet.Cells[row, col].Value = columns[col - 1];
						}
					}

					package.Save();
				}
			}
			catch (Exception ex)
			{
				Invoke((MethodInvoker)(() => lblStatusContent.Text = ex.Message));
			}
		}

		private void AppendDataToXMLFile(string filePath, string data)
		{
			// Create an XML element for the received data
			XmlDocument xmlDoc = new XmlDocument();
			XmlElement dataElement = xmlDoc.CreateElement("ReceivedData");
			dataElement.InnerText = data;

			if (!File.Exists(filePath))
			{
				// If the file doesn't exist, create a new XML document
				XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
				xmlDoc.AppendChild(xmlDeclaration);
				XmlElement root = xmlDoc.CreateElement("Data");
				xmlDoc.AppendChild(root);
				root.AppendChild(dataElement);
			}
			else
			{
				// If the file exists, load the existing XML document
				xmlDoc.Load(filePath);

				// Append the data as a new element
				XmlNode root = xmlDoc.SelectSingleNode("Data");
				root.AppendChild(dataElement);
			}

			// Save the XML data to the file, appending the new data
			xmlDoc.Save(filePath);
		}

		private void rbtExcel_CheckedChanged(object sender, EventArgs e)
		{
			saveToExcel = true; // Select Excel format
		}

		private void rbtXml_CheckedChanged(object sender, EventArgs e)
		{
			saveToExcel = false; // Select XML format
		}

		private void btResetRowCount_Click(object sender, EventArgs e)
		{
			rowCounter = 0;
			Invoke((MethodInvoker)(() => lblCurrentCount.Text = rowCounter.ToString()));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				Config.AppSettings.Settings["COMPort"].Value = cbxCOM.Text;
				Config.AppSettings.Settings["BaudRate"].Value = cbxBaudrate.Text;
				Config.AppSettings.Settings["DataBit"].Value = cbxDataBit.Text;
				Config.AppSettings.Settings["Parity"].Value = cbxParity.Text;
				Config.AppSettings.Settings["StopBits"].Value = cbxStopBit.Text;
				Config.AppSettings.Settings["FileType"].Value = rbtExcel.Checked == true ? "true" : "false";
				Config.AppSettings.Settings["AddTime"].Value = chbAddTime.Checked == true ? "true" : "false";
				Config.AppSettings.Settings["RowCount"].Value = cbxRowCount.Text;
				Config.AppSettings.Settings["Path"].Value = lblPath.Text;

				Config.Save(ConfigurationSaveMode.Modified);
				ConfigurationManager.RefreshSection("appSettings");
				MessageBox.Show("Save Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				Invoke((MethodInvoker)(() => lblStatusContent.Text = ex.Message));
			}
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
		}

		private void FormOTMData_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				this.Hide();
			}
		}
	}
}