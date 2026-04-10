using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        List<Shape> shapesList = new List<Shape>();
        bool isDragging = false;
        bool isResizing = false;
        Shape shapeToMove;
        Shape shapeToResize;
        Point lastMouse;


        private void TriangleBtnClick(object sender, EventArgs e)
        {
            Point p1 = new Point(100, 100);
            Point p2 = new Point(p1.X - 50, p1.Y + 100);
            Point p3 = new Point(p1.X + 50, p1.Y + 100);

            Triangle triangle = new Triangle(p1, p2, p3);
            shapesList.Add(triangle);
            leftPanel.Invalidate();
        }

        private void SquareBtnClick(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(50, 50, 100, 100);
            Square square = new Square(rect);
            shapesList.Add(square);
            leftPanel.Invalidate();
        }

        private void CircleBtnClick(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(150, 150, 100, 100);
            Circle circle = new Circle(rect);
            shapesList.Add(circle);
            leftPanel.Invalidate();
        }

        private void LeftPanelPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            foreach(var s in shapesList)
            {
                s.Draw(g); 
            }  
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            //Move Shape
            if (MouseButtons.Middle == e.Button)
            {
                foreach (var shape in shapesList)
                {
                    if (shape.Contains(e.Location))
                    {
                        isDragging = true;
                        shapeToMove = shape;
                        leftPanel.Cursor = Cursors.SizeAll;
                        lastMouse = e.Location; 
                        break;
                    }
                }
            }

            //Reside Shape
            if(MouseButtons.Left == e.Button)
            {
                foreach(var shape in shapesList)
                {
                    if (shape.Contains(e.Location))
                    {
                        isResizing = true;
                        shapeToResize = shape;
                        leftPanel.Cursor = Cursors.Hand;
                        break;
                    }
                }
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && shapeToMove != null)
            {
                Point currPoint = e.Location;
                int dx = e.X - lastMouse.X;
                int dy = e.Y - lastMouse.Y;
                //shapeToMove.MoveShape(currPoint.X,currPoint.Y, shapeToMove);
                leftPanel.Invalidate();
            }

            if(isResizing && shapeToResize != null)
            {
                Point currPoint = e.Location;
                shapeToResize.Resize(currPoint.X, currPoint.Y);
                leftPanel.Invalidate();
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            shapeToMove = null;
            leftPanel.Cursor = Cursors.Default;
            leftPanel.Invalidate();
        }
    }
}
 
