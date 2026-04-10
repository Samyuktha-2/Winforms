using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Button());
            //Application.Run(new Checkbox());
            //Application.Run(new Colourdialog());
            //Application.Run(new Comboboxes());
            //Application.Run(new LabelAndDayTimePicker());
            Application.Run(new TextboxandPictureBox());
            //Application.Run(new RadioButtonandProgressBar());
            //Application.Run(new MessageBoxandGoupBox());
            //Application.Run(new ErrorProvider());
            //Application.Run(new DataGridView());
            //Application.Run(new Dialog());
            //Application.Run(new MDIParent1());
        }
    }
}
