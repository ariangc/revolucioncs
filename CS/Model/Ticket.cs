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
        private int pointsGained;
        private int pointsUsed;
        private int idEmployee;
        private int idClient;
        private int clientType;

        //Constructor, getters y setters

        public Ticket(): base() {
            subtotal = new List<Double>();
        }

        public Ticket(List<Product> product, DateTime transactionDate, List<int> productQuantity, int id, double igv, List<double> subtotal, double total, int pointsGained, int idEmployee, int idClient, int clientType) : base(product, transactionDate, productQuantity)
        {
            this.Id = id;
            this.Igv = igv;
            this.Subtotal = null;
            this.Total = total;
            this.PointsGained = pointsGained;
            this.IdEmployee = idEmployee;
            this.IdClient = idClient;
            this.ClientType = clientType;
        }
        


        public int Id { get => id; set => id = value; }
        public double Igv { get => igv; set => igv = value; }
        public List<double> Subtotal { get => subtotal; set => subtotal = value; }
        public double Total { get => total; set => total = value; }
        public int PointsGained { get => pointsGained; set => pointsGained = value; }
        public int PointsUsed { get => pointsUsed; set => pointsUsed = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public int ClientType { get => clientType; set => clientType = value; }
    }
}
