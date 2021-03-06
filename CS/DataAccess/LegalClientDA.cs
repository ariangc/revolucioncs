﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using Model;
using System.ComponentModel;

namespace DataAccess {
    public class LegalClientDA {
        public int searchLegalClient(string ruc) {
            int idLegalClient = -1;
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Person_IdPerson from LegalClient where Ruc = " + ruc;

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                idLegalClient = reader.GetInt32("Person_IdPerson");
            }
            con.Close();
            return idLegalClient;
            
        }

        public void addLegalClient(LegalClient lc)
        {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "addToBDLegalClient";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("_address", MySqlDbType.String).Value = lc.Address;
            cmd.Parameters.Add("_phoneNumber", MySqlDbType.String).Value = lc.PhoneNumber;
            cmd.Parameters.Add("_email", MySqlDbType.String).Value = lc.Email;
            cmd.Parameters.Add("_companyName", MySqlDbType.String).Value = lc.CompanyName;
            cmd.Parameters.Add("_ruc", MySqlDbType.String).Value = lc.RUC;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<LegalClient> listLegalClients(string ruc, string name)
        {
            BindingList<LegalClient> list = new BindingList<LegalClient>();
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "listLegalClients";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            if (ruc.Length == 0) cmd.Parameters.Add("_ruc", MySqlDbType.String).Value = DBNull.Value;
            else cmd.Parameters.Add("_ruc", MySqlDbType.String).Value = ruc;

            if (name.Length == 0) cmd.Parameters.Add("_companyName", MySqlDbType.String).Value = DBNull.Value;
            else cmd.Parameters.Add("_companyName", MySqlDbType.String).Value = name;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                LegalClient lc = new LegalClient();
                lc.Address = reader.GetString("Address");
                lc.CompanyName = reader.GetString("CompanyName");
                lc.Email = reader.GetString("Email");
                lc.IdPerson = reader.GetInt32("IdPerson");
                lc.PhoneNumber = reader.GetString("PhoneNumber");
                lc.RUC = reader.GetString("Ruc");
                lc.Points = reader.GetInt32("Points");
                list.Add(lc);
            }
            con.Close();
            return list;
        }

        public void updateLegalClient(LegalClient lc)
        {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "updateInBDLegalClient";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("_address", MySqlDbType.String).Value = lc.Address;
            cmd.Parameters.Add("_phoneNumber", MySqlDbType.String).Value = lc.PhoneNumber;
            cmd.Parameters.Add("_email", MySqlDbType.String).Value = lc.Email;
            cmd.Parameters.Add("_ruc", MySqlDbType.String).Value = lc.RUC;
            cmd.Parameters.Add("_companyName", MySqlDbType.String).Value = lc.CompanyName;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<LegalClient> searchLegalClients(string ruc, string name)
        {
            BindingList<LegalClient> list = new BindingList<LegalClient>();
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "searchLegalClients";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            if (ruc.Length == 0) cmd.Parameters.Add("_ruc", MySqlDbType.String).Value = DBNull.Value;
            else cmd.Parameters.Add("_ruc", MySqlDbType.String).Value = ruc;

            if (name.Length == 0) cmd.Parameters.Add("_companyName", MySqlDbType.String).Value = DBNull.Value;
            else cmd.Parameters.Add("_companyName", MySqlDbType.String).Value = name;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                LegalClient lc = new LegalClient();
                lc.Address = reader.GetString("Address");
                lc.CompanyName = reader.GetString("CompanyName");
                lc.Email = reader.GetString("Email");
                lc.IdPerson = reader.GetInt32("IdPerson");
                lc.PhoneNumber = reader.GetString("PhoneNumber");
                lc.RUC = reader.GetString("Ruc");
                list.Add(lc);
            }
            con.Close();
            return list;
        }

        public void updateLegalClientPoints(int personId, int pointsGained)
        {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "updateInBDLegalClientPoints";
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
            cmd.CommandText = "select Points from LegalClient where Person_IdPerson =" + personId.ToString() + ";";
            cmd.Connection = con;
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int points = reader.GetInt32("Points");
            con.Close();
            return points;
        }
    }
}
