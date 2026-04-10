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
    public partial class castle : Form
    {
        //private bool isDrawing = false;
        //private Point startPoint;
        //private Bitmap canvas;
        //private Pen drawPen;

        public castle()
        {
            InitializeComponent();

            customPaintControl custom = new customPaintControl();
            custom.Location = new Point(50, 50);
            custom.SideWallHeight = 100;
            custom.SideWallWidth = 200;
            
            this.Controls.Add(custom);


            //this.DoubleBuffered = true;
            //canvas = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            //drawPen = new Pen(Color.Black, 10);
            //this.BackColor = Color.White;
        }

        private void castle_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImageUnscaled(canvas, Point.Empty);
            
        } 

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            customPaintControl.drawCastle(e);
        }

        private void castle_Load(object sender, EventArgs e)
        {

        }
        //private void castle_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (isDrawing)
        //    {
        //        using(Graphics g = Graphics.FromImage(canvas))
        //        {
        //            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        //            g.DrawLine(drawPen, startPoint, e.Location);
        //            startPoint = e.Location;
        //            this.Invalidate();
        //        }
        //    }
        //}

        //private void castle_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (isDrawing)
        //    {
        //        isDrawing = false;
        //    }
        //}

        //private void castle_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if(e.KeyCode == Keys.C)
        //    {
        //        using(Graphics g = Graphics.FromImage(canvas))
        //        {
        //            g.Clear(Color.White);
        //        }
        //    }
        //}
    }
}
