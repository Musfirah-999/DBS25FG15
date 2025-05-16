using DB_finalproject.DL;
using DB_finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_finalproject.BL
{
    public class PODetailBL
    {
        private PODetailsDL dal = new PODetailsDL();

      

        public bool DeleteDetail(int detailId) => dal.DeleteDetail(detailId);

        public DataTable GetDetailsByOrderId(int orderId) => dal.GetDetailsByOrderId(orderId);

        public DataTable GetAllDetails() => dal.GetAllDetails();

        internal bool AddDetail(Models.PODetails detail)
        {
            throw new NotImplementedException();
        }
    }
}
