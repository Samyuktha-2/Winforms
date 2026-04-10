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

namespace Logo
{
    public partial class LogoControl : UserControl
    {
        public LogoControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Logo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Empty, Color.Empty, 45f);

            ColorBlend blend = new ColorBlend();
            blend.Colors = new Color[] {
                Color.FromArgb(255, 247, 119, 55),
                Color.FromArgb(255, 255, 0, 128),
                Color.FromArgb(255, 193, 53, 132),
                Color.FromArgb(255, 131, 58, 180)
            };

            blend.Positions = new float[]
            {
                0.0f,0.35f,0.7f,1.0f
            };
             
            brush.InterpolationColors = blend;

            using (GraphicsPath gp = RoundedRectangle(rect, 25))
            {
                g.FillPath(brush, gp);
            }
           
        
            Rectangle innerRect = new Rectangle(10, 10, rect.Width - 20, rect.Height - 20);
            Pen pen = new Pen(Color.White, 5);
            using (GraphicsPath gp = RoundedRectangle(innerRect, 20)) 
            {
                g.DrawPath(pen, gp);
            }
            
            Rectangle circle = new Rectangle();
            int size = Math.Min(rect.Width, rect.Height);

            circle.Width = circle.Height = (int)(size * 0.50f);
             
            circle.X = rect.X + (rect.Width - circle.Width) / 2;
            circle.Y = rect.Y + (rect.Height - circle.Width) / 2;

            
            g.DrawEllipse(pen, circle);

            Rectangle innerCircle = new Rectangle();
            int innerCircleDia = (int)(size * 0.10f);
            innerCircle.Width = innerCircle.Height = innerCircleDia;
            int innerPadding = (int)(size * 0.085f);

            innerCircle.X = innerRect.Right - innerPadding - innerCircleDia;
            innerCircle.Y = innerRect.Top + innerPadding;

            g.FillEllipse(Brushes.White, innerCircle);
        }

        private GraphicsPath RoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int maxRadius = Math.Max(rect.Width, rect.Height) / 2;
            radius = Math.Min(maxRadius, radius);

            int diameter = radius * 2;

            if(radius == 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseAllFigures();

            return path;
        }
    }
}
