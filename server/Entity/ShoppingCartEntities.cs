using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ShoppingCartEntities
    {
        public List<ItemCartEntities> itemsCart { get; set; }
        public short sum { get; set; }
    }
}
