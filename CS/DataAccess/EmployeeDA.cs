using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeDA
    {
        public EmployeeDA()
        {

        }

        public string returnPassword()
        {
            string cadena = "Server=quilla.lab.inf.pucp.edu.pe;" + "User=inf282g3; database=inf282g3;" +
                "port=3306; password=H9u1oC; SslMode=none;" + "";
            
            return "1";
        }
    }
}
