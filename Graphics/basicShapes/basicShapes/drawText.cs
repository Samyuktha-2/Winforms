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
    public partial class drawText : Form
    {
        public drawText()
        {
            InitializeComponent();
        }

        private void drawText_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawString("Hello", new Font("Times new Roman", 20), Brushes.Black, new Point(10, 10));

            Font font = new Font("Times new Roman", 30);
            string text = "HELLO";

            SizeF textSize = g.MeasureString(text, font);

            g.DrawRectangle(Pens.Black, 100, 100, textSize.Width, textSize.Height);
            g.DrawString(text, font, Brushes.Blue, 100, 100);

        }
    }
}
