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
    internal class StDL
    {
        public int AddStockRequest(ST request)
        {
            string query = "INSERT INTO stock_request (pharmacist_id, supplier_id, request_date, status) VALUES (@pharmacistId, @supplierId, @requestDate, @status); SELECT LAST_INSERT_ID();";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@pharmacistId", request.PharmacistId);
                cmd.Parameters.AddWithValue("@supplierId", request.SupplierId);
                cmd.Parameters.AddWithValue("@requestDate", request.RequestDate);
                cmd.Parameters.AddWithValue("@status", request.Status);

                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        public DataTable GetAllStockRequests()
        {
            string query = "SELECT * FROM stock_request";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public int DeleteStockRequest(int requestId)
        {
            string query = $"DELETE FROM stock_request WHERE request_id = {requestId}";
            return DatabaseHelper.Instance.Update(query);
        }
    }
}
