using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userControl
{
    public partial class loginPanel : UserControl
    {
        public loginPanel()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get { return userNameTextbox.Text; }
            set { userNameTextbox.Text = value; }
        }
    }
}
