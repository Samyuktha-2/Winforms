using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practise
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            if (e.Link.LinkData != null)   // check to avoid null crash
            {
                linkLabel1.LinkVisited = true;

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = e.Link.LinkData.ToString(),
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("No link data found!");
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "Visit school website";
            linkLabel1.Links.Clear();
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://www.yellowtrainschool.com/");
             
        }

        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime start = monthCalendar1.SelectionStart;
            DateTime end = monthCalendar1.SelectionEnd;
            MessageBox.Show($"Selected: {start.ToShortDateString()} to {end.ToShortDateString()}");
        }
    }
}
