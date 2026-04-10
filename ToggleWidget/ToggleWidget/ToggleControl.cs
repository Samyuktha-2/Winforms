using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace ToggleWidget
{
    public partial class ToggleControl : UserControl
    {
        int currentKnobX;
        int targetKnobX;
        Timer timer = new Timer();
        int timerSpeed = 4;
        private bool isOn = false;
        int padding = 4;
        int knobDiameter;


        public bool Checked
        {
            get => isOn;
            set
            {
                if (isOn == value) return;
                isOn = value;
                TriggerTimer();
            }
        }

        public ToggleControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true; 
            this.Size = new Size(200, 125);
            knobDiameter = Height - padding * 2;

            currentKnobX = padding;
            targetKnobX = padding;
             
            timer.Interval = 10;
            timer.Tick += TimerTick;
            
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Color bg = isOn ? Color.Green : Color.Gray;
           
            using (GraphicsPath gp = GetRoundedRect(rect, Height / 2)) 
            using(SolidBrush brush = new SolidBrush(bg))
            {
                g.FillPath(brush, gp);
                
            }

            knobDiameter = Height - padding * 2;
            int knobX = currentKnobX;  //-> animation used here
            //int knobX = isOn ? Width - knobDiameter - padding : padding;
            int knobY = (Height - knobDiameter) / 2;
            using (SolidBrush knobBrush = new SolidBrush(Color.WhiteSmoke))
            {
                g.FillEllipse(knobBrush, knobX, knobY, knobDiameter, knobDiameter);
            }

            string text = isOn ? "ON" : "OFF";

            using (Font font = new Font("Segoe UI", Height / 4f, FontStyle.Bold))
            using (Brush textBrush = new SolidBrush(isOn ? Color.Black : Color.White))
            {
                SizeF textSize = g.MeasureString(text, font);

                float textX = isOn ? padding : Width - textSize.Width - padding;
                float textY = (Height - textSize.Height) / 2f;

                g.DrawString(text, font, textBrush, textX, textY);
            }

        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            if (diameter > rect.Width || diameter > rect.Height)
            {
                diameter = Math.Min(rect.Width, rect.Height);
                radius = diameter / 2;
            }

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            //path.AddArc(rect.X, rect.Y, rect.Width/2, diameter, 90, 180);
            //path.AddArc(rect.Width/2, rect.Y , rect.Width/2, diameter, 270, 180);
            //path.CloseFigure();

            return path;
        }
         

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            isOn = !isOn;                   
        }

        private void TriggerTimer()
        {
            targetKnobX = isOn ? Width - knobDiameter - padding : padding;
            //true -> on -> end of box
            //false -> off -> beginning of box
            timer.Start();
        }

        private void TimerTick(object sender,EventArgs e)
        {
            if(currentKnobX < targetKnobX)
            {
                currentKnobX += timerSpeed;
            }
            else if(targetKnobX < currentKnobX)
            {
                currentKnobX -= timerSpeed;
            }

            if (Math.Abs(currentKnobX - targetKnobX) <= timerSpeed)
            {
                currentKnobX = targetKnobX;
                timer.Stop();
            }
            Invalidate();
        }
    }
}
