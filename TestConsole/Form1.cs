using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace TestConsole
{
    public partial class Form1 : Form
    {

        private RobotConsole robotConsole;

        public Form1()
        {
            InitializeComponent();

            this.robotConsole = new RobotConsole();
			consoleView1.RobotConsole = this.robotConsole;
			
			robotConsole[Switches.Switch1].SwitchStateChanged += switchStateChanged;
			robotConsole[Switches.Switch2].SwitchStateChanged += switchStateChanged;
			robotConsole[Switches.Switch3].SwitchStateChanged += switchStateChanged;
			robotConsole[Switches.Switch4].SwitchStateChanged += switchStateChanged;
		}

		void switchStateChanged(object sender, SwitchEventArgs e)
		{
			robotConsole[(Leds)(int)e.Swi].LedEnabled = e.SwitchEnabled;
		}
	}
}
