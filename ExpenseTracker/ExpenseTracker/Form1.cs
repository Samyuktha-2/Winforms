using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        FlowLayoutPanel ContentPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Right,
            Size = new Size(690, 489)
        };

        private void DashboardBtn(object sender, EventArgs e)
        {
            this.Controls.Remove(panel1);
            this.Controls.Remove(button5);
            ContentPanel.Controls.Clear();
             
            Panel topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Size = new Size(710, 145)
            };

            DashboardUserControl dashboardUserControl = new DashboardUserControl();
            ExpenseUserControl expenseUserControl = new ExpenseUserControl();
             
            this.Controls.Add(ContentPanel);
            ContentPanel.Controls.Add(topPanel);
            ContentPanel.Controls.Add(expenseUserControl);
            topPanel.Controls.Add(dashboardUserControl); 
            
        }

        private void AddExpenseBtn(object sender, EventArgs e)
        {
            this.Controls.Remove(panel1);
            this.Controls.Remove(button5);
            ContentPanel.Controls.Clear();

            AddExpenseUserControl addExpense = new AddExpenseUserControl();
            addExpense.Dock = DockStyle.Top;
            ExpenseUserControl expenseUserControl = new ExpenseUserControl();

            this.Controls.Add(ContentPanel);
            ContentPanel.Controls.Add(addExpense);
            ContentPanel.Controls.Add(expenseUserControl);
        }

        private void ViewExpenseBtn(object sender, EventArgs e)
        {
            this.Controls.Remove(panel1);
            this.Controls.Remove(button5);
            ContentPanel.Controls.Clear();

            ExpenseUserControl expense = new ExpenseUserControl();

            this.Controls.Add(ContentPanel);
            ContentPanel.Controls.Add(expense); 
        }

        private void AddIncomeBtn(object sender, EventArgs e)
        {
            this.Controls.Remove(panel1);
            this.Controls.Remove(button5);
            ContentPanel.Controls.Clear();

            AddIncomeUserControl addIncome = new AddIncomeUserControl();
            addIncome.Dock = DockStyle.Top;
            addIncome.BorderStyle = BorderStyle.FixedSingle;

            Label newIncomeLbl = new Label {
                Text = "New Income: ",
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Microsoft Sans Serif",15,FontStyle.Bold),
                Location = new Point(250,140),
                AutoSize = true
            };


            this.Controls.Add(ContentPanel);
            ContentPanel.Controls.Add(addIncome);
            ContentPanel.Controls.Add(newIncomeLbl);

        }

        private void LoginBtn(object sender, EventArgs e)
        {
            this.Controls.Remove(panel1);
            this.Controls.Remove(button5); 


            LoginUserControl loginUser = new LoginUserControl();
            //loginUser.LoginSuccess += Login_LoginSuccess;
            this.Controls.Add(ContentPanel);
            ContentPanel.Controls.Add(loginUser);
        }
    }
}
