using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SmallNetGame
{

    class UDPclient
    {
        static void Main1(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //IPAddress broadcast = IPAddress.Parse("192.168.0.255");
            IPAddress broadcast = IPAddress.Parse("127.0.0.1");

            //byte[] sendbuf = Encoding.ASCII.GetBytes(args[0]);
            byte[] sendbuf = Encoding.ASCII.GetBytes("Hallo");

            IPEndPoint ep = new IPEndPoint(broadcast, 11000);

            s.SendTo(sendbuf, ep);

            Console.WriteLine("Message sent to the broadcast address");
            Console.ReadKey();
        }
    }
}