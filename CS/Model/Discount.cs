using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Discount
    {
        private int clientPointsRequired;
        private string description;
        private int productId;
        private double factor;

        public Discount(int points, string description, int productId, double factor)
        {
            this.clientPointsRequired = points;
            this.description = description;
            this.productId = productId;
            this.factor = factor;
        }

        public int ClientPointsRequired { get => clientPointsRequired; set => clientPointsRequired = value; }
        public string Description { get => description; set => description = value; }
        public int ProductId { get => productId; set => productId = value; }
        public double Factor { get => factor; set => factor = value; }

    }
}
