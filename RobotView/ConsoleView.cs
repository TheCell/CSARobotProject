using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;
using RobotCtrl.Input;
using RobotCtrl.Output;

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
                var keyValuePair = value[0];
                switchView1.Switch = keyValuePair.Key;
                ledView1.Led = keyValuePair.Value;

                keyValuePair = value[1];
                switchView2.Switch = keyValuePair.Key;
                ledView2.Led = keyValuePair.Value;

                keyValuePair = value[2];
                switchView3.Switch = keyValuePair.Key;
                ledView3.Led = keyValuePair.Value;

                keyValuePair = value[3];
                switchView4.Switch = keyValuePair.Key;
                ledView4.Led = keyValuePair.Value;
            }
        }
    }
}