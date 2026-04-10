using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MouseClick += (s, e) => checkClick = true;
            MouseDown += (s, e) =>
            {
                if (checkClick)
                {
                    checkClick = false;
                    changePanelPosition(e);
                }
            };
            
        }

        bool isDragging = false;
        Point dragCursorPoint;
        Point dragPanelPoint;

        bool checkClick = false;

        bool isResizing = false;
        string resizeDirection = "";
        const int resizeMargin = 8;
        Size oldPanelSize;
        
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            //panel drag movement
            if(e.Button == MouseButtons.Middle)
            {
                isDragging = true;
                dragCursorPoint = Cursor.Position;
                dragPanelPoint = panel.Location;

                panel.Cursor = Cursors.SizeAll;
                //panel.Cursor = Cursors.Hand;
            }

            //panel resize
            if(e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
            {
                resizeDirection = getResizeDirection(e.Location);
                if(resizeDirection != "")
                {
                    isResizing = true;
                }
                oldPanelSize = panel.Size;
            }
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            //pannel movement
            if (isDragging)
            {
                Point difference = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                panel.Location = Point.Add(dragPanelPoint, new Size(difference));
                panel.Cursor = Cursors.SizeAll;
            }

            //panel resize
            if (isResizing)
            {
                resizePanel(e);
                string dir = getResizeDirection(e.Location);
                switch (dir)
                {
                    case "Right":
                        panel.Cursor = Cursors.SizeWE; break;
                    case "Left":
                        panel.Cursor = Cursors.SizeWE; break;
                    case "Top":
                        panel.Cursor = Cursors.SizeNS; break;
                    case "Bottom":
                        panel.Cursor = Cursors.SizeNS; break;
                    case "TopLeft":
                    case "BottomRight":
                        panel.Cursor = Cursors.SizeNWSE; break;
                    case "TopRight":
                    case "BottomLeft":
                        panel.Cursor = Cursors.SizeNESW; break;
                    default:
                        panel.Cursor = Cursors.Default; break;
                }
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                isDragging = false;

                Point difference = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Point newLocation = Point.Add(dragPanelPoint, new Size(difference));


                if (newLocation.X < 0) newLocation.X = 0;
                if (newLocation.Y < 0) newLocation.Y = 0;

                if(newLocation.X + panel.Width > this.ClientSize.Width) newLocation.X = this.ClientSize.Width - panel.Width;
                if (newLocation.Y + panel.Height > this.ClientSize.Height) newLocation.Y = this.ClientSize.Height - panel.Height;

                panel.Location = new Point(newLocation.X, newLocation.Y);

                panel.Cursor = Cursors.Default;
            }

            if (isResizing)
            {
                isResizing = false;
                resizeDirection = "";
                panel.Cursor = Cursors.Default;
            }
        }
        
        private string getResizeDirection(Point mouse)
        {
            bool right = mouse.X >= panel.Width - resizeMargin;
            bool bottom = mouse.Y >= panel.Height - resizeMargin;
            bool left = mouse.X <= resizeMargin;
            bool top = mouse.Y <= resizeMargin;

            if (right && bottom) return "BottomRight";
            if (left && bottom) return "BottomLeft";
            if (right && top) return "TopRight";
            if (left && top) return "TopLeft";
            if (right) return "Right";
            if (left) return "Left";
            if (bottom) return "Bottom";
            if (top) return "Top";
            return "";
        }

        private void resizePanel(MouseEventArgs e)
        {
            int minWidth = 50, minHeight = 50;
            int maxWidth = this.ClientSize.Width, maxHeight = this.ClientSize.Height;

            if (resizeDirection.Contains("Right"))
            {
                int newWidth = e.X;
                int allowedWidth = Math.Min(newWidth, maxWidth - panel.Left);
                panel.Width = Math.Max(minWidth, allowedWidth);
            }

            if (resizeDirection.Contains("Bottom"))
            {
                int newHeight = e.Y;
                int allowedHeight = Math.Min(newHeight, maxHeight - panel.Top);
                panel.Height = Math.Max(minHeight, allowedHeight);
            }

            if (resizeDirection.Contains("Left"))
            {
                int newLeft = panel.Left + e.X;
                int newWidth = panel.Width - e.X;

                if (newLeft >= 0 && newWidth >= minWidth)
                {
                    panel.Left = newLeft;
                    panel.Width = Math.Min(newWidth, maxWidth - newLeft);
                }
            }

            if (resizeDirection.Contains("Top"))
            {
                int newTop = panel.Top + e.Y;
                int newHeight = panel.Height - e.Y;

                if(newTop >= 0 && newHeight >= minHeight)
                {
                    panel.Top = newTop;
                    panel.Height = Math.Min(newHeight, maxHeight - newHeight);
                }
            }
        }
        
        private void panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int resizeMargin = 10;

            bool nearTop = e.Y <= resizeMargin;
            bool nearLeft = e.X <= resizeMargin;

            if (nearLeft || nearTop) return;

            if (e.Button == MouseButtons.Left)
            {
                Point mouse = this.PointToClient(Cursor.Position);

                int newX = mouse.X - panel.Width / 2;
                int newY = mouse.Y - panel.Height / 2;

                if (newX < 0) newX = 0;
                if (newY < 0) newY = 0;

                if (newX + panel.Width > this.ClientSize.Width) newX = this.ClientSize.Width - panel.Width;
                if (newY + panel.Height > this.ClientSize.Height) newY = this.ClientSize.Height - panel.Height;

                panel.Location = new Point(newX, newY);
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Right)
            {
                panel.Size = oldPanelSize;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oldPanelSize = panel.Size;
        }

        private void changePanelPosition(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Point mouse = this.PointToClient(Cursor.Position);

                int newX = mouse.X - panel.Width / 2;
                int newY = mouse.Y - panel.Height / 2;

                if (newX < 0) newX = 0;
                if (newY < 0) newY = 0;

                if (newX + panel.Width > this.ClientSize.Width) newX = this.ClientSize.Width - panel.Width;
                if (newY + panel.Height > this.ClientSize.Height) newY = this.ClientSize.Height - panel.Height;

                panel.Location = new Point(newX, newY);
            }
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            panel.BackColor = Color.LightBlue;
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            panel.BackColor = Color.White;
        }
    }
}
