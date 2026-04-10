namespace RatioPanel
{
    partial class RowCol
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.okBtn = new System.Windows.Forms.Button();
            this.colRatioValue = new System.Windows.Forms.TextBox();
            this.rowRatioValue = new System.Windows.Forms.TextBox();
            this.colRationLabel = new System.Windows.Forms.Label();
            this.rowRatioLabel = new System.Windows.Forms.Label();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(652, 450);
            this.mainPanel.TabIndex = 5;
            // 
            // rightPanel
            // 
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Controls.Add(this.okBtn);
            this.rightPanel.Controls.Add(this.colRatioValue);
            this.rightPanel.Controls.Add(this.rowRatioValue);
            this.rightPanel.Controls.Add(this.colRationLabel);
            this.rightPanel.Controls.Add(this.rowRatioLabel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(652, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(148, 450);
            this.rightPanel.TabIndex = 4;
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(50, 173);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(48, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn);
            // 
            // colRatioValue
            // 
            this.colRatioValue.Location = new System.Drawing.Point(25, 147);
            this.colRatioValue.Name = "colRatioValue";
            this.colRatioValue.Size = new System.Drawing.Size(100, 20);
            this.colRatioValue.TabIndex = 1;
            // 
            // rowRatioValue
            // 
            this.rowRatioValue.Location = new System.Drawing.Point(25, 104);
            this.rowRatioValue.Name = "rowRatioValue";
            this.rowRatioValue.Size = new System.Drawing.Size(100, 20);
            this.rowRatioValue.TabIndex = 1;
            // 
            // colRationLabel
            // 
            this.colRationLabel.AutoSize = true;
            this.colRationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRationLabel.Location = new System.Drawing.Point(26, 127);
            this.colRationLabel.Name = "colRationLabel";
            this.colRationLabel.Size = new System.Drawing.Size(65, 17);
            this.colRationLabel.TabIndex = 0;
            this.colRationLabel.Text = "Col Ratio";
            // 
            // rowRatioLabel
            // 
            this.rowRatioLabel.AutoSize = true;
            this.rowRatioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowRatioLabel.Location = new System.Drawing.Point(26, 84);
            this.rowRatioLabel.Name = "rowRatioLabel";
            this.rowRatioLabel.Size = new System.Drawing.Size(72, 17);
            this.rowRatioLabel.TabIndex = 0;
            this.rowRatioLabel.Text = "Row Ratio";
            // 
            // RowCol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.rightPanel);
            this.Name = "RowCol";
            this.Text = "RowCol";
            this.Resize += new System.EventHandler(this.FormResize);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox rowRatioValue;
        private System.Windows.Forms.Label rowRatioLabel;
        private System.Windows.Forms.TextBox colRatioValue;
        private System.Windows.Forms.Label colRationLabel;
    }
}