using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.converts;

namespace DAL.function
{
    public class CustomersFunction
    {
        public static List<CustomersEntities> SelectAll()
        {
            
            finalAngularDbEntities db = new finalAngularDbEntities();
            return CustomersConvert.ConvertListToEntities(db.customer.ToList());
        }

        public static CustomersEntities SelectById(int id)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            return CustomersConvert.ConvertToEntities(db.customer.FirstOrDefault(c => c.cusId == id));
        }

        public static async Task Add(CustomersEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.customer.Add(CustomersConvert.ConvertToDB(c));
            await db.SaveChangesAsync();
        }
        public static async Task Delete(CustomersEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.customer.Remove(CustomersConvert.ConvertToDB(c));
            await db.SaveChangesAsync();
        }
        public static async Task DeleteById(int id)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.customer.Remove(db.customer.First(c => c.cusId == id));
            await db.SaveChangesAsync();
        }
        public static async Task Edit(CustomersEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            customer nc = db.customer.First(tc => tc.cusId == c.id);
            if (nc != null)
            {
                db.customer.Remove(nc);
                db.customer.Add(CustomersConvert.ConvertToDB(c));
                await db.SaveChangesAsync();
            }
        }
    }
}
