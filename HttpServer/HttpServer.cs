﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace HttpServer
{
    public class HttpServer
    {
        public static void StartListening()
        {
            var ipAddress = Dns.GetHostEntry("localhost").AddressList[0];
            var listen = new TcpListener(ipAddress, 8080);
            listen.Start();
            while (true)
            {
                Console.WriteLine("Warte auf Verbindung auf Port " + listen.LocalEndpoint + "...");
                var client = listen.AcceptTcpClient();
                Console.WriteLine("Verbindung zu " + client.Client.RemoteEndPoint);
                var tcpHandler = new TcpHandler(client);
                new Thread(tcpHandler.DoEcho).Start();
            }
        }
    }
}