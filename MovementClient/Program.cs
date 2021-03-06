﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MovementClient
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && File.Exists(args[0]))
            {
				var tcpClient = new TcpClient("192.168.1.4", 1337);
				try
				{
					using (NetworkStream networkStream = tcpClient.GetStream())
					{
						using (StreamWriter streamWriter = new StreamWriter(networkStream))
						{
							var streamReader = new StreamReader(args[0]);
							var line = "";

							while ((line = streamReader.ReadLine()) != null)
							{
								Console.WriteLine(line);
								streamWriter.WriteLine(line);
								streamWriter.Flush();
							}

							streamReader.Close();
							//streamWriter.Close();
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error" + ex.Message);
				}
			}
		}
    }
}