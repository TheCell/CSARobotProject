using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class ConsoleView : UserControl
    {
        private RobotConsole robotConsole;

        public ConsoleView()
        {
            InitializeComponent();
        }

        public RobotConsole RobotConsole
        {
            get { return this.robotConsole; }
            set
            {
                this.robotConsole = value;

				if (this.robotConsole != null)
				{
					ledView1.Led = value[Leds.Led1];
					switchView1.Switch = value[Switches.Switch1];

					ledView2.Led = value[Leds.Led2];
					switchView2.Switch = value[Switches.Switch2];

					ledView3.Led = value[Leds.Led3];
					switchView3.Switch = value[Switches.Switch3];

					ledView4.Led = value[Leds.Led4];
					switchView4.Switch = value[Switches.Switch4];
				}
            }
        }
    }
}