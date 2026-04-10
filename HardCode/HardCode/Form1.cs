using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender,EventArgs e)
        {
            MessageBox.Show($"Name: {nameTextbox.Text}\nDesignation: {designationTextbox.Text}\nFeedback: {feedbackTextbox.Text}");
            nameTextbox.Clear();
            designationTextbox.Clear();
            feedbackTextbox.Clear();
        }

        private void nameTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextbox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("This field cannot be empty!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
