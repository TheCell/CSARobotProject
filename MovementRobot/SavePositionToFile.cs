using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RobotCtrl;

namespace MovementRobot
{
    class SavePositionToFile
    {

        private Drive drive;

        public void StartWriting(Drive drive)
        {
            this.drive = drive;
            this.ClearFile();
            // TODO: save the current position to the file. once every 200ms
        }

        private void ClearFile()
        {

        }
    }
}
