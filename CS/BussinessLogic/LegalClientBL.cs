﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;
using System.ComponentModel;

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

        public BindingList<LegalClient> listLegalClients(string ruc, string name)
        {
            return dataAccess.listLegalClients(ruc, name);
        }

        public void updateLegalClient(LegalClient lc)
        {
            dataAccess.updateLegalClient(lc);
        }

        public BindingList<LegalClient> searchLegalClients(string ruc, string name)
        {
            return dataAccess.searchLegalClients(ruc, name);
        }
    }
}
