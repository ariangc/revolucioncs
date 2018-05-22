using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Enumerators;

namespace Model{
	public class Sale : Transaction{
		
		public Sale(List<Product> product, DateTime transactionDate, List<int> productQuantity, DateTime expirationDate): base(product, transactionDate, productQuantity, expirationDate){
		}
		public void consultSimilarProducts(){

		}

		public void consultDiscounts(){

		}

		private void lowStockWarning(){

		}

		private void needPrescriptionWarning(){

		}
	}
}
