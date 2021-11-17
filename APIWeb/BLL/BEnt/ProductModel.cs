using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Quantity { get; set; }

    }
}
