using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Track
{ 
    class Data
    {
        public DateTime DATE { get; set; }
        public string TYPE { get; set; }
        public string CATEGORY { get; set; }
        public int AMOUNT { get; set; } 
        
        public Data(DateTime date, string type,string category,int amount)
        {
            DATE = date;
            TYPE = type;
            CATEGORY = category;
            AMOUNT = amount; 
        } 
    }
}
