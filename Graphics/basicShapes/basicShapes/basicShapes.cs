using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicShapes
{
    public partial class basicShapes : Form
    {
        public basicShapes()
        {
            InitializeComponent();
        }

        private void basicShapes_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //to draw line
            g.DrawLine(Pens.Black, new Point(100, 10), new Point(200, 10));

            Rectangle[] rectangles =
                {
                new Rectangle(100,200,100,80),
                new Rectangle(100,300,100,80),
                new Rectangle(100,400,100,80)
                };

            g.DrawRectangle(Pens.RosyBrown, new Rectangle(new Point(100, 50), new Size(100, 80)));
            //g.DrawRectangles(Pens.RoyalBlue, rectangles);

            //g.FillRectangles(Brushes.IndianRed, rectangles);

            g.DrawEllipse(Pens.Indigo, 230, 10, 50, 100);

            g.FillEllipse(Brushes.Indigo, rectangles[0]);

            g.DrawPolygon(Pens.Black, new Point[]{
                new Point(350, 10),
                new Point(550, 10),
                new Point(400, 30)
            });

            g.DrawArc(Pens.Black, rectangles[1], 77, 275);

            g.DrawPie(Pens.Black, rectangles[2], 45, 180);

            g.DrawBezier(Pens.Blue, new Point(350, 100), new Point(400, 50), new Point(450, 250), new Point(500, 200));
        }

        private void basicShapes_Load(object sender, EventArgs e)
        {

        }
    }
}
