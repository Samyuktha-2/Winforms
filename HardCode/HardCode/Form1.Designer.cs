using System.Drawing;
namespace HardCode
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
            this.feedbackFormLabel = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.designationLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.designationTextbox = new System.Windows.Forms.TextBox();
            this.secondPanel = new System.Windows.Forms.Panel();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.feedbackTextbox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.firstPanel.SuspendLayout();
            this.secondPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // feedbackFormLabel
            // 
            this.feedbackFormLabel.AutoSize = true;
            this.feedbackFormLabel.BackColor = System.Drawing.Color.LightBlue;
            this.feedbackFormLabel.Location = new System.Drawing.Point(150, 25);
            this.feedbackFormLabel.Name = "feedbackFormLabel";
            this.feedbackFormLabel.Size = new System.Drawing.Size(81, 13);
            this.feedbackFormLabel.TabIndex = 0;
            this.feedbackFormLabel.Text = "Feedback Form";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightBlue;
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.feedbackFormLabel);
            this.panel.Controls.Add(this.secondPanel);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(40, 10);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(400, 400);
            this.panel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Beige;
            this.groupBox1.Controls.Add(this.firstPanel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(48, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "user details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // firstPanel
            // 
            this.firstPanel.BackColor = System.Drawing.Color.LightCyan;
            this.firstPanel.Controls.Add(this.nameLabel);
            this.firstPanel.Controls.Add(this.designationLabel);
            this.firstPanel.Controls.Add(this.nameTextbox);
            this.firstPanel.Controls.Add(this.designationTextbox);
            this.firstPanel.Location = new System.Drawing.Point(6, 19);
            this.firstPanel.Name = "firstPanel";
            this.firstPanel.Size = new System.Drawing.Size(300, 100);
            this.firstPanel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Location = new System.Drawing.Point(21, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // designationLabel
            // 
            this.designationLabel.AutoSize = true;
            this.designationLabel.Location = new System.Drawing.Point(21, 53);
            this.designationLabel.Name = "designationLabel";
            this.designationLabel.Size = new System.Drawing.Size(63, 13);
            this.designationLabel.TabIndex = 1;
            this.designationLabel.Text = "Designation";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(100, 22);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(150, 20);
            this.nameTextbox.TabIndex = 2;
            this.nameTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextbox_Validating);
            // 
            // designationTextbox
            // 
            this.designationTextbox.Location = new System.Drawing.Point(100, 50);
            this.designationTextbox.Name = "designationTextbox";
            this.designationTextbox.Size = new System.Drawing.Size(150, 20);
            this.designationTextbox.TabIndex = 3;
            // 
            // secondPanel
            // 
            this.secondPanel.BackColor = System.Drawing.Color.Cyan;
            this.secondPanel.Controls.Add(this.feedbackLabel);
            this.secondPanel.Controls.Add(this.feedbackTextbox);
            this.secondPanel.Controls.Add(this.submitButton);
            this.secondPanel.Location = new System.Drawing.Point(50, 160);
            this.secondPanel.Name = "secondPanel";
            this.secondPanel.Size = new System.Drawing.Size(300, 150);
            this.secondPanel.TabIndex = 2;
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(21, 25);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(55, 13);
            this.feedbackLabel.TabIndex = 0;
            this.feedbackLabel.Text = "Feedback";
            // 
            // feedbackTextbox
            // 
            this.feedbackTextbox.Location = new System.Drawing.Point(100, 22);
            this.feedbackTextbox.Name = "feedbackTextbox";
            this.feedbackTextbox.Size = new System.Drawing.Size(150, 20);
            this.feedbackTextbox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Snow;
            this.submitButton.ForeColor = System.Drawing.Color.Black;
            this.submitButton.Location = new System.Drawing.Point(100, 80);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(50, 25);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Feedback Form";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.firstPanel.ResumeLayout(false);
            this.firstPanel.PerformLayout();
            this.secondPanel.ResumeLayout(false);
            this.secondPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label feedbackFormLabel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel firstPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label designationLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox designationTextbox;
        private System.Windows.Forms.Panel secondPanel;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.TextBox feedbackTextbox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

