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
    internal class PODetailsDL
    {
        private readonly DatabaseHelper db = DatabaseHelper.Instance;

        public bool AddDetail(PODetails detail)
        {
            string query = "INSERT INTO purchase_order_details (order_id, quantity, total_amount) VALUES (@oid, @qty, @amt)";
            using (var con = db.getConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@oid", detail.OrderId);
                    cmd.Parameters.AddWithValue("@qty", detail.Quantity);
                    cmd.Parameters.AddWithValue("@amt", detail.TotalAmount);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteDetail(int detailId)
        {
            string query = "DELETE FROM purchase_order_details WHERE detail_id = @id";
            using (var con = db.getConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", detailId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable GetDetailsByOrderId(int orderId)
        {
            string query = "SELECT detail_id, order_id, quantity, total_amount FROM purchase_order_details WHERE order_id = @oid";
            using (var con = db.getConnection())
            {
                con.Open();
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@oid", orderId);
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetAllDetails()
        {
            string query = "SELECT detail_id, order_id, quantity, total_amount FROM purchase_order_details";
            return db.GetDataTable(query);
        }
    }

    internal class PODetails
    {
        public int DetailId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
    }




}

