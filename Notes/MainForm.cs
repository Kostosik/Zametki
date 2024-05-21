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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TEST");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
