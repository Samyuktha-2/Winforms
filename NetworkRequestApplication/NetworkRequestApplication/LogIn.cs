using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkRequestApplication
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void usernameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only alpahbets and numbers allowed");
            }
        }

        private void loginButton_OnClick(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text.Trim();
            string password = passwordTextbox.Text.Trim();

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Both fields must be filled", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();

            this.Hide();
        }

        private void showPasswordCheckbox_CheckedChanged(object sender,EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                passwordTextbox.PasswordChar = '\0';
            }
            else
            {
                passwordTextbox.PasswordChar = '*';
            }
        }

        private void LogIn_Resize(object sender, EventArgs e)
        {
            // Center loginPanel
            loginPanel.Left = (this.ClientSize.Width - loginPanel.Width) / 2;
            loginPanel.Top = (this.ClientSize.Height - loginPanel.Height) / 2;

            // Center login label (if you want it centered on top of panel)
            loginLabel.Left = (this.ClientSize.Width - loginLabel.Width) / 2;
            loginLabel.Top = loginPanel.Top - loginLabel.Height - 20; // 20px gap above panel
        }

    }
}
