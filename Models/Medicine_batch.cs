using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_finalproject.Models
{
    class Medicine_batch
    {
        public int BatchId { get; set; }
        public string BatchNumber { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int MedicineId { get; set; }
    }
}
