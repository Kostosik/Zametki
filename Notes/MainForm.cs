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
        List<UserControlNotes> notes;
        public MainForm()
        {
            InitializeComponent();
            notes = new List<UserControlNotes> ();
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            UserControlNotes note = new UserControlNotes(notes.Count);
            notes.Add(note);

            notesFlowLayoutPanel.Controls.Add(note);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
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
            string connectionString = null;
            DBConnection connection = new DBConnection(connectionString);


        }
    }
}
