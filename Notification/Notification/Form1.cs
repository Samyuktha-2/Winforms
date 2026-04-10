using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }  

        private void AddNoti(object sender, EventArgs e)
        {
            int num = (int)numericUpDown1.Value;
            DateTime date = DateTime.Now;
            drawBell1.DrawString(num,date);

        } 

        private void ShowBtnClick(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (!int.TryParse(textBox2.Text, out int toView))
            {
                MessageBox.Show("Enter a valid number");
                return;
            }

            List<Notification> notifications = drawBell1.GetNotifications();

            if (notifications.Count == 0)
            {
                MessageBox.Show("No notifications available");
                return;
            }
             
            if (toView > notifications.Count)
            {
                toView = notifications.Count;
            }

            listView1.Visible = true;
            listView1.View = View.Details;
             
             
            for (int i = notifications.Count - 1; i >= notifications.Count() - toView; i--)
            {
                ListViewItem item = new ListViewItem(notifications[i].Num.ToString());
                item.SubItems.Add(notifications[i].Date.ToString("dd-MM-yyyy HH:mm:ss"));
                listView1.Items.Add(item); 
            }
        }
    }
}
