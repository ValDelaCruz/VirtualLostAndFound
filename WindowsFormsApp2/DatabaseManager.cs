using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp2
{
    class DatabaseManager
    {
        MySqlConnection con;

        public DatabaseManager()
        {
            string connect = "SERVER=" + Configuration.dbHost + ";DATABASE=" + Configuration.dbName + ";USERNAME=" + Configuration.dbUser + ";PASSWORD=" +Configuration.dbPass + ";Convert Zero DateTime = true";
            con = new MySqlConnection(connect);
        }


    }
}
