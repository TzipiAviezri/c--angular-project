using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL.converts
{
    public class productsConverts
    {
        public static ProductsEntities ConvertToEntities(products p)
        {
            ProductsEntities np = new ProductsEntities()
            {            
               prodName = p.productName,
               idCategory = (short)p.idCategory,
              color = p.color,
              amount = (short)p.amount,
              img = p.img,
              price = (short)p.price
            };
            if (p.productId != null)
                np.id = p.productId;
            return np;
        }
        public static products ConvertToDB(ProductsEntities p)
        {
            products np = new products()
            {
                 productId= p.id,
                 productName = p.prodName,
                 idCategory = p.idCategory,
                 color = p.color,
                 amount = p.amount,
                 img = p.img,
                 price = p.price

            };
            return np;
        }


        public static List<ProductsEntities> ConvertListToEntities(List<products> listProduct)
        {
            List<ProductsEntities> productList = new List<ProductsEntities>();
            listProduct.ForEach(p =>
            {
                productList.Add(ConvertToEntities(p));
            });
            return productList;
        }

        public static List<products> ConvertListToDB(List<ProductsEntities> listProduct)
        {
            List<products> productList = new List<products>();
            listProduct.ForEach(p =>
            {
                productList.Add(ConvertToDB(p));
            });
            return productList;
        }
    }
}
