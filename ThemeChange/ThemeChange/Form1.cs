using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ThemeChange.Theme.Theme;

namespace ThemeChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        private AppTheme currentTheme = AppTheme.Light;

        private void ThemeBtn_Click(object sender, EventArgs e)
        {
            currentTheme = currentTheme == AppTheme.Light ? AppTheme.Dark : AppTheme.Light;
            ApplyTheme(currentTheme);
            ApplyThemeToControls(this);
        }
    }
}
