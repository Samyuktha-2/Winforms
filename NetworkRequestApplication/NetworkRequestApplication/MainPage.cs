using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkRequestApplication
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Example logic
            if (radioButton1.Checked)
            {
                indianPanel.Visible = true;
                groupResident.Height = 150;
            }
            else
            {
                indianPanel.Visible = false;
                groupResident.Height = 70;
            }
        }

        private void radioButton2_CheckedChanged(object sender,EventArgs e)
        {
            if (radioButton2.Checked)
            {
                nriPanel.Visible = true;
                groupResident.Height = 200;
            }
            else
            {
                nriPanel.Visible = false;
                groupResident.Height = 70;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                othersPanel.Visible = true;
                groupResident.Height = 200;
            }
            else
            {
                othersPanel.Visible = false;
                groupResident.Height = 70;
            }
        }

        private void richAddressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richAddressTextBox.AppendText(Environment.NewLine); // Add newline
                richAddressTextBox.Height += 20;
                e.SuppressKeyPress = true;                      
            }
            int lineCount = richAddressTextBox.Lines.Length;
            int minHeight = 30;
            int maxHeight = 200;
            int newHeight = richAddressTextBox.Font.Height * lineCount + 5;
            richAddressTextBox.Height = Math.Max(minHeight, Math.Min(maxHeight, newHeight));
        }

        private void richPermanentAddressTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                richPermanentAddressTextbox.AppendText(Environment.NewLine); // Add newline
                richPermanentAddressTextbox.Height += 20;
                e.SuppressKeyPress = true;
            }

            int lineCount = richPermanentAddressTextbox.Lines.Length;
            int minHeight = 30;
            int maxHeight = 200;
            int newHeight = richPermanentAddressTextbox.Font.Height * lineCount + 5;
            richPermanentAddressTextbox.Height = Math.Max(minHeight, Math.Min(maxHeight, newHeight));

            int minWidth = 100;
            int maxWidth = 500;
            int textWidth = TextRenderer.MeasureText(richPermanentAddressTextbox.Text, richPermanentAddressTextbox.Font).Width;
            int newWidth = textWidth + 10;

            richPermanentAddressTextbox.Width = Math.Max(minWidth, Math.Min(maxWidth, newWidth));
        }

        private void richLocalStayAddressTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richLocalStayAddressTextbox.AppendText(Environment.NewLine); // Add newline
                richLocalStayAddressTextbox.Height += 20;
                e.SuppressKeyPress = true;
            }

            int lineCount = richLocalStayAddressTextbox.Lines.Length;
            int minHeight = 30;
            int maxHeight = 200;
            int newHeight = richLocalStayAddressTextbox.Font.Height * lineCount + 5;
            richLocalStayAddressTextbox.Height = Math.Max(minHeight, Math.Min(maxHeight, newHeight));

            int minWidth = 100;
            int maxWidth = 500;
            int textWidth = TextRenderer.MeasureText(richLocalStayAddressTextbox.Text, richLocalStayAddressTextbox.Font).Width;
            int newWidth = textWidth + 10;

            richLocalStayAddressTextbox.Width = Math.Max(minWidth, Math.Min(maxWidth, newWidth));
        }

        private void newConnectionRB_CheckedChanged(object sender, EventArgs e)
        {
            if (newConnectionRB.Checked)
            {
                newConnectionPanel.Visible = true;
                servicePanel.Height = 200;
            }
            else
            {
                newConnectionPanel.Visible = false;
                servicePanel.Height = 70;
            }
        }

        private void relocationRB_CheckedChanged(object sender, EventArgs e)
        {
            if (relocationRB.Checked)
            {
                relocationPanel.Visible = true;
                servicePanel.Height = 200;
            }
            else
            {
                relocationPanel.Visible = false;
                servicePanel.Height = 70;
            }
        }

        private void cardRB_CheckedChanged(object sender, EventArgs e)
        {
            if (cardRB.Checked)
            {
                cardPanel.Visible = true;
            }
            else
            {
                cardPanel.Visible = false;
            }
        }
    } 
}
