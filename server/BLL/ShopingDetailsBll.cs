using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.function;

namespace BLL
{
    class ShoppingDetailsBll
    {
        public static List<ShoppingDetailsEntities> GetAll() => ShoppingDetailsFunction.SelectAll();
        public static ShoppingDetailsEntities GetById(int id) => ShoppingDetailsFunction.SelectById(id);
        public static async Task Add(ShoppingDetailsEntities c) => await ShoppingDetailsFunction.Add(c);
        public static async Task Edit(ShoppingDetailsEntities c) => await ShoppingDetailsFunction.Edit(c);
        public static async Task DeleteById(int id) => await ShoppingDetailsFunction.DeleteById(id);
    }
}
