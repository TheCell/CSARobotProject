using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using MovementRobot;
using RobotCtrl;

namespace MovementServer
{
    class MovementRobot
    {
        private TcpClient tcpClient;
        private readonly Robot robot;
        private readonly Drive drive;
        private const float Speed = 0.5f;
        private const float Acceleration = 0.3f;

        public MovementRobot(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;
            this.robot = new Robot();
            this.drive = this.robot.Drive;
        }

        public void StartMoving()
        {
            var streamReader = new StreamReader(this.tcpClient.GetStream());
            var savePositionToFile = new SavePositionToFile(drive);
            new Thread(savePositionToFile.StartWriting).Start();
            var line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                if (line.Equals("Start"))
                {
                    this.drive.Power = true;
                } else if (line.StartsWith("TrackLine "))
                {
                    var value = int.Parse(line.Replace("TrackLine ", ""));
                    this.drive.RunLine(5, Speed, Acceleration);
                }
            }
            while (!this.drive.Done)
            {
                Thread.Sleep(100);
            }
        }
    }
}