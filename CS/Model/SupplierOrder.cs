using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Enumerators;

namespace Model
{
	public class SupplierOrder : Transaction{
		private Supplier mySupplier;
		private int quantity;
		private int boxSize;

		public SupplierOrder(List<Product> product, DateTime transactionDate, List<int> productQuantity, DateTime expirationDate, Supplier mySupplier, int quantity, int boxSize): base(product, transactionDate, productQuantity){
			this.mySupplier = mySupplier;
			this.quantity = quantity;
			this.boxSize = boxSize;
		}

		public Supplier MySupplier {
			set {
				mySupplier = value;
			}
			get {
				return mySupplier;
			}
		}

		public int Quantity
        {
			set {
                quantity = value;
			}
			get {
				return quantity;
			}
		}

		public int BoxSize {
			set {
				boxSize = value;
			}
			get {
				return boxSize;
			}
		}

		private void maxStockWarning(){

		}
	}
}
