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
    public partial class drawImage : Form
    {
        public drawImage()
        {
            InitializeComponent();
        }

        private void drawImage_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Image img = Image.FromFile(@"C:\Users\OptiCheck\Downloads\user_icon.png");

            g.DrawImage(img, 10, 10, 150, 100);

            g.DrawImageUnscaled(img, 200, 10);
        }
    }
}
