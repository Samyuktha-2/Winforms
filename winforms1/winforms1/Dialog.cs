using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace winforms1
{
    public partial class Dialog : Form
    {
        private string[] linesToPrint;
        private int currentLineIndex;

        public Dialog()
        {
            InitializeComponent();

            printDocument1.DocumentName = "My Document";
            pageSetupDialog1.Document = printDocument1;

            // Attach the PrintPage event handler
            printDocument1.PrintPage += printDocument1_PrintPage;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Select file to open";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                textBox2.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save your file";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox2.Text);
                textBox1.Text = saveFileDialog1.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Font = fontDialog1.Font;
                textBox2.ForeColor = fontDialog1.Color;
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreparePrint();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void PreparePrint()
        {
            linesToPrint = textBox2.Text.Replace("\r\n", "\n").Replace("\r", "\n").Split('\n');
            currentLineIndex = 0;
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PreparePrint();
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print(); // ✅ Correct way to trigger actual printing
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Margins
            float left = e.MarginBounds.Left;
            float top = e.MarginBounds.Top;

            // Font and formatting
            Font printFont = textBox2.Font ?? new Font("Arial", 10);
            float lineHeight = printFont.GetHeight(e.Graphics);

            // Lines per page
            int linesPerPage = (int)(e.MarginBounds.Height / lineHeight);
            int count = 0;
            float yPos = top;

            // Print each line
            while (count < linesPerPage && currentLineIndex < linesToPrint.Length)
            {
                string line = linesToPrint[currentLineIndex];
                e.Graphics.DrawString(line, printFont, Brushes.Black, left, yPos);
                yPos += lineHeight;
                currentLineIndex++;
                count++;
            }

            // Check if more pages are needed
            e.HasMorePages = currentLineIndex < linesToPrint.Length;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cut");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paste");
        }
    }
}
