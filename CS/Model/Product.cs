using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Product
    {
        private int id;
        private string name;
        private List<string> components = new List<string>();
        private double price;
        private bool needsPrescription;
        private double utility;
        private int points;
        private int totalItems;

        public Product() { }

        //constructor con lista de componentes
        public Product(int id, string name, List<string> components, double price, bool needsPrescription, double utility, int points)
        {
            this.id = id;
            this.name = name;
            this.components = components;
            this.price = price;
            this.needsPrescription = needsPrescription;
            this.utility = utility;
            this.points = points;
            this.totalItems = 0;
        }
        //constructor sin lista de componentes
        public Product(int id, string name, double price, bool needsPrescription, double utility, int points)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.needsPrescription = needsPrescription;
            this.utility = utility;
            this.points = points;
        }

        //getters y setters
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public bool NeedsPrescription
        {
            get { return this.needsPrescription; }
            set { this.needsPrescription = value; }
        }
        public double Utility
        {
            get { return this.utility; }
            set { this.utility = value; }
        }
        public int Points
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public int TotalItems { get => totalItems; set => totalItems = value; }

        //Métodos
        public void addComponent(string componentName)
        {
            this.components.Add(componentName);
        }

        public void addComponent(List<string> componentNames) {
            foreach (string x in componentNames) {
                this.components.Add(x);
            }
        }
    }
}
