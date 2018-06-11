using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
            try
            {
                string passwordBD = dataAccess.returnPassword(username);
                return passwordRecieve.Equals(passwordBD);
            }
            catch (MySqlException e)
            {
                return false;
            }
        }

        public Employee getEmployee(string dni) {
            return dataAccess.getEmployee(dni);
        }

        public void changePassword(string pass)
        {
            dataAccess.changePassword(pass);
        }
    }
}
