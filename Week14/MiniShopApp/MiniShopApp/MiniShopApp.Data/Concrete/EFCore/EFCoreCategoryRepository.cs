using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EFCore
{
    public class EFCoreCategoryRepository : EFCoreGenericRepository<Category, MiniShopContext>, ICategoryRepository
    {
        //Burada yazmasa da EFCoreGenericRepository içindeki 5 CRUD işlemlerimiz var
        public List<Category> GetProductsByCategory(string name)
        {
            throw new NotImplementedException();
        }
    }
}
