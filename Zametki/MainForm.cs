using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zametki
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            UserControlNotes note = new UserControlNotes();
            note.Parent = this;
        }
    }
}
