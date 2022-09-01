using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace DAL.converts
{
   public class SoppingConvert
    {
        public static ShoppingEntities ConvertToEntities(shoping s)
        {  
            ShoppingEntities ns = new ShoppingEntities()
            {
                id = s.shopingId,
                CustomerId = (short)s.customerId,
                date = (DateTime)s.shopingDate,
                sum = (short)s.shopingSum,
                shopingDetails = ShoppingDetailsConvert.ConvertListToEntities(s.details.ToList())
            };
            return ns;
        }
        public static shoping ConvertToDB(ShoppingEntities s)
        {
            shoping ns = new shoping()
            {
                shopingId = s.id,
                customerId=s.CustomerId,
                shopingDate=s.date,
                shopingSum=s.sum
               // details = ShoppingDetailsConvert.ConvertListToDB(s.shopingDetails)
            };
            return ns;
        }


        public static List<ShoppingEntities> ConvertListToEntities(List<shoping> ListShopping)
        {
            List<ShoppingEntities> ShoppingList = new List<ShoppingEntities>();
            ListShopping.ForEach(s =>
            {
                ShoppingList.Add(ConvertToEntities(s));
            });
            return ShoppingList;
        }
        public static List<shoping> ConvertListToDB(List<ShoppingEntities> ListShopping)
        {
            List<shoping> ShoppingList = new List<shoping>();
            ListShopping.ForEach(s =>
            {
                ShoppingList.Add(ConvertToDB(s));
            });
            return ShoppingList;
        }
    }
}
