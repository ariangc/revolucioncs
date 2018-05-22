using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Supplier
    {
        private int id;
        private string name;
        private List<Product> products;
        private string address;
        private int phoneNumber;

        public Supplier(int id, string name, List<Product> products, string address, int phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.products = products;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        //getters y setters
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public List<Product> Products
        {
            get
            {
                return products;
            }

            set
            {
                products = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public int PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        //Métodos
    }
}
