using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

namespace SmallNetGame
{

    public class UDPserver
    {
        private UdpClient listener;
        private IPEndPoint groupEP;
        private TextBox textBox;
        private Thread recieveThread;
        private string newTextForTextBox;

        private const int listenPort = 11000;

        public void StartListener(TextBox textBox)
        {
            this.textBox = textBox;
            listener = new UdpClient(listenPort);
            groupEP = new IPEndPoint(IPAddress.Any, listenPort);

            recieveThread = new Thread(new ParameterizedThreadStart(RecieveServers));
            recieveThread.IsBackground = true;
            recieveThread.Start(Thread.CurrentThread);
        }

        private void RecieveServers(object obj) {
            bool done = false;

            List<string[]> servers = new List<string[]>();

            try {
                while (!done) {
                    byte[] bytes = listener.Receive(ref groupEP);

                    string recieved = Encoding.ASCII.GetString(bytes, 0, bytes.Length);

                    string[] recievedSplit = Regex.Split(recieved, ";");

                    //if (recievedSplit[0] == "HOST") {
                    //    if (!servers.Contains(recievedSplit)) {
                    //        servers.Add(recievedSplit);
                    //    }
                    //}

                    bool isAdded = false;
                    foreach (string[] x in servers) {
                        if (recievedSplit[1] == x[1] && recievedSplit[2] == x[2]) {
                            isAdded = true;
                        }
                    }
                    if (!isAdded) {
                        servers.Add(recievedSplit);
                    }

                    string text = string.Empty;
                    for (int i = 0; i < servers.Count; i++) {
                        text += servers[i][2] + "\n";
                    }
                    newTextForTextBox = text;

                    if (!(obj as Thread).IsAlive) {
                        Thread.CurrentThread.Abort();
                    }
                    Thread.Sleep(1);
                }
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            } finally {
                listener.Close();
            }
        }

        public void UpdateTextBox() {
            if (textBox.Text != newTextForTextBox) {
                textBox.Text = newTextForTextBox;
            }
        }
    }
}