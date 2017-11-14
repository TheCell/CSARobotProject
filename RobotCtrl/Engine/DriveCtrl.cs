using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RobotCtrl.Engine
{
    public class DriveCtrl : IDisposable
    {
        #region members

        private int ioAddress;

        #endregion


        #region constructor & destructor

        public DriveCtrl(int IOAddress)
        {
            this.ioAddress = IOAddress;
            Reset();
        }

        public void Dispose()
        {
            Reset();
        }

        #endregion


        #region properties

        /// <summary>
        /// Schaltet die Stromversorgung der beiden Motoren ein oder aus.
        /// </summary>
        public bool Power
        {
            set { DriveState = (value) ? DriveState | 0x03 : DriveState & ~0x03; }
        }


        /// <summary>
        /// Liefert den Status ob der rechte Motor ein-/ausgeschaltet ist bzw. schaltet den rechten Motor ein-/aus.
        /// Die Information dazu steht im Bit0 von DriveState.
        /// </summary>
        public bool PowerRight
        {
            get { return (DriveState & 0x01) == 1; }
            set { DriveState = (value) ? DriveState | 0x01 : DriveState & ~0x01; }
        }


        /// <summary>
        /// Liefert den Status ob der linke Motor ein-/ausgeschaltet ist bzw. schaltet den linken Motor ein-/aus.
        /// </summary>
        public bool PowerLeft
        {
            get { return (DriveState >> 1 & 0x01) == 1; }
            set { DriveState = (value) ? DriveState | 0x02 : DriveState & ~0x02; }
        }


        /// <summary>
        /// Bietet Zugriff auf das Status-/Controlregister
        /// </summary>
        public int DriveState
        {
            get { return IOPort.Read(Constants.IODriveCtrl); }
            set { IOPort.Write(Constants.IODriveCtrl, value); }
        }

        #endregion


        #region methods

        /// <summary>
        /// Setzt die beiden Motorencontroller (LM629) zurück, 
        /// indem kurz die Reset-Leitung aktiviert wird.
        /// </summary>
        public void Reset()
        {
            IOPort.Write(ioAddress, 0x00);
            Thread.Sleep(5);
            IOPort.Write(ioAddress, 0x80);
            Thread.Sleep(5);
            IOPort.Write(ioAddress, 0x00);
            Thread.Sleep(5);
        }

        #endregion
    }
}