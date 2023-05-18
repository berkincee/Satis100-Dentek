using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satis100.Models
{
    public class Model
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public Make Make { get; set; }

    }
}
