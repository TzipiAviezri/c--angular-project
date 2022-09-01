using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.function;

namespace BLL
{
    public class ShoppingDoing
    {
        public static async Task doShopig(short customerId, ShoppingCartEntities shopCart)
        {
            List<ShoppingDetailsEntities> n = new List<ShoppingDetailsEntities>();
            shopCart.itemsCart.ForEach(x => {
                n.Add(new ShoppingDetailsEntities()
                {
                    idProduct = x.idProduct,
                    amount = x.amount,
                    idShopping = ++ShoppingEntities.indexShop
                });
            });

            ShoppingEntities s = new ShoppingEntities()
            {
                CustomerId = customerId,
                date = DateTime.Today,
                sum = shopCart.sum,
                shopingDetails = n
            };
            await ShoppingFunction.Add(s);





            ShoppingDetailsEntities sc = new ShoppingDetailsEntities() {
            };

        }
    }
}
