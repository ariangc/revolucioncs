using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;
using Utils;

namespace DataAccess {
    public class TicketDA {
        public int addTicket(Ticket t) {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "addToBDTicket";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("_total", MySqlDbType.Double).Value = t.Total;
            cmd.Parameters.Add("_igv", MySqlDbType.Double).Value = Math.Truncate(t.Igv*100)/100;
            cmd.Parameters.Add("_date", MySqlDbType.DateTime).Value = t.TransactionDate;
            cmd.Parameters.Add("_pointsGained", MySqlDbType.Int32).Value = t.PointsGained;
            cmd.Parameters.Add("_pointsUsed", MySqlDbType.Int32).Value = t.PointsUsed;
            cmd.Parameters.Add("_idEmployee", MySqlDbType.Int32).Value = t.IdEmployee;
            cmd.Parameters.Add("_clientType", MySqlDbType.Int32).Value = t.ClientType;
            cmd.Parameters.Add("_clientIdPerson", MySqlDbType.Int32).Value = t.IdClient;
            cmd.Parameters.Add("_idTicket", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            con.Close();
            return Int32.Parse(cmd.Parameters["_idTicket"].Value.ToString());
        }

        public void addProductXTicket(Product p, Ticket t)
        {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "addToBDProductXTicket";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("id_product", MySqlDbType.Int32).Value = p.Id;
            cmd.Parameters.Add("id_ticket", MySqlDbType.Int32).Value = t.Id;
            cmd.Parameters.Add("_idDiscount", MySqlDbType.Int32).Value = p.idDiscount;
            cmd.Parameters.Add("subtotal", MySqlDbType.Double).Value = p.Subtotal;
            cmd.Parameters.Add("quantity", MySqlDbType.Int32).Value = p.QuantitySale;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
