using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UdpAppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient(3535);
            udpClient.JoinMulticastGroup(IPAddress.Parse("224.1.8.5"), 50);

            IPEndPoint endPoint = null;
            byte[] receiveData = udpClient.Receive(ref endPoint);

            Console.WriteLine(Encoding.Default.GetString(receiveData));
            Process.Start(Encoding.Default.GetString(receiveData).Substring(0,8),Encoding.Default.GetString(receiveData).Substring(8));
            
            udpClient.Close();
            Console.ReadLine();
        }
    }
}