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
        private readonly Drive drive;
        private DateTime startTime;

        public bool IsLogging { private get; set; }


        public SavePositionToFile(Drive drive)
        {
            this.drive = drive;
            startTime = DateTime.Now;
            this.IsLogging = false;
        }

        public void StartWriting()
        {
            this.IsLogging = true;
            this.ClearFile();
            try
            {
                var sw = new StreamWriter(@"Temp\positionsLog.csv");
                sw.WriteLine("Team 02");
                while (IsLogging)
                {
                    TimeSpan timeDelta = DateTime.Now.Subtract(startTime);

                    if (timeDelta.TotalMilliseconds > 200.0f)
                    {
                        startTime = DateTime.Now;
                        string logstring = "";
                        logstring += startTime.ToString("dd/MM/yyyy-hh:mm:ss.fff");
                        logstring += ";" + drive.Position.X.ToString("0.00000");
                        logstring += ";" + drive.Position.Y.ToString("0.00000");
                        sw.WriteLine(logstring);
                        sw.Flush();
                    }
                }
                sw.Close();
                Console.WriteLine("fertig.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void ClearFile()
        {
            if (File.Exists(@"Temp\positionsLog.csv"))
            {
                FileStream fs = File.Open(@"Temp\positionsLog.csv", FileMode.Open);
                fs.SetLength(0);
                fs.Close();
            }
        }
    }
}