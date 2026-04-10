using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class task1 : Form
    {
        public task1()
        {
            InitializeComponent();
        }

        List<Label> label = new List<Label>();

        private void addBtn_Click(object sender, EventArgs e)
        {
            labelCreation();
            onResizeClicked();
        }


        private void labelCreation()
        {
            int requiredLabel = Convert.ToInt32(rowBox.Value * colBox.Value);

            if(requiredLabel > label.Count)
            {
                int needed = requiredLabel - label.Count;
                for(int i = 0; i < needed; i++)
                {
                    Label l = new Label
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.Lavender
                    };
                    label.Add(l);
                    mainPanel.Controls.Add(l);
                }
            }
            else if(requiredLabel < label.Count)
            {
                int toRemove = label.Count - requiredLabel;
                for(int i = 0; i < toRemove; i++)
                {
                    var last = label[label.Count - 1];
                    mainPanel.Controls.Remove(last);
                    label.RemoveAt(label.Count - 1);
                }
            }
        }
        

        private void resizeBtn_Click(object sender, EventArgs e)
        {
            onResizeClicked();
        }

        protected override void OnResize(EventArgs e)
        {
            //onResizeClicked();
            base.OnResize(e);

            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                onResizeClicked();
            }
        }
        
        private void onResizeClicked()
        {
            int rows = Convert.ToInt32(rowBox.Value);
            int cols = Convert.ToInt32(colBox.Value);
            int rowGaps = Convert.ToInt32(rowGapBox.Value);
            int colGaps = Convert.ToInt32(colGapBox.Value);

            int totalWidth = mainPanel.ClientSize.Width;
            int totalHeight = mainPanel.ClientSize.Height;


            int width = (totalWidth - colGaps * (cols - 1)) / cols;
            int height = (totalHeight - rowGaps * (rows - 1)) / rows;

            int counter = 0;
            int x = 0,y = 0;

            foreach (Label l in label)
            {
                int row = counter / cols;
                int col = counter % cols;

                l.Size = new Size(width, height);

                int rightEdge = x + width;
                int remaining = totalWidth - rightEdge;

                if (col == cols - 1 && remaining < totalWidth * 0.1)
                {
                    // Move last label fully inside panel
                    if (rightEdge > totalWidth)
                    {
                        int newX = totalWidth - width - colGaps;
                        if (newX < colGaps) newX = colGaps;
                        l.Location = new Point(newX, y);
                    }
                    else
                    {
                        l.Location = new Point(x, y);
                    }
                }
                else
                {
                    l.Location = new Point(x, y);
                }

                l.Text = $"{counter + 1} | W:{l.Width} | H:{l.Height}";
                mainPanel.Controls.Add(l);

                counter++;
                x += width + colGaps;

                if (col == cols - 1)
                {
                    x = 0;
                    y += height + rowGaps;
                }
            }
        }

        
    }
}

