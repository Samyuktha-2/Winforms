using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordWrapping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panel2.Resize += PanelResize;
        }

        List<WordWrap> labels = new List<WordWrap>();
        int x = 0, y = 0;
        private void AddBtn(object sender, EventArgs e)
        {
            Label label = new Label
            {
                Text = BreakLongWords(textBox1.Text),
                AutoSize = false,
                Width = panel2.Width,
                BorderStyle = BorderStyle.FixedSingle
            };
             

            Button delBtn = new Button
            {
                Text = "DELETE", 
                Size = new Size(75, 23)
            };
             

            labels.Add(new WordWrap(label,delBtn));

            panel2.Controls.Add(label);
            panel2.Controls.Add(delBtn);
            textBox1.Clear();

            LayoutItems();
        }

        public class WordWrap
        {
            public Label Label { get; set; }
            public Button DelBtn { get; set; }
            public WordWrap(Label l,Button db)
            {
                Label = l;
                DelBtn = db;
            }
        }

        string BreakLongWords(string text, int chunkSize = 5)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append(text[i]);
                if (i % chunkSize == 0)
                    sb.Append('\u200B'); // zero-width space
            }
            return sb.ToString();
        }


        private void LayoutItems()
        {
            int currentY = 0;

            foreach (var item in labels)
            {
                Label lbl = item.Label;
                Button btn = item.DelBtn;
                 
                lbl.MaximumSize = new Size(panel2.Width , 0);
                lbl.Width = panel2.Width;
                lbl.Size = lbl.PreferredSize;
                lbl.Location = new Point(5, currentY);

                currentY += lbl.Height + 3;
                 
                btn.Location = new Point(5, currentY);
                currentY += btn.Height + 6;
            }
        }


        private void PanelResize(object sender,EventArgs e)
        {
            LayoutItems();
        }
    }
}
