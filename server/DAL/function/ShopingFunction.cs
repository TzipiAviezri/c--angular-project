using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.converts;

namespace DAL.function
{
    public class ShoppingFunction
    {
        
        public static List<ShoppingEntities> SelectAll()
        {

            finalAngularDbEntities db = new finalAngularDbEntities();
            return SoppingConvert.ConvertListToEntities(db.shoping.ToList());
        }

        public static ShoppingEntities SelectById(int id)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            return SoppingConvert.ConvertToEntities(db.shoping.FirstOrDefault(c => c.shopingId == id));
        }

        public static async Task Add(ShoppingEntities c)
        {
            try
            {
                finalAngularDbEntities db = new finalAngularDbEntities();
                shoping s = SoppingConvert.ConvertToDB(c);
                db.shoping.Add(s);
                await db.SaveChangesAsync();
                foreach (var x in c.shopingDetails)
                {
                    x.idShopping = s.shopingId;
                    details xs = converts.ShoppingDetailsConvert.ConvertToDB(x);
                    db.details.Add(xs);
                }

                await db.SaveChangesAsync();
            }
            catch(Exception e)
            {

            }

        }
        public static async Task Delete(ShoppingEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.shoping.Remove(SoppingConvert.ConvertToDB(c));
            await db.SaveChangesAsync();
        }
        public static async Task DeleteById(int id)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.shoping.Remove(db.shoping.First(c => c.shopingId == id));
            await db.SaveChangesAsync();
        }
        public static async Task Edit(ShoppingEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            shoping nc = db.shoping.First(tc => tc.shopingId == c.id);
            if (nc != null)
            {
                db.shoping.Remove(nc);
                db.shoping.Add(SoppingConvert.ConvertToDB(c));
                await db.SaveChangesAsync();
            }
        }
    }
}
