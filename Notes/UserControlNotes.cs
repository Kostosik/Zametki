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
    public partial class UserControlNotes : UserControl
    {
        private int noteIndex;

        public UserControlNotes(int noteIndex)
        {
            InitializeComponent();

            this.noteIndex = noteIndex;
        }

        public UserControlNotes(int id,string topText,string bottomText)
        {
            noteIndex=id;
            topTextBox.Text=topText;
            noteRichTextBox.Text=bottomText;
        }

        private void UserControlNotes_Load(object sender, EventArgs e)
        {
            noteRichTextBox.ReadOnly = true;

            topTextBox.ReadOnly = true;
            topTextBox.BackColor = Color.White;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNoteForm editNoteForm = new EditNoteForm(this);
            editNoteForm.Show();
        }

        internal void changeText(TextBox topTextBox,RichTextBox richTextBox)
        {
            this.topTextBox.Text = topTextBox.Text;
            this.noteRichTextBox.Text = richTextBox.Text;
        }

        internal void changeText(string topText,string  richText)
        {
            this.topTextBox.Text = topText;
            this.noteRichTextBox.Text = richText;
        }

        internal string getTopText()
        {
            return topTextBox.Text;
        }

        internal string getMainText()
        {
            return noteRichTextBox.Text;
        }

        internal int getNoteIndex()
        {
            return noteIndex;
        }
    }
}
