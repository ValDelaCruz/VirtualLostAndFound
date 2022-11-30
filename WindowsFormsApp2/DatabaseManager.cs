using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public bool RegisterUser(string firstname, string middleinitial, string lastname, string usertype,int contactNo, string email, string username, string password )
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `users`(`Firstname`, `Middle Initial`, `Last Name`, `User Type`, `Contact Number`, `Email`, `Username`, `Password`) VALUES(@firstname, @middleinitial, @lastname, @usertype, @contactNo, @email, @username, @password);", con);

            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@middleinitial", middleinitial);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@usertype", usertype);
            cmd.Parameters.AddWithValue("@contactNo", contactNo);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
  

            int result = cmd.ExecuteNonQuery();


            con.Close();

            return true;
        }
    }
}
