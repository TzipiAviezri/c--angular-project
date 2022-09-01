using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL.converts
{
   public class ShoppingDetailsConvert
    {
        public static ShoppingDetailsEntities ConvertToEntities(details d)
        {
            ShoppingDetailsEntities nd = new ShoppingDetailsEntities()
            {
                idShoppingDetails = d.detailsId,
              idProduct = (short)d.productId,
              idShopping = (short)d.shopingId,
              amount = (short)d.amount,
            };
            return nd;
        }
        public static details ConvertToDB(ShoppingDetailsEntities d)
        {
            details nd = new details()
            {
               amount = d.amount,
               shopingId = d.idShopping,
               productId = d.idProduct
            };
            return nd;
        }


        public static List<ShoppingDetailsEntities> ConvertListToEntities(List<details> listDetails)
        {
            List<ShoppingDetailsEntities> detailsList = new List<ShoppingDetailsEntities>();
            listDetails.ForEach(d =>
            {
                detailsList.Add(ConvertToEntities(d));
            });
            return detailsList;
        }

        public static List<details> ConvertListToDB(List<ShoppingDetailsEntities> listDetails)
        {
            List<details> detailsList = new List<details>();
            listDetails.ForEach(d =>
            {
                detailsList.Add(ConvertToDB(d));
            });
            return detailsList;
        }

    }
}
