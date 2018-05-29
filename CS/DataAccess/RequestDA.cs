﻿using Model;
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
            cmd.CommandText = "SELECT * FROM Requirement WHERE Employee_IdPerson = " + id + " and State = 1";
            MySqlDataReader reader = cmd.ExecuteReader();
            int index = 0;
            while (reader.Read())
            {
                Request r = new Request();
                r.Description = reader.GetString("Description");
                string type = reader.GetString("Type");
                if (type.Equals("Sugerencia")) r.Type = Enumerators.RequirementType.Sugerencia;
                else if (type.Equals("Problema")) r.Type = Enumerators.RequirementType.Problema;
                else r.Type = Enumerators.RequirementType.Otro;
                r.IdEmployee = reader.GetInt32("Employee_IdPerson");
                r.IdRequest = reader.GetInt32("IdRequirement");
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
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "deleteInBDRequirement";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("id", MySqlDbType.Int32).Value = r.IdRequest;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void modifyRequest(Request r)
        {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "updateInBDRequirement";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("_description", MySqlDbType.String).Value = r.Description;
            cmd.Parameters.Add("_idRequirement", MySqlDbType.Int32).Value = r.IdRequest;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
