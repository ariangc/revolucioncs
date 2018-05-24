using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BussinessLogic
{
    public class EmployeeBL
    {
        private EmployeeDA dataAccess;
        public EmployeeBL()
        {
            dataAccess = new EmployeeDA();
        }

        public bool passwordVerify(string username, string passwordRecieve)
        {
            string passwordBD = dataAccess.returnPassword(username);
            return passwordRecieve.Equals(passwordBD);
        }

        public string getEmployeeName(string dni) {
            return dataAccess.getEmployeeName(dni);
        }

        public void changePassword(string pass)
        {
            dataAccess.changePassword(pass);
        }
    }
}
