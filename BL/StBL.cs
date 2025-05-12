using DB_finalproject.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_finalproject.DL;
using DB_finalproject.Models;

namespace DB_finalproject.BL
{
    internal class StBL
    {
        private StDL dal = new StDL();

        public int AddRequest(ST request)
        {
            return dal.AddStockRequest(request);
        }

        public DataTable GetRequests()
        {
            return dal.GetAllStockRequests();
        }

        public int DeleteRequest(int requestId)
        {
            return dal.DeleteStockRequest(requestId);
        }
    }
}
