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
        private DiscountDA discountDA;

        public TicketBL() {
            dataAccess = new TicketDA();
            productDA = new ProductDA();
            naturalClientDA = new NaturalClientDA();
            legalClientDA = new LegalClientDA();
            discountDA = new DiscountDA();
        }

        public void addTicket(BindingList<Product> listProducts, int idClient, int idEmployee, int clientType, Dictionary<int, double> discountFactor) { //clientType: 0->natural client; 1-> legal client
            List<int> productQuantity = new List<int>();
            List<double> subtotal = new List<double>();
            Dictionary<int, int> quantityAux = new Dictionary<int, int>();

            double total = 0.0;
            int pointsGained = 0;

            foreach (Product p in listProducts) {
                productQuantity.Add(p.QuantitySale);
            }

            foreach (Product p in listProducts) {
                double subt = p.QuantitySale * p.Price;
                if (discountFactor.ContainsKey(p.Id)) subt *= discountFactor[p.Id];
                subtotal.Add(subt);
                total += subt;
            }

            //Agregar ticket
            pointsGained = (int)(total / 15); //pointsGained
            Ticket t = new Ticket(listProducts.ToList<Product>(), DateTime.Now, productQuantity, 0, total*0.18, subtotal, total, pointsGained, idEmployee, idClient, clientType);
            t.Id = dataAccess.addTicket(t);

            //Agregar productXTicket
            foreach (Product p in listProducts) {
                dataAccess.addProductXTicket(p, t);
                productDA.substractStock(p);
            }

            //Actualizar la cantidad de puntos del cliente si es que es diferente de cero
            if (pointsGained > 0 && clientType == 0) naturalClientDA.updateNaturalClientPoints(idClient, pointsGained);
            else if (pointsGained > 0 && clientType == 1) legalClientDA.updateLegalClientPoints(idClient, pointsGained);
            if (discountFactor.ContainsKey(-1)) {
                int resPoints = (int)discountFactor[-1];
                if(clientType == 0) naturalClientDA.updateNaturalClientPoints(idClient, -1 * resPoints);
                else legalClientDA.updateLegalClientPoints(idClient, -1 * pointsGained);
            }
        }

        public Dictionary<int, double> getDiscounts(BindingList<Product> listProducts, int idClient, int clientType) {
            Dictionary<int, int> quantityAux = new Dictionary<int, int>();
            Dictionary<int, double> discountFactor = new Dictionary<int, double>();

            foreach (Product p in listProducts) {
                quantityAux.Add(p.Id, p.QuantitySale);
            }

            int points;
            if (clientType == 0) points = naturalClientDA.getPoints(idClient);
            else points = legalClientDA.getPoints(idClient);
            List<Discount> discounts = discountDA.getApplicableDiscounts(listProducts.ToList<Product>(), points);
            discounts.OrderBy(o => o.Factor).ToList();
            int resPoints = 0;
            foreach (Discount d in discounts) {
                int idProduct = d.ProductId;
                if (discountFactor.ContainsKey(idProduct)) continue;
                else {
                    int totPoints = quantityAux[idProduct] * d.ClientPointsRequired;
                    if (totPoints <= points) {
                        points -= totPoints;
                        discountFactor.Add(idProduct, d.Factor);
                        resPoints += totPoints;
                    }
                }
            }
            discountFactor.Add(-1, resPoints);
            return discountFactor;
        }
    }
}
