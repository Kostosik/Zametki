using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    internal class NoteParser
    {
        public NoteParser() 
        {
            
        }

        internal List<UserControlNotes> parseFromDataBase(List<int> ids,List<string> topTexts,List<string>bottomTexts)
        {
            List<UserControlNotes> notes = new List<UserControlNotes>();

            for (int i = 0; i < ids.Count; i++)
            {
                UserControlNotes note = new UserControlNotes(ids[i], topTexts[i], bottomTexts[i]);
                notes.Add(note);
            }

            return notes;
        }

        internal void parseToDataBase(List<UserControlNotes> notes) 
        {

        }
    }
}