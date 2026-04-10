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
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void DataGridView_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Charles", "10", "Melbourne", "2010-04-15");
            dataGridView1.Rows.Add("Enid", "10", "Melbourne", "2010-04-29");
            dataGridView1.Rows.Add("Baren", "6", "Melbourne", "2010-04-20");
            dataGridView1.Rows.Add("Abby", "10", "Melbourne", "2010-04-29");
            dataGridView1.Rows.Add("David", "5", "Melbourne", "2010-04-29");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.RemoveAt(3);
        } 

        private void navigate_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }
    }
}
