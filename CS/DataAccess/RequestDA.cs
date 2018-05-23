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
            cmd.CommandText = "SELECT * FROM Requirement WHERE ";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Request r = new Request();
                r.Description = reader.GetString("Description");
                string type = reader.GetString("Type");
                //if(type == "Suggestion")
                //{
                    
                //}
                list.Add(r);
            }
            con.Close();
            return list;
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
            cmd.Parameters.Add("_type", MySqlDbType.String).Value = r.Description;
            cmd.Parameters.Add("_User_IdUser", MySqlDbType.Int32).Value = r.Username;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
