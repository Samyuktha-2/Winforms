using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class task2 : Form
    {
        public task2()
        {
            InitializeComponent();
        }

        List<Label> label = new List<Label>();
        
        private bool validateInput(TextBox box, ErrorProvider error,string message)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                error.SetError(box, message);
                return false;
            }
            error.Clear();
            return true;
        }

        public int x = 0, y = 0, maxHeight = 0;
        public int counter = 1;

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool validWidth = validateInput(widthBox, errorProvider1, "Enter valid number");
            bool validHeight = validateInput(heightBox, errorProvider2, "Enter valid number");

            if (!validWidth || !validHeight) return;

            int w = int.Parse(widthBox.Text);
            int h = int.Parse(heightBox.Text);

            if(x + w > mainPanel.Width)
            {
                x = 0;
                y += maxHeight;
                maxHeight = 0;
            }

            Label l = new Label
            {
                Text = $"{counter++}",
                Width = w,
                Height = h,
                Location = new Point(x, y),
                BorderStyle = BorderStyle.FixedSingle
            };

            //l.Text = $"{counter++} + {l.Width} + {l.Height} + {l.Location.X} + {l.Location.Y}";
            x += w;
            maxHeight = (h > maxHeight) ? h : maxHeight;

            if(x > mainPanel.Width)
            {
                x = 0;
                y += maxHeight;
                maxHeight = 0;
            }

            label.Add(l);
            mainPanel.Controls.Add(l);
            
            widthBox.Clear();
            heightBox.Clear();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            bool validName = validateInput(nameBox, errorProvider3, "Enter valid name");

            if (!validName) return;

            mainPanel.Controls.Clear(); 

            int newx = 0, newy = 0;
            int newHeight = 0;

            for (int i = 0; i < label.Count; i++)
            {
                
                if (Convert.ToInt32(label[i].Text) == Convert.ToInt32(nameBox.Text))
                { 
                    label.Remove(label[i]);
                    break; 
                }

            }

            foreach(Label l in label)
            {
                if (newx + l.Width > mainPanel.Width)
                {
                    newx = 0;
                    newy += newHeight;
                    newHeight = 0;
                }
                l.Location = new Point(newx, newy);
                newx += l.Width;
                newHeight = Math.Max(newHeight, l.Height);
                x = newx;
                y = newy;
                maxHeight = newHeight;
                mainPanel.Controls.Add(l);
            }
            nameBox.Clear();
        }

        protected override void OnResize(EventArgs e)
        {
            
            base.OnResize(e);

            if(this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                onFormResize();
            }
        }

        private void onFormResize()
        {
            int newx = 0, newy = 0;
            int newHeight = 0;

            foreach (Label l in label)
            {
                if (newx + l.Width > mainPanel.Width)
                {
                    newx = 0;
                    newy += newHeight;
                    newHeight = 0;
                }
                l.Location = new Point(newx, newy);
                newx += l.Width;
                newHeight = Math.Max(newHeight, l.Height);
                x = newx;
                y = newy;
                maxHeight = newHeight;
                mainPanel.Controls.Add(l);
            }
        }

    }
}
