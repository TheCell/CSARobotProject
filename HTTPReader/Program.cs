using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace HTTPReader
{
	class Program
	{
		static void Main(string[] args)
		{
			var tcpClient = new TcpClient("192.168.1.4", 8080);
			try
			{
				using (NetworkStream networkStream = tcpClient.GetStream())
				{
					using (StreamReader streamReader = new StreamReader(networkStream))
					{
						var line = "";

						Console.WriteLine("Reading from Robot");
						while ((line = streamReader.ReadLine()) != null)
						{
							Console.WriteLine(line);
						}
						Console.WriteLine("Finished reading from Robot");
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
