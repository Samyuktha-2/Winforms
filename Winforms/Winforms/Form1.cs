using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms  
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "Full Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Hello! {textBox1.Text} {textBox2.Text}");
            //textBox3.Text = $"{textBox1.Text} {textBox2.Text}";           
            //progressBar1.Value += 10;
            //Form2 form = new Form2();
            //form.Show();
            toolStripProgressBar1.Value += 50;
            toolStripStatusLabel1.Text = "Working.....";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Created by Sam");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
