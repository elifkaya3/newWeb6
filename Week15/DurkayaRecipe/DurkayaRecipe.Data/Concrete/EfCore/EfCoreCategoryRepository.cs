using DurkayaRecipe.Data.Abstract;
using DurkayaRecipe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurkayaRecipe.Data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, DurkayaRecipeContext>, ICategoryRepository
    {
        public Category GetByIdWithCategories(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
