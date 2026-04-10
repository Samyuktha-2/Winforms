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
    public partial class Checkbox : Form
    {
        public Checkbox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Checkbox has been checked!");
            Application.Exit();
        }
         
        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("State = " + checkBox2.CheckState.ToString());
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "CheckedChange -> " + checkBox3.Checked.ToString();
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            label1.Text = "CheckStateChanged -> " + checkBox3.CheckState.ToString();
        }
    }
}
