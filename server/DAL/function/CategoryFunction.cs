using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.converts;

namespace DAL.function
{
    public class CategoryFunction
    {
        public static List<CategoryEntities> SelectAll()
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            return CategoryConverts.ConvertListToEntities(db.category.ToList());
        }

        public static CategoryEntities SelectById(int id)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            return CategoryConverts.ConvertToEntities(db.category.FirstOrDefault(c => c.id == id));
        }

        public static async Task Add(CategoryEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.category.Add(CategoryConverts.ConvertToDB(c));
            await db.SaveChangesAsync();
        }
        public static async Task Delete(CategoryEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.category.Remove(CategoryConverts.ConvertToDB(c));
            await db.SaveChangesAsync();
        }
        public static async Task DeleteById(int id)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.category.Remove(db.category.First(c => c.id == id));
            await db.SaveChangesAsync();
        }
        public static async Task Edit(CategoryEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            category nc = db.category.First(tc => tc.id == c.id);
            if (nc != null)
            {
                db.category.Remove(nc);
                db.category.Add(CategoryConverts.ConvertToDB(c));
                await db.SaveChangesAsync();
            }
        }
    }
}
