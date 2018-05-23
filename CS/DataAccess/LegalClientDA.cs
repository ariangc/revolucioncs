using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using Model;

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
        }
    }
}
