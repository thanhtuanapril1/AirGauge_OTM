using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTMDataSerial
{
	internal class ClassSerial
	{
		public void RefreshPortList(SerialPort serialPort, ComboBox comboBox)
		{
			string[] ports = SerialPort.GetPortNames();

			// Clear the existing items in the ComboBox
			comboBox.Items.Clear();
			// Populate the ComboBox with the available COM ports
			comboBox.Items.AddRange(ports);
		}
	}
}
