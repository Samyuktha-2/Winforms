using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PieChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; 
        }
        int a = 40, b = 20, c = 40;
        private void FormPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(100, 100, 200, 200);

            float startAngle = 0F;
            float aStartAngle = 360F * a / 100F;
            float bStartAngle = 360F * b / 100F;
            float cStartAngle = 360F * c / 100F;


            g.FillPie(Brushes.Lavender,rect, startAngle, aStartAngle);
            g.DrawPie(Pens.Black, rect, startAngle, aStartAngle);
            startAngle += aStartAngle;
            g.FillPie(Brushes.Beige, rect, startAngle, bStartAngle);
            g.DrawPie(Pens.Black, rect, startAngle, bStartAngle);
            startAngle += bStartAngle;
            g.FillPie(Brushes.BurlyWood, rect, startAngle, cStartAngle);
            g.DrawPie(Pens.Black, rect, startAngle, cStartAngle);
            
        }
    }
}
