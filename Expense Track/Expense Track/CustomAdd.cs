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
    public partial class CustomAdd : UserControl
    {
        public event Action<string, string> ItemAdded;

        public CustomAdd(string type)
        {
            InitializeComponent();

            typeTextBox.Text = type;
        }

        private void AddBtnClick(object sender, EventArgs e)
        {
            string newItem = categoryTextbox.Text.Trim();  

            if (string.IsNullOrEmpty(newItem))
            {
                MessageBox.Show("Please enter a value");
                return;
            }
             
            ItemAdded?.Invoke(typeTextBox.Text, newItem);

            categoryTextbox.Clear();
        }
    }
}
