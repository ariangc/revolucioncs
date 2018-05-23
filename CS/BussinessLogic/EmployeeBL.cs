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
        private EmployeeDA employeeDataAccess;
        public EmployeeBL()
        {
            employeeDataAccess = new EmployeeDA();
        }

        public bool passwordVerify(string username, string passwordRecieve)
        {
            string passwordBD = employeeDataAccess.returnPassword(username);
            return passwordRecieve.Equals(passwordBD);
        }

        public string getEmployeeName(string dni) {
            return employeeDataAccess.getEmployeeName(dni);
        }
    }
}
