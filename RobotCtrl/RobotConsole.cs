using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotCtrl.Input;
using RobotCtrl.Output;

namespace RobotCtrl
{
    public class RobotConsole
    {
        private readonly IDictionary<int, KeyValuePair<Switch, Led>> switchLedMap;

        public RobotConsole()
        {
            this.switchLedMap = new Dictionary<int, KeyValuePair<Switch, Led>>();

            for (var index = 0; index < 4; index++)
            {
                this.switchLedMap.Add(index, new KeyValuePair<Switch, Led>(new Switch(), new Led()));
                this.switchLedMap[index].Key.SwitchStateChangedEventHandler += OnSwitchStateChanged;
            }
        }

        public KeyValuePair<Switch, Led> this[int index] => this.switchLedMap[index];

        private void OnSwitchStateChanged(object sender, SwitchEventArgs args)
        {
            var _switch = (Switch) sender;
            foreach (var keyValuePair in this.switchLedMap)
            {
                KeyValuePair<Switch, Led> pair = keyValuePair.Value;
                if (pair.Key.Equals(_switch))
                {
                    pair.Value.OnLedStateChanged(args.State);
                }
            }
        }
    }
}