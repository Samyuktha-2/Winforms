namespace MaterialSpinTextboxPaint
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
            this.components = new System.ComponentModel.Container();
            this.materialSpinControlPaint1 = new MaterialSpinTextboxPaint.MaterialSpinControlPaint();
            this.minValue = new System.Windows.Forms.TextBox();
            this.maxValue = new System.Windows.Forms.TextBox();
            this.incrementStepValue = new System.Windows.Forms.TextBox();
            this.incrementSpeedValue = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.incrementStepLabel = new System.Windows.Forms.Label();
            this.incrementSpeedLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // materialSpinControlPaint1
            // 
            this.materialSpinControlPaint1.IncrementSpeed = 1;
            this.materialSpinControlPaint1.IncrementStep = 1;
            this.materialSpinControlPaint1.Location = new System.Drawing.Point(258, 76);
            this.materialSpinControlPaint1.Max = 100;
            this.materialSpinControlPaint1.Min = 0;
            this.materialSpinControlPaint1.Name = "materialSpinControlPaint1";
            this.materialSpinControlPaint1.Size = new System.Drawing.Size(215, 45);
            this.materialSpinControlPaint1.TabIndex = 0;
            this.materialSpinControlPaint1.Value = 0;
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(363, 167);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(51, 20);
            this.minValue.TabIndex = 1;
            this.minValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinValueKeyPress);
            this.minValue.Leave += new System.EventHandler(this.MinValueLeave);
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(363, 196);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(51, 20);
            this.maxValue.TabIndex = 2;
            this.maxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxValueKeyPress);
            this.maxValue.Leave += new System.EventHandler(this.MaxValueLeave);
            // 
            // incrementStepValue
            // 
            this.incrementStepValue.Location = new System.Drawing.Point(363, 222);
            this.incrementStepValue.Name = "incrementStepValue";
            this.incrementStepValue.Size = new System.Drawing.Size(51, 20);
            this.incrementStepValue.TabIndex = 3;
            this.incrementStepValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IncrementStepValueKeyPress);
            this.incrementStepValue.Leave += new System.EventHandler(this.IncrementStepValueLeave);
            // 
            // incrementSpeedValue
            // 
            this.incrementSpeedValue.Location = new System.Drawing.Point(363, 248);
            this.incrementSpeedValue.Name = "incrementSpeedValue";
            this.incrementSpeedValue.Size = new System.Drawing.Size(51, 20);
            this.incrementSpeedValue.TabIndex = 4;
            this.incrementSpeedValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IncrementSpeedValueKeyPress);
            this.incrementSpeedValue.Leave += new System.EventHandler(this.IncrementSpeedValueLeave);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(310, 171);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 5;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(310, 200);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 6;
            this.maxLabel.Text = "Max";
            // 
            // incrementStepLabel
            // 
            this.incrementStepLabel.AutoSize = true;
            this.incrementStepLabel.Location = new System.Drawing.Point(258, 226);
            this.incrementStepLabel.Name = "incrementStepLabel";
            this.incrementStepLabel.Size = new System.Drawing.Size(79, 13);
            this.incrementStepLabel.TabIndex = 7;
            this.incrementStepLabel.Text = "Increment Step";
            // 
            // incrementSpeedLabel
            // 
            this.incrementSpeedLabel.AutoSize = true;
            this.incrementSpeedLabel.Location = new System.Drawing.Point(255, 252);
            this.incrementSpeedLabel.Name = "incrementSpeedLabel";
            this.incrementSpeedLabel.Size = new System.Drawing.Size(88, 13);
            this.incrementSpeedLabel.TabIndex = 8;
            this.incrementSpeedLabel.Text = "Increment Speed";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incrementSpeedLabel);
            this.Controls.Add(this.incrementStepLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.incrementSpeedValue);
            this.Controls.Add(this.incrementStepValue);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.materialSpinControlPaint1);
            this.Name = "Form1";
            this.Text = "Material Spin Box (Paint)";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSpinControlPaint materialSpinControlPaint1;
        private System.Windows.Forms.TextBox minValue;
        private System.Windows.Forms.TextBox maxValue;
        private System.Windows.Forms.TextBox incrementStepValue;
        private System.Windows.Forms.TextBox incrementSpeedValue;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label incrementStepLabel;
        private System.Windows.Forms.Label incrementSpeedLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}

