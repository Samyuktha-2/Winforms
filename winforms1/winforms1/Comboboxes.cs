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
    public partial class Comboboxes : Form
    {
        int counter = 4;
        public Comboboxes()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Item " + counter);
            counter++;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            //removed as per selected item, if item not selected no error is shown
            comboBox1.Items.Remove(comboBox1.SelectedItem);   

            //same removed as per selected item but based on index 
            //if no item is selected then argument out of range value -1 error is thrown
            //comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);  
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
