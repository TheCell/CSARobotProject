using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace HttpServer
{
    public class TcpHandler
    {
        private readonly TcpClient client;
        private string fileBuffer;

        public TcpHandler(TcpClient client)
        {
            this.client = client;
        }

        public void SendLog()
        {
            if (File.Exists(@"Temp\positionsLog.csv"))
            {
                var streamReader = new StreamReader(@"Temp\positionsLog.csv");
                this.fileBuffer = streamReader.ReadToEnd();
                streamReader.Close();
            }
            else
            {
                Console.WriteLine("Failed to read file.");
            }

            //Console.WriteLine(this.fileBuffer);

            Console.WriteLine("Starting to send Log");

            if (this.fileBuffer == null)
            {
                return;
            }
            var streamWriter = new StreamWriter(this.client.GetStream());
            try
            {
                streamWriter.WriteLine("HTTP/1.1 200 OK");
                streamWriter.WriteLine("Content-Length: " + this.fileBuffer.Length);
                streamWriter.WriteLine("Content-Type: text/plain");
                streamWriter.WriteLine();
                streamWriter.Write(this.fileBuffer);
                streamWriter.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                client.Close();
            }

            Console.Write("Finished send Log");

            /*
            var streamWriter = new StreamWriter(this.client.GetStream());
            streamWriter.WriteLine("HTTP/1.1 200 OK");
            streamWriter.WriteLine("Content-Length: " + this.fileBuffer.Length);
            streamWriter.WriteLine("Content-Type: application/force-download");
            streamWriter.WriteLine("Content-Transfer-Encoding: binary");
            streamWriter.WriteLine("Content-Disposition: attachment; filename=\"positionsLog.csv\"");
            streamWriter.WriteLine();
            streamWriter.Write(this.fileBuffer);
            streamWriter.Flush();
            streamWriter.Close();
            client.Close();
            */
        }
    }
}