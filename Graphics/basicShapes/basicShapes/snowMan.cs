using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicShapes
{
    public partial class snowMan : Form
    {
        public snowMan()
        {
            InitializeComponent();
            this.DoubleBuffered = true; 
        }


        bool isdragging = false;
        Point dragCursorPoint;
        Point dragPanelPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Middle && Control.ModifierKeys == Keys.Control)
            {
                this.Invalidate();
                isdragging = true;
                dragCursorPoint = Cursor.Position;
                dragPanelPoint = panel1.Location;

                panel1.Cursor = Cursors.SizeAll;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isdragging)
            {
                Point difference = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                panel1.Location = Point.Add(dragPanelPoint, new Size(difference));
                panel1.Cursor = Cursors.SizeAll;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isdragging)
            {
                isdragging = false;

                Point difference = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Point newLocation = Point.Add(dragPanelPoint, new Size(difference));

                if (newLocation.X < 0) newLocation.X = 0;
                if (newLocation.Y < 0) newLocation.Y = 0;

                if (newLocation.X + panel1.Width > this.ClientSize.Width) newLocation.X = this.ClientSize.Width - panel1.Width;
                if (newLocation.Y + panel1.Height > this.ClientSize.Height) newLocation.Y = this.ClientSize.Height - panel1.Height;

                panel1.Location = newLocation;

                panel1.Cursor = Cursors.Default;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(panel1.BackColor);
            Point[] points =
            {
                new Point(150,145),
                new Point(160,150),
                new Point(150,155)
            };

            //hat base
            g.FillEllipse(Brushes.Black, 90, 90, 120, 25);

            //hat top
            g.FillRectangle(Brushes.Black, 120, 45, 60, 100);

            //face
            g.FillEllipse(Brushes.White, 100, 100, 100, 100);

            //eyes
            g.FillEllipse(Brushes.Black, 125, 130, 10, 10);
            g.FillEllipse(Brushes.Black, 165, 130, 10, 10);

            //nose
            g.FillPolygon(Brushes.Black, points);

            //mouth
            g.DrawArc(Pens.Black, 135, 165, 40, 10, 0, 180);

            //body
            g.FillEllipse(Brushes.White, 75, 190, 150, 150);

            //left hand
            g.DrawLine(Pens.Black, new Point(55, 210), new Point(100, 230));
            g.DrawLine(Pens.Black, new Point(58, 200), new Point(69, 215));
            g.DrawLine(Pens.Black, new Point(55, 220), new Point(69, 215));

            //right hand
            g.DrawLine(Pens.Black, new Point(245, 210), new Point(200, 230));
            g.DrawLine(Pens.Black, new Point(242, 200), new Point(231, 215));
            g.DrawLine(Pens.Black, new Point(245, 220), new Point(231, 215));

        }


    }
}
