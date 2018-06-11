using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Enumerators;

namespace Model
{
	public abstract class Transaction {
		private List<Product> product;
		private DateTime transactionDate;
		private List<int> productQuantity;

        //Constructor, getters y setters

        public Transaction() {
            this.product = null;
            this.productQuantity = null;
        }

		public Transaction(List<Product> product, DateTime transactionDate, List<int> productQuantity){
			this.Product = null;
			this.transactionDate = transactionDate;
			this.ProductQuantity = null;
		}

		public DateTime TransactionDate {
			set {
				transactionDate = value;
			}
			get {
				return transactionDate;
			}
		}

        public List<int> ProductQuantity { get => productQuantity; set => productQuantity = value; }
        public List<Product> Product { get => product; set => product = value; }

        
	}
}
