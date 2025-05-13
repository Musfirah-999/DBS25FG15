using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_finalproject.DL;
using DB_finalproject.Models;

namespace DB_finalproject.DL
{
    internal class StDetailDL
    {
        public int AddStockRequestDetail(StDetail detail)
        {
            string query = "INSERT INTO stock_request_details (request_id, medicine_id, requested_quantity) VALUES (@requestId, @medicineId, @requestedQuantity)";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@requestId", detail.RequestId);
                cmd.Parameters.AddWithValue("@medicineId", detail.MedicineId);
                cmd.Parameters.AddWithValue("@requestedQuantity", detail.RequestedQuantity);
                return cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetDetailsByRequestId(int requestId)
        {
            string query = $"SELECT * FROM stock_request_details WHERE request_id = {requestId}";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public int DeleteRequestDetail(int detailId)
        {
            string query = $"DELETE FROM stock_request_details WHERE detail_id = {detailId}";
            return DatabaseHelper.Instance.Update(query);
        }

        public DataTable GetRequestIDs()
        {
            string query = "SELECT request_id FROM stock_request";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public DataTable GetMedicines()
        {
            string query = "SELECT medicine_id, name FROM medicines";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}
