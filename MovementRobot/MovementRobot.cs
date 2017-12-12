using System;
using System.Collections.Generic;
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
            //TODO: read lines in file
            this.drive.Power = true;
            var savePositionToFile = new SavePositionToFile();
            new Thread(savePositionToFile.StartWriting).Start();
            this.drive.RunLine(5, Speed, Acceleration);
            while (!this.drive.Done)
            {
                Thread.Sleep(100);
            }
        }

    }
}
