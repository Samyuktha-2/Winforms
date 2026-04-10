namespace task1
{
    partial class task1
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
            this.resizeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.rowGapBox = new System.Windows.Forms.NumericUpDown();
            this.colGapBox = new System.Windows.Forms.NumericUpDown();
            this.colBox = new System.Windows.Forms.NumericUpDown();
            this.rowGapLabel = new System.Windows.Forms.Label();
            this.rowBox = new System.Windows.Forms.NumericUpDown();
            this.colGapLabel = new System.Windows.Forms.Label();
            this.colLabel = new System.Windows.Forms.Label();
            this.rowLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowGapBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colGapBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.resizeBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.rowGapBox);
            this.panel1.Controls.Add(this.colGapBox);
            this.panel1.Controls.Add(this.colBox);
            this.panel1.Controls.Add(this.rowGapLabel);
            this.panel1.Controls.Add(this.rowBox);
            this.panel1.Controls.Add(this.colGapLabel);
            this.panel1.Controls.Add(this.colLabel);
            this.panel1.Controls.Add(this.rowLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(500, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            // 
            // resizeBtn
            // 
            this.resizeBtn.Location = new System.Drawing.Point(65, 272);
            this.resizeBtn.Name = "resizeBtn";
            this.resizeBtn.Size = new System.Drawing.Size(75, 23);
            this.resizeBtn.TabIndex = 2;
            this.resizeBtn.Text = "RESIZE";
            this.resizeBtn.UseVisualStyleBackColor = true;
            this.resizeBtn.Click += new System.EventHandler(this.resizeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(49, 110);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // rowGapBox
            // 
            this.rowGapBox.Location = new System.Drawing.Point(89, 205);
            this.rowGapBox.Name = "rowGapBox";
            this.rowGapBox.Size = new System.Drawing.Size(51, 20);
            this.rowGapBox.TabIndex = 1;
            this.rowGapBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // colGapBox
            // 
            this.colGapBox.Location = new System.Drawing.Point(89, 231);
            this.colGapBox.Name = "colGapBox";
            this.colGapBox.Size = new System.Drawing.Size(51, 20);
            this.colGapBox.TabIndex = 1;
            this.colGapBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // colBox
            // 
            this.colBox.Location = new System.Drawing.Point(73, 71);
            this.colBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colBox.Name = "colBox";
            this.colBox.Size = new System.Drawing.Size(51, 20);
            this.colBox.TabIndex = 1;
            this.colBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rowGapLabel
            // 
            this.rowGapLabel.AutoSize = true;
            this.rowGapLabel.Location = new System.Drawing.Point(31, 209);
            this.rowGapLabel.Name = "rowGapLabel";
            this.rowGapLabel.Size = new System.Drawing.Size(52, 13);
            this.rowGapLabel.TabIndex = 0;
            this.rowGapLabel.Text = "Row Gap";
            // 
            // rowBox
            // 
            this.rowBox.Location = new System.Drawing.Point(73, 37);
            this.rowBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowBox.Name = "rowBox";
            this.rowBox.Size = new System.Drawing.Size(51, 20);
            this.rowBox.TabIndex = 1;
            this.rowBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // colGapLabel
            // 
            this.colGapLabel.AutoSize = true;
            this.colGapLabel.Location = new System.Drawing.Point(35, 235);
            this.colGapLabel.Name = "colGapLabel";
            this.colGapLabel.Size = new System.Drawing.Size(45, 13);
            this.colGapLabel.TabIndex = 0;
            this.colGapLabel.Text = "Col Gap";
            // 
            // colLabel
            // 
            this.colLabel.AutoSize = true;
            this.colLabel.Location = new System.Drawing.Point(29, 75);
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(22, 13);
            this.colLabel.TabIndex = 0;
            this.colLabel.Text = "Col";
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Location = new System.Drawing.Point(29, 41);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(29, 13);
            this.rowLabel.TabIndex = 0;
            this.rowLabel.Text = "Row";
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 600);
            this.mainPanel.TabIndex = 1;
            // 
            // task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Name = "task1";
            this.Text = "Task 1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowGapBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colGapBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resizeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown colGapBox;
        private System.Windows.Forms.NumericUpDown colBox;
        private System.Windows.Forms.NumericUpDown rowBox;
        private System.Windows.Forms.Label colGapLabel;
        private System.Windows.Forms.Label colLabel;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.NumericUpDown rowGapBox;
        private System.Windows.Forms.Label rowGapLabel;
    }
}