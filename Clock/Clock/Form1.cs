using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            this.DoubleBuffered = true;
        } 

        public void DrawHand(Graphics g,int centerX,int centerY,int length,Pen pen,float angle)
        {
            angle -= 90;
            double rad = (angle * Math.PI) / 180;
            int x = centerX + (int)(length * Math.Cos(rad));
            int y = centerY + (int)(length * Math.Sin(rad));

            g.DrawLine(pen, centerX, centerY, x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
            Invalidate();
        }

        private void UpdateLabel()
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int radius = Height / 4;
            int centerX = Width / 2;
            int centerY = Height / 2;

            g.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);
            DateTime now = DateTime.Now;
            float secAngle = now.Second * 6;
            float minAngle = now.Minute * 6 + now.Second * 0.1f;
            float hourAngle = (now.Hour % 12) * 30 + now.Minute * 0.5f;

            DrawHand(g, centerX, centerY, radius - 70, Pens.Red, secAngle);
            DrawHand(g, centerX, centerY, radius - 50, Pens.Black, minAngle);
            DrawHand(g, centerX, centerY, radius - 20, Pens.Black, hourAngle);

            g.FillEllipse(Brushes.Black, centerX - 5, centerY - 5, 10, 10);

            for(int i = 1; i <= 12; i++)
            {
                float angle = (i * 30) - 90;
                double rad = angle * Math.PI / 180;

                int newRadius = radius - 25;

                int x = centerX + (int)(newRadius * Math.Cos(rad));
                int y = centerY + (int)(newRadius * Math.Sin(rad));

                string text = i.ToString();
                SizeF textSize = g.MeasureString(text, Font);

                x -= (int)(textSize.Width / 2);
                y -= (int)(textSize.Height / 2);

                g.DrawString(text, Font, Brushes.Black, x, y);
            }

            for(int i = 1; i <= 60; i++)
            {
                float angle = (i * 6) - 90;
                double rad = angle * Math.PI / 180;

                int outerRadius = radius;
                int innerRadius = (i % 5 == 0) ? radius - 15 : radius - 8;

                int x1 = centerX + (int)(innerRadius * Math.Cos(rad));
                int y1 = centerY + (int)(innerRadius * Math.Sin(rad));

                int x2 = centerX + (int)(outerRadius * Math.Cos(rad));
                int y2 = centerY + (int)(outerRadius * Math.Sin(rad));

                using (Pen pen = new Pen(Color.Black, (i % 5 == 0) ? 2 : 1))
                {
                    g.DrawLine(pen, x1, y1, x2, y2);
                }

            }
        }
    }
}
