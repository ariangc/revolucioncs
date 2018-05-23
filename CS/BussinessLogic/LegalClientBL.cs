using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace BussinessLogic {
    public class LegalClientBL {
        private LegalClientDA dataAccess;

        public LegalClientBL() {
            dataAccess = new LegalClientDA();
        }

        public int searchLegalClient(string ruc) {
            return dataAccess.searchLegalClient(ruc);
        }

        public void addLegalClient(LegalClient lc)
        {
            dataAccess.addLegalClient(lc);
        }
    }
}
