using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        Form2 f2 = new Form2();
        private void showBtn_Click(object sender, EventArgs e)
        { 
            f2.Show();
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

         
        private void closeBtn_Click(object sender, EventArgs e)
        {
            f2.Hide();
        }
        private void showDialogBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Visible = {this.Visible}, IsDisposed = {this.IsDisposed}");
            f2.ShowDialog();
        }

         
    }
}

