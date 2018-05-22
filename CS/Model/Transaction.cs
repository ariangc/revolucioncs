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
		private DateTime expirationDate;

        //Constructor, getters y setters
		public Transaction(List<Product> product, DateTime transactionDate, List<int> productQuantity, DateTime expirationDate){
			this.Product = null;
			this.transactionDate = transactionDate;
			this.ProductQuantity = null;
			this.expirationDate = expirationDate;
		}

		public DateTime TransactionDate {
			set {
				transactionDate = value;
			}
			get {
				return transactionDate;
			}
		}

		public DateTime ExpirationDate {
			set {
				expirationDate = value;
			}
			get {
				return expirationDate;
			}
		}

        public List<int> ProductQuantity { get => productQuantity; set => productQuantity = value; }
        public List<Product> Product { get => product; set => product = value; }

        
	}
}
