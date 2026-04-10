namespace Evaluation2
{
    partial class CategoryForm
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.newnamelb = new System.Windows.Forms.Label();
            this.newnametb = new System.Windows.Forms.TextBox();
            this.newcategoryaddbt = new System.Windows.Forms.Button();
            this.newcategorydonebt = new System.Windows.Forms.Button();
            this.newcategorydeletebt = new System.Windows.Forms.Button();
            this.newcategoryeditbt = new System.Windows.Forms.Button();
            this.editnamelb = new System.Windows.Forms.Label();
            this.editnametb = new System.Windows.Forms.TextBox();
            this.limitlb = new System.Windows.Forms.Label();
            this.limittb = new System.Windows.Forms.TextBox();
            this.Paddcategory = new System.Windows.Forms.Panel();
            this.Backbt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.Paddcategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(381, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 395);
            this.panel1.TabIndex = 3;
            // 
            // GridView
            // 
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.BackgroundColor = System.Drawing.Color.White;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(462, 395);
            this.GridView.TabIndex = 0;
            // 
            // newnamelb
            // 
            this.newnamelb.BackColor = System.Drawing.Color.Transparent;
            this.newnamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newnamelb.Location = new System.Drawing.Point(29, 30);
            this.newnamelb.Name = "newnamelb";
            this.newnamelb.Size = new System.Drawing.Size(113, 22);
            this.newnamelb.TabIndex = 11;
            this.newnamelb.Text = "Enter Name";
            this.newnamelb.Visible = false;
            // 
            // newnametb
            // 
            this.newnametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newnametb.Location = new System.Drawing.Point(167, 30);
            this.newnametb.Multiline = true;
            this.newnametb.Name = "newnametb";
            this.newnametb.Size = new System.Drawing.Size(137, 22);
            this.newnametb.TabIndex = 12;
            this.newnametb.Visible = false;
            // 
            // newcategoryaddbt
            // 
            this.newcategoryaddbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.newcategoryaddbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newcategoryaddbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newcategoryaddbt.Location = new System.Drawing.Point(276, 213);
            this.newcategoryaddbt.Name = "newcategoryaddbt";
            this.newcategoryaddbt.Size = new System.Drawing.Size(75, 29);
            this.newcategoryaddbt.TabIndex = 13;
            this.newcategoryaddbt.Text = "Add";
            this.newcategoryaddbt.UseVisualStyleBackColor = false;
            this.newcategoryaddbt.Click += new System.EventHandler(this.Newcategoryaddbt_Click);
            // 
            // newcategorydonebt
            // 
            this.newcategorydonebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.newcategorydonebt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newcategorydonebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newcategorydonebt.Location = new System.Drawing.Point(257, 325);
            this.newcategorydonebt.Name = "newcategorydonebt";
            this.newcategorydonebt.Size = new System.Drawing.Size(75, 29);
            this.newcategorydonebt.TabIndex = 14;
            this.newcategorydonebt.Text = "Done";
            this.newcategorydonebt.UseVisualStyleBackColor = false;
            this.newcategorydonebt.Click += new System.EventHandler(this.Newcategorydonebt_Click);
            // 
            // newcategorydeletebt
            // 
            this.newcategorydeletebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.newcategorydeletebt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newcategorydeletebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newcategorydeletebt.Location = new System.Drawing.Point(167, 213);
            this.newcategorydeletebt.Name = "newcategorydeletebt";
            this.newcategorydeletebt.Size = new System.Drawing.Size(75, 29);
            this.newcategorydeletebt.TabIndex = 15;
            this.newcategorydeletebt.Text = "Delete";
            this.newcategorydeletebt.UseVisualStyleBackColor = false;
            this.newcategorydeletebt.Click += new System.EventHandler(this.Newcategorydeletebt_Click);
            // 
            // newcategoryeditbt
            // 
            this.newcategoryeditbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.newcategoryeditbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newcategoryeditbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newcategoryeditbt.Location = new System.Drawing.Point(50, 213);
            this.newcategoryeditbt.Name = "newcategoryeditbt";
            this.newcategoryeditbt.Size = new System.Drawing.Size(75, 29);
            this.newcategoryeditbt.TabIndex = 16;
            this.newcategoryeditbt.Text = "Edit";
            this.newcategoryeditbt.UseVisualStyleBackColor = false;
            this.newcategoryeditbt.Click += new System.EventHandler(this.Newcategoryeditbt_Click);
            // 
            // editnamelb
            // 
            this.editnamelb.BackColor = System.Drawing.Color.Transparent;
            this.editnamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editnamelb.Location = new System.Drawing.Point(29, 125);
            this.editnamelb.Name = "editnamelb";
            this.editnamelb.Size = new System.Drawing.Size(113, 22);
            this.editnamelb.TabIndex = 17;
            this.editnamelb.Text = "New Name";
            this.editnamelb.Visible = false;
            // 
            // editnametb
            // 
            this.editnametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editnametb.Location = new System.Drawing.Point(167, 125);
            this.editnametb.Multiline = true;
            this.editnametb.Name = "editnametb";
            this.editnametb.Size = new System.Drawing.Size(137, 22);
            this.editnametb.TabIndex = 18;
            this.editnametb.Visible = false;
            // 
            // limitlb
            // 
            this.limitlb.BackColor = System.Drawing.Color.Transparent;
            this.limitlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limitlb.Location = new System.Drawing.Point(29, 75);
            this.limitlb.Name = "limitlb";
            this.limitlb.Size = new System.Drawing.Size(113, 22);
            this.limitlb.TabIndex = 19;
            this.limitlb.Text = "Enter Limit";
            this.limitlb.Visible = false;
            // 
            // limittb
            // 
            this.limittb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limittb.Location = new System.Drawing.Point(167, 75);
            this.limittb.Multiline = true;
            this.limittb.Name = "limittb";
            this.limittb.Size = new System.Drawing.Size(137, 22);
            this.limittb.TabIndex = 20;
            this.limittb.Visible = false;
            // 
            // Paddcategory
            // 
            this.Paddcategory.BackColor = System.Drawing.Color.Transparent;
            this.Paddcategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Paddcategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Paddcategory.Controls.Add(this.Backbt);
            this.Paddcategory.Controls.Add(this.limittb);
            this.Paddcategory.Controls.Add(this.limitlb);
            this.Paddcategory.Controls.Add(this.editnametb);
            this.Paddcategory.Controls.Add(this.editnamelb);
            this.Paddcategory.Controls.Add(this.newcategoryeditbt);
            this.Paddcategory.Controls.Add(this.newcategorydeletebt);
            this.Paddcategory.Controls.Add(this.newcategorydonebt);
            this.Paddcategory.Controls.Add(this.newcategoryaddbt);
            this.Paddcategory.Controls.Add(this.newnametb);
            this.Paddcategory.Controls.Add(this.newnamelb);
            this.Paddcategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.Paddcategory.Location = new System.Drawing.Point(0, 0);
            this.Paddcategory.Name = "Paddcategory";
            this.Paddcategory.Size = new System.Drawing.Size(381, 395);
            this.Paddcategory.TabIndex = 2;
            // 
            // Backbt
            // 
            this.Backbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Backbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Backbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbt.Location = new System.Drawing.Point(50, 325);
            this.Backbt.Name = "Backbt";
            this.Backbt.Size = new System.Drawing.Size(75, 29);
            this.Backbt.TabIndex = 21;
            this.Backbt.Text = "Back";
            this.Backbt.UseVisualStyleBackColor = false;
            this.Backbt.Click += new System.EventHandler(this.Backbt_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Paddcategory);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.Paddcategory.ResumeLayout(false);
            this.Paddcategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Label newnamelb;
        private System.Windows.Forms.TextBox newnametb;
        private System.Windows.Forms.Button newcategoryaddbt;
        private System.Windows.Forms.Button newcategorydonebt;
        private System.Windows.Forms.Button newcategorydeletebt;
        private System.Windows.Forms.Button newcategoryeditbt;
        private System.Windows.Forms.Label editnamelb;
        private System.Windows.Forms.TextBox editnametb;
        private System.Windows.Forms.Label limitlb;
        private System.Windows.Forms.TextBox limittb;
        private System.Windows.Forms.Panel Paddcategory;
        private System.Windows.Forms.Button Backbt;
    }
}