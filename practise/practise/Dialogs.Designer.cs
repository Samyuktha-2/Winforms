namespace practise
{
    partial class Dialogs
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.chooseFont = new System.Windows.Forms.Button();
            this.chooseColour = new System.Windows.Forms.Button();
            this.chooseFolder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblPath = new System.Windows.Forms.TextBox();
            this.printFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(28, 25);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(404, 244);
            this.txtContent.TabIndex = 0;
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(28, 275);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(124, 21);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(28, 302);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(124, 22);
            this.saveFile.TabIndex = 2;
            this.saveFile.Text = "Save File";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // chooseFont
            // 
            this.chooseFont.Location = new System.Drawing.Point(28, 330);
            this.chooseFont.Name = "chooseFont";
            this.chooseFont.Size = new System.Drawing.Size(124, 20);
            this.chooseFont.TabIndex = 3;
            this.chooseFont.Text = "choose font";
            this.chooseFont.UseVisualStyleBackColor = true;
            this.chooseFont.Click += new System.EventHandler(this.chooseFont_Click);
            // 
            // chooseColour
            // 
            this.chooseColour.Location = new System.Drawing.Point(28, 356);
            this.chooseColour.Name = "chooseColour";
            this.chooseColour.Size = new System.Drawing.Size(124, 20);
            this.chooseColour.TabIndex = 4;
            this.chooseColour.Text = "Choose Colour";
            this.chooseColour.UseVisualStyleBackColor = true;
            this.chooseColour.Click += new System.EventHandler(this.chooseColour_Click);
            // 
            // chooseFolder
            // 
            this.chooseFolder.Location = new System.Drawing.Point(28, 382);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(124, 20);
            this.chooseFolder.TabIndex = 5;
            this.chooseFolder.Text = "Choose Folder";
            this.chooseFolder.UseVisualStyleBackColor = true;
            this.chooseFolder.Click += new System.EventHandler(this.chooseFolder_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(453, 25);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(335, 20);
            this.lblPath.TabIndex = 7;
            // 
            // printFile
            // 
            this.printFile.Location = new System.Drawing.Point(28, 408);
            this.printFile.Name = "printFile";
            this.printFile.Size = new System.Drawing.Size(124, 20);
            this.printFile.TabIndex = 8;
            this.printFile.Text = "Print File";
            this.printFile.UseVisualStyleBackColor = true;
            this.printFile.Click += new System.EventHandler(this.printFile_Click);
            // 
            // Dialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printFile);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.chooseFolder);
            this.Controls.Add(this.chooseColour);
            this.Controls.Add(this.chooseFont);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.txtContent);
            this.Name = "Dialogs";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button chooseFont;
        private System.Windows.Forms.Button chooseColour;
        private System.Windows.Forms.Button chooseFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1; 
        private System.Windows.Forms.TextBox lblPath;
        private System.Windows.Forms.Button printFile;
    }
}