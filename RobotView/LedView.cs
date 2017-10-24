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
    public partial class LedView : UserControl
    {
        private bool state;
        private Led led;

        public LedView()
        {
            InitializeComponent();
            this.State = false;
        }

        public bool State
        {
            set
            {
                this.state = value;
                pictureBox1.Image = this.state ? Resource.LedOn : Resource.LedOff;
            }
            get { return this.state; }
        }

        public Led Led
        {
            set
            {
				if (led != null)
				{
					this.led.LedStateChanged -= OnLedStateChangedEvent;
				}

				this.led = value;
				if (led != null)
				{
					this.led.LedStateChanged += OnLedStateChangedEvent;
				}
			}

            get { return this.led; }
        }

        private void OnLedStateChangedEvent(object sender, LedEventArgs args)
        {
            State = args.LedEnabled;
        }
    }
}