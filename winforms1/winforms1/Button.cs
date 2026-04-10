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
    public partial class Button : Form
    {
        public Button()
        {
            InitializeComponent();
        }

        private void msgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void clickMe_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
