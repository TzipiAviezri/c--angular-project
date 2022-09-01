using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ShoppingEntities
    {
        public static short indexShop = 0;
        public short id { get; set; }
        public short CustomerId { get; set; }
        public DateTime date { get; set; }
        public short sum { get; set; }
        public List<ShoppingDetailsEntities> shopingDetails { get; set; }
        
    }
}
