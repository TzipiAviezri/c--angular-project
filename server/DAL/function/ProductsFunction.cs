using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.converts;

namespace DAL.function
{
    public class ProductsFunction
    {
        
        
        public static List<ProductsEntities> SelectAll()
        {

            finalAngularDbEntities db = new finalAngularDbEntities();
            return productsConverts.ConvertListToEntities(db.products.ToList());
        }

        public static ProductsEntities SelectById(int id)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            products p = db.products.FirstOrDefault(c => c.productId == id);
            if(p!=null)
            return productsConverts.ConvertToEntities(db.products.FirstOrDefault(c => c.productId == id));
            return null;

        }

        public static async Task Add(ProductsEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.products.Add(productsConverts.ConvertToDB(c));
            await db.SaveChangesAsync();
        }
        public static async Task Delete(ProductsEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.products.Remove(productsConverts.ConvertToDB(c));
            await db.SaveChangesAsync();
        }
        public static async Task DeleteById(int id)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
/*            db.products.Remove(db.products.Find(c => c.productId == id));
*/            await db.SaveChangesAsync();
        }
        public static async Task Edit(ProductsEntities c)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            products nc = db.products.First(tc => tc.productId == c.id);
            if (nc != null)
            {

                nc.productName = c.prodName;
                nc.amount = c.amount;
                nc.price = c.price;
                nc.img = c.img;
                nc.idCategory = c.idCategory;
                nc.color = c.color;

                await db.SaveChangesAsync();
            }
        }
        public static async Task IncAmount(int id)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.products.First(p => p.productId == id).amount++;
            await db.SaveChangesAsync();
        }
        public static async Task DecAmount(int id)
        {
            finalAngularDbEntities db = new finalAngularDbEntities();
            db.products.First(p => p.productId == id).amount--;
            await db.SaveChangesAsync();
        }
    }
}
