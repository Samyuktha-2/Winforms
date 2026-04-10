using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagenation
{
    public partial class Pagenation : Form
    {
        public Pagenation()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        PagenationController pagenation = new PagenationController();
        private void OKBtn(object sender, EventArgs e)
        {
            Controls.RemoveByKey("Pagenation");
            int page;
            if (!string.IsNullOrWhiteSpace(pageCount.Text) && int.TryParse(pageCount.Text, out page) && page > 0)
            {
                page = int.Parse(pageCount.Text);

            }
            else
            {
                page = 10;
            } 
            pagenation.TotalPages = page;
            pagenation.Name = "Pagenation";
            pagenation.Location = new Point(20, 20);

            Controls.Add(pagenation);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            pagenation.BuildUI();
        }
    }
}
  
