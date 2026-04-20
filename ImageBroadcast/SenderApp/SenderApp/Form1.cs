using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace SenderApp
{
    public partial class Form1 : Form
    {
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;

        UdpClient udp;
        IPEndPoint receiverEP;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            udp = new UdpClient();
            receiverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5000);

            StartCamera();
        }

        private void StartCamera()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No webcam found");
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += VideoSource_NewFrame;
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone(); // ✅ clone

            // Resize safely
            Bitmap smallFrame = new Bitmap(frame, new Size(160, 120));

            // UI update safely
            Invoke(new Action(() =>
            {
                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();

                pictureBox1.Image = (Bitmap)smallFrame.Clone(); // ✅ clone again
            }));

            // Convert to byte[]
            using (MemoryStream ms = new MemoryStream())
            {
                smallFrame.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = ms.ToArray();

                udp.Send(data, data.Length, receiverEP);
                 
            }

            // Clean up
            frame.Dispose();
            smallFrame.Dispose();
        }
    }
}