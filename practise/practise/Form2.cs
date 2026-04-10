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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
            this.VisibleChanged += Form2_VisibleChanged;
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load (object sender, EventArgs e)
        {
            MessageBox.Show("Form2 Load fired (only once at startup)");
        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
           // MessageBox.Show($"Form2 VisibleChanged fired, Visible = {this.Visible}");
        }
    }
}
