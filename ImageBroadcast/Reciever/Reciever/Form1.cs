using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Reciever
{
    public partial class Form1 : Form
    {

        UdpClient udp;
        Thread receiveThread;
        DateTime lastReceivedTime = DateTime.Now;
        bool isStreaming = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Receiver started...");
            StartReceiver();

            Thread monitorThread = new Thread(MonitorStream);
            monitorThread.IsBackground = true;
            monitorThread.Start();
        }

        private void StartReceiver()
        {
            udp = new UdpClient(5000); // must match sender port

            receiveThread = new Thread(ReceiveData);
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        private void MonitorStream()
        {
            while (true)
            {
                Thread.Sleep(1000); // check every 1 sec

                if (isStreaming && (DateTime.Now - lastReceivedTime).TotalSeconds > 3)
                {
                    isStreaming = false;

                    BeginInvoke(new Action(() =>
                    {
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                            pictureBox1.Image = null;
                        }

                        MessageBox.Show("Streaming has been stopped");
                    }));
                }
            }
        }

        private void ReceiveData()
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                try
                {
                    byte[] data = udp.Receive(ref ep);

                    lastReceivedTime = DateTime.Now;
                    isStreaming = true;

                    Console.WriteLine($"Received: {data.Length} bytes");

                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        Image img = Image.FromStream(ms);

                        if (pictureBox1.IsHandleCreated)
                        {
                            BeginInvoke(new Action(() =>
                            {
                                if (pictureBox1.Image != null)
                                    pictureBox1.Image.Dispose();

                                pictureBox1.Image = new Bitmap(img);
                            }));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            udp?.Close();
            receiveThread?.Abort();
            base.OnFormClosing(e);
        }
         
    }
}