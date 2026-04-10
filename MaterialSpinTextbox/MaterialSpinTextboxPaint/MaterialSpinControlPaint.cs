using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSpinTextboxPaint
{
    public partial class MaterialSpinControlPaint : UserControl
    {
        public MaterialSpinControlPaint()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            this.Size = new Size(215, 45);
            this.Location = new Point(0, 0);
        }

        Rectangle label = new Rectangle(54, 10, 100, 20);
        Rectangle negBtn = new Rectangle(7, 10, 41, 20); 
        Rectangle posBtn = new Rectangle(160, 10, 42, 20);
        private int _value = 0;
        private int min = 0;
        private int max = 100;
        private int step = 1;
        private int speed = 1;
        private bool isDragging = false;
        private int lastX;
        private int trackingPoint;

        public int Value
        {
            get => _value;
            set
            {
                if (value < min) _value = min;
                else if (value > max) _value = max;
                else _value = value;

                Invalidate();
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            
            g.DrawRectangle(Pens.Black, label);

            g.DrawString(_value.ToString(), new Font("Microsoft Sans Serif", 10F), Brushes.Black, new Point(100, 12));

            
            g.DrawRectangle(Pens.Black, negBtn);
            g.DrawRectangle(Pens.Black, posBtn);
            
            g.DrawString("-", new Font("Microsoft Sans Serif", 15F, FontStyle.Bold), Brushes.Black, new Point(22, 5));
            g.DrawString("+", new Font("Microsoft Sans Serif", 12F, FontStyle.Bold), Brushes.Black, new Point(170, 10));
        }

        private void MaterialSpinControlPaintClick(object sender, EventArgs e)
        {
            Point cursorPoint = this.PointToClient(Cursor.Position);
            if (negBtn.Contains(cursorPoint))
            {
                Value -= step;
            }
            else if (posBtn.Contains(cursorPoint))
            {
                Value += step;
            }
            Invalidate();
        }

        private void MaterialSpinControlPaintMouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point cursorPoint = this.PointToClient(Cursor.Position);
            if (label.Contains(cursorPoint))
            {
                textbox1.Visible = true;
                textbox1.Text = _value.ToString();
                textbox1.Focus();
                textbox1.SelectAll();
            }
        }

        private void TextBoxKeyDown(object sender,KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ApplyText();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBoxKeyPress(object sender,KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if(!char.IsControl(e.KeyChar) && e.KeyChar != '-' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textbox1, "Enter only numeric");
            }
        }

        private void ApplyText()
        {
            Value = int.Parse(textbox1.Text);
            Invalidate();
            textbox1.Visible = false;
        }

        private void MaterialSpinControlPaintMouseDown(object sender, MouseEventArgs e)
        {
            Point cursourPoint = this.PointToClient(Cursor.Position);
            if (label.Contains(cursourPoint))
            {
                isDragging = true;
                lastX = e.X;
            }
        }

        private void MaterialSpinControlPaintMouseMove(object sender, MouseEventArgs e)
        {
            if (!isDragging) return;

            int xDirection = e.X - lastX;
            ++trackingPoint;
            if(trackingPoint == IncrementSpeed)
            {
                if (xDirection > 0)
                    Value += step;
                else
                    Value -= step;

                Invalidate();
                trackingPoint = 0;
            } 
        }

        private void MaterialSpinControlPaintMouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            trackingPoint = 0;
        }
    }
}
