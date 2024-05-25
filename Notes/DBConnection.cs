using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Notes
{
    internal class DBConnection
    {
        string connectionString;
        MySqlConnection conn;
        public DBConnection(string connectionString) 
        {
            this.connectionString = connectionString;
            conn = null;
        }

        internal void connect()
        {
            try
            {
                conn = new MySqlConnection(connectionString);

            }catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
                Application.Exit();
            };

            conn.Open();
        }

        internal MySqlConnection getConnection()
        {
            if (conn == null)
            {
                throw new ArgumentNullException("SQLConnection");
            }
            return conn;
        }

        internal void closeConnection()
        {
            if (conn == null)
            {
                throw new ArgumentNullException("SQLConnection");
            }
            if(conn.State == System.Data.ConnectionState.Closed) 
            {
                return;
            }
            conn.Close();
        }
    }
}
