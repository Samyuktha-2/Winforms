using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Task2_StickyNotes
{
    class NotificationManager
    {
        private static List<NotificationForm> notificationForms = new List<NotificationForm>();
        private static int spacing = 10;
        private static int rightMargin = 20;
        private static int bottomMargin = 20;
        private static int notiFormWidth;

        public static void Remove(NotificationForm nf)
        {
            if (notificationForms.Contains(nf))
            {
                notificationForms.Remove(nf);
                NotificationPosition();
            }
        }

        public static void Show(string msg)
        {
            NotificationForm nf = new NotificationForm(msg);
            notiFormWidth = nf.Width;
            notificationForms.Add(nf);
            NotificationPosition();
            nf.Show();
        } 

        public static void NotificationPosition()
        {
            Screen screen = Screen.PrimaryScreen;

            int x = screen.WorkingArea.Right - rightMargin - notiFormWidth;
            int y = screen.WorkingArea.Bottom - bottomMargin;
            
            foreach (var n in notificationForms)
            {
                n.Location = new Point(x, y - n.Height);
                y -= (n.Height + spacing);
            }
        }
    }
}
