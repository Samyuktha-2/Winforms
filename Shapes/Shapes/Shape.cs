using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        public abstract void Draw(Graphics g); 
        //public abstract void MoveShape(int dx, int dy,Shape shape); 
        public abstract bool Contains(Point p);
        public abstract void Resize(int dx, int dy);

    }
}
