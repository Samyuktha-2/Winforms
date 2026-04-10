using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSpinTextboxPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MinValueLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minValue.Text))
                materialSpinControlPaint1.Min = int.Parse("0");
            else
                materialSpinControlPaint1.Min = int.Parse(minValue.Text);
        }

        private void MaxValueLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maxValue.Text))
                materialSpinControlPaint1.Max = int.Parse("100");
            else
                materialSpinControlPaint1.Max = int.Parse(maxValue.Text);
        }

        private void IncrementStepValueLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(incrementStepValue.Text))
                materialSpinControlPaint1.IncrementStep = int.Parse("1");
            else
                materialSpinControlPaint1.IncrementStep = int.Parse(incrementStepValue.Text);
        }

        private void IncrementSpeedValueLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(incrementSpeedValue.Text))
                materialSpinControlPaint1.IncrementStep = int.Parse("1");
            else
                materialSpinControlPaint1.IncrementSpeed = int.Parse(incrementSpeedValue.Text);
        }

        private void MinValueKeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if (!char.IsControl(e.KeyChar) && e.KeyChar != '-' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(minValue, "Enter only numeric");
            }
        }

        private void MaxValueKeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider2.Clear();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider2.SetError(maxValue, "Enter only numeric");
            }
        }
         
        private void IncrementStepValueKeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider3.Clear();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider3.SetError(incrementStepValue, "Enter only numeric");
            }
        } 

        private void IncrementSpeedValueKeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider4.Clear();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider4.SetError(incrementSpeedValue, "Enter only numeric");
            } 
        }
    }
}
