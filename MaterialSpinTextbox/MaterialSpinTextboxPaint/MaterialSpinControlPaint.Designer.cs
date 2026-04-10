namespace MaterialSpinTextboxPaint
{
    partial class MaterialSpinControlPaint
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(54, 10);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(100, 20);
            this.textbox1.TabIndex = 0;
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox1.Visible = false;
            this.textbox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            this.textbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // MaterialSpinControlPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textbox1);
            this.Name = "MaterialSpinControlPaint";
            this.Size = new System.Drawing.Size(436, 151);
            this.Click += new System.EventHandler(this.MaterialSpinControlPaintClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MaterialSpinControlPaintMouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MaterialSpinControlPaintMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MaterialSpinControlPaintMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MaterialSpinControlPaintMouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
