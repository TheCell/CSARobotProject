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

        private readonly RobotConsole robotConsole;

        public Form1()
        {
            InitializeComponent();
            this.robotConsole = new RobotConsole();
            consoleView1.RobotConsole = this.robotConsole;
        }
    }
}
