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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            dt.Columns.Add("Category ID", typeof(String));
            dt.Columns.Add("Category Name", typeof(String));
            dt.Columns.Add("Category Limit", typeof(int)); 
            GridView.DataSource = dt;
            PrintCategory();
        }

        String  change = "", newcategoryname = "", editname = "";
        int editlimit, newcategorylimit;

        DataTable dt = new DataTable();

        public void PrintCategory()
        {
            dt.Clear();
            for(int i = 0; i < RegionEditor.licategory.Count; i++)
            {
                dt.Rows.Add(RegionEditor.licategory[i].CategoryId, RegionEditor.licategory[i].Category, RegionEditor.licategory[i].Limit);
            }
        }

        private void Newcategoryeditbt_Click(object sender, EventArgs e)
        {
            newnamelb.Visible = true; newnametb.Visible = true; editnamelb.Visible = true;
            editnametb.Visible = true; limitlb.Visible = true; limittb.Visible = true;
            newcategoryaddbt.Enabled = false; newcategorydeletebt.Enabled = false; newcategoryeditbt.Enabled = false;
            change = "Edit";
        }

        private void Newcategoryaddbt_Click(object sender, EventArgs e)
        {
            newnamelb.Visible = true; newnametb.Visible = true; limittb.Visible = true; limitlb.Visible = true;
            newcategoryaddbt.Enabled = false; newcategorydeletebt.Enabled = false; newcategoryeditbt.Enabled = false;
            change = "Add";
        }

        private void Newcategorydeletebt_Click(object sender, EventArgs e)
        {
            newnamelb.Visible = true; newnametb.Visible = true;
            newcategoryaddbt.Enabled = false; newcategorydeletebt.Enabled = false; newcategoryeditbt.Enabled = false;
            change = "Delete";
        }

        private void Newcategorydonebt_Click(object sender, EventArgs e)
        {
            if (change == "Add")
            {
                change = "";
                if (limittb.TextLength > 0 && newnametb.TextLength > 0)
                {
                    newcategorylimit = int.Parse(limittb.Text);
                    newcategoryname = newnametb.Text;
                    CategoryLimit cl = new CategoryLimit
                    {
                        Category = newcategoryname,
                        Limit = newcategorylimit
                    };
                    RegionEditor.AddCategory(cl);
                }
            }
            else if (change == "Delete")
            {
                change = "";
                newcategoryname = newnametb.Text;
                if (newcategoryname.Length > 0)
                {
                    CategoryLimit cl = new CategoryLimit
                    {
                        Category = newcategoryname,
                    };
                    bool bol=RegionEditor.DeleteCategory(cl);
                    if (bol==true)
                    {
                        MessageBox.Show(newcategoryname + " Category is changed to Others");
                    }
                }
            }
            else if (change == "Edit")
            {
                change = "";
                newcategoryname = newnametb.Text;
                editname = editnametb.Text;
                if (newcategoryname.Length > 0 && editname.Length > 0 && limittb.TextLength > 0)
                {
                    editlimit = 1000;
                    editlimit = int.Parse(limittb.Text);
                    CategoryLimit cl = new CategoryLimit
                    {
                        Category = editname,
                        Limit=editlimit
                    };
                    RegionEditor.EditCategory(cl,newcategoryname);
                }
            }
            newnamelb.Visible = false; newnametb.Visible = false;
            limitlb.Visible = false; limittb.Visible = false;
            editnamelb.Visible = false; editnametb.Visible = false;
            newcategoryaddbt.Enabled = true; newcategorydeletebt.Enabled = true; newcategoryeditbt.Enabled = true;
            newnametb.Text = ""; limittb.Text = ""; editnametb.Text = "";
            PrintCategory();
        }

        private void Backbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
