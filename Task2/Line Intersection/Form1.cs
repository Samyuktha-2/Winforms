using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Task2
{
    public struct Line
    {
        public Point P1;
        public Point P2;

        public Line(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }
    }

    public partial class Form1 : Form
    {
        private List<List<Point>> shapes = new List<List<Point>>();
        private List<Point> currentPoint = new List<Point>();
        private List<Line> drawnLines = new List<Line>();
        private bool drawingInProgress = false;
        private int currentLineIndex = -1;

        private Timer lineTimer;  

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            lineTimer = new Timer();
            lineTimer.Interval = 1000;  
            lineTimer.Tick += timer1_Tick;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (drawingInProgress) return;

            if (e.Button == MouseButtons.Left)
            {
                currentPoint.Add(e.Location);
                Invalidate();
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && currentPoint.Count > 1 && !drawingInProgress)
            {
                drawingInProgress = true;
                currentLineIndex = 0;  
                lineTimer.Start();    
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            currentLineIndex++;
            Invalidate();

            if (currentLineIndex >= currentPoint.Count)
            { 
                lineTimer.Stop();
                shapes.Add(new List<Point>(currentPoint));
                currentPoint.Clear();
                currentLineIndex = -1;
                drawingInProgress = false;
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Draw points
            foreach (Point p in currentPoint)
                g.FillEllipse(Brushes.Black, p.X - 5, p.Y - 5, 10, 10);

            // Draw lines in progress
            if (drawingInProgress && currentPoint.Count > 1)
            {
                drawnLines.Clear();
                for (int i = 0; i < currentLineIndex && i < currentPoint.Count - 1; i++)
                {
                    Point p1 = currentPoint[i];
                    Point p2 = currentPoint[i + 1];

                    bool intersect = LineIntersectWithAny(p1, p2);

                    if (intersect)
                    {
                        g.DrawLine(Pens.Red, p1, p2);
                    }
                    else
                    {
                        g.DrawLine(Pens.Black, p1, p2);
                    }
                    drawnLines.Add(new Line(p1, p2));
                }
            }
            drawnLines.Clear();


            //completed shapes
            foreach (var shape in shapes)
            {
                for (int i = 0; i < shape.Count; i++)
                {
                    Point p1 = shape[i];
                    Point p2 = shape[(i + 1) % shape.Count];
                    g.FillEllipse(Brushes.Black, p1.X - 5, p1.Y - 5, 10, 10);
                    bool intersect = LineIntersectWithAny(p1, p2);

                    if (intersect)
                    {
                        g.DrawLine(Pens.Red, p1, p2);
                    }
                    else
                    {
                        g.DrawLine(Pens.Black, p1, p2);
                    } 
                }
            }
        }
         

        private bool LineIntersectWithAny(Point p1, Point p2)
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

            if (Math.Abs(denominator) < 0.0001f)
                return false; 

            float t = ((p3.X - p1.X) * (p4.Y - p3.Y) -
                       (p3.Y - p1.Y) * (p4.X - p3.X)) / denominator;

            float u = ((p3.X - p1.X) * (p2.Y - p1.Y) -
                       (p3.Y - p1.Y) * (p2.X - p1.X)) / denominator;

            
            const float epsilon = 0.01f;
            return (t > epsilon && t < 1 - epsilon && u > epsilon && u < 1 - epsilon);
        }

    }
}
