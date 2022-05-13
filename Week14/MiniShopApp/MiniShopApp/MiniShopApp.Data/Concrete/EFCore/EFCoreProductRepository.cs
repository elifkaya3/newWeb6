using Microsoft.EntityFrameworkCore;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EFCore
{
    public class EFCoreProductRepository : EFCoreGenericRepository<Product, MiniShopContext>, IProductRepository
    {
        public List<Product> GetHomePageProduct()
        {
            using (var context= new MiniShopContext())
            {
                return context
                    .Products
                    .Where(i => i.IsApproved && i.IsHome)
                    .ToList();
            }
        }

        private string ConvertLower(string text)
        {
            text = text.ToLower();
            text = text.Replace("ç", "c");
            text = text.Replace("ı", "i");
            text = text.Replace("ü", "u");
            text = text.Replace("ş", "s");
            text = text.Replace("ö", "o");
            text = text.Replace("ğ", "g");



            return text;
        }
        public List<Product> GetSearchResult(string searchString)
        {
            searchString = ConvertLower(searchString);

            //burada metodun döndürdüğü değer string.ama biz linq sorgularıyla çalışırken işimize yaramaıoyr 
            //DÜZELTİLECEK
            using (var context = new MiniShopContext())
            {
                var products = context.Products
                    .Where(i => i.IsApproved && (i.Name.ToLower().Contains(searchString) || i.Description.ToLower().Contains(searchString)))
                    .ToList();

                //var products = context.Products
                //   .Where(i => i.IsApproved && (ConvertLower(i.Name).Contains(searchString) || ConvertLower(i.Description).Contains(searchString)))
                //   .ToList();
                return products;
            }

        }

        //Burada yazmasa da EFCoreGenericRepository içindeki 5 CRUD işlemlerimiz var
        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            using (var context = new MiniShopContext())
            {
                var products = context
                    .Products
                    .Where(i => i.IsApproved)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(name))
                {
                    products = products
                        .Include(i => i.ProductCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.ProductCategories.Any(a => a.Category.Url == name));
                }
                return products.Skip((page-1) *pageSize).Take(pageSize).ToList();
            }
        }

        public Product GetProductsDetails(string url)
        {
            using (var context = new MiniShopContext())
            {
                return context.Products
                     .Where(i => i.Url == url)
                     .Include(i => i.ProductCategories)
                     .ThenInclude(i => i.Category)
                     .FirstOrDefault();
                //buraya daha sonra ürünün category adını da getircek eklemeler yapacağız.
            }
        }

       
    }
}
