using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Enumerators;

namespace Model
{
    public class Employee
    {
        private string email;
        private string password;
        private string fullName;
        private int id;
        private int phoneNumber;
        private UserType type; 
        private bool changePassword;

        public Employee() { }

        public Employee(string email, string password, string fullName, int id, int phoneNumber, UserType type, bool changePassword)
        {
            this.email = email;
            this.password = password;
            this.fullName = fullName;
            this.id = id;
            this.phoneNumber = phoneNumber;
            this.type = type;
            this.changePassword = changePassword;
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
        public UserType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public bool ChangePassword
        {
            get { return this.changePassword; }
            set { this.changePassword = value; }
        }

        //metodos

    }
}
