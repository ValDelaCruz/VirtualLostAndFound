using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class DatabaseManager
    {
        public static int ErrorCode;

        //For user login & registration
        public static DataTable ExecuteCommand(string command)
        {
            string myConnectionString = "Server=localhost; Database=dbvlf; Uid=root; Pwd=Valdelacruz123";
            MySqlConnection con = new MySqlConnection();
            MySqlDataAdapter adapter;

            DataTable dataTable = new DataTable();

            ErrorCode = -1;
            try
            {
                con.ConnectionString = myConnectionString;
                con.Open();

                adapter = new MySqlDataAdapter(command, con);
                adapter.Fill(dataTable);
            }
            catch (MySqlException ex)
            {
                ErrorCode =  ex.Number;
            }
            finally
            {
                con.Close();
            }

            return dataTable;
        }
    }
}
