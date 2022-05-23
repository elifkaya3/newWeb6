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
        public int GetCountByCategory(string category)
        {
            throw new NotImplementedException();

            //using (var context = new RecipeAppContext())
            //{
            //    var recipes = context
            //        Recipes()


            //    if (!string.IsNullOrEmpty(category))
            //    {
            //        recipes = recipes
            //            .Include(i => i.RecipeCategories)
            //            .ThenInclude(i => i.Category)
            //            .Where(i => i.RecipeCategories.Any(a => a.Category.Url == category));
            //    }}
            //    return recipes.Count();
        }

        public List<Recipe> GetRecipesByCategory(string name, int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetRecipesByCategory(string name)
        {
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
