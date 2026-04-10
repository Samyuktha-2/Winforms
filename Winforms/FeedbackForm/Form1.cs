using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackForm
{
    public partial class feedbackForm : Form
    {
        public feedbackForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name: {nameText.Text}\nDesignation: {designationText.Text}\nFeedback: {feedbackText.Text}");
        }


    }
}
