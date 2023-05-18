using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satis100.Models
{
    public class GridView
    {
        public string MakeName { get; set; }
        public string ModelName { get; set; }
        public int Cost { get; set; }
        public string CustomerName { get; set; }

        public Make Make { get; set; }

        public Model Model { get; set; }

        public Customer Customer { get; set; }
}
}
