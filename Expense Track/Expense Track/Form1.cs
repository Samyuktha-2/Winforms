using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Track
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            header.Location = new Point(this.ClientSize.Width / 2, 9);
            customPieChart = new CustomPieChart()
            {
                Location = new Point(5, 5),
                Dock = DockStyle.Fill
            };
            panel9.Controls.Add(customPieChart); 
        }

        CustomAdd customAdd;
        CustomFilter customFilter;
        CustomPieChart customPieChart;

        BindingList<Data> records = new BindingList<Data>();
        BindingList<ExpenseData> expenseRecord = new BindingList<ExpenseData>();

        bool isEditing = false;
        private Data editingItem = null;
        private Data deletItem = null;

        int income = 0;
        int expense = 0;
        int balance = 0;

        int customAddBtnClickCount = 0;
        int filterBtnClickCount = 0;
         
        private void TypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedItem == null) return;

            string type = typeComboBox.SelectedItem.ToString();

            expenseComboBox.Visible = type == "Expense";
            incomeComboBox.Visible = type == "Income";
        }

        private void CustomAdd(object sender, EventArgs e)
        {
            customAddBtnClickCount++;

            if(customAddBtnClickCount == 2)
            {
                panel1.Controls.Remove(customAdd);
                customAddBtnClickCount = 0;
                return;
            }

            if(typeComboBox.SelectedItem == null)
            {
                return;
            }

            string type = typeComboBox.SelectedItem.ToString();
            customAdd = new CustomAdd(type);
            customAdd.Location = new Point(18, 255);
            customAdd.ItemAdded += CustomItemAdded;
            panel1.Controls.Add(customAdd); 
        }

        private void CustomItemAdded(string type, string value)
        {
            if (type == "Income")
            {
                incomeComboBox.Items.Add(value);
            }
            else if (type == "Expense")
            {
                expenseComboBox.Items.Add(value);
            }

            panel1.Controls.Remove(customAdd);
        }

        private void AddExpense(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            string type = typeComboBox.Text;
            string category = type == "Income" ? incomeComboBox.Text : expenseComboBox.Text;

            int amount = (int)amountNum.Value;

            if(amount <= 0)
            {
                MessageBox.Show("Enter valid amount");
                return;
            }

            if((balance < amount || balance == 0 ) && type == "Expense")
            {
                MessageBox.Show("Insufficient balance");
                expenseComboBox.SelectedItem = null;
                typeComboBox.SelectedItem = null;
                amountNum.Value = 0;
                return;
            }

            Data data = new Data(date, type, category, amount);

            if(type == "Income")
            {
                income += amount;
                balance += amount;
                incomeComboBox.SelectedItem = null;
            }
            else
            {
                expense += amount;
                balance -= amount;
                 
                ExpenseData existingExpense = expenseRecord.FirstOrDefault(x => x.CATEGORY == category);
                if(existingExpense != null)
                {
                    existingExpense.AMOUNT += amount;
                }
                else
                {
                    ExpenseData expenseData = new ExpenseData(category, amount);
                    expenseRecord.Add(expenseData);
                }
                expenseComboBox.SelectedItem = null;
            }  

            incomeVal.Text = income.ToString();
            expenseVal.Text = expense.ToString();
            balanceVal.Text = balance.ToString();

            records.Add(data); 

            amountNum.Value = 0;
            
            customPieChart.SetData(expenseRecord, income, balance); 
            customPieChart.Invalidate();
            
        }

        private void UpdateData()
        {
            if (dataGridView1.Columns.Contains("Edit")) return;

            DataGridViewButtonColumn Edit = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "EDIT",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };

            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "DELETE",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };

            dataGridView1.Columns.Add(Edit);
            dataGridView1.Columns.Add(Delete);

            dataGridView1.CellContentClick += DataGridViewClick;
        }

        private void DataGridViewClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string category = null;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                editingItem = dataGridView1.Rows[e.RowIndex].DataBoundItem as Data;
                if (editingItem == null) return;

                isEditing = true;

                dateTimePicker1.Value = editingItem.DATE;
                typeComboBox.SelectedItem = editingItem.TYPE;

                if (editingItem.TYPE == "Income")
                {
                    incomeComboBox.SelectedItem = editingItem.CATEGORY;
                }
                else
                {
                    expenseComboBox.SelectedItem = editingItem.CATEGORY;
                }

                amountNum.Value = editingItem.AMOUNT;

                saveBtn.Visible = true;
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (e.RowIndex < 0) return;

                var item = dataGridView1.Rows[e.RowIndex].DataBoundItem as Data;
                if (item == null) return;

                // Update totals first
                if (item.TYPE == "Income")
                {
                    income -= item.AMOUNT;
                    balance -= item.AMOUNT;

                    incomeVal.Text = income.ToString();
                    balanceVal.Text = balance.ToString();
                }
                else
                {
                    expense -= item.AMOUNT;
                    balance += item.AMOUNT;

                    expenseVal.Text = expense.ToString();
                    balanceVal.Text = balance.ToString();

                    var exp = expenseRecord.FirstOrDefault(x => x.CATEGORY == item.CATEGORY);
                    if (exp != null)
                    {
                        exp.AMOUNT -= item.AMOUNT;
                        if (exp.AMOUNT <= 0)
                            expenseRecord.Remove(exp);
                    }
                }

                // 🔥 ONLY THIS LINE removes row
                records.Remove(item);

                // ❌ DO NOT reset DataSource here

                customPieChart.SetData(expenseRecord, income, balance);
                customPieChart.Invalidate();
            }



        }

       


        private void SaveChangesBtnClick(object sender,EventArgs e)
        {
            if (!isEditing || editingItem == null) return;

            int oldAmount = editingItem.AMOUNT;
            int newAmount = (int)amountNum.Value;
            int difference = newAmount - oldAmount;

            string category;

            if(typeComboBox.SelectedItem?.ToString() == "Income")
            {
                category = incomeComboBox.SelectedItem?.ToString();
            }
            else
            {
                category = expenseComboBox.SelectedItem?.ToString();
            }

            if(difference == 0 && editingItem.TYPE == typeComboBox.SelectedItem?.ToString() && editingItem.CATEGORY == category && editingItem.DATE == dateTimePicker1.Value)
            {
                return;
            }

            editingItem.DATE = dateTimePicker1.Value;
            editingItem.TYPE = typeComboBox.SelectedItem?.ToString();

            if(editingItem.TYPE == "Income")
            {
                editingItem.CATEGORY = incomeComboBox.SelectedItem?.ToString();

                income += difference;
                balance += difference;

                incomeVal.Text = income.ToString();
                balanceVal.Text = balance.ToString();
            }
            else
            {
                editingItem.CATEGORY = expenseComboBox.SelectedItem?.ToString();

                expense += difference;
                balance -= difference;

                expenseVal.Text = expense.ToString();
                balanceVal.Text = balance.ToString();

                ExpenseData existingExpense = expenseRecord.FirstOrDefault(x => x.CATEGORY == editingItem.CATEGORY);
                if(existingExpense!= null)
                {
                    existingExpense.AMOUNT += difference;
                }
                else
                {
                    expenseRecord.Add(new ExpenseData(editingItem.CATEGORY, newAmount));
                }
            }

            editingItem.AMOUNT = newAmount;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = records;
             
            typeComboBox.SelectedItem = null;
            incomeComboBox.SelectedItem = null;
            expenseComboBox.SelectedItem = null;
            amountNum.Value = 0;

            isEditing = false;
            editingItem = null;
            saveBtn.Visible = false;

            customPieChart.SetData(expenseRecord, income, balance);
            customPieChart.Invalidate();
        }


        private void FormLoad(object sender, EventArgs e)
        {

            dataGridView1.DataSourceChanged += DataGridView1_DataSourceChanged;
            dataGridView1.DataSource = records;
            if (!dataGridView1.Columns.Contains("EDIT"))
            {
                UpdateData();
            }
        }

        private void DataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
                dataGridView1.Columns.Clear();
            else
                UpdateData();
        }

        //FILTER
        private void FilterBtnClick(object sender, EventArgs e)
        {
            filterBtnClickCount++;

            if(filterBtnClickCount == 2)
            {
                panel7.Controls.Remove(customFilter);
                filterBtnClickCount = 0;
                return;
            }

            customFilter = new CustomFilter(expenseComboBox,incomeComboBox); 
            customFilter.Location = new Point(0, 10);

            customFilter.Filter += ShowFilteredContent;
            customFilter.Remove += RemoveFilteredContent;

            panel7.Controls.Add(customFilter);  
        }

        private void ShowFilteredContent(string type,string category,int startAmt,int endAmt)
        {
            panel7.Controls.Remove(customFilter);
            filterBtnClickCount = 0;
            type = string.IsNullOrWhiteSpace(type) ? null : type;
            category = string.IsNullOrWhiteSpace(category) ? null : category;

            if (startAmt == 0 && endAmt == 0)
                endAmt = int.MaxValue;

            var filtered = records.Where(d => (type == null || d.TYPE == type) && (category == null || d.CATEGORY == category) && 
            (d.AMOUNT >= startAmt && d.AMOUNT <= endAmt)).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filtered; 
        }

        private void RemoveFilteredContent(object sender,EventArgs e)
        {
            panel7.Controls.Remove(customFilter);
            filterBtnClickCount = 0;
            dataGridView1.DataSource = records;
        }

        
    }
}
