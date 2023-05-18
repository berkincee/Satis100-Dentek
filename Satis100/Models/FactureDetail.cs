using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satis100.Models
{
    public class FactureDetail
    {
        public int Id { get; set; }
        public int TotalCost { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerPhone { get; set; }

        public DateTime Date { get; set; }
    }
}
