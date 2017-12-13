using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using MovementRobot;
using RobotCtrl;

namespace MovementRobot
{
    public class MovementRobot
    {
        private readonly TcpClient tcpClient;
        private readonly Drive drive;
        private const float Speed = 0.5f;
        private const float Acceleration = 0.3f;

        public MovementRobot(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;
            var robot = new Robot();
            this.drive = robot.Drive;
        }

        public void StartMoving()
        {
            var streamReader = new StreamReader(this.tcpClient.GetStream());
            var buffer = new LinkedList<string>();
            var line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                if (!line.Equals("Start"))
                {
                    buffer.AddLast(line);
                }
                else
                {
                    break;
                }
            }
            streamReader.Close();

            var savePositionToFile = new SavePositionToFile(drive);
            new Thread(savePositionToFile.StartWriting).Start();
            this.drive.Power = true;

            foreach (var command in buffer)
            {
                if (command.StartsWith("TrackLine "))
                {
                    var value = float.Parse(command.Replace("TrackLine ", ""));
                    this.drive.RunLine(value, Speed, Acceleration);
                }
                else if (command.StartsWith("TrackTurnLeft "))
                {
                    var value = int.Parse(command.Replace("TrackTurnLeft ", ""));
                    this.drive.RunTurn(-value, Speed, Acceleration);
                }
                else if (command.StartsWith("TrackTurnRight "))
                {
                    var value = int.Parse(command.Replace("TrackTurnRight ", ""));
                    this.drive.RunTurn(value, Speed, Acceleration);
                }
                else if (command.StartsWith("TrackArcLeft "))
                {
                    var values = (command.Replace("TrackArcLeft ", "")).Split(' ');
                    this.drive.RunArcLeft(float.Parse(values[1]), int.Parse(values[0]), Speed, Acceleration);
                }
                else if (command.StartsWith("TrackArcRight "))
                {
                    var values = (command.Replace("TrackArcRight ", "")).Split(' ');
                    this.drive.RunArcRight(float.Parse(values[1]), int.Parse(values[0]), Speed, Acceleration);
                }
                while (!this.drive.Done)
                {
                    Thread.Sleep(50);
                }
            }

            savePositionToFile.IsLogging = false;
        }
    }
}