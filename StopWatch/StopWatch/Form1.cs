using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            label1.Text = "00:00:00:00";
        }

        private TimeSpan elapsedTime = TimeSpan.Zero;

        private void StartClick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void StopClick(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void ResetClick(object sender, EventArgs e)
        {
            timer1.Stop();
            elapsedTime = TimeSpan.Zero;
            label1.Text = "00:00:00:00";
            
        }

        private void TimerTick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromMilliseconds(timer1.Interval));
            label1.Text = elapsedTime.ToString(@"hh\:mm\:ss\:ff");  //h -> hour, m -> minute, s -> second, f -> fraction of second

        }
    }
}
