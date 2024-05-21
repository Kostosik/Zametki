using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Notes
{
    internal class DBQuery
    {
        public DBQuery() 
        {

        }

        internal void loadFromDataBase(SqlConnection conn)
        {
            string loadQuery = "SELECT * FROM " + Properties.Settings.Default.TableName;

            SqlCommand command = new SqlCommand(loadQuery, conn);
            
            List<int> ids = new List<int> ();
            List<string> topTexts = new List<string> ();
            List<string> bottomTexts = new List<string> ();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.Depth != 3)
                    {
                        throw new ArgumentException("Wrong table size");
                    }

                    ids.Add((int)reader[0] );
                    topTexts.Add((string)reader[1] );
                    bottomTexts.Add((string)reader[2] );
                }
            }
        }

        internal void saveToDataBase(SqlConnection conn)
        {
            string saveQuery = null;

            SqlCommand command = new SqlCommand(saveQuery, conn);
            command.ExecuteNonQuery();
        }
    }
}
