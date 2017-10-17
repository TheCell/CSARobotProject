using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotCtrl.Output
{
    public class LedEventArgs : EventArgs
    {
        public bool State { get; set; }
    }
}
