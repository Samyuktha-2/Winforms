using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DragDrop
{
    public partial class Form1 : Form
    {
        enum ShapeType { None, Triangle, Square, Line };

        private ShapeType currentShape = ShapeType.None;
        private List<Shape> shapes = new List<Shape>();
        private Shape selectedShape = null;
        private Point lastMousePoint;
        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        private void triangleBtn_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Triangle;
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Square;
        }

        private void pieBtn_Click(object sender, EventArgs e)
        {
            //currentShape = ShapeType.
        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            currentShape = ShapeType.Line;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentShape != ShapeType.None)
            {
                //Shape newShape = new Shape(currentShape, e.Location);
                //shapes.Add(newShape);
                currentShape = ShapeType.None;
                Invalidate();
            }
            else
            {
                foreach (var shape in shapes)
                {
                    //if (shape.Contains(e.Location))
                    //{
                    //    selectedShape = shape;
                    //    lastMousePoint = e.Location;
                    //    break;
                    //}
                }
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            //if (selectedShape != null && e.Button = MouseButtons.Left)
            //{
            //    int dx = e.X - lastMousePoint.X;
            //    int dy = e.Y - lastMousePoint.Y;
            //    selectedShape.Move(dx, dy);
            //    lastMousePoint = e.Location;
            //    Invalidate();
            //}
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            selectedShape = null;
        }
    }
    class Shape
    {
        //private ShapeType type;
        public Rectangle bounds;

        //public Shape(ShapeType type, Point location)
        //{
        //    type = type;
        //    bounds = new Rectangle(location.X - 30, location.Y - 30, 60, 60);
        //}

        public void Draw(Graphics g)
        {
            //switch (type)
            //{
            //    case ShapeType.Square:
            //        g.FillRectangle(Brushes.LightBlue, bounds);
            //        g.DrawRectangle(Pens.Black, bounds);
            //        break;
            //    case ShapeType.Triangle:
            //        Point p1 = new Point(bounds.Left + bounds.Width / 2, bounds.Top);
            //        Point p2 = new Point(bounds.Left, bounds.Bottom);
            //        Point p3 = new Point(bounds.Right, bounds.Bottom);
            //        g.FillPolygon(Brushes.LightGreen, new[] { p1, p2, p3 });
            //        g.DrawPolygon(Pens.DarkGreen, new[] { p1, p2, p3 });
            //        break;
            //    case ShapeType.Line:
            //        g.DrawLine(Pens.IndianRed, bounds.Left, bounds.Top, bounds.Right, bounds.Bottom);
            //        break;
            //}
        }

        public bool contains(Point p)
        {
            return bounds.Contains(p);
        }

        public void move(int dx, int dy)
        {
            bounds = new Rectangle(bounds.X + dx, bounds.Y + dy, bounds.Width, bounds.Height);
        }
    }
}


