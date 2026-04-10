using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicCalender
{
    public partial class DynamicCalender : Form
    {
        public DynamicCalender()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            Resize += (s, e) => Invalidate();
            Paint += DynamicCalenderPaint;

        }

        DateTime currentMonth = DateTime.Now;

        private void DynamicCalenderPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            DrawCalender(g);
        }

        private void DrawCalender(Graphics g)
        {
            int padding = 20;
            int headerHeight = 50;
            int dayHeaderHeight = 30;

            int col = 7;
            int row = 6;

            int cellWidth = (this.ClientSize.Width - padding * 2) / col;
            int cellHeight = (this.ClientSize.Height - headerHeight - padding * 2) / row;

            DrawHeader(g, padding);
            DrawDayNames(g, padding, headerHeight, cellWidth);
            DrawDates(g, padding, headerHeight, cellWidth, cellHeight);
        }

        private void DrawHeader(Graphics g,int padding)
        {
            string month = currentMonth.ToString("MMMM yyyy");
            Font font = new Font("Times new roman", 16, FontStyle.Bold);

            SizeF size = g.MeasureString(month, font);

            g.DrawString(month, font, Brushes.Black, (ClientSize.Width - size.Width) / 2, padding);
        }

        private void DrawDayNames(Graphics g,int padding,int headerHeight,int cellWidth)
        {
            string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            Font font = new Font("Times new roman", 14, FontStyle.Bold);

            for(int i = 0; i < days.Length; i++)
            {
                Rectangle rect = new Rectangle(padding + i * cellWidth, headerHeight, cellWidth, 30);
                g.DrawString(days[i], font, Brushes.Black, rect, new StringFormat { Alignment = StringAlignment.Center });
                g.DrawRectangle(Pens.Black, rect);
            }
        }

        private void DrawDates(Graphics g,int padding, int headerHeight, int cellWidth,int cellHeight)
        {
            DateTime firstDay = new DateTime(currentMonth.Year, currentMonth.Month, 1);

            int daysInMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);
            int startDate = (int)firstDay.DayOfWeek;

            Font font = new Font("times new roman", 10);

            int date = 1;
            for(int row = 0; row < 6; row++)
            {
                for(int col = 0; col < 7; col++)
                {
                    int index = row * 7 + col;

                    Rectangle cell = new Rectangle(padding + col * cellWidth, headerHeight + 30 + row * cellHeight, cellWidth, cellHeight);
                    
                    

                    if(index >= startDate && date <= daysInMonth)
                    {
                        g.DrawRectangle(Pens.Gray, cell);
                        g.DrawString(date.ToString(), font, Brushes.Black, cell.X + 10, cell.Y + 10);

                        if (isToday(date))
                        {
                            g.DrawEllipse(Pens.Red, cell.X + 5, cell.Y + 5, 25, 25);
                        }
                        date++;
                    }
                }
            }
        }

        bool isToday(int date)
        {
            DateTime today = DateTime.Today;
            return today.Year == currentMonth.Year && today.Month == currentMonth.Month && today.Day == date;
        }

        private void NextMonth(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(1);
            Invalidate();
        }

        private void PreviousMonth(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(-1);
            Invalidate();
        }
    }
}
