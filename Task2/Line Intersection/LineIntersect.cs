using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    public partial class LineIntersect : Form
    {
        public LineIntersect()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // smoother drawing
        }

        private List<Point> points = new List<Point>();
        private List<Line> drawnLines = new List<Line>();
        private bool drawLines = false;

        private void LineIntersect_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                points.Add(e.Location);
                Invalidate();
            }
        }

        private void LineIntersect_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                drawLines = true;
                Invalidate();
            }
        }

        private void LineIntersect_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Draw points
            foreach (Point p in points)
            {
                g.FillEllipse(Brushes.Black, p.X - 3, p.Y - 3, 6, 6);
            }

            if (drawLines)
            {
                drawnLines.Clear();

                // Connect every two points as one line
                for (int i = 0; i + 1 < points.Count; i += 2)
                {
                    Point p1 = points[i];
                    Point p2 = points[i + 1];

                    bool intersect = LinesIntersectWithAny(p1, p2);

                    // draw line color based on intersection
                    if (intersect)
                        g.DrawLine(Pens.Red, p1, p2);
                    else
                        g.DrawLine(Pens.Black, p1, p2);

                    drawnLines.Add(new Line(p1, p2));
                }
            }
        }

        private bool LinesIntersectWithAny(Point p1, Point p2)
        {
            foreach (Line l in drawnLines)
            {
                if (CheckIntersection(l.P1, l.P2, p1, p2))
                    return true;
            }
            return false;
        }

        private bool CheckIntersection(Point p1, Point p2, Point p3, Point p4)
        {
            float denominator = (p2.X - p1.X) * (p4.Y - p3.Y) -
                                (p2.Y - p1.Y) * (p4.X - p3.X);

            if (denominator == 0)
                return false; // parallel lines

            float t = ((p3.X - p1.X) * (p4.Y - p3.Y) -
                       (p3.Y - p1.Y) * (p4.X - p3.X)) / denominator;

            float u = ((p3.X - p1.X) * (p2.Y - p1.Y) -
                       (p3.Y - p1.Y) * (p2.X - p1.X)) / denominator;

            return (t >= 0 && t <= 1 && u >= 0 && u <= 1);
        }
    }

     
}
