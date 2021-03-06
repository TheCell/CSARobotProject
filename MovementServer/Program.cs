﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MovementServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var ipAddress = Dns.GetHostEntry("localhost").AddressList[0];
            var listen = new TcpListener(ipAddress, 1337);
            listen.Start();
            while (true)
            {
                Console.WriteLine("Warte auf Verbindung auf Port " + listen.LocalEndpoint + "...");
                var client = listen.AcceptTcpClient();
                Console.WriteLine("Verbindung zu " + client.Client.RemoteEndPoint);
                var movementRobot = new MovementRobot(client);
                movementRobot.StartMoving();
            }
        }
    }
}
