using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace DataAccess {
    public class NaturalClientDA {
        public int searchNaturalClient(string dni) {
            int idNaturalClient = -1;
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Person_IdPerson from NaturalClient where Dni = " + dni;

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                idNaturalClient = reader.GetInt32("Person_IdPerson");
            }
            con.Close();
            return idNaturalClient;
        }

        public void addNaturalClient(NaturalClient nc)
        {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "addToBDNaturalClient";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("_address", MySqlDbType.String).Value = nc.Address;
            cmd.Parameters.Add("_phoneNumber", MySqlDbType.String).Value = nc.PhoneNumber;
            cmd.Parameters.Add("_email", MySqlDbType.String).Value = nc.Email;
            cmd.Parameters.Add("_name", MySqlDbType.String).Value = nc.Name;
            cmd.Parameters.Add("_surname", MySqlDbType.String).Value = nc.Surname;
            cmd.Parameters.Add("_dni", MySqlDbType.String).Value = nc.Dni;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void updateNaturalClient(NaturalClient nc)
        {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "updateInBDNaturalClient";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("_address", MySqlDbType.String).Value = nc.Address;
            cmd.Parameters.Add("_phoneNumber", MySqlDbType.String).Value = nc.PhoneNumber;
            cmd.Parameters.Add("_email", MySqlDbType.String).Value = nc.Email;
            cmd.Parameters.Add("_name", MySqlDbType.String).Value = nc.Name;
            cmd.Parameters.Add("_surname", MySqlDbType.String).Value = nc.Surname;
            cmd.Parameters.Add("_dni", MySqlDbType.String).Value = nc.Dni;

            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        public BindingList<NaturalClient> listNaturalClients(string dni, string name, string surname)
        {
            BindingList<NaturalClient> list = new BindingList<NaturalClient>();
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "listNaturalClients";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            if (dni.Length == 0) cmd.Parameters.Add("_dni", MySqlDbType.String).Value = DBNull.Value;
            else cmd.Parameters.Add("_dni", MySqlDbType.String).Value = dni;

            if (name.Length == 0) cmd.Parameters.Add("_name", MySqlDbType.String).Value = DBNull.Value;
            else cmd.Parameters.Add("_name", MySqlDbType.String).Value = name;

            if (surname.Length == 0) cmd.Parameters.Add("_surname", MySqlDbType.String).Value = DBNull.Value;
            else cmd.Parameters.Add("_surname", MySqlDbType.String).Value = surname;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                NaturalClient nc = new NaturalClient();
                nc.Dni = reader.GetString("Dni");
                nc.Name = reader.GetString("Name");
                nc.Surname = reader.GetString("Surname");
                nc.Address = reader.GetString("Address");
                nc.PhoneNumber = reader.GetString("PhoneNumber");
                nc.Email = reader.GetString("Email");
                nc.Points = reader.GetInt32("Points");
                list.Add(nc);
            }
            con.Close();
            return list;
        }

        public BindingList<NaturalClient> searchNaturalClients(string dni, string name, string surname)
        {
            BindingList<NaturalClient> list = new BindingList<NaturalClient>();
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "listNaturalClients";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            if (dni.Length == 0) cmd.Parameters.Add("_dni", MySqlDbType.String).Value = DBNull.Value;
            else cmd.Parameters.Add("_dni", MySqlDbType.String).Value = dni;

            if (name.Length == 0) cmd.Parameters.Add("_name", MySqlDbType.String).Value = DBNull.Value;
            else cmd.Parameters.Add("_name", MySqlDbType.String).Value = name;

            if (surname.Length == 0) cmd.Parameters.Add("_surname", MySqlDbType.String).Value = DBNull.Value;
            else cmd.Parameters.Add("_surname", MySqlDbType.String).Value = surname;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                NaturalClient nc = new NaturalClient();
                nc.Dni = reader.GetString("Dni");
                nc.Name = reader.GetString("Name");
                nc.Surname = reader.GetString("Surname");
                nc.Address = reader.GetString("Address");
                nc.PhoneNumber = reader.GetString("PhoneNumber");
                nc.Email = reader.GetString("Email");
                list.Add(nc);
            }
            con.Close();
            return list;
        }

        public void updateNaturalClientPoints(int personId, int pointsGained)
        {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "updateInBDNaturalClientPoints";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("_personId", MySqlDbType.Int32).Value = personId;
            cmd.Parameters.Add("_pointsGained", MySqlDbType.Int32).Value = pointsGained;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int getPoints(int personId) {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select Points from NaturalClient where Person_IdPerson =" + personId.ToString() + ";";
            cmd.Connection = con;
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int points = reader.GetInt32("Points");
            con.Close();
            return points;
        }
    }
}
