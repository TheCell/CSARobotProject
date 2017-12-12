using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace HttpServer
{
    class TcpHandler
    {
        private readonly TcpClient client;
        private readonly string fileBuffer;

        public TcpHandler(TcpClient client)
        {
            this.client = client;
            var streamReader = File.OpenText("test.csv"); // TODO: choose file location
            this.fileBuffer = streamReader.ReadToEnd();
        }

        public void SendLog()
        {
            var streamWriter = new StreamWriter(this.client.GetStream());
            try
            {
                streamWriter.WriteLine("HTTP/1.1 200 OK");
                streamWriter.WriteLine("Content-Length: " + this.fileBuffer.Length);
                streamWriter.WriteLine("Content-Type: application/force-download");
                streamWriter.WriteLine("Content-Transfer-Encoding: binary");
                streamWriter.WriteLine("Content-Disposition: attachment; filename=\"track.csv\"");
                streamWriter.WriteLine();
                streamWriter.Write(this.fileBuffer);
                streamWriter.Flush();
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                client.Close();
            }
        }
    }
}
