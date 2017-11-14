using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;
using RobotCtrl.Engine;

namespace TestMotor
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

            DriveCtrl driveCtrl = new DriveCtrl(Constants.IODriveCtrl);
            MotorCtrl motorCtrlLeft = new MotorCtrl(Constants.IOMotorCtrlLeft);
            MotorCtrl motorCtrlRight = new MotorCtrl(Constants.IOMotorCtrlRight);

		    this.driveCtrlView.DriveCtrl = driveCtrl;
		    this.motorCtrlViewLeft.MotorCtrl = motorCtrlLeft;
		    this.motorCtrlViewRight.MotorCtrl = motorCtrlRight;
		}
	}
}
