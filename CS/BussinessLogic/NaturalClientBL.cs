using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using DataAccess;
using Model;

namespace BussinessLogic {
    public class NaturalClientBL {
        private NaturalClientDA dataAccess;

        public NaturalClientBL() {
            dataAccess = new NaturalClientDA();
        }

        public int searchNaturalClient(string dni) {
            return dataAccess.searchNaturalClient(dni);
        }

        public void addNaturalClient(NaturalClient nc)
        {
            dataAccess.addNaturalClient(nc);
        }
        
    }
}
