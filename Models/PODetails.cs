using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_finalproject.Models
{
    public class PODetails 
    {
        public int DetailId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
