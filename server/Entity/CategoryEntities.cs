using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class CategoryEntities
    {
        public short id { get; set; }
        public string name { get; set; }
        public List<ProductsEntities>  products { get; set; }
    }
}
