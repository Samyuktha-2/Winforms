using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicShapes
{
    public partial class customPaintControl : UserControl
    {
        //public customPaintControl()
        //{
        //    InitializeComponent();
        //    this.DoubleBuffered = true;
        //    this.Size = new Size(300, 100);
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    e.Graphics.FillRectangle(Brushes.LightBlue, this.ClientRectangle);

        //    e.Graphics.DrawRectangle(Pens.DarkBlue, 0, 0, this.Width - 1, this.Height - 1);

        //    using(Font f = new Font("times new roman", 30))
        //    {
        //        e.Graphics.DrawString("CUSTOM", f, Brushes.Black, 10, 15);
        //    }
        //}

        [Browsable(true)]
        [Category("Castle Settings")]
        [Description("Height of the side walls.")]
        public int SideWallHeight { get; set; } = 80;

        [Browsable(true)]
        [Category("Castle Settings")]
        [Description("Width of the side walls.")]
        public int SideWallWidth { get; set; } = 50;

        [Browsable(true)]
        [Category("Castle Settings")]
        [Description("Height of the small top walls.")]
        public int SmallWallHeight { get; set; } = 30;

        [Browsable(true)]
        [Category("Castle Settings")]
        [Description("Width of the small top walls.")]
        public int SmallWallWidth { get; set; } = 30;

        public customPaintControl()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(250, 150);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Graphics g = e.Graphics;
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //// Draw background
            //g.Clear(Color.LightBlue);

            //int baseY = this.Height - 20; // base of the castle

            //// Draw side walls
            //g.FillRectangle(Brushes.Gray, 20, baseY - SideWallHeight, SideWallWidth, SideWallHeight);
            //g.FillRectangle(Brushes.Gray, this.Width - SideWallWidth - 20, baseY - SideWallHeight, SideWallWidth, SideWallHeight);

            //// Draw small walls (on top)
            //g.FillRectangle(Brushes.DarkGray, 20 + SideWallWidth / 2 - SmallWallWidth / 2, baseY - SideWallHeight - SmallWallHeight, SmallWallWidth, SmallWallHeight);
            //g.FillRectangle(Brushes.DarkGray, this.Width - (SideWallWidth / 2 + 20 + SmallWallWidth / 2), baseY - SideWallHeight - SmallWallHeight, SmallWallWidth, SmallWallHeight);

            //// Optional: Draw door
            //g.FillRectangle(Brushes.Brown, this.Width / 2 - 20, baseY - 40, 40, 40);

            //// Draw outline
            //g.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);
        }

        public static void drawCastle(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Gray, 10, 10, 50, 80);
        }
    }

}
