using DatabaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBManager manager;

        private void AddBtn_Click(object sender, EventArgs e)
        {
            bool check = ValidateInputs();

            if (!check) return;

            int id = SetNextId();
            string name = empName.Text;
            int age = int.Parse(empAge.Text);
            int salary = int.Parse(empSalary.Text);

            ParameterData[] data = GetEmployeeData();

            var result = manager.AddData("employess", data);

            LoadData();
            RefreshContent();
            SetNextId();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager = new DBManager("localhost", "root", "", "test");
            LoadData();
            SetNextId();
        }

        private void LoadData()
        { 
            var result = manager.FetchData("employess", "1=1 ORDER BY Emp_Id ASC");

            if (result)
            {
                var tableData = result.Value;
                if (tableData == null || tableData.Count == 0)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    return;
                }
                BindGrid(tableData);
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                empId.Text = row.Cells["Emp_Id"].Value?.ToString() ?? "";
                empName.Text = row.Cells["Emp_Name"].Value?.ToString() ?? "";
                empAge.Text = row.Cells["Emp_Age"].Value?.ToString() ?? "";
                empSalary.Text = row.Cells["Emp_Salary"].Value?.ToString() ?? "";

                addBtn.Visible = false;
                editBtn.Visible = true;
                delBtn.Visible = true;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = ValidateInputs();
                if (!check) return;

                int id = int.Parse(empId.Text);
                string name = empName.Text;
                int age = int.Parse(empAge.Text);
                int salary = int.Parse(empSalary.Text);

                ParameterData[] data = GetEmployeeData();

                string condition = "Emp_Id = " + id;

                var result = manager.UpdateData("employess", condition, data);
                MessageBox.Show(result.Message);

                LoadData();
                addBtn.Visible = true;
                editBtn.Visible = false;
                delBtn.Visible = false;

                RefreshContent();
                SetNextId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(empId.Text);
                string condition = "Emp_Id = " + id;

                var result = manager.DeleteData("employess", condition);
                MessageBox.Show(result.Message);

                LoadData();
                addBtn.Visible = true;
                editBtn.Visible = false;
                delBtn.Visible = false;

                RefreshContent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RefreshContent()
        {
            empName.Text = "";
            empAge.Text = "";
            empSalary.Text = "";
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(empName.Text) ||
                string.IsNullOrWhiteSpace(empAge.Text) ||
                string.IsNullOrWhiteSpace(empSalary.Text))

            {
                MessageBox.Show("All fields are required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(empName.Text) || !empName.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Employee Name must contain only letters");
                empName.Clear();
                empName.Focus();
                return false;
            }

            if (!int.TryParse(empAge.Text, out _) ||
            !int.TryParse(empSalary.Text, out _))
            {
                MessageBox.Show("Employee Id, Age, Salary must be of integer");
                return false;
            }

            return true;
        }

        private int SetNextId()
        {
            var result = manager.FetchColumn("employess", "Emp_Id", "");

            if (result && result.Value.Count > 0)
            {
                var ids = result.Value
                                .Select(x => Convert.ToInt32(x))
                                .OrderBy(x => x)
                                .ToList();

                int nextId = 1;

                foreach (var id in ids)
                {
                    if (id != nextId)
                        break;

                    nextId++;
                }
                empId.Text = nextId.ToString();
            }
            else
            {
                empId.Text = "1";
            }

            return int.Parse(empId.Text);
        }

        private ParameterData[] GetEmployeeData()
        {
            return new ParameterData[]
                {
                    new ParameterData("Emp_Id",int.Parse(empId.Text)),
                    new ParameterData("Emp_Name",empName.Text),
                    new ParameterData("Emp_Age",int.Parse(empAge.Text)),
                    new ParameterData("Emp_Salary",int.Parse(empSalary.Text))
                };
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            string condition = BuildFilterCondition();

            var result = manager.FetchData("employess", condition);

            if (result)
            {
                var tableData = result.Value;

                if (tableData == null || tableData.Count == 0)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    MessageBox.Show("No records found");
                    return;
                }

                BindGrid(tableData);
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private string BuildFilterCondition()
        {
            List<string> condition = new List<string>();

            if (!string.IsNullOrWhiteSpace(empIdFrom.Text) && !string.IsNullOrWhiteSpace(empIdTo.Text))
            {
                condition.Add($"Emp_Id BETWEEN {empIdFrom.Text} AND {empIdTo.Text}");
            }
            else if (!string.IsNullOrWhiteSpace(empIdFrom.Text))
            {
                condition.Add($"Emp_Id = {empIdFrom.Text}");
            }

            if (!string.IsNullOrWhiteSpace(empName.Text))
            {
                condition.Add($"Emp_Name LIKE '%{empNameFrom.Text}%'");
            }

            if (!string.IsNullOrWhiteSpace(empAgeFrom.Text) && !string.IsNullOrWhiteSpace(empAgeTo.Text))
            {
                condition.Add($"Emp_Age BETWEEN {empAgeFrom.Text} AND {empAgeTo.Text}");
            }
            else if (!string.IsNullOrWhiteSpace(empAgeFrom.Text))
            {
                condition.Add($"Emp_Age = {empAgeFrom.Text}");
            }

            if (!string.IsNullOrWhiteSpace(empSalaryFrom.Text) && !string.IsNullOrWhiteSpace(empSalaryTo.Text))
            {
                condition.Add($"Emp_Salary BETWEEN {empSalaryFrom.Text} AND {empSalaryTo.Text}");
            }
            else if (!string.IsNullOrWhiteSpace(empSalaryFrom.Text))
            {
                condition.Add($"Emp_Salary = {empSalaryFrom.Text}");
            }
            return string.Join(" AND ", condition);
        }

        private void BindGrid(Dictionary<string, List<object>> tableData)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            foreach (var col in tableData.Keys)
            {
                dataGridView1.Columns.Add(col, col);
            }

            int rowCount = tableData.Values.First().Count;

            for (int i = 0; i < rowCount; i++)
            {
                List<object> row = new List<object>();

                foreach (var col in tableData.Keys)
                {
                    row.Add(tableData[col][i]);
                }
                dataGridView1.Rows.Add(row.ToArray());
            }
        }
          
        private void ClearFilter_Click(object sender, EventArgs e)
        {
            empIdFrom.Clear();
            empIdTo.Clear();
            empNameFrom.Clear();
            empAgeFrom.Clear();
            empAgeTo.Clear();
            empSalaryFrom.Clear();
            empSalaryTo.Clear();

            LoadData();
        }
    }
}
