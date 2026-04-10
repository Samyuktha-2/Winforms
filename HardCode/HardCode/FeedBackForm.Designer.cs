using System.Drawing;
using System.Windows.Forms;
namespace HardCode
{
    partial class FeedBackForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.feedbackFormLabel = new System.Windows.Forms.Label();
            this.firstPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.designationLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.designationTextbox = new System.Windows.Forms.TextBox();
            this.secondPanel = new System.Windows.Forms.Panel();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.feedbackTextbox = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.firstPanel.SuspendLayout();
            this.secondPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Snow;
            this.panel.Controls.Add(this.feedbackFormLabel);
            this.panel.Controls.Add(this.firstPanel);
            this.panel.Controls.Add(this.secondPanel);
            this.panel.Location = new System.Drawing.Point(100, 100);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 500);
            this.panel.TabIndex = 0;
            // 
            // feedbackFormLabel
            // 
            this.feedbackFormLabel.AutoSize = true;
            this.feedbackFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.feedbackFormLabel.Location = new System.Drawing.Point(185, 25);
            this.feedbackFormLabel.Name = "feedbackFormLabel";
            this.feedbackFormLabel.Size = new System.Drawing.Size(149, 25);
            this.feedbackFormLabel.TabIndex = 0;
            this.feedbackFormLabel.Text = "Feedback Form";
            // 
            // firstPanel
            // 
            this.firstPanel.BackColor = System.Drawing.Color.LightCyan;
            this.firstPanel.Controls.Add(this.nameLabel);
            this.firstPanel.Controls.Add(this.designationLabel);
            this.firstPanel.Controls.Add(this.nameTextbox);
            this.firstPanel.Controls.Add(this.designationTextbox);
            this.firstPanel.Location = new System.Drawing.Point(50, 60);
            this.firstPanel.Name = "firstPanel";
            this.firstPanel.Size = new System.Drawing.Size(400, 150);
            this.firstPanel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(70, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // designationLabel
            // 
            this.designationLabel.AutoSize = true;
            this.designationLabel.Location = new System.Drawing.Point(70, 76);
            this.designationLabel.Name = "designationLabel";
            this.designationLabel.Size = new System.Drawing.Size(63, 13);
            this.designationLabel.TabIndex = 1;
            this.designationLabel.Text = "Designation";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(150, 42);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(150, 20);
            this.nameTextbox.TabIndex = 2;
            // 
            // designationTextbox
            // 
            this.designationTextbox.Location = new System.Drawing.Point(150, 72);
            this.designationTextbox.Name = "designationTextbox";
            this.designationTextbox.Size = new System.Drawing.Size(150, 20);
            this.designationTextbox.TabIndex = 3;
            // 
            // secondPanel
            // 
            this.secondPanel.BackColor = System.Drawing.Color.LightCyan;
            this.secondPanel.Controls.Add(this.feedbackLabel);
            this.secondPanel.Controls.Add(this.feedbackTextbox);
            this.secondPanel.Controls.Add(this.submitButton);
            this.secondPanel.Location = new System.Drawing.Point(50, 220);
            this.secondPanel.Name = "secondPanel";
            this.secondPanel.Size = new System.Drawing.Size(400, 150);
            this.secondPanel.TabIndex = 2;
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(70, 28);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(55, 13);
            this.feedbackLabel.TabIndex = 0;
            this.feedbackLabel.Text = "Feedback";
            // 
            // feedbackTextbox
            // 
            this.feedbackTextbox.Location = new System.Drawing.Point(150, 26);
            this.feedbackTextbox.Name = "feedbackTextbox";
            this.feedbackTextbox.Size = new System.Drawing.Size(150, 70);
            this.feedbackTextbox.TabIndex = 1;
            this.feedbackTextbox.Text = "";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.DarkCyan;
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(190, 100);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(50, 30);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // FeedBackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.panel);
            this.Name = "FeedBackForm";
            this.Text = "FeedBackForm";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.firstPanel.ResumeLayout(false);
            this.firstPanel.PerformLayout();
            this.secondPanel.ResumeLayout(false);
            this.secondPanel.PerformLayout();
            this.ResumeLayout(false);

        }


        private Panel panel;
        private Label feedbackFormLabel;
        private Panel firstPanel;
        private Panel secondPanel;
        private Label nameLabel;
        private Label designationLabel;
        private TextBox nameTextbox;
        private TextBox designationTextbox;
        private Label feedbackLabel;
        private RichTextBox feedbackTextbox;
        private Button submitButton;



        #endregion
    }
}