using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        public event EventHandler<string> LoginSuccess;

        private void LoginBtn(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usernameTxtBox.Text))
            { 
                LoginSuccess?.Invoke(this, usernameTxtBox.Text);
            }
            else
            {
                MessageBox.Show("Please enter username");
            }
        }
    }
}
