using DurkayaRecipe.Business.Abstract;
using DurkayaRecipe.Data.Abstract;
using DurkayaRecipe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurkayaRecipe.Business.Concrete
{
    public class FoodManager : IFoodService
    {
        private IFoodRepository _foodRepository;

        public FoodManager(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }
        public void Create(Food entity)
        {
            throw new NotImplementedException();
        }

        public void Create(Food entity, int[] categoryIds)
        {
            _foodRepository.Create(entity, categoryIds);
        }

        public void Delete(Food entity)
        {
            _foodRepository.Delete(entity);
        }

        public List<Food> GetAll()
        {
            return _foodRepository.GetAll();
        }

        public Food GetById(int id)
        {
            return _foodRepository.GetById(id);
        }

        public Food GetByIdWithCategories(int id)
        {
            return _foodRepository.GetByIdWithCategories(id);
        }

        public int GetCountByCategory(string category)
        {
            return _foodRepository.GetCountByCategory(category);
        }

        public Food GetFoodDetails(string url)
        {
            return _foodRepository.GetFoodDetails(url);
        
        
        }

        public List<Food> GetFoodsByCategory(string name, int page, int pageSize)
        {
            return _foodRepository.GetFoodsByCategory(name, page, pageSize);
        }

        public List<Food> GetHomePageFoods()
        {
            return _foodRepository.GetHomePageFoods();
        }

        public List<Food> GetSearchResult(string searchString)
        {
           return _foodRepository.GetSearchResult(searchString);
        }

        public void Update(Food entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Food entity, int[] categoryIds)
        {
            _foodRepository.Update(entity, categoryIds);
        }
    }
}
