using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using DataAccess;
using Model;
using System.ComponentModel;

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

        public void updateNaturalClient(NaturalClient nc)
        {
            dataAccess.updateNaturalClient(nc);
        }

        public BindingList<NaturalClient> listNaturalClients(string dni, string name, string surname)
        {
            return dataAccess.listNaturalClients(dni, name, surname);
        }
        
    }
}
