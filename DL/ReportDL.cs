using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_finalproject.DL
{
    class ReportDL
    {
        public static DataTable GetReport()
        {
            string query = @"
               SELECT S.name , S.contact , R.request_date , D.requested_quantity ,R.status
               from suppliers S
               join stock_request R
               On S.supplier_id = R.supplier_id
               join stock_request_details D
               On R.request_id = D.request_id";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }
    }
}

