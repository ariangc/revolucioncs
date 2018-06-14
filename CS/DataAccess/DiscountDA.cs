using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;
using Utils;

namespace DataAccess {
    public class DiscountDA {

        public List<Discount> getApplicableDiscounts(List<Product> listProducts, int points) {
            List<Discount> discounts = new List<Discount>();
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            foreach (Product p in listProducts) {
                MySqlCommand cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "getApplicableDiscounts";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("_idProduct", MySqlDbType.Int32).Value = p.Id;
                cmd.Parameters.Add("points", MySqlDbType.Int32).Value = points;

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    Discount d = new Discount();
                    if (reader.GetInt32("State") == 0) continue;
                    d.ProductId = reader.GetInt32("Product_IdProduct");
                    d.Factor = reader.GetDouble("Factor");
                    d.ClientPointsRequired = reader.GetInt32("ClientPointsRequired");
                    discounts.Add(d);
                }
                con.Close();
            }
            return discounts;
        }
    }
}
