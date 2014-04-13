using Helper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class DbHandler
    {
        private static Dictionary<string, string> items = Util.LoadXml();
        public MySql.Data.MySqlClient.MySqlConnection mycon; 
        public string connStr = String.Format("server={0};user id={1}; password={2};" +
              "database=" + items["Db"] + "; pooling=false", items["DbIp"],
              items["User"], items["Pass"]);

        public DbHandler()
        {
            mycon = new MySqlConnection(connStr);
            mycon.Open();
        }

        public MySqlDataReader executeReader(string query)
        {
            MySqlConnection con = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            return cmd.ExecuteReader();
        }

        public void executeNonQuery(string query)
        {
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int executeId(string query)
        {
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    return (int)cmd.LastInsertedId;
                }
            }
        }
    }
}
