using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicPanelAdding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Label> label = new List<Label>();
        int count = 1;
        int maxHeight = 0;
        int x = 0, y = 0;

        private void AddBtn(object sender, EventArgs e)
        {
            bool validWidth = IsValidInput(widthVal, errorProvider2, "Enter valid number");
            if (!validWidth) return;

            bool validHeight = IsValidInput(heightVal, errorProvider1, "Enter valid number");
            if (!validHeight) return;

            int width = Convert.ToInt32(widthVal.Text);
            int height = Convert.ToInt32(heightVal.Text);

            if(x + width > mainPanel.Width)
            {
                x = 0;
                y += maxHeight;
                maxHeight = 0;
            }

            width = x + width > mainPanel.Width ? mainPanel.Width : width;
            height = y + height > (mainPanel.Height - y) ? mainPanel.Height - y : height;
            
            Label l = new Label
            {
                Text = $"{count++}",
                Size = new Size(width,height),
                Location = new Point(x,y),
                BorderStyle = BorderStyle.FixedSingle
            };

            x += width;

            maxHeight = maxHeight < height ? height : maxHeight;
            
            if (x > mainPanel.Width)
            {
                x = 0;
                y += maxHeight;
                maxHeight = 0;
            }

            label.Add(l);
            mainPanel.Controls.Add(l);

            widthVal.Clear();
            heightVal.Clear();
        }

        private void FormResize(object sender, EventArgs e)
        {
            LabelResize();
        }

        private void LabelResize()
        {
            int newX = 0, newY = 0, newMaxHeight = 0;
            int count = 1;

            foreach(Label l in label)
            {
                if(newX + l.Width > mainPanel.Width)
                {
                    newX = 0;
                    newY += newMaxHeight;
                    newMaxHeight = 0;
                }

                l.Location = new Point(newX, newY);
                l.Text = $"{count++}";
                newX += l.Width;

                newMaxHeight = newMaxHeight < l.Height ? l.Height : newMaxHeight;

                x = newX;
                y = newY;
                maxHeight = newMaxHeight;
            }
        }

        private void RemoveBtn(object sender, EventArgs e)
        {
            bool validCount = IsValidInput(removeVal, errorProvider3, "Enter valid number visible on the label");

            int removeLabel = Convert.ToInt32(removeVal.Text);
            if(!(removeLabel > 0) && !(removeLabel <= count))
            {
                MessageBox.Show("Enter the value displayed on label");
            }

            foreach(Label l in label)
            {
                if(removeLabel.ToString() == l.Text)
                {
                    label.Remove(l);
                    mainPanel.Controls.Remove(l);
                    LabelResize();
                    removeVal.Clear();
                    return;
                }
            }
        }

        private bool IsValidInput(TextBox textBox,ErrorProvider error,string message)
        {
            if (!int.TryParse(textBox.Text, out int value) || value <= 0)
            {
                error.SetError(textBox, message);
                return false;
            } 
            error.Clear();
            return true;
        }  
    }
}
