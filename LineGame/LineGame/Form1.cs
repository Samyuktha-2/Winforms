using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineGame
{
    public class Lines
    {
        public Point start;
        public Point end;
        public Color lineColor;
        public Lines(Point s,Point e, Color l)
        {
            start = s;
            end = e;
            lineColor = l;
        }
    }

    public partial class Form1 : Form
    {
        List<Panel> topPanel = new List<Panel>();
        List<Panel> bottomPanel = new List<Panel>();
        bool panelCreated = false;

        List<Lines> lines = new List<Lines>();
        Point startPoint;
        Point endPoint;
        bool isDrawing = false;

        //List<Color> colors = new List<Color> { Color.Red,Color}

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            topPanel.Clear();
            bottomPanel.Clear();
            lines.Clear();
            mainPanel.Invalidate();

            int obj;
            if(!int.TryParse(panelBox.Text,out obj) || obj > 5 || obj == 0)
            {
                errorProvider1.SetError(panelBox, "Invalid Input");
                panelBox.Clear();
            }
            else
            {
                errorProvider1.Clear();
            }
            int width = 80;
            int height = 60;
            int gap = (mainPanel.ClientSize.Width - (width * obj)) / (obj + 1);
            int yTop = 0;
            int yBottom = mainPanel.ClientSize.Height - height;

            for(int i = 0; i < obj; i++)
            {
                Panel p = new Panel
                {
                    Size = new Size(width, height),
                    Location = new Point(gap + i * (width + gap), yTop),
                    BackColor = Color.Black
                };
                topPanel.Add(p);
                mainPanel.Controls.Add(p);
            }

            for (int i = 0; i < obj; i++)
            {
                Panel p = new Panel
                { 
                    Size = new Size(width, height),
                    Location = new Point(gap + i * (width + gap), yBottom),
                    BackColor = Color.Black
                };
                topPanel.Add(p);
                mainPanel.Controls.Add(p);
            }

            panelBox.Clear();
            panelCreated = true;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Pen p = new Pen(Color.Black, 3))
            {
                foreach (var v in lines)
                {
                    g.DrawLine(p, v.start, v.end);
                }

                if (isDrawing)
                {
                    g.DrawLine(Pens.Red, startPoint, endPoint);
                }
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {

            if (!panelCreated) return;

            if(e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                endPoint = e.Location; 
                lines.Add(new Lines(startPoint, endPoint,Color.Black));
                mainPanel.Invalidate();
            }
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                mainPanel.Invalidate();
            }
        }

        
    }
}

