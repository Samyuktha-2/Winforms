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
    public partial class TextboxandPictureBox : Form
    {
        public TextboxandPictureBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (checkBox1.Checked)
            {
                if(textBox6.TextLength != 0)
                {
                    textBox6.ReadOnly = true;
                    checkBox1.Enabled = false;
                }
                else
                {
                    errorProvider1.SetError(textBox6, "Textbox cannot be empty. Enter valid text");
                    //MessageBox.Show("Textbox cannot be empty. Enter valid text");
                }
            }
            else
            {
                if (textBox6.TextLength == 0)
                {
                    errorProvider1.SetError(textBox6, "Textbox cannot be empty. Enter valid text");
                    //MessageBox.Show("Textbox cannot be empty. Enter valid text");
                }
                else
                {
                    errorProvider1.SetError(textBox6, "Click on check box!");
                    //MessageBox.Show("Click on check box!");
                }  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //user_icon1 must be there in bin -> debug folder
            pictureBox3.Load("user_icon1.png");
            pictureBox4.Image = Image.FromFile("user_icon1.png"); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox1.Text);
            MessageBox.Show(maskedTextBox2.Text);
            MessageBox.Show(maskedTextBox3.Text);
        }
    }
}