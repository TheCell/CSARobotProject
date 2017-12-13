using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace MovementServer
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(HttpServer.HttpServer.StartListening).Start();
			
            var listen = new TcpListener(IPAddress.Any, 1337);
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