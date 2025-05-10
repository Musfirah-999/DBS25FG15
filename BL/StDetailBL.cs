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
    internal class StDetailBL
    {
        private StDetailDL dal = new StDetailDL();

        public int AddRequestDetail(StDetail detail)
        {
            return dal.AddStockRequestDetail(detail);
        }

        public DataTable GetRequestDetails(int requestId)
        {
            return dal.GetDetailsByRequestId(requestId);
        }

        public int DeleteRequestDetail(int detailId)
        {
            return dal.DeleteRequestDetail(detailId);
        }

        public DataTable GetAllRequestIDs()
        {
            return dal.GetRequestIDs();
        }

        public DataTable GetAllMedicines()
        {
            return dal.GetMedicines();
        }
    }
}
