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
    public partial class CustomFilter : UserControl
    {
        ComboBox expense;
        ComboBox income;

        public event Action<string,string,int,int> Filter;
        public event EventHandler Remove;

        public CustomFilter(ComboBox expenseComboBox,ComboBox incomeComboBox)
        {
            InitializeComponent();

            expense = expenseComboBox;
            income = incomeComboBox;
            startRange.KeyPress += AmountEntred;
            endRange.KeyPress += AmountEntred;
        }

        private void ApplyFilter(object sender, EventArgs e)
        {
            string type = comboBox1.SelectedItem?.ToString();
            string category = categoryComboBox.SelectedItem?.ToString();

            int startAmt = 0;
            int endAmt = int.MaxValue;

            int.TryParse(startRange.Text, out startAmt);
            int.TryParse(endRange.Text, out endAmt);

            if (startAmt > endAmt)
            {
                MessageBox.Show("Start amount cannot be greater than end amount");
                return;
            }

            Filter?.Invoke(type, category, startAmt, endAmt);
        }

        private void TypeSelectedIndexChanged(object sender, EventArgs e)
        {
            categoryComboBox.Items.Clear(); 
            if(comboBox1.SelectedItem.ToString() == "Expense")
            {
                object[] items = new object[expense.Items.Count];
                expense.Items.CopyTo(items, 0);
                categoryComboBox.Items.AddRange(items);
            }
            else if(comboBox1.SelectedItem.ToString() == "Income")
            {
                object[] items = new object[income.Items.Count];
                income.Items.CopyTo(items, 0);
                categoryComboBox.Items.AddRange(items);
            } 
        }

        private void RemoveFilter(object sender, EventArgs e)
        {
            Remove?.Invoke(sender, e);
        }

        private void AmountEntred (object sender,KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
