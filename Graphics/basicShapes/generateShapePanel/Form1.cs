using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generateShapePanel
{
    public partial class Form1 : Form
    {
        int counter = 1;
        int x = 0, y = 0,maxheight = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(widthBox.Text);
            int height = Convert.ToInt32(heightBox.Text);
            Label l = new Label
            {
                Text = $"{counter++}",
                Size = new Size(width, height),
                Location = new Point(x, y),
                BorderStyle = BorderStyle.FixedSingle
            };

            x += width;
            maxheight = (maxheight < height) ? height : maxheight;
            if(x > this.mainPanel.Width)
            {
                x = 0;
                y += maxheight;
            }

            mainPanel.Controls.Add(l);

        }
         
    }
}
