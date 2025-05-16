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
    internal class POBL
    {
        private PODL dal = new PODL();

        public bool AddOrder(PO po)
        {
            if (po.SupplierId == 0 || po.RequestId == 0)
                throw new System.Exception("Supplier and Request must be selected.");

            return dal.AddOrder(po);
        }

        public bool DeleteOrder(int orderId) => dal.DeleteOrder(orderId);

        public DataTable GetOrders() => dal.GetOrders();

        public DataTable GetSuppliers() => dal.GetSuppliers();

        public DataTable GetRequests() => dal.GetRequests();
    }


}
