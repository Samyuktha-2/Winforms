using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using OpenCvSharp.Extensions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraApplcation
{
    public partial class UsingWebCam : Form
    {
        public UsingWebCam()
        {
            InitializeComponent();
        }

        VideoCapture capture;
        UdpClient udp;
        IPEndPoint recieverEp;

        private void StartServerBtn_Click(object sender, EventArgs e)
        {
            capture = new VideoCapture(0);
            udp = new UdpClient();
            recieverEp = new IPEndPoint(IPAddress.Parse("192.168.1.xx"), 5000);

            Thread t = new Thread(Stream);
            t.IsBackground = true;
            t.Start();
        }

        void Stream()
        {
            Mat frame = new Mat();
            while (true)
            {
                capture.Read(frame);

                if (frame.Empty()) continue;

                // Resize → reduce size
                Cv2.Resize(frame, frame, new OpenCvSharp.Size(320, 240));

                // Compress to JPEG (low quality)
                var imageBytes = frame.ToBytes(".jpg", new ImageEncodingParam(ImwriteFlags.JpegQuality, 50));

                // Send via UDP
                udp.Send(imageBytes, imageBytes.Length, recieverEp);

                // Show preview
                Invoke(new Action(() =>
                {
                    pictureBox1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);
                }));

                Thread.Sleep(30); // ~30 FPS
                
            }
            

        }
    }
}
