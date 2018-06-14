using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class NaturalClient : Person {
        private string name;
        private string surname;
        private string dni;
        private int points;

        public NaturalClient() : base() { }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Points { get => points; set => points = value; }
    }
}
