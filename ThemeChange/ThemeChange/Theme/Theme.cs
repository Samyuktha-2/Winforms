using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemeChange.Theme
{
    public class Theme
    {
        public enum AppTheme
        {
            Light,Dark
        }

        public static Color BackColor;
        public static Color ForeColor;
        public static Color ButtonColor;
        public static Color PanelColor;
        public static Color TextboxColor;
        public static Color LabelBackColor;

        public static void ApplyTheme(AppTheme appTheme)
        {
            if(appTheme == AppTheme.Dark)
            {
                BackColor = Color.DimGray;
                ForeColor = Color.AntiqueWhite;
                ButtonColor = Color.LightGray;
                PanelColor = Color.LightPink;
                TextboxColor = Color.Transparent;
                LabelBackColor = Color.LightPink;
            }
            else
            {
                BackColor = Color.White;
                ForeColor = Color.Black;
                ButtonColor = Color.PeachPuff;
                PanelColor = Color.Peru;
                //TextboxColor = Color.Transparent;
                LabelBackColor = Color.Peru;
            }
        }

        public static void ApplyThemeToControls(Control control)
        {
            control.BackColor = Theme.BackColor;
            control.ForeColor = Theme.ForeColor;
            if(control is Button)
            {
                control.BackColor = Theme.ButtonColor;
            }
            if(control is Panel)
            {
                control.BackColor = Theme.PanelColor;
            }
            //if(control is TextBox)
            //{
            //    control.BackColor = Theme.TextboxColor;
            //}
            if (control is Label)
            {
                control.BackColor = Theme.LabelBackColor;
            }

            foreach (Control c in control.Controls)
            {
                ApplyThemeToControls(c);
            }
        }
    }
}
