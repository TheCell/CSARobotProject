using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotCtrl.Output
{
    public class Led
    {
        public delegate void LedStateChanged(object sender, LedEventArgs args);

        public event LedStateChanged LedStateChangedEventHandler;

        public void OnLedStateChanged(bool state)
        {
            if (LedStateChangedEventHandler != null)
            {
                LedStateChangedEventHandler(this, new LedEventArgs() {State = state});
            }
        }
    }
}