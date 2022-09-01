using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.converts;

namespace DAL.function
{
   public class ShoppingDetailsFunction
    {
        public static List<ShoppingDetailsEntities> SelectAll()
        {

            finalAngularDbEntities db = new finalAngularDbEntities();
            return ShoppingDetailsConvert.ConvertListToEntities(db.details.ToList());
        }

        public static ShoppingDetailsEntities SelectById(int id)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            return ShoppingDetailsConvert.ConvertToEntities(db.details.FirstOrDefault(c => c.detailsId == id));
        }

        public static async Task Add(ShoppingDetailsEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.details.Add(ShoppingDetailsConvert.ConvertToDB(c));
            await db.SaveChangesAsync();
        }
        public static async Task Delete(ShoppingDetailsEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.details.Remove(ShoppingDetailsConvert.ConvertToDB(c));
            await db.SaveChangesAsync();
        }
        public static async Task DeleteById(int id)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.details.Remove(db.details.First(c => c.detailsId == id));
            await db.SaveChangesAsync();
        }
        public static async Task Edit(ShoppingDetailsEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            details nc = db.details.First(tc => tc.detailsId == c.idShoppingDetails);
            if (nc != null)
            {
                db.details.Remove(nc);
                db.details.Add(ShoppingDetailsConvert.ConvertToDB(c));
                await db.SaveChangesAsync();
            }
        }
    }
}
