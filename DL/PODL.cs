using DB_finalproject.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_finalproject.DL
{
    internal class PODL
    {


        private readonly DatabaseHelper db = DatabaseHelper.Instance;

        public bool AddOrder(PO po)
        {
            string query = "INSERT INTO purchase_order (supplier_id, request_id, date_issued) VALUES (@sup, @req, @date)";
            using (var con = db.getConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@sup", po.SupplierId);
                    cmd.Parameters.AddWithValue("@req", po.RequestId);
                    cmd.Parameters.AddWithValue("@date", po.DateIssued);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteOrder(int orderId)
        {
            string query = "DELETE FROM purchase_order WHERE order_id = @id";
            using (var con = db.getConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", orderId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable GetOrders()
        {
            string query = "SELECT order_id, supplier_id, request_id, date_issued FROM purchase_order";
            return db.GetDataTable(query);
        }

        public DataTable GetSuppliers()
        {
            return db.GetDataTable("SELECT supplier_id, name FROM suppliers");
        }

        public DataTable GetRequests()
        {
            return db.GetDataTable("SELECT request_id FROM stock_request WHERE status = 'Approved'");
        }
    }
 }

