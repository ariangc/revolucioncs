using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Person {
        private int idPerson;
        private string address;
        private string phoneNumber;
        private string email;

        public Person() { }

        public int IdPerson { get => idPerson; set => idPerson = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
    }
}
