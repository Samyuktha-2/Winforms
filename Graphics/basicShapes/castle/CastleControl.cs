using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace castle
{
    public class Fort
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Brush brush { get; set; }
        public Pen pen { get; set; }

        public Fort(int x, int y, int width, int height, Brush brush, Pen pen)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            this.brush = brush;
            this.pen = pen;
        }
    }

    public class Top
    {
        public Point point1 { get; set; }
        public Point point2 { get; set; }
        public Point point3 { get; set; }
        public Brush brush { get; set; }
        public Pen pen { get; set; }

        public Top(Point p1,Point p2,Point p3,Brush brush,Pen pen){
            point1 = p1;
            point2 = p2;
            point3 = p3;
            this.brush = brush;
            this.pen = pen;
        }
    }

    public class Door
    {
        public Brush brush { get; set; }
        public Rectangle rectangle { get; set; }
        public float startAngle { get; set; }
        public float sweepAngle { get; set; }

        public Door(Brush brush, Rectangle rect, float sa, float sw)
        {
            this.brush = brush;
            rectangle = rect;
            startAngle = sa;
            sweepAngle = sw;
        }
    }

    public partial class CastleControl : UserControl
    {
        public Fort mainFort { get; set; }
        public Fort leftFort { get; set; }
        public Fort rightFort { get; set; }
        public Fort centerFort { get; set; }

        public Top leftTop { get; set; }
        public Top centerTop { get; set; }
        public Top rightTop { get; set; }

        public Door mainDoor { get; set; }
        public Door leftSmallDoor { get; set; }
        public Door centerSmallDoor { get; set; }
        public Door rightSmallDoor { get; set; }

        public CastleControl()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (mainFort != null) drawFort(e, mainFort);
            if (leftFort != null) drawFort(e, leftFort);
            if (rightFort != null) drawFort(e, rightFort);
            if (centerFort != null) drawFort(e, centerFort);

            if (leftTop != null) drawTop(e, leftTop);
            if (centerTop != null) drawTop(e, centerTop);
            if (rightTop != null) drawTop(e, rightTop);

            if (mainDoor != null) drawDoor(e, mainDoor);
            if (leftSmallDoor != null) drawDoor(e, leftSmallDoor);
            if (centerSmallDoor != null) drawDoor(e, centerSmallDoor);
            if (rightSmallDoor != null) drawDoor(e, rightSmallDoor);

        }

        public static void drawFort(PaintEventArgs e, Fort fort)
        {
            e.Graphics.FillRectangle(fort.brush, fort.X, fort.Y, fort.Width, fort.Height);
            e.Graphics.DrawRectangle(fort.pen, fort.X, fort.Y, fort.Width, fort.Height);
        }

        public static void drawTop(PaintEventArgs e,Top top)
        {
            Point[] point = { top.point1, top.point2, top.point3 };
            e.Graphics.FillPolygon(top.brush,point);
        }

        public static void drawDoor(PaintEventArgs e,Door door)
        {
            e.Graphics.FillPie(door.brush, door.rectangle, door.startAngle, door.sweepAngle);
        }

        
    }
}
