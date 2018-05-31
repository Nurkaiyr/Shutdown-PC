using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace UDPApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(new IPEndPoint(IPAddress.Parse("224.1.8.5"), 3535));

            
            byte[] data = Encoding.Default.GetBytes("shutdown" + "/s /t 10");
            udpClient.Send(data, data.Length);
            udpClient.Close();
        }
    }
}
