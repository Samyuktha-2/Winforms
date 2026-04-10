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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int i = 1;
         

        private void addButton_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Button " + i++;
            outputFlowPanel.Controls.Add(btn);
        }

        int j = 1;
        private void tabAddButton_Click(object sender, EventArgs e)
        {
             


            TabPage t1 = new TabPage
            {
                Text = "Welcome tab" + j
            };

            TabPage t2 = new TabPage
            {
                Text = "Setting" + j++
            };

            tabControl1.Controls.Add(t1);
            tabControl1.Controls.Add(t2);
        }

        private void tabDelButton_Click(object sender, EventArgs e)
        {
             if(tabControl1.TabPages.Count > 0)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.TabPages.Count - 1);
            }
            else
            {
                MessageBox.Show("No more tabs to remove");
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex >= 0)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
            }
        }

        private void colorBtn_click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cd.Color;
            }
        }
    }
}
