namespace UnsafeCode
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
            this.unsafeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UnsafeBtn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UnsafeBtn3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UnsafeBtn4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UnsafeBtn5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unsafeBtn
            // 
            this.unsafeBtn.Location = new System.Drawing.Point(214, 91);
            this.unsafeBtn.Name = "unsafeBtn";
            this.unsafeBtn.Size = new System.Drawing.Size(75, 23);
            this.unsafeBtn.TabIndex = 0;
            this.unsafeBtn.Text = "Unsafe Btn";
            this.unsafeBtn.UseVisualStyleBackColor = true;
            this.unsafeBtn.Click += new System.EventHandler(this.UnsafeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // UnsafeBtn2
            // 
            this.UnsafeBtn2.Location = new System.Drawing.Point(171, 158);
            this.UnsafeBtn2.Name = "UnsafeBtn2";
            this.UnsafeBtn2.Size = new System.Drawing.Size(118, 23);
            this.UnsafeBtn2.TabIndex = 2;
            this.UnsafeBtn2.Text = "Unsafe Btn (fixed)";
            this.UnsafeBtn2.UseVisualStyleBackColor = true;
            this.UnsafeBtn2.Click += new System.EventHandler(this.UnsafeBtn2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // UnsafeBtn3
            // 
            this.UnsafeBtn3.Location = new System.Drawing.Point(399, 158);
            this.UnsafeBtn3.Name = "UnsafeBtn3";
            this.UnsafeBtn3.Size = new System.Drawing.Size(118, 23);
            this.UnsafeBtn3.TabIndex = 4;
            this.UnsafeBtn3.Text = "Unsafe Btn (fixed) ";
            this.UnsafeBtn3.UseVisualStyleBackColor = true;
            this.UnsafeBtn3.Click += new System.EventHandler(this.UnsafeBtn3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // UnsafeBtn4
            // 
            this.UnsafeBtn4.Location = new System.Drawing.Point(171, 270);
            this.UnsafeBtn4.Name = "UnsafeBtn4";
            this.UnsafeBtn4.Size = new System.Drawing.Size(118, 23);
            this.UnsafeBtn4.TabIndex = 6;
            this.UnsafeBtn4.Text = "Unsafe StackAlloc";
            this.UnsafeBtn4.UseVisualStyleBackColor = true;
            this.UnsafeBtn4.Click += new System.EventHandler(this.UnsafeBtn4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // UnsafeBtn5
            // 
            this.UnsafeBtn5.Location = new System.Drawing.Point(171, 325);
            this.UnsafeBtn5.Name = "UnsafeBtn5";
            this.UnsafeBtn5.Size = new System.Drawing.Size(118, 23);
            this.UnsafeBtn5.TabIndex = 8;
            this.UnsafeBtn5.Text = "StackAlloc Span";
            this.UnsafeBtn5.UseVisualStyleBackColor = true;
            this.UnsafeBtn5.Click += new System.EventHandler(this.UnsafeBtn5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UnsafeBtn5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UnsafeBtn4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UnsafeBtn3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnsafeBtn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unsafeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button unsafeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UnsafeBtn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UnsafeBtn3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UnsafeBtn4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UnsafeBtn5;
        private System.Windows.Forms.Label label5;
    }
}

