namespace DatabaseConnection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.empId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.empSalary = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.empName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.empNameFrom = new System.Windows.Forms.TextBox();
            this.empAgeTo = new System.Windows.Forms.TextBox();
            this.empIdTo = new System.Windows.Forms.TextBox();
            this.empAgeFrom = new System.Windows.Forms.TextBox();
            this.empIdFrom = new System.Windows.Forms.TextBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empSalaryFrom = new System.Windows.Forms.TextBox();
            this.empSalaryTo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ClearFilter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ClearFilter);
            this.panel1.Controls.Add(this.filterBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 607);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.empId);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.empAge);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.delBtn);
            this.panel5.Controls.Add(this.empSalary);
            this.panel5.Controls.Add(this.addBtn);
            this.panel5.Controls.Add(this.editBtn);
            this.panel5.Controls.Add(this.empName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 231);
            this.panel5.TabIndex = 7;
            // 
            // empId
            // 
            this.empId.Location = new System.Drawing.Point(96, 27);
            this.empId.Name = "empId";
            this.empId.ReadOnly = true;
            this.empId.Size = new System.Drawing.Size(123, 20);
            this.empId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Emp_Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emp_Id";
            // 
            // empAge
            // 
            this.empAge.Location = new System.Drawing.Point(96, 106);
            this.empAge.Name = "empAge";
            this.empAge.Size = new System.Drawing.Size(123, 20);
            this.empAge.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Emp_Salary";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(144, 193);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 4;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Visible = false;
            this.delBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // empSalary
            // 
            this.empSalary.Location = new System.Drawing.Point(96, 147);
            this.empSalary.Name = "empSalary";
            this.empSalary.Size = new System.Drawing.Size(123, 20);
            this.empSalary.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(69, 193);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(30, 193);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Save Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Visible = false;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // empName
            // 
            this.empName.Location = new System.Drawing.Point(96, 67);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(123, 20);
            this.empName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.empSalaryTo);
            this.panel2.Controls.Add(this.empNameFrom);
            this.panel2.Controls.Add(this.empAgeTo);
            this.panel2.Controls.Add(this.empSalaryFrom);
            this.panel2.Controls.Add(this.empIdTo);
            this.panel2.Controls.Add(this.empAgeFrom);
            this.panel2.Controls.Add(this.empIdFrom);
            this.panel2.Location = new System.Drawing.Point(31, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 262);
            this.panel2.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "To";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Emp_Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Emp_Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Emp_Id";
            // 
            // empNameFrom
            // 
            this.empNameFrom.Location = new System.Drawing.Point(12, 90);
            this.empNameFrom.Name = "empNameFrom";
            this.empNameFrom.Size = new System.Drawing.Size(124, 20);
            this.empNameFrom.TabIndex = 1;
            // 
            // empAgeTo
            // 
            this.empAgeTo.Location = new System.Drawing.Point(96, 151);
            this.empAgeTo.Name = "empAgeTo";
            this.empAgeTo.Size = new System.Drawing.Size(40, 20);
            this.empAgeTo.TabIndex = 1;
            // 
            // empIdTo
            // 
            this.empIdTo.Location = new System.Drawing.Point(96, 44);
            this.empIdTo.Name = "empIdTo";
            this.empIdTo.Size = new System.Drawing.Size(40, 20);
            this.empIdTo.TabIndex = 1;
            // 
            // empAgeFrom
            // 
            this.empAgeFrom.Location = new System.Drawing.Point(12, 151);
            this.empAgeFrom.Name = "empAgeFrom";
            this.empAgeFrom.Size = new System.Drawing.Size(40, 20);
            this.empAgeFrom.TabIndex = 1;
            // 
            // empIdFrom
            // 
            this.empIdFrom.Location = new System.Drawing.Point(12, 44);
            this.empIdFrom.Name = "empIdFrom";
            this.empIdFrom.Size = new System.Drawing.Size(40, 20);
            this.empIdFrom.TabIndex = 1;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(30, 237);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(75, 23);
            this.filterBtn.TabIndex = 5;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(253, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 607);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // empSalaryFrom
            // 
            this.empSalaryFrom.Location = new System.Drawing.Point(12, 218);
            this.empSalaryFrom.Name = "empSalaryFrom";
            this.empSalaryFrom.Size = new System.Drawing.Size(40, 20);
            this.empSalaryFrom.TabIndex = 1;
            // 
            // empSalaryTo
            // 
            this.empSalaryTo.Location = new System.Drawing.Point(96, 218);
            this.empSalaryTo.Name = "empSalaryTo";
            this.empSalaryTo.Size = new System.Drawing.Size(40, 20);
            this.empSalaryTo.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Emp_Salary";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "From";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(93, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "To";
            // 
            // ClearFilter
            // 
            this.ClearFilter.Location = new System.Drawing.Point(125, 237);
            this.ClearFilter.Name = "ClearFilter";
            this.ClearFilter.Size = new System.Drawing.Size(75, 23);
            this.ClearFilter.TabIndex = 5;
            this.ClearFilter.Text = "Clear Filter";
            this.ClearFilter.UseVisualStyleBackColor = true;
            this.ClearFilter.Click += new System.EventHandler(this.ClearFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 607);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empSalary;
        private System.Windows.Forms.TextBox empAge;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.TextBox empId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empIdTo;
        private System.Windows.Forms.TextBox empIdFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empNameFrom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox empAgeTo;
        private System.Windows.Forms.TextBox empAgeFrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox empSalaryTo;
        private System.Windows.Forms.TextBox empSalaryFrom;
        private System.Windows.Forms.Button ClearFilter;
    }
}

