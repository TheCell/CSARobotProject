using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestDrive
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.commonRunParameters1.SpeedChanged += CommonRunParameters1_SpeedChanged;
			this.commonRunParameters1.AccelerationChanged += CommonRunParameters1_AccelerationChanged;
		}

		private void CommonRunParameters1_AccelerationChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void CommonRunParameters1_SpeedChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}
