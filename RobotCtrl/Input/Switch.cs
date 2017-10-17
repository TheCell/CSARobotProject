using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotCtrl.Input
{
    public class Switch
    {
        public delegate void SwitchStateChangedEvent(object sender, SwitchEventArgs args);

        public event SwitchStateChangedEvent SwitchStateChangedEventHandler;

        public virtual void OnSwitchStateChanged(bool state)
        {
            if (SwitchStateChangedEventHandler != null)
            {
                SwitchStateChangedEventHandler(this, new SwitchEventArgs() { State = state});
            }
        }
    }
}
