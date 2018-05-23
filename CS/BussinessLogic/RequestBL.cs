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

        public void newRequest(Request r)
        {
            dataAccess.newRequest(r);
        }
    }
}
