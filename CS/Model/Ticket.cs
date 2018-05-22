using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket : Transaction
    {
        private int id;
        private double igv;
        private List<Double> subtotal;
        private double total;
        private int points;

        //Constructor, getters y setters
        public Ticket(List<Product> product, DateTime transactionDate, List<int> productQuantity, DateTime expirationDate, int id, double igv, List<double> subtotal, double total, int points) : base(product, transactionDate, productQuantity, expirationDate)
        {
            this.Id = id;
            this.Igv = igv;
            this.Subtotal = null;
            this.Total = total;
            this.Points = points;
        }


        public int Id { get => id; set => id = value; }
        public double Igv { get => igv; set => igv = value; }
        public List<double> Subtotal { get => subtotal; set => subtotal = value; }
        public double Total { get => total; set => total = value; }
        public int Points { get => points; set => points = value; }
        
    }
}
