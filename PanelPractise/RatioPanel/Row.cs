using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatioPanel
{
    public partial class Row : Form
    {
        public Row()
        {
            InitializeComponent();
        }

        string[] parts;
        int[] value;
        List<Label> label = new List<Label>();

        private void OkBtn(object sender, EventArgs e)
        {
            parts = ratioValue.Text.Split(' ');
            value = parts.Select(int.Parse).ToArray(); 

            for(int i = 0; i < value.Length; i++)
            {
                Label l = new Label
                {
                    BorderStyle = BorderStyle.FixedSingle
                };
                label.Add(l);
            }
            LabelResize();
        }

        private void LabelResize()
        {
            int total = value.Sum();
            int count = 0;
            int y = 0;
            foreach(Label l in label)
            {
                int height = (int)((value[count] / (float)total) * mainPanel.Height);
                l.Text = $"{value[count] * 100 / total}";
                l.Location = new Point(0, y);
                l.Size = new Size(mainPanel.Width, height);

                y += height;
                count++;
                mainPanel.Controls.Add(l);
            }

        }

        private void FormResize(object sender, EventArgs e)
        {
            LabelResize();
        }
    }
}
