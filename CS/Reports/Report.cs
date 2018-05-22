using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports {
    public class Report {
        private DateTime initialDate;
        private DateTime finalDate;

        public Report(DateTime initialDate, DateTime finalDate) {
            this.initialDate = initialDate;
            this.finalDate = finalDate;
        }

        public DateTime InitialDate {
            get {
                return initialDate;
            }
            set {
                initialDate = value;
            }
        }

        public DateTime FinalDate {
            get {
                return finalDate;
            }
            set {
                finalDate = value;
            }
        }

        public void createReport() {

        }

        public void exportToExcel() {

        }
    }
}