using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductsEntities
    {
        public short id { get; set; }
        public string prodName { get; set; }
        public short idCategory { get; set; }
        public string nameCategory { get; set; }
        public short price { get; set; }
        public string img { get; set; }
        public string color { get; set; }
        public short amount { get; set; }
       
    }
}
