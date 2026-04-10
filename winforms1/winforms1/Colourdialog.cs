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
    public partial class Colourdialog : Form
    {
        public Colourdialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result =  colorDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;  //changes button colour
                //BackColor = colorDialog1.Color;  //changes background colour
            }
        }
    }
}
