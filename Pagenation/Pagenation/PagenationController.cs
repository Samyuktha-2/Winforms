using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pagenation
{
    public partial class PagenationController : UserControl
    {
        private int selectedButton = 1;
        private int totalPages = 1;

        private int ButtonSizeWidth = 40;
        private int ButtonSizeHeight = 40;
        private int Gap = 6;

        public int TotalPages
        {
            get => totalPages;
            set
            {
                totalPages = value;
                selectedButton = Math.Min(selectedButton, totalPages);
                BuildUI();
            }
        }

        public PagenationController()
        {
            InitializeComponent();
            DoubleBuffered = true;

            Height = ButtonSizeWidth + 10 ;
            Width = (12) * (ButtonSizeWidth + Gap);
            MinimumSize = new Size(Width, Height);  
            BuildUI();
        }

        public void BuildUI()
        {
            Controls.Clear();

            int x = 0;
              
            AddNavButton("«", selectedButton > 1, () =>
            {
                selectedButton--;
                BuildUI();
            }, ref x);

            AddPageButtons(ref x);

            AddNavButton("»", selectedButton < totalPages, () =>
            {
                selectedButton++;
                BuildUI();
            }, ref x);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ButtonSizeWidth = (Width - (Gap * 12)) / 12;
            ButtonSizeHeight = Height - 10;
            BuildUI();
        }

        private void AddNavButton(string text, bool enabled, Action onClick, ref int x)
        {
            Button btn = CreateButton(text);
            btn.Enabled = enabled;
            btn.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            btn.Click += (s, e) => onClick();

            btn.Location = new Point(x, 5);
            Controls.Add(btn);
            x += ButtonSizeWidth + Gap;
        }

        private void AddPageButtons(ref int x)
        {
            const int TOTAL_VISIBLE = 10;

            if(TotalPages <= 10)
            { 
                for (int i = 1; i <= 10; i++)
                {
                    AddPageButton(i, ref x);
                }
                return;
            }
            AddPageButton(1, ref x);

            bool showLeftDots = selectedButton > 5;
            //bool showLeftDots = selectedButton >= 5;
            bool showRightDots = selectedButton < totalPages - 4;

            int slotsUsed = 2;
            if (showLeftDots) slotsUsed++;
            if (showRightDots) slotsUsed++;

            int middleSlots = TOTAL_VISIBLE - slotsUsed;

            int start = selectedButton - middleSlots / 2;
            int end = start + middleSlots - 1;

            start = Math.Max(start, 2);
            end = Math.Min(end, totalPages - 1);

            while (end - start + 1 < middleSlots)
            {
                if (start > 2) start--;
                else if (end < totalPages - 1) end++;
                else break;
            }

            if (showLeftDots)
                AddDots(ref x);

            for (int i = start; i <= end; i++)
                AddPageButton(i, ref x);

            if (showRightDots)
                AddDots(ref x);

            AddPageButton(totalPages, ref x);
        }

        private void AddPageButton(int page, ref int x)
        {
            Button btn = CreateButton(page.ToString());

            if (page == selectedButton)
            {
                btn.BackColor = Color.FromArgb(0, 120, 215);
                btn.ForeColor = Color.White;
            }

            btn.Click += (s, e) =>
            {
                selectedButton = page;
                BuildUI();
            };

            btn.Location = new Point(x, 5);
            Controls.Add(btn);
            x += ButtonSizeWidth + Gap;
        }

        private void AddDots(ref int x)
        {
            Label dots = new Label
            {
                Text = "...",
                Width = ButtonSizeWidth,
                Height = ButtonSizeWidth,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(x, 5)
            };

            Controls.Add(dots);
            x += ButtonSizeWidth + Gap;
        }

        private Button CreateButton(string text)
        {
            return new Button
            {
                Text = text,
                Width = ButtonSizeWidth,
                Height = ButtonSizeHeight,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.Black
            };
        }
    }
}
