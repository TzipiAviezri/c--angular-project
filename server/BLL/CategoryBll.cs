using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.function;


namespace BLL
{
    public class CategoryBll
    {

        public static List<CategoryEntities> GetAll() =>  CategoryFunction.SelectAll();
        public static CategoryEntities GetById(int id) => CategoryFunction.SelectById(id);
        public static async Task Add(CategoryEntities c) => await CategoryFunction.Add(c);
        public static async Task Edit(CategoryEntities c) => await CategoryFunction.Edit(c); 
        public static async Task DeleteById(int id) => await CategoryFunction.DeleteById(id);


    }
}
