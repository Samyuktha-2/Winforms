using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatioPanel
{
    public partial class RowCol : Form
    {
        public RowCol()
        {
            InitializeComponent();
        }
         
        List<Label> label = new List<Label>();
        int[] rowValue;
        int[] colValue;

        private void OkBtn(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            label.Clear();

            rowValue = ConvertToValue(rowRatioValue.Text);
            colValue = ConvertToValue(colRatioValue.Text);

            for(int i = 0;i < rowValue.Length; i++)
            {
                for(int j = 0; j < colValue.Length; j++)
                {
                    Label l = new Label
                    { 
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    label.Add(l);
                }
            }

            LabelResize();
            rowRatioValue.Clear();
            colRatioValue.Clear();
        }

        private void LabelResize()
        {
            int x = 0, y = 0;
            int rowCount = 0, colCount = 0;

            int colTotal = colValue.Sum();
            int rowTotal = rowValue.Sum();

            foreach(Label l in label)
            {
                int width = (int)((colValue[colCount] / (float)colTotal) * mainPanel.Width);
                int height = (int)((rowValue[rowCount] / (float)rowTotal) * mainPanel.Height);

                l.Size = new Size(width, height);
                l.Location = new Point(x, y);
                l.Text = $"{rowCount + 1}, {colCount + 1}";

                x += width;
                colCount++;

                if (colCount%colValue.Length == 0)
                {
                    rowCount++;
                    x = 0;
                    y += height;
                    colCount = 0;
                }

                mainPanel.Controls.Add(l);
            }
        }

        private int[] ConvertToValue(string text)
        {
            string[] part = text.Split(' ');
            return part.Select(int.Parse).ToArray();
        }

        private void FormResize(object sender, EventArgs e)
        {
            LabelResize();
        }
    }
}
