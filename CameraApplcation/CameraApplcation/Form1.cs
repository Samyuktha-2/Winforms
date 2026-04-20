using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading.Tasks;
using System.Text;
using System.IO;

namespace CameraApplcation
{
    public partial class Form1 : Form
    {
        HttpListener listener;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartServerBtn_Click(object sender, EventArgs e)
        {
            listener = new HttpListener();

            listener.Prefixes.Add("http://192.168.1.52:8000/");
            listener.Start();


            Task.Run(() =>
            {
                while (true)
                {
                    

                    //string message = "Server is running";
                    //byte[] buffer = Encoding.UTF8.GetBytes(message);
                    //response.OutputStream.Write(buffer, 0, buffer.Length);
                    //response.OutputStream.Close();

                    var context = listener.GetContext();
                    var response = context.Response;
                    Console.WriteLine("Request received from: " + context.Request.RemoteEndPoint);
                    string imagePath = @"C:\Users\OptiCheck\Desktop\WINFORMS\CameraApplcation\CameraApplcation\Image\philipp-dusel-t_VkKLO9Fqo-unsplash.jpg";
                    byte[] imageByte = File.ReadAllBytes(imagePath);
                    response.ContentType = "Image/jpeg";
                    response.OutputStream.Write(imageByte, 0, imageByte.Length); 
                    
                }
            });

            MessageBox.Show("Server runs on port 8000");
        }
    }
}
