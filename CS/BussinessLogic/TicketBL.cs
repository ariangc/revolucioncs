using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;

namespace BussinessLogic {
    public class TicketBL {
        private TicketDA dataAccess;

        public TicketBL() {
            dataAccess = new TicketDA();
        }

        public void addTicket(Ticket t) {
            dataAccess.addTicket(t);
        }
    }
}
