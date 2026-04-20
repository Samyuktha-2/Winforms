using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Anounmyous Method
            button1.Click += delegate (object sender, EventArgs e)
              {
                  MessageBox.Show("Button1 Clicked thru Anounmyous Method");
              };

            //Lambda Expression
            button2.Click += (sender, e) => MessageBox.Show("Button2 clicked thru Lambda Expression");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Enter value");
                return;
            }

            int num = Int32.Parse(textBox1.Text);

            label1.Text = (num * num).ToString();

            textBox1.Text = "";

        }
    }
}
