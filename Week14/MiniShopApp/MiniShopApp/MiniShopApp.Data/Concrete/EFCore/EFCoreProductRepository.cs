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
        //Burada yazmasa da EFCoreGenericRepository içindeki 5 CRUD işlemlerimiz var
        public List<Product> GetProductsByCategory(string name)
        {
            throw new NotImplementedException();
        }
    }
}
