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
		private Robot robot;
		private Drive drive;
		private RobotConsole robotConsole;

		public Form1()
		{
			

			InitializeComponent();

			this.robot = new Robot();
			this.drive = robot.Drive;

			this.commonRunParameters1.SpeedChanged += CommonRunParameters1_SpeedChanged;
			this.commonRunParameters1.AccelerationChanged += CommonRunParameters1_AccelerationChanged;
			this.drive.Power = true;
			this.driveView1.Drive = drive;
			this.runLine1.Drive = drive;
			this.runArc1.Drive = drive;
			this.runTurn1.Drive = drive;
			this.radarView1.Radar = robot.radar;
			this.robotConsole = new RobotConsole();
			consoleView1.RobotConsole = this.robotConsole;
			
			robotConsole[Switches.Switch1].SwitchStateChanged += switchStateChanged;
			robotConsole[Switches.Switch2].SwitchStateChanged += switchStateChanged;
			robotConsole[Switches.Switch3].SwitchStateChanged += switchStateChanged;
			robotConsole[Switches.Switch4].SwitchStateChanged += switchStateChanged;

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

		void switchStateChanged(object sender, SwitchEventArgs e)
		{
			if (InvokeRequired)
			{
				Invoke(new EventHandler<SwitchEventArgs>(switchStateChanged), sender, e);
			}
			else
			{

				robotConsole[(Leds)(int)e.Swi].LedEnabled = e.SwitchEnabled;

				if ((int)e.Swi == 1 && e.SwitchEnabled)
				{
					runLine1.Start();
				}
				else if ((int)e.Swi == 2 && e.SwitchEnabled)
				{
					runArc1.Start();
				}
				else if ((int)e.Swi == 3 && e.SwitchEnabled)
				{
					runTurn1.Start();
				}
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (robot.radar.Distance < 0.3f) robot.Drive.Stop();
		}
	}
}
