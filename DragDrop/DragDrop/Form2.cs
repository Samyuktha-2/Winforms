using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDrop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        bool drawRectangle = false;
        private List<Rectangle> rectangles = new List<Rectangle>();
        private int selectRectIndex;

        bool drawTriangle = false;
        private List<Point[]> triangles = new List<Point[]>();

        bool drawPoint = false;
        private List<Point> linePoint = new List<Point>();

        bool isDragging = false;
        Point lastCursorPosition;

        private void rectangleBtn_Click(object sender, EventArgs e)
        {
            drawRectangle = true;   
        }

        private void triangleBtn_Click(object sender, EventArgs e)
        {
            drawTriangle = true;
        }

        private void pointBtn_Click(object sender, EventArgs e)
        {
            drawPoint = true;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach(Rectangle r in rectangles)
            {
                g.FillRectangle(Brushes.Bisque, r);
                g.DrawRectangle(Pens.Black, r);
            }

            foreach(Point[] p in triangles)
            {
                g.FillPolygon(Brushes.BlanchedAlmond, p);
                g.DrawPolygon(Pens.Black, p);
            }

            for(int i = 0; i < linePoint.Count; i += 2)
            {
                g.FillEllipse(Brushes.Black, linePoint[i].X, linePoint[i].Y, 10, 10);
            }
        }

        private void mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawRectangle)
            {
                Point point = e.Location;
                rectangles.Add(new Rectangle(point.X, point.Y, 100, 80));
                drawRectangle = false;
            }

            if (drawTriangle)
            {
                Point p1 = e.Location;
                Point p2 = new Point(e.Location.X - 100, e.Location.Y + 100);
                Point p3 = new Point(e.Location.X + 100, e.Location.Y + 100);
                Point[] point = { p1, p2, p3 };
                triangles.Add(point);
                drawTriangle = false;
            }

            if (drawPoint)
            {
                Point point = e.Location;
                linePoint.Add(point);
                drawPoint = false;
            }
            mainPanel.Invalidate();
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            for(int i = rectangles.Count - 1; i >= 0; i--)
            {
                if (rectangles[i].Contains(e.Location))
                {
                    selectRectIndex = i;
                    isDragging = true;
                    lastCursorPosition = e.Location;
                    mainPanel.Invalidate();
                    return;
                }

                selectRectIndex = -1;
                mainPanel.Invalidate();
            }
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && selectRectIndex >= 0)
            {
                int dx = e.X - lastCursorPosition.X;
                int dy = e.Y - lastCursorPosition.Y;

                Rectangle moved = rectangles[selectRectIndex];
                moved.X += dx;
                moved.Y += dy;
                rectangles[selectRectIndex] = moved;
                lastCursorPosition = e.Location;
                mainPanel.Invalidate(); 
            } 

        }
    }
}
