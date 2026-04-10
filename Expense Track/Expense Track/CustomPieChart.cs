using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Track
{
    public partial class CustomPieChart : UserControl
    {
        private BindingList<ExpenseData> ExpenseRecords;
        private int Income;
        private int Balance; 

        public CustomPieChart()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Size = new Size(300, 300);
        }

        public void SetData(BindingList<ExpenseData> records, int income, int balance)
        {
            ExpenseRecords = records;
            Income = income;
            Balance = balance;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Income <= 0 || ExpenseRecords == null || ExpenseRecords.Count == 0)
                return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle pieRect = new Rectangle(20, 20, 200, 200);
            float startAngle = 0f;

            int total = ExpenseRecords.Count;
            int index = 0;
             
            foreach (var exp in ExpenseRecords)
            {
                Color shade = GetShade(index, total);
                using (Brush brush = new SolidBrush(shade))
                {
                    float sweepAngle = (float)exp.AMOUNT / Income * 360f;
                    g.FillPie(brush, pieRect, startAngle, sweepAngle);
                    g.DrawPie(Pens.White, pieRect, startAngle, sweepAngle);

                    startAngle += sweepAngle;
                }
                index++;
            }
             
            float balanceAngle = (float)Balance / Income * 360f;
            Color balanceColor = ControlPaint.DarkDark(baseColor);

            using (Brush balanceBrush = new SolidBrush(balanceColor))
            {
                g.FillPie(balanceBrush, pieRect, startAngle, balanceAngle);
                g.DrawPie(Pens.White, pieRect, startAngle, balanceAngle);
            }
             
            PieDetails(g);
        }



        private void PieDetails(Graphics g)
        {
            if (ExpenseRecords == null || ExpenseRecords.Count == 0)
                return;

            int x = 240;
            int y = 30;
            int boxSize = 15;
            int gap = 30;

            Font font = new Font("Times New Roman", 10);

            int totalItems = ExpenseRecords.Count + 1;  
             
            g.FillRectangle(Brushes.Black, x - 10, y - 10, 150, totalItems * gap);
            g.DrawRectangle(Pens.White, x - 10, y - 10, 150, totalItems * gap);

            int index = 0;
             
            foreach (var exp in ExpenseRecords)
            {
                Color shade = GetShade(index, ExpenseRecords.Count);

                using (Brush brush = new SolidBrush(shade))
                {
                    g.FillRectangle(brush, x, y, boxSize, boxSize);
                }

                float percent = ((float)exp.AMOUNT / Income) * 100;
                string text = $"{exp.CATEGORY} - {percent}%";
                g.DrawRectangle(Pens.White, x, y, boxSize, boxSize);
                g.DrawString(text, font, Brushes.White, x + 25, y - 2);

                y += gap;
                index++;
            }
             
            Color balanceColor = ControlPaint.DarkDark(baseColor);

            using (Brush balanceBrush = new SolidBrush(balanceColor))
            {
                g.FillRectangle(balanceBrush, x, y, boxSize, boxSize);
            }

            g.DrawRectangle(Pens.White, x, y, boxSize, boxSize);
            g.DrawString("Balance", font, Brushes.White, x + 25, y - 2);
        }


        Color baseColor = Color.Turquoise;

        private Color GetShade(int index, int total)
        {
            float factor = 0.55f + (0.3f * index / Math.Max(1, total - 1));

            int r = (int)(baseColor.R * factor);
            int g = (int)(baseColor.G * factor);
            int b = (int)(baseColor.B * factor);

            return Color.FromArgb(r, g, b);
        }
    }

}



