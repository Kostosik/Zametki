using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class MainForm : Form
    {
        private List<UserControlNotes> notes;
        DBConnection dBConnection;

        public MainForm()
        {
            InitializeComponent();
            notes = new List<UserControlNotes> ();
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            UserControlNotes note;
            if (notes.Count == 0)
                note = new UserControlNotes(1);
            else
                note = new UserControlNotes(notes[notes.Count-1].getNoteIndex()+1);
            notes.Add(note);

            notesFlowLayoutPanel.Controls.Add(note);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBQuery dBQuery = new DBQuery();
            dBQuery.saveAllToDataBase(dBConnection.getConnection(), notes);

            Application.Exit();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            notesFlowLayoutPanel.Width = this.Width - 40;
            notesFlowLayoutPanel.Height = this.Height - 100;
            addNoteButton.Location = new System.Drawing.Point(12, this.Height - 74);
        }

        private void loadNotes()
        {
            string connectionString = "server=localhost;uid=root;pwd=admin;database=" + Notes.Properties.Settings.Default.DBName;
            dBConnection = new DBConnection(connectionString);
            dBConnection.connect();

            DBQuery query = new DBQuery();

            noteStruct []notesToCreate;
            notesToCreate = query.loadFromDataBase(dBConnection.getConnection());

            for(int i =0;i<notesToCreate.Length;i++)
            {
                UserControlNotes note = new UserControlNotes(notesToCreate[i].Id, notesToCreate[i].topText, notesToCreate[i].bottomText);
                notes.Add(note);
                notesFlowLayoutPanel.Controls.Add(note);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadNotes();
        }

        internal void deleteNote(UserControlNotes noteToDelete)
        {
            notes.Remove(noteToDelete);
            notesFlowLayoutPanel.Controls.Remove(noteToDelete);

            DBQuery query = new DBQuery();
            query.deleteNoteFromDataBase(dBConnection.getConnection(), noteToDelete);
        }
    }
}
