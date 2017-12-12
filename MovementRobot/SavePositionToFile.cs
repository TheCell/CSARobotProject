using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RobotCtrl;

namespace MovementRobot
{
    public class SavePositionToFile
    {

        private Drive drive;

        public SavePositionToFile(Drive drive)
        {
            this.drive = drive;
        }

        public void StartWriting()
        {
            this.ClearFile();
            // TODO: save the current position to the file. once every 200ms
        }

        private void ClearFile()
        {

        }
    }
}
