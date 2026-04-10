using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Point P3 { get; set; }

        public Triangle(Point p1,Point p2,Point p3)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.P3 = p3;
        }

        public override void Draw(Graphics g )
        {
            Point[] points = { P1, P2, P3 };
            using(Pen p = new Pen(Brushes.Black, 5f))
            {
                g.DrawPolygon(p, points);
            } 
            g.FillPolygon(Brushes.LightGray, points); 
        }

        //public override void MoveShape(int x,int y,Shape s)
        //{
        //    //P1 = new Point(x, y);
        //    //P2 = new Point(x - 50, y + 100);
        //    //P3 = new Point(x + 50, y + 100);
        //    Shape movedTriangle = s;
            
        //}

        public override bool Contains(Point p)
        {
            using(GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(new[] { P1, P2, P3 });
                return path.IsVisible(p);
            }
        }

        public override void Resize(int dx, int dy)
        {
            
        }
    }
}
