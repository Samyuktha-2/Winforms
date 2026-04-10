using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        Rectangle Sides { get; set; }

        public Square(Rectangle sides)
        {
            this.Sides = sides;
        }

        public override void Draw(Graphics g)
        {
            using(Pen p = new Pen(Brushes.Black, 5f))
            {
                g.DrawRectangle(p, Sides);
            }
            g.FillRectangle(Brushes.LightGray, Sides);
        }

        //public override void MoveShape(int x,int y)
        //{
        //    Sides = new Rectangle(x, y, 100, 100);
        //}

        public override bool Contains(Point p)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(Sides);
                return path.IsVisible(p);
            }
        }

        public override void Resize(int dx, int dy)
        {
            
        }
    }
}
