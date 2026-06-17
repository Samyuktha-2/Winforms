namespace WriteintoXML
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
            this.IdLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.NameTxtbox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FindLbl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IdSearchbox = new System.Windows.Forms.TextBox();
            this.NameSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UpdateStatusLbl = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.IdUpdateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameUpdateBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.IdDeleteBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DeleteStatusLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(24, 13);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(22, 13);
            this.IdLbl.TabIndex = 0;
            this.IdLbl.Text = "Id: ";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(5, 45);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(41, 13);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name: ";
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.Location = new System.Drawing.Point(52, 10);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.IdTxtBox.TabIndex = 1;
            // 
            // NameTxtbox
            // 
            this.NameTxtbox.Location = new System.Drawing.Point(52, 42);
            this.NameTxtbox.Name = "NameTxtbox";
            this.NameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.NameTxtbox.TabIndex = 2;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(27, 78);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(49, 30);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(103, 78);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(49, 30);
            this.ReadBtn.TabIndex = 4;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(898, 217);
            this.dataGridView1.TabIndex = 3;
            // 
            // FindLbl
            // 
            this.FindLbl.Location = new System.Drawing.Point(70, 75);
            this.FindLbl.Name = "FindLbl";
            this.FindLbl.Size = new System.Drawing.Size(49, 30);
            this.FindLbl.TabIndex = 5;
            this.FindLbl.Text = "Find";
            this.FindLbl.UseVisualStyleBackColor = true;
            this.FindLbl.Click += new System.EventHandler(this.FindLbl_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ReadBtn);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.NameTxtbox);
            this.panel1.Controls.Add(this.IdTxtBox);
            this.panel1.Controls.Add(this.NameLbl);
            this.panel1.Controls.Add(this.IdLbl);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 118);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.FindLbl);
            this.panel2.Controls.Add(this.IdSearchbox);
            this.panel2.Controls.Add(this.NameSearchBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(173, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 118);
            this.panel2.TabIndex = 7;
            // 
            // IdSearchbox
            // 
            this.IdSearchbox.Location = new System.Drawing.Point(55, 10);
            this.IdSearchbox.Name = "IdSearchbox";
            this.IdSearchbox.Size = new System.Drawing.Size(100, 20);
            this.IdSearchbox.TabIndex = 1;
            // 
            // NameSearchBox
            // 
            this.NameSearchBox.Location = new System.Drawing.Point(55, 43);
            this.NameSearchBox.Name = "NameSearchBox";
            this.NameSearchBox.Size = new System.Drawing.Size(100, 20);
            this.NameSearchBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name: ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.UpdateStatusLbl);
            this.panel3.Controls.Add(this.UpdateBtn);
            this.panel3.Controls.Add(this.IdUpdateBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.NameUpdateBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(354, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 118);
            this.panel3.TabIndex = 8;
            // 
            // UpdateStatusLbl
            // 
            this.UpdateStatusLbl.AutoSize = true;
            this.UpdateStatusLbl.Location = new System.Drawing.Point(6, 103);
            this.UpdateStatusLbl.Name = "UpdateStatusLbl";
            this.UpdateStatusLbl.Size = new System.Drawing.Size(35, 13);
            this.UpdateStatusLbl.TabIndex = 6;
            this.UpdateStatusLbl.Text = "label5";
            this.UpdateStatusLbl.Visible = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(53, 69);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(59, 30);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // IdUpdateBox
            // 
            this.IdUpdateBox.Location = new System.Drawing.Point(53, 10);
            this.IdUpdateBox.Name = "IdUpdateBox";
            this.IdUpdateBox.Size = new System.Drawing.Size(100, 20);
            this.IdUpdateBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name: ";
            // 
            // NameUpdateBox
            // 
            this.NameUpdateBox.Location = new System.Drawing.Point(53, 43);
            this.NameUpdateBox.Name = "NameUpdateBox";
            this.NameUpdateBox.Size = new System.Drawing.Size(100, 20);
            this.NameUpdateBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id: ";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(54, 42);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(59, 30);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // IdDeleteBox
            // 
            this.IdDeleteBox.Location = new System.Drawing.Point(41, 10);
            this.IdDeleteBox.Name = "IdDeleteBox";
            this.IdDeleteBox.Size = new System.Drawing.Size(100, 20);
            this.IdDeleteBox.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.DeleteStatusLbl);
            this.panel4.Controls.Add(this.IdDeleteBox);
            this.panel4.Controls.Add(this.DeleteBtn);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(523, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 117);
            this.panel4.TabIndex = 9;
            // 
            // DeleteStatusLbl
            // 
            this.DeleteStatusLbl.AutoSize = true;
            this.DeleteStatusLbl.Location = new System.Drawing.Point(3, 78);
            this.DeleteStatusLbl.Name = "DeleteStatusLbl";
            this.DeleteStatusLbl.Size = new System.Drawing.Size(35, 13);
            this.DeleteStatusLbl.TabIndex = 6;
            this.DeleteStatusLbl.Text = "label5";
            this.DeleteStatusLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox IdTxtBox;
        private System.Windows.Forms.TextBox NameTxtbox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FindLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox IdSearchbox;
        private System.Windows.Forms.TextBox NameSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox IdUpdateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameUpdateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UpdateStatusLbl;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox IdDeleteBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label DeleteStatusLbl;
    }
}

