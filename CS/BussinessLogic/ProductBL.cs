using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace BussinessLogic {
    public class ProductBL {
        private ProductDA dataAccess;

        public ProductBL() {
            dataAccess = new ProductDA();
        }

        public BindingList<Product> listProducts() {
            return dataAccess.listProducts();
        }
    }
}
