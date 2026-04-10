namespace FeedbackForm
{
    partial class feedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feedbackForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.designationLabel = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.designationText = new System.Windows.Forms.TextBox();
            this.feedbackText = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.feedbackFormLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Snow;
            this.nameLabel.Location = new System.Drawing.Point(54, 43);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 26);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // designationLabel
            // 
            this.designationLabel.AutoSize = true;
            this.designationLabel.BackColor = System.Drawing.Color.Snow;
            this.designationLabel.Location = new System.Drawing.Point(54, 104);
            this.designationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.designationLabel.Name = "designationLabel";
            this.designationLabel.Size = new System.Drawing.Size(117, 26);
            this.designationLabel.TabIndex = 1;
            this.designationLabel.Text = "Designation";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.BackColor = System.Drawing.Color.Snow;
            this.feedbackLabel.Location = new System.Drawing.Point(54, 161);
            this.feedbackLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(94, 26);
            this.feedbackLabel.TabIndex = 2;
            this.feedbackLabel.Text = "Feedback";
            // 
            // nameText
            // 
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameText.Location = new System.Drawing.Point(241, 40);
            this.nameText.Margin = new System.Windows.Forms.Padding(6);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(196, 40);
            this.nameText.TabIndex = 3;
            // 
            // designationText
            // 
            this.designationText.Location = new System.Drawing.Point(241, 101);
            this.designationText.Margin = new System.Windows.Forms.Padding(6);
            this.designationText.Name = "designationText";
            this.designationText.Size = new System.Drawing.Size(196, 40);
            this.designationText.TabIndex = 4;
            // 
            // feedbackText
            // 
            this.feedbackText.Location = new System.Drawing.Point(241, 158);
            this.feedbackText.Margin = new System.Windows.Forms.Padding(6);
            this.feedbackText.Name = "feedbackText";
            this.feedbackText.Size = new System.Drawing.Size(196, 40);
            this.feedbackText.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Snow;
            this.submitButton.Location = new System.Drawing.Point(148, 240);
            this.submitButton.Margin = new System.Windows.Forms.Padding(6);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(150, 46);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // feedbackFormLabel
            // 
            this.feedbackFormLabel.AutoSize = true;
            this.feedbackFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.feedbackFormLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedbackFormLabel.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackFormLabel.ForeColor = System.Drawing.Color.White;
            this.feedbackFormLabel.Location = new System.Drawing.Point(301, 58);
            this.feedbackFormLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.feedbackFormLabel.Name = "feedbackFormLabel";
            this.feedbackFormLabel.Size = new System.Drawing.Size(165, 26);
            this.feedbackFormLabel.TabIndex = 7;
            this.feedbackFormLabel.Text = "Feedback Form";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Controls.Add(this.feedbackText);
            this.panel1.Controls.Add(this.designationText);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Controls.Add(this.feedbackLabel);
            this.panel1.Controls.Add(this.designationLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(138, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 362);
            this.panel1.TabIndex = 8;
            // 
            // feedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(755, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.feedbackFormLabel);
            this.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "feedbackForm";
            this.Text = "Feedback Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label designationLabel;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox designationText;
        private System.Windows.Forms.TextBox feedbackText;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label feedbackFormLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

