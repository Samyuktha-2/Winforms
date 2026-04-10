using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_StickyNotes
{
    public partial class NotificationForm : Form
    {
        int stepValue = 0;
        public NotificationForm(string message)
        {
            InitializeComponent();

            msgLabel.Text = message;
            timer1.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            stepValue = progressBar1.Value +  10;
            if (stepValue <= progressBar1.Maximum)
            {
                progressBar1.Value = stepValue;
            }
            else
            {
                timer1.Stop();
                NotificationManager.Remove(this);
                this.Close();
            }
        }
    }
}
