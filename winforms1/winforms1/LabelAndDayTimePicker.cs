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
    public partial class LabelAndDayTimePicker : Form
    {
        public LabelAndDayTimePicker()
        {
            InitializeComponent();
        }

        private void LabelAndDayTimePicker_Load(object sender, EventArgs e)
        {
            label1.Text = "SELECT YOUR COUNTRY!";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker1.Value.ToString();  //date and time  
            label3.Text = dateTimePicker1.Value.Date.ToString("yyyy - MM - dd");  //only date  
            label4.Text = dateTimePicker1.Value.ToString("hh:mm:ss tt");  //only time 
            label5.Text = dateTimePicker1.Value.Month.ToString();  //only month  
        }
    }
}
