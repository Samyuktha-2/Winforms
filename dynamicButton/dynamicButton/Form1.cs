using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamicButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (rowTextBox.Text == "" || colTextBox.Text == "")
            {
                MessageBox.Show("Enter valid input");
            }

            this.outputpanel.Controls.Clear();

            int buttonCount = 1;

            int row = int.Parse(rowTextBox.Text);
            int col = int.Parse(colTextBox.Text);

            int boxWidth = this.outputpanel.Width;
            int boxHeight = this.outputpanel.Height;

            int btnWidth = boxWidth / col;
            int btnHeight = boxHeight / row;

            for(int r = 0; r < row; r++)
            {
                for(int c = 0; c < col; c++)
                {
                    Button btn = new Button
                    {
                        Text = $"{buttonCount++}",
                        Width = btnWidth,
                        Height = btnHeight,
                        Left = c * btnWidth,
                        Top = r * btnHeight
                    };

                    this.outputpanel.Controls.Add(btn);
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (rowTextBox.Text == "" || colTextBox.Text == "")
            {
                MessageBox.Show("Enter valid input");
            }

            int row = int.Parse(rowTextBox.Text);
            int col = int.Parse(colTextBox.Text);

            int boxWidth = outputpanel.Width;
            int boxHeight = outputpanel.Height;

            int btnWidth = boxWidth / col;
            int btnHeight = boxHeight / row;

            int buttonCount = 0;

            foreach (Control ctrl in outputpanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    int r = buttonCount / col;
                    int c = buttonCount % col;

                    btn.Width = btnWidth;
                    btn.Height = btnHeight;
                    btn.Left = c * btnWidth;
                    btn.Top = r * btnHeight;

                    buttonCount++;
                }
            }

        }



    }
}
