using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SmallNetGame
{

    class UDPclient
    {
        Socket s;
        byte[] sendbuf;
        IPEndPoint ep;
        bool isSetup = false;

        public void Setup(string hostName)
        {
            string hostIp = string.Empty;
            //byte[] sendbuf = Encoding.ASCII.GetBytes(args[0]);
            IPAddress[] addresses = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            IPAddress epAddress = IPAddress.Any;
            foreach (IPAddress ip in addresses) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    hostIp = ip.ToString();
                    epAddress = ip;
                    break;
                }
            }

            if (hostIp != string.Empty) {
                s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                //IPAddress broadcast = IPAddress.Parse("192.168.0.255");
                //IPAddress broadcast = IPAddress.Parse("127.0.0.1");



                sendbuf = Encoding.ASCII.GetBytes("HOST;" + hostIp + ";" + hostName + "'s Lobby");

                ep = new IPEndPoint(epAddress, 11000);

                s.SendTo(sendbuf, ep);

                isSetup = true;
            }
        }

        public void BroadCast(Label label) {
            if (isSetup) {
                s.SendTo(sendbuf, ep);
                label.Text = "sent a message";
            }
        }
    }
}