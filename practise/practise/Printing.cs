using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;


namespace practise
{
    public partial class Printing : Form
    {
        private string[] linesToPrint;
        private int currentLineIndex;

        public Printing()
        {
            InitializeComponent();

            printDocument1.DocumentName = "My Document";
            printDialog1.Document = printDocument1;
            pageSetupDialog1.Document = printDocument1;
            printPreviewDialog1.Document = printDocument1;
        } 

        private void btnPageSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PreparePrint();
            printDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                PreparePrint();
                printDocument1.Print();
            }
        }

        private void PreparePrint()
        {
            linesToPrint = txtContent.Text.Replace("\r\n", "\n").Replace("\r", "\n").Split('\n');
            currentLineIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Margins
            float left = e.MarginBounds.Left;
            float top = e.MarginBounds.Top;

            // Font and formatting
            Font printFont = txtContent.Font ?? new Font("Arial", 10);
            float lineHeight = printFont.GetHeight(e.Graphics);  //needed to space lines properly on paper

            // How many lines per page
            int linesPerPage = (int)(e.MarginBounds.Height / lineHeight);
            int count = 0;
            float yPos = top;

            // Loop through each line until page is filled
            while (count < linesPerPage && currentLineIndex < linesToPrint.Length)
            {
                string line = linesToPrint[currentLineIndex];

                // Create layout area — defines how wide we can print
                SizeF layoutArea = new SizeF(e.MarginBounds.Width, e.MarginBounds.Height);

                // For wrapping and partial line drawing
                int charFitted, linesFilled;

                // Measure how many characters fit into one line width
                e.Graphics.MeasureString(line, printFont, layoutArea, StringFormat.GenericDefault,
                                         out charFitted, out linesFilled);

                // Draw that portion
                string toPrint = line.Substring(0, charFitted);
                e.Graphics.DrawString(toPrint, printFont, Brushes.Black,
                                      new RectangleF(left, yPos, e.MarginBounds.Width, lineHeight * linesFilled),
                                      StringFormat.GenericDefault);

                yPos += lineHeight * linesFilled;

                // If full line was printed, move to next one
                if (charFitted >= line.Length)
                {
                    currentLineIndex++;
                }
                else
                {
                    // Not all chars printed — keep rest for next iteration
                    linesToPrint[currentLineIndex] = line.Substring(charFitted);
                }

                count += linesFilled;
            }

            // Check if more pages needed
            e.HasMorePages = currentLineIndex < linesToPrint.Length;
        }
    }
}
