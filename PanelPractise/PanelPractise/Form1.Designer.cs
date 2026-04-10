namespace PanelPractise
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
            this.components = new System.ComponentModel.Container();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.colGapVal = new System.Windows.Forms.NumericUpDown();
            this.colVal = new System.Windows.Forms.NumericUpDown();
            this.rowGapVal = new System.Windows.Forms.NumericUpDown();
            this.rowVal = new System.Windows.Forms.NumericUpDown();
            this.colGapLabel = new System.Windows.Forms.Label();
            this.colLbl = new System.Windows.Forms.Label();
            this.rowGapLabel = new System.Windows.Forms.Label();
            this.rowLbl = new System.Windows.Forms.Label();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colGapVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowGapVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowVal)).BeginInit();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Controls.Add(this.panel1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(600, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(200, 450);
            this.rightPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 450);
            this.mainPanel.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ok);
            this.panel1.Controls.Add(this.colGapVal);
            this.panel1.Controls.Add(this.colVal);
            this.panel1.Controls.Add(this.rowGapVal);
            this.panel1.Controls.Add(this.rowVal);
            this.panel1.Controls.Add(this.colGapLabel);
            this.panel1.Controls.Add(this.colLbl);
            this.panel1.Controls.Add(this.rowGapLabel);
            this.panel1.Controls.Add(this.rowLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 448);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(56, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 24);
            this.button2.TabIndex = 15;
            this.button2.Text = "RESIZE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ResizeBtn);
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(77, 125);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(48, 23);
            this.ok.TabIndex = 14;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.OkBtn);
            // 
            // colGapVal
            // 
            this.colGapVal.Location = new System.Drawing.Point(105, 262);
            this.colGapVal.Name = "colGapVal";
            this.colGapVal.Size = new System.Drawing.Size(82, 20);
            this.colGapVal.TabIndex = 10;
            // 
            // colVal
            // 
            this.colVal.Location = new System.Drawing.Point(105, 99);
            this.colVal.Name = "colVal";
            this.colVal.Size = new System.Drawing.Size(82, 20);
            this.colVal.TabIndex = 11;
            // 
            // rowGapVal
            // 
            this.rowGapVal.Location = new System.Drawing.Point(105, 228);
            this.rowGapVal.Name = "rowGapVal";
            this.rowGapVal.Size = new System.Drawing.Size(82, 20);
            this.rowGapVal.TabIndex = 12;
            // 
            // rowVal
            // 
            this.rowVal.Location = new System.Drawing.Point(105, 65);
            this.rowVal.Name = "rowVal";
            this.rowVal.Size = new System.Drawing.Size(82, 20);
            this.rowVal.TabIndex = 13;
            // 
            // colGapLabel
            // 
            this.colGapLabel.AutoSize = true;
            this.colGapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGapLabel.Location = new System.Drawing.Point(27, 262);
            this.colGapLabel.Name = "colGapLabel";
            this.colGapLabel.Size = new System.Drawing.Size(76, 17);
            this.colGapLabel.TabIndex = 6;
            this.colGapLabel.Text = "COL GAP";
            // 
            // colLbl
            // 
            this.colLbl.AutoSize = true;
            this.colLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLbl.Location = new System.Drawing.Point(53, 101);
            this.colLbl.Name = "colLbl";
            this.colLbl.Size = new System.Drawing.Size(39, 17);
            this.colLbl.TabIndex = 7;
            this.colLbl.Text = "COL";
            // 
            // rowGapLabel
            // 
            this.rowGapLabel.AutoSize = true;
            this.rowGapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowGapLabel.Location = new System.Drawing.Point(21, 231);
            this.rowGapLabel.Name = "rowGapLabel";
            this.rowGapLabel.Size = new System.Drawing.Size(82, 17);
            this.rowGapLabel.TabIndex = 8;
            this.rowGapLabel.Text = "ROW GAP";
            // 
            // rowLbl
            // 
            this.rowLbl.AutoSize = true;
            this.rowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowLbl.Location = new System.Drawing.Point(47, 67);
            this.rowLbl.Name = "rowLbl";
            this.rowLbl.Size = new System.Drawing.Size(45, 17);
            this.rowLbl.TabIndex = 9;
            this.rowLbl.Text = "ROW";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.rightPanel);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.FormResize);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colGapVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowGapVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowVal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.NumericUpDown colGapVal;
        private System.Windows.Forms.NumericUpDown colVal;
        private System.Windows.Forms.NumericUpDown rowGapVal;
        private System.Windows.Forms.NumericUpDown rowVal;
        private System.Windows.Forms.Label colGapLabel;
        private System.Windows.Forms.Label colLbl;
        private System.Windows.Forms.Label rowGapLabel;
        private System.Windows.Forms.Label rowLbl;
    }
}

