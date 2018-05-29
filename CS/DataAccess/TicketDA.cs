using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace DataAccess
{
    public class TicketDA
    {
        public void addTicket(Ticket ticket)
        {
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "addToBDTicket";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("_total", MySqlDbType.Double).Value = ticket.Total;
            cmd.Parameters.Add("_igv", MySqlDbType.Double).Value = ticket.Igv;
            cmd.Parameters.Add("_date", MySqlDbType.DateTime).Value = DateTime.Today.Date;
            cmd.Parameters.Add("_pointsGained", MySqlDbType.Int32).Value = ticket.PointsGained;
            cmd.Parameters.Add("_pointsUsed", MySqlDbType.Int32).Value = ticket.PointsUsed;
            cmd.Parameters.Add("_idEmployee", MySqlDbType.Int32).Value = ticket.IdEmployee;
            //cmd.Parameters.Add("_idNaturalClient", MySqlDbType.Int32).Value = ticket.RUC;
            //cmd.Parameters.Add("_idLegalClient", MySqlDbType.Int32).Value = ticket.RUC;
            //falta esperar los cambios en los procedures y la BD para agregar tipo de cliente y el idCliente
            cmd.ExecuteNonQuery();
        }
    }
}
