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
            cmd.CommandText = "SELECT * FROM Requirement";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Request r = new Request();
                r.Description = reader.GetString("Description");
                string type = reader.GetString("Type");
                if(type == "Suggestion")
                {
                    
                }
                list.Add(r);
            }
            con.Close();
            return list;
        }
    }
}
