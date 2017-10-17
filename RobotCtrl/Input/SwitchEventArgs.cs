using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotCtrl.Input
{
    public class SwitchEventArgs : EventArgs
    {
        public bool State { get; set; }
    }
}
