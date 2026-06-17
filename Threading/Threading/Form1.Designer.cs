namespace Threading
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CounterBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CounterBtn2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CounterBtn3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CounterBtn4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // CounterBtn
            // 
            this.CounterBtn.Location = new System.Drawing.Point(503, 75);
            this.CounterBtn.Name = "CounterBtn";
            this.CounterBtn.Size = new System.Drawing.Size(75, 43);
            this.CounterBtn.TabIndex = 3;
            this.CounterBtn.Text = "Counter with 2 Thread";
            this.CounterBtn.UseVisualStyleBackColor = true;
            this.CounterBtn.Click += new System.EventHandler(this.CounterBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // CounterBtn2
            // 
            this.CounterBtn2.Location = new System.Drawing.Point(386, 75);
            this.CounterBtn2.Name = "CounterBtn2";
            this.CounterBtn2.Size = new System.Drawing.Size(75, 43);
            this.CounterBtn2.TabIndex = 3;
            this.CounterBtn2.Text = "Counter with 1 Thread";
            this.CounterBtn2.UseVisualStyleBackColor = true;
            this.CounterBtn2.Click += new System.EventHandler(this.CounterBtn2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // CounterBtn3
            // 
            this.CounterBtn3.Location = new System.Drawing.Point(253, 70);
            this.CounterBtn3.Name = "CounterBtn3";
            this.CounterBtn3.Size = new System.Drawing.Size(75, 52);
            this.CounterBtn3.TabIndex = 5;
            this.CounterBtn3.Text = "UI update after Thread execution";
            this.CounterBtn3.UseVisualStyleBackColor = true;
            this.CounterBtn3.Click += new System.EventHandler(this.CounterBtn3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // CounterBtn4
            // 
            this.CounterBtn4.Location = new System.Drawing.Point(253, 215);
            this.CounterBtn4.Name = "CounterBtn4";
            this.CounterBtn4.Size = new System.Drawing.Size(75, 49);
            this.CounterBtn4.TabIndex = 7;
            this.CounterBtn4.Text = "Thread safe using Locker";
            this.CounterBtn4.UseVisualStyleBackColor = true;
            this.CounterBtn4.Click += new System.EventHandler(this.CounterBtn4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CounterBtn4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CounterBtn3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CounterBtn2);
            this.Controls.Add(this.CounterBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CounterBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CounterBtn2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CounterBtn3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CounterBtn4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

