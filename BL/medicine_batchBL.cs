using DB_finalproject.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DB_finalproject.DL;
using DB_finalproject.Models;
using System.Threading.Tasks;

namespace DB_finalproject.BL
{
    class medicine_batchBL
    {
        public DataTable GetAllBatchesTable()
        {
            return Medicine_batchDL.GetAllBatches();
        }

        public Dictionary<string, int> GetMedicineMap()
        {
            return Medicine_batchDL.GetMedicineIdMap();
        }

        public void AddToDB(string batchNumber, DateTime expiry, int medicineId, int quantity)
        {
            var batch = new Medicine_batch
            {
                BatchNumber = batchNumber,
                ExpiryDate = expiry,
                MedicineId = medicineId,
                Quantity = quantity
            };
            Medicine_batchDL.InsertBatch(batch);
        }

        public void UpdateBatch(int batchId, string batchNumber, DateTime expiry, int medicineId, int quantity)
        {
            var batch = new Medicine_batch
            {
                BatchId = batchId,
                BatchNumber = batchNumber,
                ExpiryDate = expiry,
                MedicineId = medicineId,
                Quantity = quantity
            };
            Medicine_batchDL.UpdateBatch(batch);
        }

        public void DeleteBatch(int batchId)
        {
            Medicine_batchDL.DeleteBatch(batchId);
        }
    }
}

