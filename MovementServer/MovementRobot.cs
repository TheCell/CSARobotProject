using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using RobotCtrl;

namespace MovementServer
{
    class MovementRobot
    {
        private TcpClient tcpClient;

        public MovementRobot(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;
            new Robot();
        }

        public void StartMoving()
        {
            
        }

    }
}
