using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms1
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                string fileContent = System.IO.File.ReadAllText(FileName);

                Form childForm = new Form();
                childForm.MdiParent = this;
                childForm.Text = System.IO.Path.GetFileName(FileName);

                TextBox textBox = new TextBox();
                textBox.Multiline = true;
                textBox.Dock = DockStyle.Fill;
                textBox.ScrollBars = ScrollBars.Both;
                textBox.Text = fileContent;

                childForm.Controls.Add(textBox);
                childForm.Show();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get the active MDI child (the one in focus)
            Form activeChild = this.ActiveMdiChild;
            if (activeChild == null)
            {
                MessageBox.Show("No document is open to save.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try to find a TextBox in that form
            TextBox textBox = activeChild.Controls.OfType<TextBox>().FirstOrDefault();
            if (textBox == null)
            {
                MessageBox.Show("No editable text area found in this document.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open the Save File dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                // Actually write the contents to the selected file
                System.IO.File.WriteAllText(fileName, textBox.Text);

                // Update window title
                activeChild.Text = System.IO.Path.GetFileName(fileName);
                MessageBox.Show("File saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null && ActiveMdiChild.ActiveControl is TextBox textBox)
            {
                textBox.Cut();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null && ActiveMdiChild.ActiveControl is TextBox textBox)
            {
                textBox.Copy();
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null && ActiveMdiChild.ActiveControl is TextBox textBox)
            {
                textBox.Paste();
            }
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void loadButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.MdiParent = this;

            //changing the size of MDIParent1 according to child form
            //this.Width = button.Width + 50;
            //this.Height = button.Height + 100;

            //changing the size of child form according to MDIParent1
            button.Dock = DockStyle.Fill;
            button.Show();
        }

        private void loadDatGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.MdiParent = this;

            //changing the size of MDIParent1 according to child form
            //this.Width = dataGridView.Width + 50;
            //this.Height = dataGridView.Height + 100;

            //changing the size of child form according to MDIParent1
            dataGridView.Dock = DockStyle.Fill;

            dataGridView.Show();
        }

        private void loadLabelAndDayTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabelAndDayTimePicker labelAndDayTimePicker = new LabelAndDayTimePicker();
            labelAndDayTimePicker.MdiParent = this;

            //changing the size of MDIParent1 according to child form
            //this.Width = labelAndDayTimePicker.Width + 50;
            //this.Height = labelAndDayTimePicker.Height + 100;

            //changing the size of child form according to MDIParent1
            labelAndDayTimePicker.Dock = DockStyle.Fill;

            labelAndDayTimePicker.Show();
        }
         
    }
}
