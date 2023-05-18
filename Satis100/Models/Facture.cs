using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satis100.Models
{
    public class Facture
    {
        public int Id { get; set; }
        public int TotalCost { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public List<Model> Models { get; set; }
        public DateTime Date { get; set; }


    }
}
