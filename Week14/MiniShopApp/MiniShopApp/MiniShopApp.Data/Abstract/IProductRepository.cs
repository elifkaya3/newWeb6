using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        //Product'a özgü memberlarımı buraya yazabilirim.

        //ekstra kullanmka istedğim metodları ekleyebilirim 
        List<Product> GetProductsByCategory(string name);
        Product GetProductsDetails(string url);
        List<Product> GetHomePageProduct();
        List<Product> GetSearchResult(string searchString); 

    }
}
