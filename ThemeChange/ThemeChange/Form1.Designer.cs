namespace ThemeChange
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
            this.MainBox = new System.Windows.Forms.Panel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ThemeBtn = new System.Windows.Forms.Button();
            this.MainBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBox
            // 
            this.MainBox.BackColor = System.Drawing.Color.Peru;
            this.MainBox.Controls.Add(this.LoginBtn);
            this.MainBox.Controls.Add(this.nameTextbox);
            this.MainBox.Controls.Add(this.passwordTextbox);
            this.MainBox.Controls.Add(this.PassLabel);
            this.MainBox.Controls.Add(this.HeadingLabel);
            this.MainBox.Controls.Add(this.NameLabel);
            this.MainBox.Location = new System.Drawing.Point(260, 101);
            this.MainBox.Name = "MainBox";
            this.MainBox.Padding = new System.Windows.Forms.Padding(5);
            this.MainBox.Size = new System.Drawing.Size(230, 244);
            this.MainBox.TabIndex = 0;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(78, 167);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 28);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(122, 65);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameTextbox.TabIndex = 1;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(122, 110);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextbox.TabIndex = 1;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PassLabel.Location = new System.Drawing.Point(8, 105);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(106, 25);
            this.PassLabel.TabIndex = 0;
            this.PassLabel.Text = "Password";
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HeadingLabel.Location = new System.Drawing.Point(55, 14);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(120, 25);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Login Form";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NameLabel.Location = new System.Drawing.Point(8, 65);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(68, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // ThemeBtn
            // 
            this.ThemeBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.ThemeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeBtn.Location = new System.Drawing.Point(719, 12);
            this.ThemeBtn.Name = "ThemeBtn";
            this.ThemeBtn.Size = new System.Drawing.Size(69, 28);
            this.ThemeBtn.TabIndex = 1;
            this.ThemeBtn.Text = "Theme";
            this.ThemeBtn.UseVisualStyleBackColor = false;
            this.ThemeBtn.Click += new System.EventHandler(this.ThemeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThemeBtn);
            this.Controls.Add(this.MainBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainBox.ResumeLayout(false);
            this.MainBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button ThemeBtn;
    }
}

