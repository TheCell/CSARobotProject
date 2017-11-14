using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace TestDrive
{
	public partial class Form1 : Form
	{
		private Drive drive;

		public Form1()
		{
			InitializeComponent();

			this.commonRunParameters1.SpeedChanged += CommonRunParameters1_SpeedChanged;
			this.commonRunParameters1.AccelerationChanged += CommonRunParameters1_AccelerationChanged;
			this.drive = new Drive();
			this.drive.Power = true;
			this.driveView1.Drive = drive;
			this.runLine1.Drive = drive;
			this.runArc1.Drive = drive;
			this.runTurn1.Drive = drive;

			CommonRunParameters1_AccelerationChanged(null, EventArgs.Empty);
			CommonRunParameters1_SpeedChanged(null, EventArgs.Empty);
		}

		private void CommonRunParameters1_AccelerationChanged(object sender, EventArgs e)
		{
			this.runLine1.Acceleration = this.commonRunParameters1.Acceleration;
			this.runArc1.Acceleration = this.commonRunParameters1.Acceleration;
			this.runTurn1.Acceleration = this.commonRunParameters1.Acceleration;
		}

		private void CommonRunParameters1_SpeedChanged(object sender, EventArgs e)
		{
			this.runLine1.Speed = this.commonRunParameters1.Speed;
			this.runArc1.Speed = this.commonRunParameters1.Speed;
			this.runTurn1.Speed = this.commonRunParameters1.Speed;
		}
	}
}
