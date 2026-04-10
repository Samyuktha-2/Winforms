using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Shapes
{
    class Circle : Shape
    {
        Rectangle Dimension { get; set; }

        public Circle(Rectangle dimension)
        {
            this.Dimension = dimension;
        }

        public override void Draw(Graphics g)
        {
            using(Pen p = new Pen(Brushes.Black, 5f))
            {
                g.DrawEllipse(p, Dimension);
            }
            g.FillEllipse(Brushes.LightGray, Dimension);
        }

        //public override void MoveShape(int x,int y)
        //{
        //    Dimension = new Rectangle(x, y, 100, 100);
        //}

        public override bool Contains(Point p)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(Dimension);
                return path.IsVisible(p);
            }
        }

        public override void Resize(int dx, int dy)
        {
            
        }

    }
}
