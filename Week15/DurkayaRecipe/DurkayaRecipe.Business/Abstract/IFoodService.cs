using DurkayaRecipe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurkayaRecipe.Business.Abstract
{
    public interface IFoodService
    {
        Food GetById(int id);
        List<Food> GetAll();
        void Create(Food entity);
        void Update(Food entity);
        void Delete(Food entity);
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
