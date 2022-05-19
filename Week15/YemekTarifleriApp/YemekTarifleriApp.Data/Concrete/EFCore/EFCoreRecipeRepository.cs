using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleriApp.Data.Abstract;
using YemekTarifleriApp.Entity;

namespace YemekTarifleriApp.Data.Concrete.EFCore
{
    public class EFCoreRecipeRepository : EFCoreGenericRepository<Recipe, RecipeAppContext>, IRecipeRepository
    {
        public List<Recipe> GetRecipesByCategory(string name)
        {
            //içine yapmak istediğim metodlar yazılacak.

            throw new NotImplementedException();
        }
        //public Recipe GetRecipeDetails(string url)
        //{
        //    using (var context = new RecipeAppContext())
        //    {
        //        return context
        //            .Recipes
        //            .Where(i => i.Url == url)
        //            .Include(i => i.RecipeCategory)
        //            .ThenInclude(i => i.Category)
        //            .FirstOrDefault();
        //    }
        //}
    }
}
