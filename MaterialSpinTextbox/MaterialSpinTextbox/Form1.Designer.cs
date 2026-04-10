namespace MaterialSpinTextbox
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
            this.minValue = new System.Windows.Forms.TextBox();
            this.maxValue = new System.Windows.Forms.TextBox();
            this.incrementStepValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.incrementSpeedLabel = new System.Windows.Forms.Label();
            this.incrementSpeedValue = new System.Windows.Forms.TextBox();
            this.materialSpinControl11 = new MaterialSpinTextbox.MaterialSpinControl();
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
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(243, 169);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(68, 20);
            this.minValue.TabIndex = 1;
            this.minValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinValueKeyPress);
            this.minValue.Leave += new System.EventHandler(this.MinValueLeave);
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(243, 195);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(68, 20);
            this.maxValue.TabIndex = 2;
            this.maxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxValueKeyPress);
            this.maxValue.Leave += new System.EventHandler(this.MaxValueLeave);
            // 
            // incrementStepValue
            // 
            this.incrementStepValue.Location = new System.Drawing.Point(243, 221);
            this.incrementStepValue.Name = "incrementStepValue";
            this.incrementStepValue.Size = new System.Drawing.Size(68, 20);
            this.incrementStepValue.TabIndex = 3;
            this.incrementStepValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IncrementStepValueKeyPress);
            this.incrementStepValue.Leave += new System.EventHandler(this.IncrementStepValueLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Increment Step";
            // 
            // incrementSpeedLabel
            // 
            this.incrementSpeedLabel.AutoSize = true;
            this.incrementSpeedLabel.Location = new System.Drawing.Point(149, 250);
            this.incrementSpeedLabel.Name = "incrementSpeedLabel";
            this.incrementSpeedLabel.Size = new System.Drawing.Size(88, 13);
            this.incrementSpeedLabel.TabIndex = 10;
            this.incrementSpeedLabel.Text = "Increment Speed";
            // 
            // incrementSpeedValue
            // 
            this.incrementSpeedValue.Location = new System.Drawing.Point(243, 246);
            this.incrementSpeedValue.Name = "incrementSpeedValue";
            this.incrementSpeedValue.Size = new System.Drawing.Size(68, 20);
            this.incrementSpeedValue.TabIndex = 9;
            this.incrementSpeedValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IncrementSpeedValueKeyPress);
            this.incrementSpeedValue.Leave += new System.EventHandler(this.IncrementSpeedValueLeave);
            // 
            // materialSpinControl11
            // 
            this.materialSpinControl11.IncrementSpeed = 1;
            this.materialSpinControl11.IncrementStep = 1;
            this.materialSpinControl11.Location = new System.Drawing.Point(161, 107);
            this.materialSpinControl11.Max = 100;
            this.materialSpinControl11.Min = 0;
            this.materialSpinControl11.Name = "materialSpinControl11";
            this.materialSpinControl11.Size = new System.Drawing.Size(215, 42);
            this.materialSpinControl11.TabIndex = 0;
            this.materialSpinControl11.Value = 0;
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
            this.ClientSize = new System.Drawing.Size(581, 399);
            this.Controls.Add(this.incrementSpeedLabel);
            this.Controls.Add(this.incrementSpeedValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incrementStepValue);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.materialSpinControl11);
            this.Name = "Form1";
            this.Text = "Material Spin Box";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSpinControl materialSpinControl11;
        private System.Windows.Forms.TextBox minValue;
        private System.Windows.Forms.TextBox maxValue;
        private System.Windows.Forms.TextBox incrementStepValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label incrementSpeedLabel;
        private System.Windows.Forms.TextBox incrementSpeedValue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}

