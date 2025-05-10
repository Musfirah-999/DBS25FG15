using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_finalproject.Models
{
    internal class ST
    {
        public int RequestId { get; set; }
        public int PharmacistId { get; set; }
        public int SupplierId { get; set; }
        public DateTime RequestDate { get; set; }
        public string Status { get; set; } = "Pending";
        public int MedicineId { get; internal set; }
        public int RequestedQuantity { get; internal set; }
    }
}
