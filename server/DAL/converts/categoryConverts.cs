using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace DAL.converts
{
   public class CategoryConverts
    {
        public static CategoryEntities ConvertToEntities(category c)
        {
            CategoryEntities nc = new CategoryEntities()
            {
                id = c.id,
                name = c.nameCategory,  
            };
            return nc;
        }
        public static category ConvertToDB(CategoryEntities c)
        {
            category nc = new category()
            {    id = c.id,
                nameCategory=c.name,
                
            };
            return nc;
        }


        public static List<CategoryEntities> ConvertListToEntities(List<category> ListCategory)
        {
            List<CategoryEntities> categoryList = new List<CategoryEntities>();
            ListCategory.ForEach(c =>
            {
                categoryList.Add(ConvertToEntities(c));
            });
            return categoryList;
        }
        public static List<category> ConvertListToDB(List<CategoryEntities> ListCategory)
        {
            List<category> categoryList = new List<category>();
            ListCategory.ForEach(c=>
            {
                categoryList.Add(CategoryConverts.ConvertToDB(c));
            });
            return categoryList;
        }
    }
}
