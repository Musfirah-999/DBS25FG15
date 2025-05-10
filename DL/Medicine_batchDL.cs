using DB_finalproject.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_finalproject.Models;
using System.Data;
using System.Windows.Forms;

namespace DB_finalproject.DL
{
    class Medicine_batchDL
    {
        public static List<string> GetMedicineList()
        {
            List<string> medicines = new List<string>();
            string query = "SELECT name FROM medicines";
            using (var reader = DatabaseHelper.Instance.GetDataReader(query))
            {
                while (reader.Read())
                {
                    medicines.Add(reader["name"].ToString());
                }
            }
            return medicines;
        }

        public static DataTable GetAllBatches()
        {
            string query = @"SELECT mb.batch_id, mb.batch_number, mb.quantity, mb.expiry_date, m.name 
                             FROM medicine_batch mb 
                             JOIN medicines m ON mb.medicine_id = m.medicine_id";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static void InsertBatch(Medicine_batch batch)
        {
            string query = $@"INSERT INTO medicine_batch (medicine_id, batch_number, quantity, expiry_date) 
                              VALUES ('{batch.MedicineId}', '{batch.BatchNumber}', '{batch.Quantity}', '{batch.ExpiryDate:yyyy-MM-dd}')";
            DatabaseHelper.Instance.Update(query);
        }

        public static void UpdateBatch(Medicine_batch batch)
        {
            string query = $@"UPDATE medicine_batch 
                              SET batch_number = '{batch.BatchNumber}', 
                                  quantity = {batch.Quantity}, 
                                  expiry_date = '{batch.ExpiryDate:yyyy-MM-dd}', 
                                  medicine_id = {batch.MedicineId}
                              WHERE batch_id = {batch.BatchId}";
            DatabaseHelper.Instance.Update(query);
        }

        public static void DeleteBatch(int batchId)
        {
            string query = $"DELETE FROM medicine_batch WHERE batch_id = {batchId}";
            DatabaseHelper.Instance.Update(query);
        }

        public static Dictionary<string, int> GetMedicineIdMap()
        {
            var map = new Dictionary<string, int>();
            string query = "SELECT medicine_id, name FROM medicines";
            using (var reader = DatabaseHelper.Instance.GetDataReader(query))
            {
                while (reader.Read())
                {
                    map[reader["name"].ToString()] = Convert.ToInt32(reader["medicine_id"]);
                }
            }
            return map;
        }
    }
}
