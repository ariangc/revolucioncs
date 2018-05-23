using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class EmployeeBL
    {
        private string passwordRecieve;
        private EmployeeDA employeeDataAccess;
        public EmployeeBL()
        {
            employeeDataAccess = new EmployeeDA();
        }

        public bool passwordVerify(string passwordRecieve)
        {
            string passwordBD = employeeDataAccess.returnPassword();
            return passwordRecieve.Equals(passwordBD);
        }
    }
}
