using DurkayaRecipe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurkayaRecipe.Data.Abstract
{
    public interface IFoodRepository  : IRepository<Food>
    {
        List<Food> GetFoodsByCategory(string name, int page, int pageSize);
        List<Food> GetHomePageFoods();
        Food GetFoodDetails(string url);
        List<Food> GetSearchResult(string searchString);
        int GetCountByCategory(string category);
        void Create(Food entity, int[] categoryIds);
        void Update(Food entity, int[] categoryIds);
        Food GetByIdWithCategories(int id);
    }
}
