using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace DataAccess
{
    public class RequestDA
    {
        public BindingList<Request> listRequests()
        {
            BindingList<Request> list = new BindingList<Request>();
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            int id = returnIdUser(Constants.CurrentUserName);
            cmd.CommandText = "SELECT * FROM Requirement WHERE Employee_IdPerson = "+ id +" and State = 1";
            MySqlDataReader reader = cmd.ExecuteReader();
            int index = 0;
            while (reader.Read())
            {
                Request r = new Request();
                r.Description = reader.GetString("Description");
                string type = reader.GetString("Type");
                if (type == "Suggestion") r.Type = Enumerators.RequirementType.Suggestion;
                else if (type == "Warning") r.Type = Enumerators.RequirementType.Warning;
                else r.Type = Enumerators.RequirementType.Other;
                r.IdEmployee = reader.GetInt32("Employee_IdPerson");
                r.Index = ++index;
                list.Add(r);
            }
            con.Close();
            return list;
        }

        public int returnIdUser(string us)
        {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Person_IdPerson FROM Employee WHERE Dni = " + us;
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int aux = reader.GetInt32("Person_IdPerson");
            con.Close();
            return aux;
        }
        public void newRequest(Request r)
        {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "addToBDRequirement";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("_description", MySqlDbType.String).Value = r.Description;
            cmd.Parameters.Add("_type", MySqlDbType.String).Value = r.Type;
            cmd.Parameters.Add("_User_IdUser", MySqlDbType.Int32).Value = r.IdEmployee;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void deleteRequest(Request r)
        {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT IdRequirement FROM Requirement WHERE Description = \""+r.Description +"\" and Type = \""+r.Type.ToString()+"\" and Employee_IdPerson ="+r.IdEmployee+";";
            Console.WriteLine(cmd.CommandText);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int idRequest = reader.GetInt32("IdRequirement");
            con.Close();

            con.Open();
            cmd.CommandText = "deleteInBDRequirement";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("id", MySqlDbType.Int32).Value = idRequest;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
