using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.function;

namespace BLL
{
    public class CustomerBll
    {
        public static List<CustomersEntities> GetAll() => CustomersFunction.SelectAll();
        public static CustomersEntities GetById(int id) => CustomersFunction.SelectById(id);
        public static async Task Add(CustomersEntities c) => await CustomersFunction.Add(c);
        public static async Task Edit(CustomersEntities c) => await CustomersFunction.Edit(c);
        public static async Task DeleteById(int id) => await CustomersFunction.DeleteById(id);

        public static CustomersEntities CheckIfExist(string name, short pin) =>
             CustomersFunction.SelectAll().Find(x => x.name ==name && x.pin == pin);
    }
}
