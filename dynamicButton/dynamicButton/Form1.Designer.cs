namespace dynamicButton
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
            this.outputpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.innerInputLabel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.colTextBox = new System.Windows.Forms.TextBox();
            this.rowTextBox = new System.Windows.Forms.TextBox();
            this.colLabel = new System.Windows.Forms.Label();
            this.rowLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.innerInputLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputpanel
            // 
            this.outputpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputpanel.BackColor = System.Drawing.Color.Silver;
            this.outputpanel.Location = new System.Drawing.Point(0, 0);
            this.outputpanel.Name = "outputpanel";
            this.outputpanel.Size = new System.Drawing.Size(834, 561);
            this.outputpanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.innerInputLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(831, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 561);
            this.panel2.TabIndex = 1;
            // 
            // innerInputLabel
            // 
            this.innerInputLabel.Controls.Add(this.addButton);
            this.innerInputLabel.Controls.Add(this.colTextBox);
            this.innerInputLabel.Controls.Add(this.rowTextBox);
            this.innerInputLabel.Controls.Add(this.colLabel);
            this.innerInputLabel.Controls.Add(this.rowLabel);
            this.innerInputLabel.Location = new System.Drawing.Point(6, 12);
            this.innerInputLabel.Name = "innerInputLabel";
            this.innerInputLabel.Size = new System.Drawing.Size(144, 102);
            this.innerInputLabel.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(57, 64);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(36, 22);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // colTextBox
            // 
            this.colTextBox.Location = new System.Drawing.Point(47, 38);
            this.colTextBox.Name = "colTextBox";
            this.colTextBox.Size = new System.Drawing.Size(88, 20);
            this.colTextBox.TabIndex = 3;
            // 
            // rowTextBox
            // 
            this.rowTextBox.Location = new System.Drawing.Point(47, 11);
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.Size = new System.Drawing.Size(88, 20);
            this.rowTextBox.TabIndex = 2;
            // 
            // colLabel
            // 
            this.colLabel.AutoSize = true;
            this.colLabel.Location = new System.Drawing.Point(10, 45);
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(22, 13);
            this.colLabel.TabIndex = 1;
            this.colLabel.Text = "Col";
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Location = new System.Drawing.Point(3, 18);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(29, 13);
            this.rowLabel.TabIndex = 0;
            this.rowLabel.Text = "Row";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.outputpanel);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(250, 150);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel2.ResumeLayout(false);
            this.innerInputLabel.ResumeLayout(false);
            this.innerInputLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel outputpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel innerInputLabel;
        private System.Windows.Forms.Label colLabel;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox colTextBox;
        private System.Windows.Forms.TextBox rowTextBox;
    }
}

