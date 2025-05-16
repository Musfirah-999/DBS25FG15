using DB_finalproject.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DB_finalproject.DL;
using DB_finalproject.Models;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_finalproject.BL
{
    class medicine_batchBL
    {
        private readonly Medicine_batchDL dal = new Medicine_batchDL();

        public bool AddBatch(Medicine_batch batch)
        {
            Validate(batch);
         
            return dal.Add(batch);
        }

        public bool UpdateBatch(Medicine_batch batch)
        {
            Validate(batch);
            return dal.Update(batch);
        }

        public bool DeleteBatch(int batchId)
        {
            return dal.Delete(batchId);
        }

        public DataTable GetAllBatches()
        {
            return dal.GetAll();
        }

        public DataTable GetMedicineList()
        {
            return dal.GetMedicines();
        }

        private void Validate(Medicine_batch batch)
        {
            if (string.IsNullOrWhiteSpace(batch.BatchNumber))
                throw new Exception("Batch Number is required.");
            if (batch.Quantity <= 0)
                throw new Exception("Quantity must be greater than 0.");
        }
    }
}

