using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.function;

namespace BLL
{
    public class ProductBll
    {
        
        public static List<ProductsEntities> GetAll() => ProductsFunction.SelectAll();
        public static ProductsEntities GetById(int id) => ProductsFunction.SelectById(id);
        public static List<ProductsEntities> GetByIdCategory(int id) => ProductsFunction.SelectAll().Where(x => x.id == id).ToList();
        public static List<ProductsEntities> GetByIdNameCategory(string n) =>
            ProductsFunction.SelectAll().Where(x => x.id == CategoryFunction.SelectAll().Find(y => y.name == n).id).ToList();
        public static async Task Add(ProductsEntities c) => await ProductsFunction.Add(c);
        public static async Task Edit(ProductsEntities c) => await ProductsFunction.Edit(c);
        public static async Task DeleteById(int id) => await ProductsFunction.DeleteById(id);
        public static async Task DecAmount(int id) => await ProductsFunction.DecAmount(id);
        public static async Task IncAmount(int id) => await ProductsFunction.IncAmount(id);
        
    }
}
