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
    public partial class EditNoteForm : Form
    {
        UserControlNotes noteToEdit;
        public EditNoteForm(UserControlNotes noteToEdit)
        {
            InitializeComponent();
            this.noteToEdit = noteToEdit;
            this.topTextBox.Text = noteToEdit.getTopText();
            this.richTextBox1.Text=noteToEdit.getMainText();
        }

        private void EditNoteForm_Load(object sender, EventArgs e)
        {
            this.Size = noteToEdit.Size + new Size(100,100);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            noteToEdit.changeText(topTextBox, richTextBox1);
            this.Close();
        }

        private void EditNoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            noteToEdit.changeText(topTextBox, richTextBox1);
        }
    }
}
