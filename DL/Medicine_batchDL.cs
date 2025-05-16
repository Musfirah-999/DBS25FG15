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
        private readonly DatabaseHelper db = DatabaseHelper.Instance;

        public bool Add(Medicine_batch batch)
        {
            MessageBox.Show($"VALUES ({batch.MedicineId}, '{batch.BatchNumber}', '{batch.ExpiryDate:yyyy-MM-dd}', {batch.Quantity})");
            string query = $"INSERT INTO medicine_batch (medicine_id, batch_number, expiry_date, quantity) " +
                           $"VALUES ({batch.MedicineId}, '{batch.BatchNumber}', '{batch.ExpiryDate:yyyy-MM-dd}', '{batch.Quantity}')";

            bool output = db.Update(query) > 0;

            if (output)
            {
                return output;
            }

            // Ensure all code paths return a value
            return false;
        }

        public bool Update(Medicine_batch batch)
        {
            string query = $"UPDATE medicine_batch SET medicine_id={batch.MedicineId}, batch_number='{batch.BatchNumber}', " +
                           $"quantity={batch.Quantity}, expiry_date='{batch.ExpiryDate:yyyy-MM-dd}' " +
                           $"WHERE batch_id={batch.BatchId}";
            return db.Update(query) > 0;
        }

        public bool Delete(int batchId)
        {
            string query = $"DELETE FROM medicine_batch WHERE batch_id={batchId}";
            return db.Update(query) > 0;
        }

        public DataTable GetAll()
        {
            return db.GetDataTable("SELECT b.batch_id, m.name AS medicine_name, b.batch_number, b.quantity, b.expiry_date " +
                                   "FROM medicine_batch b JOIN medicines m ON b.medicine_id = m.medicine_id");
        }


        public DataTable GetMedicines()
        {
            return db.GetDataTable("SELECT medicine_id, name FROM medicines");
        }
    }
}
