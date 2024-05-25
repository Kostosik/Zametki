using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Runtime.Remoting.Contexts;

namespace Notes
{
    struct noteStruct
    {
        public int Id { get; set; }
        public string topText { get; set; }
        public string bottomText { get; set; }
    }

    internal class DBQuery
    {
        public DBQuery() 
        {

        }

        internal noteStruct[] loadFromDataBase(MySqlConnection conn)
        {
            string loadQuery = "SELECT * FROM " + Properties.Settings.Default.TableName;

            MySqlCommand command = new MySqlCommand(loadQuery, conn);
            
            List<int> ids = new List<int> ();
            List<string> topTexts = new List<string> ();
            List<string> bottomTexts = new List<string> ();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.FieldCount != 3)
                    {
                        throw new ArgumentException("Wrong table size");
                    }

                    ids.Add((int)reader[0] );
                    topTexts.Add((string)reader[1] );
                    bottomTexts.Add((string)reader[2] );
                }
            }
            noteStruct[] toReturn = new noteStruct[ids.Count];
            for(int i=0;i<ids.Count;i++)
            {
                toReturn[i].Id = ids[i];
                toReturn[i].topText = topTexts[i];
                toReturn[i].bottomText = bottomTexts[i];
            }

            return toReturn;
        }

        internal List<int> loadIdsFromDataBase(MySqlConnection conn)
        {
            List<int> ids =  new List<int>();

            string loadQuery = "SELECT idnotes FROM " + Properties.Settings.Default.TableName;
            MySqlCommand command = new MySqlCommand(loadQuery, conn);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.FieldCount != 1)
                    {
                        throw new ArgumentException("Wrong table size");
                    }

                    ids.Add((int)reader[0]);
                }
            }

            return ids;
        }

        internal void updateSingleNote(MySqlConnection conn,UserControlNotes noteToSave)
        {
            int idToSave = noteToSave.getNoteIndex();
            string topText = noteToSave.getTopText();
            string bottomText = noteToSave.getMainText();

            string updateQuery = "update " + Properties.Settings.Default.TableName +" set topTextColumn = ('" + topText + "') , bottomTextColumn = ('" + bottomText + "') where idnotes = " + idToSave;

            MySqlCommand command = new MySqlCommand(updateQuery, conn);
            command.ExecuteNonQuery();
        }

        internal void addSingleNoteToDataBase(MySqlConnection conn, UserControlNotes noteToSave)
        {
            int idToSave = noteToSave.getNoteIndex();
            string topText = noteToSave.getTopText();
            string bottomText = noteToSave.getMainText();

            string addQuery = "insert into " + Properties.Settings.Default.TableName + " values ("+ idToSave +", ' " + topText + " ' ,' " + bottomText + "' )";

            MySqlCommand command = new MySqlCommand(addQuery, conn);
            command.ExecuteNonQuery();
        }

        internal void saveAllToDataBase(MySqlConnection conn,List<UserControlNotes> notesToSave)
        {
            List<int> ids = loadIdsFromDataBase(conn);

            for (int i = 1; i < notesToSave.Count+1; i++)
            {
                if (ids.Contains(notesToSave[i-1].getNoteIndex()))
                {
                    updateSingleNote(conn, notesToSave[i-1]);
                }
                else
                {
                    addSingleNoteToDataBase(conn, notesToSave[i-1]);
                }
            }
        }

        internal void deleteNoteFromDataBase(MySqlConnection conn, UserControlNotes noteToDelete)
        {
            int idToDelete = noteToDelete.getNoteIndex();

            string addQuery = "delete from " + Properties.Settings.Default.TableName + " where idnotes = " + idToDelete;

            MySqlCommand command = new MySqlCommand(addQuery, conn);
            command.ExecuteNonQuery();
        }
    }
}
