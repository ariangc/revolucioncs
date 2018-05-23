using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

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
    }
}
