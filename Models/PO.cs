using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_finalproject.Models
{
    internal class PO
    {
        public int OrderId { get; set; }
        public int SupplierId { get; set; }
        public int RequestId { get; set; }
        public DateTime DateIssued { get; set; }
    }
}
