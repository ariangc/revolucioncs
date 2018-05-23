using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;
using Utils;

namespace DataAccess {
    public class ProductDA {
        public BindingList<Product> listProducts() {
            BindingList<Product> list = new BindingList<Product>();
            MySqlConnection con = new MySqlConnection(Constants.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "queryProductsTEST";

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                Product p = new Product();
                p.Id = reader.GetInt32("IdProduct");
                p.Name = reader.GetString("Name");
                p.Price = reader.GetDouble("Price");
                p.NeedsPrescription = (reader.GetInt32("NeedsPrescription") == 1);
                p.Utility = reader.GetDouble("Utility");
                p.Points = reader.GetInt32("Points");
                p.TotalItems = reader.GetInt32("TotalItems");
                Console.WriteLine(p.Id + " " + p.Name + " " + p.Price + " " + p.NeedsPrescription);
                list.Add(p);
            }
            con.Close();
            return list;
        }
    }
}
