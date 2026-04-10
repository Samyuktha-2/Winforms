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
    public partial class ErrorProvider : Form
    {
        private string username = "admin";
        private string password = "admin";
        public ErrorProvider()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(username) && textBox2.Text.Equals(password))
            {
                MessageBox.Show("Login sucessfull");
            }
            else
            {
                if (!textBox1.Text.Equals(username)) 
                    errorProvider1.SetError(textBox1,"Invalid username"); 
                else 
                    errorProvider1.Clear(); 

                if (!textBox2.Text.Equals(password)) 
                    errorProvider2.SetError(textBox2,"Invalid password"); 
                else 
                    errorProvider2.Clear(); 
            }
        }
    }
}
