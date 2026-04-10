using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace castle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CastleControl castleControl = new CastleControl();
            castleControl.Location = new Point(0, 0);
            castleControl.Size = this.ClientSize;
            castleControl.BorderStyle = BorderStyle.FixedSingle;

            castleControl.mainFort = new Fort(225, 350, 325, 150, Brushes.SaddleBrown, Pens.White);
            castleControl.leftFort = new Fort(125, 200, 100, 350, Brushes.SaddleBrown, Pens.White);
            castleControl.rightFort = new Fort(450, 200, 100, 350, Brushes.SaddleBrown, Pens.White);
            castleControl.centerFort = new Fort(300, 200, 75, 150, Brushes.SaddleBrown, Pens.White);

            castleControl.leftTop = new Top(new Point(125, 200),new Point(175, 100), new Point(225, 200), Brushes.Khaki, Pens.Black);
            castleControl.centerTop = new Top(new Point(300, 200), new Point(334, 125), new Point(375, 200), Brushes.Khaki, Pens.Black);
            castleControl.rightTop = new Top(new Point(450, 200), new Point(500, 100), new Point(550, 200), Brushes.Khaki, Pens.Black);

            castleControl.mainDoor = new Door(Brushes.White, new Rectangle(290, 375, 100, 150), 180, 180);
            castleControl.leftSmallDoor = new Door(Brushes.White, new Rectangle(150, 250, 50, 100), 180, 180);
            castleControl.centerSmallDoor = new Door(Brushes.White, new Rectangle(313, 225, 50, 75), 180, 180);
            castleControl.rightSmallDoor = new Door(Brushes.White, new Rectangle(475, 250, 50, 100), 180, 180);

            this.Controls.Add(castleControl);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

    }
}
