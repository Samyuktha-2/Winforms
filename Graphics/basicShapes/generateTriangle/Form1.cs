using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generateTriangle
{
    public partial class Form1 : Form
    {
        private Point commonPoint = new Point(10, 10);

        private List<Point[]> triangle = new List<Point[]>();
        private List<Point> square = new List<Point>();
        private List<Point> circle = new List<Point>();

        private const int shapeSize = 40;
        private const int spacing = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void triangleBtn_Click(object sender, EventArgs e)
        {
            int panelWidth = mainPanel.ClientSize.Width;

            Point p1 = new Point(commonPoint.X, commonPoint.Y + shapeSize);
            Point p2 = new Point(commonPoint.X + shapeSize / 2, commonPoint.Y);
            Point p3 = new Point(commonPoint.X + shapeSize, commonPoint.Y + shapeSize);

            triangle.Add(new Point[] { p1, p2, p3 });

            commonPoint.X += spacing;

            if(commonPoint.X + shapeSize > panelWidth)
            {
                commonPoint.X = 10;
                commonPoint.Y += spacing;
            }

            mainPanel.Invalidate();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach(Point[] tri in triangle)
            {
                g.DrawPolygon(Pens.Black, tri);
            }    

            foreach(Point sq in square)
            {
                g.DrawRectangle(Pens.Black, new Rectangle(sq.X, sq.Y, 40, 40));
            }

            foreach(Point cr in circle)
            {
                g.DrawEllipse(Pens.Black, new Rectangle(cr.X, cr.Y, 40, 40));
            }
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            int panelWidth = mainPanel.ClientSize.Width;

            square.Add(commonPoint);

            commonPoint.X += spacing;

            if(commonPoint.X + shapeSize > panelWidth)
            {
                commonPoint.X = 10;
                commonPoint.Y += spacing;
            }

            mainPanel.Invalidate();
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            int panelWidth = mainPanel.ClientSize.Width;

            circle.Add(commonPoint);
            commonPoint.X += spacing;

            if(commonPoint.X + shapeSize > panelWidth)
            {
                commonPoint.X = 10;
                commonPoint.Y += spacing;
            }

            mainPanel.Invalidate();
        }
    }
}