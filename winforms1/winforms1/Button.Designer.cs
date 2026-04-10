namespace winforms1
{
    partial class Button
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
            this.clickMe = new System.Windows.Forms.Button();
            this.msgBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickMe
            // 
            this.clickMe.Location = new System.Drawing.Point(452, 201);
            this.clickMe.Name = "clickMe";
            this.clickMe.Size = new System.Drawing.Size(163, 42);
            this.clickMe.TabIndex = 0;
            this.clickMe.Text = "CLICK ME TO EXIT!";
            this.clickMe.UseVisualStyleBackColor = true;
            this.clickMe.Click += new System.EventHandler(this.clickMe_Click);
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(147, 201);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(128, 42);
            this.msgBox.TabIndex = 1;
            this.msgBox.Text = "MSG BOX!";
            this.msgBox.UseVisualStyleBackColor = true;
            this.msgBox.Click += new System.EventHandler(this.msgBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.clickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickMe;
        private System.Windows.Forms.Button msgBox;
    }
}

