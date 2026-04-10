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
    public partial class Col : Form
    {
        public Col()
        {
            InitializeComponent();
        }

        string[] parts;
        int[] value;
        List<Label> label = new List<Label>();

        private void OkBtn(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            label.Clear();

            parts = ratioValue.Text.Split(' ');
            value = parts.Select(int.Parse).ToArray(); 
  
            for(int i = 0 ; i < value.Length ; i++)
            {  
                Label l = new Label
                { 
                    BorderStyle = BorderStyle.FixedSingle
                };
                label.Add(l);
            }

            LabelResize();
        }

        private void FormResize(object sender, EventArgs e)
        {
            LabelResize();
        }

        private void LabelResize()
        {
            int total = value.Sum();
            int count = 0;

            int x = 0;
            foreach (Label l in label)
            {
                int width = (int)((value[count] / (float)total) * mainPanel.Width);
                l.Text = $"{value[count] * 100 / total}";
                l.Location = new Point(x, 0);
                l.Size = new Size(width, mainPanel.Height);

                x += width;
                count++;
                mainPanel.Controls.Add(l);
            }
        }
    }
}
 