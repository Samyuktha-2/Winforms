using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task2_StickyNotes
{
    public partial class StickyNotesControl : UserControl
    {

        public string Title
        {
            get => titleLabel.Text;
            set => titleLabel.Text = value;
        }

        public string TimeStamp
        {
            get => timeStampLabel.Text;
            set => timeStampLabel.Text = value;
        }

        public Color TopPanelColor
        {
            get => topPanel.BackColor;
            set => topPanel.BackColor = value;
        }

        public string FilePath { get; set; }

        public event EventHandler NoteClicked; 
        public event EventHandler NoteDoubleClick;
        public event EventHandler DeleteNoteRequested;

        public StickyNotesControl()
        {
            InitializeComponent();

            this.Click += AllClick;
            this.DoubleClick += NotesDoubleClick;
            titleLabel.Click += AllClick;
            timeStampLabel.Click += AllClick;
            menuLabel.Click += MenuClick;


        } 

        public void AllClick(object sender, EventArgs e)
        {
            NoteClicked?.Invoke(this, EventArgs.Empty);
        }

        public void MenuClick(object sender, EventArgs e)
        {
           
            contextMenuStrip1.Show(menuLabel, 0, menuLabel.Height);
        }

        public void NotesDoubleClick(object sender,EventArgs e)
        {
            NoteDoubleClick?.Invoke(this, EventArgs.Empty);
        }

        private void OpenNote_Click(object sender, EventArgs e)
        {
            NoteDoubleClick(this,EventArgs.Empty);
        }


        private void DeleteNote_Click(object sender, EventArgs e)
        { 
            DeleteNoteRequested?.Invoke(this, EventArgs.Empty);
        }

    }
}
