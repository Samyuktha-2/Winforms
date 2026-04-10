using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation2
{
    public class Expense
    {
        public int Id { get; set; }
        public String Category { get; set; }
        public String CategoryName { get; set; }
        public int Amount { get; set; }
        public String Date { get; set; }
    }
    
    public class CategoryLimit
    {
        public String CategoryId { get; set; }
        public String Category { get; set; }
        public int Limit { get; set; }
    }

    public static class RegionEditor
    {
        public static List<Expense> liexpense = new List<Expense>();
        public static List<CategoryLimit> licategory = new List<CategoryLimit>();
        public static List<CategoryLimit> licategoryview = new List<CategoryLimit>();
        public static Dictionary<String, int> budgetlimit = new Dictionary<String, int>();

        static int id = 0,cid=1;
        static String categoryid = "";


        public static bool AddExpense(Expense epx)
        {
            String sdate = epx.Date.Substring(3, 7);
            for (int i = 0; i < licategory.Count; i++)
            {
                if (epx.Category == licategory[i].Category)
                {
                    if (budgetlimit.ContainsKey(sdate))
                       {
                        if (budgetlimit[sdate] + epx.Amount <= licategory[i].Limit)
                        {
                            budgetlimit[sdate] = budgetlimit[sdate] + epx.Amount;
                            break;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (epx.Amount <= licategory[i].Limit)
                        {
                            budgetlimit.Add(sdate, epx.Amount);
                            break;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            id++;
            Expense ep = new Expense
            {
                Id =id,
                Category = epx.Category,
                CategoryName = epx.CategoryName,
                Amount = epx.Amount,
                Date = epx.Date
            };
            liexpense.Add(ep);
            return true;
        }

        public static bool EditExpense(Expense epx,int changid)
        {
            for (int k = 0; k < liexpense.Count; k++)
            {
                if (liexpense[k].Id == changid)
                {
                    String sdate = liexpense[k].Date.Substring(3, 7);
                    for (int i = 0; i < licategory.Count; i++)
                    {
                        if (liexpense[k].Category == licategory[i].Category)
                        {
                            if (budgetlimit.ContainsKey(sdate))
                            {
                                if (budgetlimit[sdate] + epx.Amount -liexpense[k].Amount <= licategory[i].Limit)
                                {
                                    budgetlimit[sdate] = budgetlimit[sdate] + epx.Amount - liexpense[k].Amount;
                                    id++;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    liexpense[k].Category = epx.Category;
                    liexpense[k].CategoryName = epx.CategoryName;
                    liexpense[k].Amount = epx.Amount;
                    liexpense[k].Date = epx.Date;
                    return true;
                }
            }
            return false;
        }

        public static bool DeleteExpense(int changid)
        {
            for (int i = 0; i < liexpense.Count; i++)
            {
                if (liexpense[i].Id == changid)
                {
                    liexpense.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public static void AddCategory(CategoryLimit clt)
        {
            CategoryLimit cl = new CategoryLimit
            {
                CategoryId = categoryid,
                Category = clt.Category,
                Limit = clt.Limit
            };
            licategory.Insert(licategory.Count - 1, cl);
            licategoryview.Insert(licategoryview.Count - 1, cl);
            Changecategoryid();
        }

        public static bool DeleteCategory(CategoryLimit clt)
        {
            for (int i = 0; i < licategory.Count - 1; i++)
            {
                if (licategory[i].Category == clt.Category)
                {
                    licategory.RemoveAt(i);
                    licategoryview.RemoveAt(i);
                    foreach (Expense j in RegionEditor.liexpense)
                    {
                        if (j.Category == clt.Category)
                        {
                            j.Category = "Others";
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static void EditCategory(CategoryLimit clt,String oldname)
        {
            for (int i = 0; i < licategory.Count - 1; i++)
            {
                if (licategory[i].Category == oldname)
                {
                    licategory[i].Category = clt.Category;
                    licategoryview[i].Category = clt.Category;
                    licategory[i].Limit = clt.Limit;
                    for (int j = 0; j < liexpense.Count; j++)
                    {
                        if (liexpense[j].Category == oldname)
                        {
                            liexpense[j].Category = clt.Category;
                        }
                    }
                }
            }
        }

        public static void CategoryAdd()
        {
            Changecategoryid();
            CategoryLimit cl1 = new CategoryLimit
            {
                CategoryId = categoryid,
                Category = "Food",
                Limit = 5000
            };
            licategoryview.Add(cl1);
            licategory.Add(cl1); Changecategoryid();
            CategoryLimit cl2 = new CategoryLimit
            {
                CategoryId = categoryid,
                Category = "Clothes",
                Limit = 4000
            };
            licategoryview.Add(cl2);
            licategory.Add(cl2); Changecategoryid();
            CategoryLimit cl3 = new CategoryLimit
            {
                CategoryId = categoryid,
                Category = "Travel",
                Limit = 2000
            };
            licategoryview.Add(cl3);
            licategory.Add(cl3); Changecategoryid();
            CategoryLimit cl4 = new CategoryLimit
            {
                CategoryId = categoryid,
                Category = "Car expense",
                Limit = 3500
            };
            licategoryview.Add(cl4);
            licategory.Add(cl4); Changecategoryid();
            CategoryLimit cl5 = new CategoryLimit
            {
                CategoryId = categoryid,
                Category = "Domestic expense",
                Limit = 1500
            };
            licategoryview.Add(cl5);
            licategory.Add(cl5); Changecategoryid();
            CategoryLimit cl6 = new CategoryLimit
            {
                CategoryId = categoryid,
                Category = "Others",
                Limit = 5000
            };
            licategoryview.Add(cl6);
            licategory.Add(cl6); Changecategoryid();
        }

        public static void Changecategoryid()
        {
            categoryid = "C" + cid;
            cid++;
        }

    }
}
