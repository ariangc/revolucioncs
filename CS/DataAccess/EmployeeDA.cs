using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using Model;

namespace DataAccess
{
    public class EmployeeDA
    {
        public EmployeeDA()
        {

        }

        public string returnPassword(string username)
        {
            string cadena = Constants.connectionString;
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT Password FROM Employee WHERE Dni = " + username + ";";
            comando.Connection = con;
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            string pass = reader.GetString("Password");
            con.Close();
            return pass;
        }

        public Employee getEmployee(string username) {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM Employee WHERE Dni = " + username + ";";
            comando.Connection = con;
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            Employee employee = new Employee();
            employee.FullName = reader.GetString("Name") + " " + reader.GetString("Surname");
            employee.Id = reader.GetInt32("Person_IdPerson");
            con.Close();
            return employee;
        }

        public void changePassword(string pass)
        {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            MySqlCommand cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "updatePassword";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("_username", MySqlDbType.String).Value = Constants.CurrentUserName;
            cmd.Parameters.Add("_newPassword", MySqlDbType.String).Value = pass;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
