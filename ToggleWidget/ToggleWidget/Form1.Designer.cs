namespace ToggleWidget
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
            this.toggleControl1 = new ToggleWidget.ToggleControl();
            this.SuspendLayout();
            // 
            // toggleControl1
            // 
            this.toggleControl1.Checked = false;
            this.toggleControl1.Location = new System.Drawing.Point(107, 109);
            this.toggleControl1.Name = "toggleControl1";
            this.toggleControl1.Size = new System.Drawing.Size(256, 68);
            this.toggleControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 496);
            this.Controls.Add(this.toggleControl1);
            this.Name = "Form1";
            this.Text = "Toggle Button";
            this.ResumeLayout(false);

        }

        #endregion

        private ToggleControl toggleControl1;
    }
}

