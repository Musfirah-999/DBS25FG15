using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_finalproject.Models
{
    internal class StDetail
    {

        public int DetailId { get; set; }
        public int RequestId { get; set; }
        public int MedicineId { get; set; }
        public int RequestedQuantity { get; set; }
    }
}

