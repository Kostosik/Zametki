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
        int noteIndex;

        public UserControlNotes(int noteIndex)
        {
            InitializeComponent();
            this.noteIndex = noteIndex;
            //MessageBox.Show(noteIndex.ToString());
        }

        private void noteRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlNotes_Load(object sender, EventArgs e)
        {
            noteRichTextBox.ReadOnly = true;
            //noteRichTextBox.Enabled = false;
            //noteRichTextBox.BackColor = Color.White;

            topTextBox.ReadOnly = true;
            //topTextBox.Enabled=false;
            topTextBox.BackColor = Color.White;

            //noteSplitContainer.BackColor = Color.White;
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

        internal string getTopText()
        {
            return topTextBox.Text;
        }

        internal string getMainText()
        {
            return noteRichTextBox.Text;
        }
    }
}
