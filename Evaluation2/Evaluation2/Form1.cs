using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        String datetime = "", category = "", categoryname = "";
        int rangeamount = 0, amount, changeid;

        private void Badd_Click(object sender, EventArgs e)
        {
            if (categorycb.Text.Length > 0 && datepicker.Value.ToShortDateString().Length > 0 && amounttb.TextLength > 0 && Categorynametb.TextLength > 0)
            {
                category = categorycb.Text;
                categoryname = Categorynametb.Text;
                datetime = datepicker.Value.ToShortDateString();
                amount = int.Parse(amounttb.Text);
                Expense ep = new Expense
                {
                    Category = category,
                    CategoryName = categoryname,
                    Amount = amount,
                    Date = datetime
                };
                bool bol=RegionEditor.AddExpense(ep);
                if (bol==false)
                {
                    MessageBox.Show("Amount Limit Exceeds!!!");
                    return;
                }
                dt.Clear();
                for (int i = 0; i < RegionEditor.liexpense.Count; i++)
                {
                    dt.Rows.Add(RegionEditor.liexpense[i].Id, RegionEditor.liexpense[i].Category, RegionEditor.liexpense[i].CategoryName, RegionEditor.liexpense[i].Amount, RegionEditor.liexpense[i].Date);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Details to Add");
            }
        }

        private void Bedit_Click(object sender, EventArgs e)
        {
            Peditordelete.Visible = true;
            EditorDelete.Text = "Edit";
            Badd.Enabled = false;
            Bedit.Enabled = false;
            Bremove.Enabled = false;
            pviewdifferent.Enabled = false;
        }

        private void Bremove_Click(object sender, EventArgs e)
        {
            Peditordelete.Visible = true;
            EditorDelete.Text = "Delete";
            Badd.Enabled = false;
            Bedit.Enabled = false;
            Bremove.Enabled = false;
            paddeditremove.Enabled = false;
            pviewdifferent.Enabled = false;
        }

        private void EditorDelete_Click(object sender, EventArgs e)
        {
            if (changeidtb.TextLength > 0)
            {
                changeid = int.Parse(changeidtb.Text);
            }
            else
            {
                MessageBox.Show("Enter valid Id");
                return;
            }
            if (EditorDelete.Text == "Edit")
            {
                category = categorycb.Text;
                categoryname = Categorynametb.Text;
                datetime = datepicker.Value.ToShortDateString();
                if (amounttb.TextLength > 0)
                {
                    amount = int.Parse(amounttb.Text);
                }
                Expense ep = new Expense
                {
                    Category = category,
                    CategoryName = categoryname,
                    Amount = amount,
                    Date = datetime
                };
                bool bol=RegionEditor.EditExpense(ep,changeid);
                if ( bol==false)
                {
                    MessageBox.Show("Amount Limit Exceeds!!!");
                    return;
                }
                //else if (RegionEditor.count == -1)
                //{
                //    MessageBox.Show("Invalid Id!!!");
                //    return;
                //}
            }
            else if (EditorDelete.Text == "Delete")
            {
                bool b=RegionEditor.DeleteExpense(changeid);
                if (b==false)
                {
                    MessageBox.Show("Invalid Id");
                }
            }
            dt.Clear();
            for (int i = 0; i < RegionEditor.liexpense.Count; i++)
            {
                dt.Rows.Add(RegionEditor.liexpense[i].Id, RegionEditor.liexpense[i].Category, RegionEditor.liexpense[i].CategoryName, RegionEditor.liexpense[i].Amount, RegionEditor.liexpense[i].Date);
            }
        }
          
        private void Cancelbt_Click(object sender, EventArgs e)
        {
            Peditordelete.Visible = false;
            Badd.Enabled = true;
            Bedit.Enabled = true;
            Bremove.Enabled = true;
            paddeditremove.Enabled = true;
            pviewdifferent.Enabled = true;
        }

        private void Baddcategory_Click(object sender, EventArgs e)
        {
            CategoryForm cf = new CategoryForm();
            cf.ShowDialog();
            UpdateCategory();
            dt.Clear();
        }

        private void Changeidtb_TextChanged(object sender, EventArgs e)
        {
            if (changeidtb.TextLength > 0 && EditorDelete.Text == "Edit")
            {
                int newid = int.Parse(changeidtb.Text);
                for (int i = 0; i < RegionEditor.liexpense.Count; i++)
                {
                    if (RegionEditor.liexpense[i].Id == newid)
                    {
                        categorycb.Text = RegionEditor.liexpense[i].Category;
                        Categorynametb.Text = RegionEditor.liexpense[i].CategoryName;
                        amounttb.Text = "" + RegionEditor.liexpense[i].Amount;
                        datepicker.Text = RegionEditor.liexpense[i].Date;
                    }
                }
            }
        }

        private void Openclosebt_Click_1(object sender, EventArgs e)
        {
            if (Pleft.Visible == true)
            {
                Pleft.Visible = false;
                pdmview.Width = pviewdifferent.Width / 3;
                prview.Width = pviewdifferent.Width / 3;
                pcview.Width = pviewdifferent.Width / 3;
            }
            else
            {
                Pleft.Visible = true;
                pdmview.Width = pviewdifferent.Width / 3;
                prview.Width = pviewdifferent.Width / 3;
                pcview.Width = pviewdifferent.Width / 3;
            }
        }

        private void Viewbt_Click(object sender, EventArgs e)
        {
            dt.Clear();
            for (int i = 0; i < RegionEditor.liexpense.Count; i++)
            {
                dt.Rows.Add(RegionEditor.liexpense[i].Id, RegionEditor.liexpense[i].Category, RegionEditor.liexpense[i].CategoryName, RegionEditor.liexpense[i].Amount, RegionEditor.liexpense[i].Date);
            }
        }

        private void Amountviewbt_Click_1(object sender, EventArgs e)
        {
            ChangeDateRange();
            MessageBox.Show("Total Amount is: " + rangeamount);
        }

        private void CategoryView_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            String selectedcategory = CategoryView.Text;
            for (int i = 0; i < RegionEditor.liexpense.Count; i++)
            {
                if (RegionEditor.liexpense[i].Category == selectedcategory)
                {
                    dt.Rows.Add(RegionEditor.liexpense[i].Id, RegionEditor.liexpense[i].Category, RegionEditor.liexpense[i].CategoryName, RegionEditor.liexpense[i].Amount, RegionEditor.liexpense[i].Date);
                }
            }
        }

        private void Startrangepickerview_ValueChanged(object sender, EventArgs e)
        {
            ChangeDateRange();
        }

        private void Endrangepickerview_ValueChanged_1(object sender, EventArgs e)
        {
            ChangeDateRange();
        }

        private void Datepickerview_ValueChanged(object sender, EventArgs e)
        {
            dt.Clear();
            String newdate = datepickerview.Value.ToShortDateString();
            for (int i = 0; i < RegionEditor.liexpense.Count; i++)
            {
                if (newdate == RegionEditor.liexpense[i].Date)
                {
                    dt.Rows.Add(RegionEditor.liexpense[i].Id, RegionEditor.liexpense[i].Category, RegionEditor.liexpense[i].CategoryName, RegionEditor.liexpense[i].Amount, RegionEditor.liexpense[i].Date);
                }
            }
        }

        private void Monthpickerview_ValueChanged_1(object sender, EventArgs e)
        {
            dt.Clear();
            String newdate = Monthpickerview.Value.ToShortDateString();
            for (int i = 0; i < RegionEditor.liexpense.Count; i++)
            {
                if (newdate.Substring(3, 7) == RegionEditor.liexpense[i].Date.Substring(3, 7))
                {
                    dt.Rows.Add(RegionEditor.liexpense[i].Id, RegionEditor.liexpense[i].Category, RegionEditor.liexpense[i].CategoryName, RegionEditor.liexpense[i].Amount, RegionEditor.liexpense[i].Date);
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            FormResizeFunction();
        }

        private void Newnametb_TextChanged(object sender, EventArgs e)
        {
            String str = newnametb.Text;
            for(int i = 0; i < RegionEditor.licategory.Count; i++)
            {
                if (RegionEditor.licategory[i].Category == str)
                {
                    limittb.Text = "" + RegionEditor.licategory[i].Limit;
                }
            }
        }

        private void Amounttb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar>=48  && e.KeyChar<=57) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Idtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Limittb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        public void ChangeDateRange()
        {
            DateTime startdate = Convert.ToDateTime(Startrangepickerview.Value.ToShortDateString());
            DateTime enddate = Convert.ToDateTime(Endrangepickerview.Value.ToShortDateString());
            dt.Clear(); rangeamount = 0;
            for (int i = 0; i < RegionEditor.liexpense.Count; i++)
            {
                DateTime newdate = Convert.ToDateTime(RegionEditor.liexpense[i].Date);
                if (newdate >= startdate && newdate <= enddate)
                {
                    rangeamount += RegionEditor.liexpense[i].Amount;
                    dt.Rows.Add(RegionEditor.liexpense[i].Id, RegionEditor.liexpense[i].Category, RegionEditor.liexpense[i].CategoryName, RegionEditor.liexpense[i].Amount, RegionEditor.liexpense[i].Date);
                }
            }
        }

        public void UpdateCategory()
        {
            categorycb.DataSource = null;
            CategoryView.DataSource = null;
            categorycb.DataSource = RegionEditor.licategory;
            CategoryView.DataSource = RegionEditor.licategoryview;
            categorycb.DisplayMember = nameof(CategoryLimit.Category);
            CategoryView.DisplayMember = nameof(CategoryLimit.Category);
            dt.Clear();
        }

        public void FormResizeFunction()
        {
            DoubleBuffered = true;
            int width = Width;
            int height = Height;
            Pleft.Width = width * 30 / 100;
            pviewdifferent.Height = height * 10 / 100;
            paddeditremove.Location = new Point(Pleft.Width / 2 - paddeditremove.Width / 2, Pleft.Height / 2 - paddeditremove.Height / 2);
            Peditordelete.Location = new Point(Pleft.Width / 2 - Peditordelete.Width / 2, paddeditremove.Height + paddeditremove.Location.Y);
            Paddcategory.Location = new Point((Pback.Width / 4) - (Paddcategory.Width / 2), (Pback.Height / 2) - (Paddcategory.Height / 2));
            Pcategoryview.Height = CategoryView.Height;
            pdmview.Width = pviewdifferent.Width / 3;
            prview.Width = pviewdifferent.Width / 3;
            pcview.Width = pviewdifferent.Width / 3;
            viewbt.Width = pviewrange.Width/2;
            Monthpickerview.Width = pdmview.Width / 2;
            datepickerview.Width = pdmview.Width / 2;
            Startrangepickerview.Width = prview.Width / 2;
            Endrangepickerview.Width = prview.Width / 2;
            CategoryView.Width = Pcategoryview.Width / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Category", typeof(String));
            dt.Columns.Add("Category Name", typeof(String));
            dt.Columns.Add("Amount", typeof(int));
            dt.Columns.Add("Date", typeof(String));
            GridView.DataSource = dt;
            GridView.ReadOnly = true;
            RegionEditor.CategoryAdd();
            UpdateCategory(); FormResizeFunction();
        }
    }
}
