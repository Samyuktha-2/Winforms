using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Track
{
    public class ExpenseData
    {
        public string CATEGORY { get; set; }
        public int AMOUNT { get; set; }
        public Brush COLOR { get; set; }

        public ExpenseData(string category,int amount)
        {
            CATEGORY = category;
            AMOUNT = amount; 
        } 
    }
}
