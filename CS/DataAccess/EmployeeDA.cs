using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace DataAccess
{
    public class EmployeeDA
    {
        public EmployeeDA()
        {

        }

        public string returnPassword()
        {
            string cadena = Constants.connectionString;
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "";
            comando.Connection = con;
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();


            return "1";
        }
    }
}
