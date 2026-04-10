using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSpinTextbox
{
    public partial class MaterialSpinControl : UserControl
    {
        private int min = 0;
        private int max = 100;
        private int _value = 0;
        private int step = 1;
        private bool isDragging = false;
        private int lastX;
        private int speed = 1;
        private int trackPoint;

        public int Value
        {
            get => _value;
            set
            {
                if (value < min) _value = min;
                else if (value > max) _value = max;
                else _value = value;

                UpdateLabel();
            }
        }
         
        public int Min
        {
            get => min;
            set
            {
                if (value >= max)
                {
                    max = value + 1;
                }

                min = value;

                if (_value < min)
                    Value = min;
            }
        }


        public int Max
        {
            get => max;
            set
            {
                if (value <= min)
                {
                    min = value - 1;    
                }

                max = value;

                if (_value > max)
                    Value = max;
            }
        }


        public int IncrementStep
        {
            get => step;
            set
            {
                step = value > 0 ? value : 1;
            }
        }

        public int IncrementSpeed
        {
            get => speed;
            set
            {
                speed = value;
            }
        }

        public MaterialSpinControl()
        {
            InitializeComponent();
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            label1.Text = _value.ToString();
        } 

        private void Increment(object sender, EventArgs e)
        {
            Value += step;
            UpdateLabel();
        }

        private void Decrement(object sender, EventArgs e)
        {
            Value -= step;
            UpdateLabel();
        }

        private void Label1MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastX = e.X;
            trackPoint = 0;
        }

        private void LabelMouseMove(object sender, MouseEventArgs e)
        {
            if (!isDragging) return;

            int xDirection = e.X - lastX;
            ++trackPoint;
            if (trackPoint == IncrementSpeed)
            {
                if(xDirection > 0)
                Value += step;
                else
                {
                    Value -= step;
                    
                }
                UpdateLabel();
                trackPoint = 0;
            }  
        }

        private void LabelMouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            trackPoint = 0;
        }

        private void LabelMouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = false;
            textBox1.Text = label1.Text;

            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if (!char.IsControl(e.KeyChar) && e.KeyChar != '-' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox1, "Enter only numeric");
            }
        } 

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyText();
                e.SuppressKeyPress = true;
            }
        }

        private void ApplyText()
        {
            Value = int.Parse(textBox1.Text); 
            label1.Visible = true;
            textBox1.Visible = false;
        }
    }
}
