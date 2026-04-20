     using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Notification
{
    public partial class DrawBell : UserControl
    {
        public DrawBell()
        {
            InitializeComponent();
            Paint += PaintBell;
            this.DoubleBuffered = true;
        }

        int notiCount = 0;
        public static List<Notification> notiPriority = new List<Notification>();
        Brush myBrush = Brushes.White;
        int currPriority = 0;

        private void PaintBell(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.DrawEllipse(Pens.Black, 156, 110, 15, 15);
            g.FillEllipse(Brushes.LightSalmon, 156, 110, 15, 15);

            using (GraphicsPath bellPath = drawBell())
            {
                g.DrawPath(Pens.Black, bellPath);
                g.FillPath(Brushes.LightSalmon, bellPath);
            }

            g.DrawEllipse(Pens.Black, 152, 185, 20, 15);
            g.FillEllipse(Brushes.LightSalmon, 152, 185, 20, 15);

            g.DrawEllipse(Pens.Black, 102, 180, 125, 10);
            g.FillEllipse(Brushes.LightSalmon, 102, 180, 125, 10);

            g.DrawEllipse(Pens.Black, 180, 120, 30, 30);
            g.FillEllipse(myBrush, 180, 120, 30, 30);

            if(notiCount != 0)
            {
                g.DrawString(notiCount.ToString(), new Font("Times new roman", 10, FontStyle.Bold), Brushes.White, 190, 130);
            }
        }

        private GraphicsPath drawBell()
        {
            GraphicsPath bell = new GraphicsPath();
            bell.AddArc(114, 125, 100, 120, 180, 180);
            bell.AddLine(114, 185, 214, 185);

            bell.CloseFigure();
            return bell;
        }

        public void DrawString(int num,DateTime date)
        {
            notiPriority.Add(new Notification(num, date));
            if(currPriority == 0)
            {
                currPriority = num;
            }
            else if(currPriority > num)
            {
                currPriority = num;
            }

            switch (currPriority)
            {
                case 1: myBrush = Brushes.Red;break;
                case 2: myBrush = Brushes.Orange; break;
                case 3: myBrush = Brushes.Blue; break;
                case 4: myBrush = Brushes.Green; break;
            }
            notiCount++;
            Invalidate();
        }
         
        public List<Notification> GetNotifications()
        {
            return notiPriority;
        }
    }
    public class Notification
    {
        public int Num { get; set; }
        public DateTime Date { get; set; }

        public Notification(int num, DateTime date)
        {
            Num = num;
            Date = date;
        }
    }
}
