using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bundle
    {
        private int idSupplier;
        private int idProduct;
        private string productDesc; //Product description
        private int productQuantity;
        private DateTime expirationDate;
        private int quantityBox;
        private int boxSize;
        private double subtotal;
        private DateTime registerDate;

        public Bundle() { }

        public int IdSupplier { get => idSupplier; set => idSupplier = value; }
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public string ProductDesc { get => productDesc; set => productDesc = value; }
        public int ProductQuantity { get => productQuantity; set => productQuantity = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }
        public int QuantityBox { get => quantityBox; set => quantityBox = value; }
        public int BoxSize { get => boxSize; set => boxSize = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public DateTime RegisterDate { get => registerDate; set => registerDate = value; }
    }
}
