using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;
using System.ComponentModel;

namespace BussinessLogic {
    public class TicketBL {
        private TicketDA dataAccess;
        private ProductDA productDA;
        private NaturalClientDA naturalClientDA;
        private LegalClientDA legalClientDA;

        public TicketBL() {
            dataAccess = new TicketDA();
            productDA = new ProductDA();
            naturalClientDA = new NaturalClientDA();
            legalClientDA = new LegalClientDA();
        }

        public void addTicket(BindingList<Product> listProducts, int idClient, int idEmployee, char clientType, bool hasDiscount) {
            List<int> productQuantity = new List<int>();
            List<double> subtotal = new List<double>();
            List<double> discFactor = new List<double>(); 
            double total = 0.0;

            if (hasDiscount) {
                // aqui debemos hacer algo con los descuentos uwu
            }

            foreach (Product p in listProducts) {
                productQuantity.Add(p.QuantitySale);
                subtotal.Add(p.QuantitySale * p.Price);
                total += p.QuantitySale * p.Price;
            }

            //Agregar ticket

            Ticket t = new Ticket(listProducts.ToList<Product>(), DateTime.Now, productQuantity, 0, 0.27, subtotal, total, (int)(total / 15), idEmployee, idClient, clientType);
            //dataAccess.addTicket(t);

            //Agregar productXTicket
            /*
            foreach (Product p in listProducts) {
                dataAccess.addProductXTicket(p, t);
                productDA.substractStock(p);
            }
            */


        }
    }
}
