using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.function;

namespace BLL
{
   public class ShoppingBll
    {
        public static List<ShoppingEntities> GetAll() => ShoppingFunction.SelectAll();
        public static ShoppingEntities GetById(int id) => ShoppingFunction.SelectById(id);
        public static async Task Add(ShoppingEntities c) => await ShoppingFunction.Add(c);
        public static async Task Edit(ShoppingEntities c) => await ShoppingFunction.Edit(c);
        public static async Task DeleteById(int id) => await ShoppingFunction.DeleteById(id);
    }
}
