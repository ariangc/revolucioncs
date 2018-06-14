﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class LegalClient : Person {
        private string companyName;
        private string ruc;
        private int points;

        public LegalClient() : base() { }

        public string CompanyName { get => companyName; set => companyName = value; }
        public string RUC { get => ruc; set => ruc = value; }
        public int Points { get => points; set => points = value; }
    }
}
