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
    public partial class DragShape : Form
    { 
        private List<Rectangle> rectList = new List<Rectangle>();
        private List<Rectangle> ellipseList = new List<Rectangle>();
        private Rectangle? selectedRect = null;

        bool isDragging = false;
        bool drawRectangle = false;
        bool drawEllipse = false;
         
        Point lastCursorLocation;

        public DragShape()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void DragShape_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach(Rectangle r in rectList)
            {
                g.FillRectangle(Brushes.AliceBlue, r);
                g.DrawRectangle(Pens.Black, r);
            }

            foreach(Rectangle ell in ellipseList)
            {
                g.FillEllipse(Brushes.Black, ell);
            }
            
        }

        private void DragShape_MouseDown(object sender, MouseEventArgs e)
        {
            
            if(e.Button == MouseButtons.Middle)
            {
                for (int i = rectList.Count - 1; i >= 0; i--)
                {
                    if (rectList[i].Contains(e.Location))
                    {
                        selectedRect = rectList[i];
                        isDragging = true;
                        lastCursorLocation = e.Location;
                        break;
                    }
                }
            }
             
            if (drawEllipse && e.Button == MouseButtons.Left)
            {
                Rectangle ellipse = new Rectangle(e.X - 5, e.Y - 5, 10, 10);
                ellipseList.Add(ellipse);
                Invalidate();
            }
        }

        private void DragShape_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && selectedRect.HasValue)
            {
                int dx = e.X - lastCursorLocation.X;
                int dy = e.Y - lastCursorLocation.Y;

                Rectangle moved = selectedRect.Value;
                moved.X += dx;
                moved.Y += dy;

                int index = rectList.IndexOf(selectedRect.Value);
                rectList[index] = moved;
                selectedRect = moved;

                lastCursorLocation = e.Location;
                Invalidate(); 
            }
        }

        private void DragShape_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            selectedRect = null;

            if (drawEllipse)
            {
                drawEllipse = false;
            }
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawEllipse = true;
            Invalidate();
        }

        private void DragShape_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawRectangle)
            {
                drawRectangle = false;
                Point point = e.Location;
                Rectangle r = new Rectangle(point.X, point.Y, 100, 80);
                rectList.Add(r);
            }
            Invalidate();
        }
    }
}
