using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Task2_StickyNotes
{
    public partial class MainForm : Form
    {
        public string folder = @"C:\Users\OptiCheck\Desktop\sticky notes";

        private bool selectMode = false;
         
        private readonly Color NormalColor = Color.White;
        private readonly Color SelectedColor = Color.Beige;
        

        public MainForm()
        {
            InitializeComponent();
            SubForm.AddNoteRequested += AddLabel_Click;
        }
         
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(folder))
                return;

            foreach (var file in Directory.GetFiles(folder, "*.txt"))
            {
                string[] lines = File.ReadAllLines(file);

                Color noteColor = Color.LightYellow;
                string content = string.Empty;
                int startIndex = 0;

                if (lines.Length > 0 && lines[0].StartsWith("COLOR:"))
                {
                    string colorPart = lines[0].Substring(6); 
                    string[] rgb = colorPart.Split(',');

                    if (rgb.Length == 3 && int.TryParse(rgb[0], out int r) && int.TryParse(rgb[1], out int g) && int.TryParse(rgb[2], out int b))
                    {
                        noteColor = Color.FromArgb(r, g, b);
                    }
                    
                    content = string.Join(Environment.NewLine,lines.Skip(1));
                }
                else
                {
                    content = string.Join(Environment.NewLine,lines);
                }

                string title = Path.GetFileNameWithoutExtension(file); 
                string dateTime = File.GetCreationTime(file).ToString("dd-MM-yyyy hh:mm tt");
                
                DisplayNotes(title, content, dateTime, file,noteColor);
            }
        }
         
        private void AddLabel_Click(object sender, EventArgs e)
        { 
            SubForm subForm = new SubForm();
            subForm.Notify += CallNotification;

            if (subForm.ShowDialog() != DialogResult.OK)
                return;

            string filePath = SaveNotes(subForm.Title, subForm.Content,subForm.PickedColor); 
            string dateTime = File.GetCreationTime(filePath).ToString("dd-MM-yyyy hh:mm tt");
  

            DisplayNotes(subForm.Title, subForm.Content, dateTime, filePath,subForm.PickedColor );
        }

        private string SaveNotes(string title, string content ,Color color)
        {
            if (!Directory.Exists(folder))Directory.CreateDirectory(folder);

            string filePath = Path.Combine(folder, title + ".txt");
            string colorLine = $"COLOR: {color.R},{color.G},{color.B}";

            File.WriteAllText(filePath, colorLine + Environment.NewLine + content);

            return filePath;
        }
         
        private void DisplayNotes(string title, string content, string dateTime, string filePath, Color topColor)
        {
            StickyNotesControl note = new StickyNotesControl
            {
                Title = title,
                TimeStamp = dateTime,
                FilePath = filePath,
                Tag = filePath,
                Width = mainPanel.ClientSize.Width - 20,
                TopPanelColor = topColor,
                Dock = DockStyle.Top
            };

            
            note.NoteClicked += Note_Click;
            note.NoteDoubleClick += Note_DoubleClick;
            note.DeleteNoteRequested += NoteControl_DeleteNoteRequested;

            mainPanel.Controls.Add(note);
            mainPanel.PerformLayout();
        }
         
        private void Note_Click(object sender, EventArgs e)
        {
            if (!selectMode)
                return;

            StickyNotesControl note = sender as StickyNotesControl;

            if (note == null)
                return;

            note.BackColor = note.BackColor == SelectedColor  ? NormalColor : SelectedColor;
        }
         
        private void SelectAllBtn_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Count == 0)
            {
                MessageBox.Show("No notes available");
                return;
            }

            selectMode = !selectMode;
            delIconBox.Visible = selectMode;

            foreach (Control c in mainPanel.Controls)
            {
                if (c is StickyNotesControl note)
                {
                    note.BackColor = selectMode ? SelectedColor : NormalColor;
                }
            }
        }
         
         
        private void CallNotification(object sender, EventArgs e)
        {
            NotificationManager.Show("Note Saved");
        }

        private void Note_DoubleClick(object sender, EventArgs e)
        {
            StickyNotesControl note = sender as StickyNotesControl;
            if (note == null || !File.Exists(note.FilePath))
                return;
             
            string[] lines = File.ReadAllLines(note.FilePath);

            string content;
            Color noteColor = Color.LightYellow;

            if (lines.Length > 0 && lines[0].StartsWith("COLOR:"))
            {
                string[] rgb = lines[0].Substring(6).Split(',');

                if (rgb.Length == 3 && int.TryParse(rgb[0], out int r) && int.TryParse(rgb[1], out int g) && int.TryParse(rgb[2], out int b))
                {
                    noteColor = Color.FromArgb(r, g, b);
                }

                content = string.Join(Environment.NewLine, lines.Skip(1));
            }
            else
            {
                content = string.Join(Environment.NewLine, lines);
            }

            SubForm subForm = new SubForm();
            subForm.LoadNote(note.Title, content, note.FilePath, noteColor);

            if (subForm.ShowDialog() != DialogResult.OK)
                return;

            string oldFilePath = note.FilePath;
            string newTitle = subForm.Title;
            string newFilePath = Path.Combine(folder, newTitle + ".txt");

            SaveNotes(newTitle, subForm.Content, subForm.PickedColor);

            if (oldFilePath != newFilePath && File.Exists(oldFilePath))
                File.Delete(oldFilePath);

            note.Title = newTitle;
            note.FilePath = newFilePath;
            note.TimeStamp = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            note.TopPanelColor = subForm.PickedColor;

            NotificationManager.Show("Note updated successfully");
        }


        
        private void NoteControl_DeleteNoteRequested(object sender, EventArgs e)
        {
            var noteControl = sender as StickyNotesControl;
            if (noteControl.Tag == null) return;

            string file = noteControl.Tag.ToString();

            if (File.Exists(file))
                File.Delete(file);

            mainPanel.Controls.Remove(noteControl);
            NotificationManager.Show($"Note \"{noteControl.Title}\" deleted successfully");
        }

        int themeCount = 0;
        private void DarkMode(object sender, EventArgs e)
        {
            themeCount += 1;
            if (themeCount == 1)
            {
                this.topPanel.BackColor = Color.Black;
                this.mainPanel.BackColor = Color.Black;
                this.addLabel.BorderStyle = BorderStyle.FixedSingle;
                this.addLabel.ForeColor = Color.White;
                this.label1.ForeColor = Color.White;
                this.selectAllBtn.ForeColor = Color.White;
                this.selectAllBtn.BackColor = Color.Black; 
            }
            else if (themeCount == 2)
            {
                themeCount = 0;
                this.topPanel.BackColor = Color.LightCyan;
                this.mainPanel.BackColor = Color.Gainsboro;
                this.addLabel.BorderStyle = BorderStyle.None;
                this.addLabel.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.selectAllBtn.ForeColor = Color.Black;
                this.selectAllBtn.BackColor = Color.PaleTurquoise;
            }  
        }

        private void DeleteIconBox_Click(object sender, EventArgs e)
        {
            List<StickyNotesControl> toDelete = new List<StickyNotesControl>();

            foreach (Control c in mainPanel.Controls)
            {
                if (c is StickyNotesControl note &&
                    note.BackColor == SelectedColor)
                {
                    if (File.Exists(note.FilePath))
                        File.Delete(note.FilePath);

                    NotificationManager.Show($"Note \"{note.Title}\" deleted");

                    toDelete.Add(note);
                }
            }

            foreach (var note in toDelete)
            {
                mainPanel.Controls.Remove(note);
            }

            selectMode = false;
            delIconBox.Visible = false;
        }

    }
}
