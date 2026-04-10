using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelPractise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Label> label = new List<Label>();
        int row, col;
        int rowGap, colGap;
         
        private void FormResize(object sender, EventArgs e)
        {
            LabelResize();
        }

        private void OkBtn(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            label.Clear();

            row = (int)rowVal.Value;
            col = (int)colVal.Value;

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    Label l = new Label
                    {
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    label.Add(l);
                }
            }

            LabelResize();
        }

        private void ResizeBtn(object sender, EventArgs e)
        {
            rowGap = (int)rowGapVal.Value;
            colGap = (int)colGapVal.Value;

            LabelResize();
        }
         
        private void LabelResize()
        {
            if (row == 0 || col == 0) return;

            mainPanel.Controls.Clear();

            int width = (mainPanel.ClientSize.Width - (col - 1) * colGap) / col;
            int height = (mainPanel.ClientSize.Height - (row - 1) * rowGap) / row;

            int y = 0, x = 0;
            int count = 1;

            foreach(Label l in label)
            {
                l.Text = $"W: {width}, H: {height}";
                l.Size = new Size(width, height);
                l.Location = new Point(x, y);
                x += l.Width + colGap;
                if(count % col == 0)
                {
                    x = 0;
                    y += l.Height + rowGap ;
                }
                count++;
                mainPanel.Controls.Add(l);
            }
            
        }
    }
}
