using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practise
{
    public partial class Dialogs : Form
    {
        

        public Dialogs()
        {
            InitializeComponent();
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Select a file to open";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtContent.Text = File.ReadAllText(openFileDialog1.FileName);
                lblPath.Text = "Opened: " + openFileDialog1.FileName;
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save your file";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtContent.Text);
                lblPath.Text = "Saved to: " + saveFileDialog1.FileName;
            }
        }

        private void chooseFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true; // allow color selection

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtContent.Font = fontDialog1.Font;
                txtContent.ForeColor = fontDialog1.Color;
            }
        }

        private void chooseColour_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color; // changes form background
                this.openFile.BackColor = colorDialog1.Color;
            }
        }

        private void chooseFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select a folder to save your work";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = "Selected Folder: " + folderBrowserDialog1.SelectedPath;
            }
        }

        private void printFile_Click(object sender, EventArgs e)
        {
            Printing print = new Printing();
            print.ShowDialog();
        }
    }
}
