using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class DatabaseManager
    {
        public static int ErrorCode;
        static string myConnectionString = "Server=localhost; Database=dbvlf; Uid=root; Pwd=Valdelacruz123";
        static MySqlConnection con = new MySqlConnection();
        static MySqlDataAdapter adapter;

        //For user login & registration
        public static DataTable ExecuteCommand(string command)
        {
           
            
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

         public static DataTable RetrieveData()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT ItemID, ItemType, ItemColor, ItemBrand, LocationFound, DateFound, TimeFound FROM FinderPost", con);
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);

            BindingSource binding = new BindingSource();
            binding.DataSource = table;
            adapter.Update(table);

            return table;
        } 


    }
}
