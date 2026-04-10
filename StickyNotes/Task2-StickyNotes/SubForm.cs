using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_StickyNotes
{
    public partial class SubForm : Form
    {
        public event EventHandler Notify;
        public static event EventHandler AddNoteRequested;

        public string Title { get; private set; }
        public string Content { get; private set; }
        public Color PickedColor { get; private set; }


        public string OriginalFilePath { get; private set; }

        public SubForm()
        {
            InitializeComponent();

            PickedColor = Color.LightYellow;
            colorPreviewPanel.BackColor = PickedColor;
        } 
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(titleTextBox.Text.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Title must contain only Characters or Digits");
                titleTextBox.Clear();
                return;
            }

            Title = titleTextBox.Text;
            Content = contentTextBox.Text;

            if(string.IsNullOrEmpty(titleTextBox.Text))
            {
                errorProvider1.SetError(titleTextBox, "Title cannot be empty");
                return;
            }

            errorProvider1.Clear();
            Notify?.Invoke(this, EventArgs.Empty);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void LoadNote(string title, string content, string filePath,Color color)
        { 
            OriginalFilePath = filePath; 
            titleTextBox.Text = title;
            contentTextBox.Text = content;
            PickedColor = color;
            colorPreviewPanel.BackColor = PickedColor;
        } 

        private void AddNewLabel_Click(object sender, EventArgs e)
        {
            AddNoteRequested?.Invoke(this, EventArgs.Empty);
        } 

        private void PickColorBtn_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                PickedColor = colorDialog1.Color;
                colorPreviewPanel.BackColor = PickedColor;
            }
        }
    }
}
