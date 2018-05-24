using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class RequestBL
    {
        private RequestDA dataAccess;
        public RequestBL()
        {
            dataAccess = new RequestDA();
        }

        public BindingList<Request> listRequests()
        {
            return dataAccess.listRequests();
        }

        public int returnIdUser(string us)
        {
            return dataAccess.returnIdUser(us);
        }

        public void newRequest(Request r)
        {
            dataAccess.newRequest(r);
        }

        public void deleteRequest(Request r)
        {
            dataAccess.deleteRequest(r);
        }

        public void modifyRequest(Request r)
        {
            dataAccess.modifyRequest(r);
        }
    }
}
