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
    public partial class SwitchView : UserControl
    {
        private bool state;
        private Switch _switch;

        public SwitchView()
        {
            InitializeComponent();
            State = false;
        }

        public bool State
        {
            set
            {
                this.state = value;
                pictureBox1.Image = this.state ? Resource.SwitchOn : Resource.SwitchOff;
            }
            get { return this.state; }
        }

        public Switch Switch
        {
            set
            {
				if (_switch != null)
				{
					this._switch.SwitchStateChanged -= OnSwitchStateChangedEvent;
				}

                this._switch = value;
				if (_switch != null)
				{
					this._switch.SwitchStateChanged += OnSwitchStateChangedEvent;
				}
			}
            get { return _switch; }
        }

        private void OnSwitchStateChangedEvent(object sender, SwitchEventArgs args)
        {
			if (InvokeRequired) // Pr�ft ob Thread != GUI-Thread
			{
				// Synchronisierung notwendig
				Invoke(new EventHandler<SwitchEventArgs>(OnSwitchStateChangedEvent), sender, args);
			}
			else
			{
				// Synchronisierung nicht notwendig
				State = args.SwitchEnabled;
			}
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
			System.Diagnostics.Debug.WriteLine(e);
			Switch.OnSwitchStateChanged(new SwitchEventArgs(Switches.Switch1, !State));
        }
    }
}