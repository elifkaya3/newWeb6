using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleriApp.Data.Abstract;
using YemekTarifleriApp.Entity;

namespace YemekTarifleriApp.Data.Concrete.EFCore
{
    public class EFCoreCategoryRepository : EFCoreGenericRepository<Category, RecipeAppContext>, ICategoryRepository
    {
        public List<Category> GetRecipesByCategory(string name)
        {
            //içine yapmak istediğim metodlar yazılacak.
            throw new NotImplementedException();
        }
    }
}
