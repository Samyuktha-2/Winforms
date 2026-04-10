using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms1
{
    public partial class RadioButtonandProgressBar : Form
    {
        public RadioButtonandProgressBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "radioButton1 is checked";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "radioButton2 is checked";
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "radioButton3 is checked";
            }
        }

        private void RadioButtonandProgressBar_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 50;
            }
            else
            {
                MessageBox.Show("Loaded");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 100; i++)
            {
                progressBar3.Value = i;

                await Task.Delay(25); //UI will be responsive and progress visible smoothly

                //System.Threading.Thread.Sleep(25);  //the whole form will sleep for 2.5sec (25 millisec)
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender,e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (progressBar4.Value < 100)
            {
                progressBar4.Value += 1;
            }
        }
    }
}
