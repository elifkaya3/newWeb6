using DurkayaRecipe.Data.Abstract;
using DurkayaRecipe.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurkayaRecipe.Data.Concrete.EfCore
{
    public class EfCoreFoodRepository : EfCoreGenericRepository<Food, DurkayaRecipeContext>, IFoodRepository
    {
        private string ConvertLower(string text)
        {
            text = text.Replace("I", "i");
            text = text.Replace("İ", "i");
            text = text.Replace("ı", "i");

            text = text.ToLower();
            text = text.Replace("ç", "c");
            text = text.Replace("ö", "o");
            text = text.Replace("ü", "u");
            text = text.Replace("ş", "s");
            text = text.Replace("ğ", "g");
            return text;
        }

        public List<Food> GetSearchResult(string searchString)
        {
            searchString = ConvertLower(searchString);
            using (var context = new DurkayaRecipeContext())
            {
                var foods = context
                    .Foods
                    .Where(i => i.IsApproved).ToList();
                foreach (var item in foods)
                {
                    item.FoodName = ConvertLower(item.FoodName);
                    item.FoodDescription = ConvertLower(item.FoodDescription);
                }
                var foods2 = foods
                    .Where(i => i.FoodName == searchString || i.FoodDescription == searchString)
                    .ToList();

                return foods2;
            }
        }

        public Food GetFoodDetails(string url)
        {
            using (var context = new DurkayaRecipeContext())
            {
                return context
                    .Foods
                    .Where(i => i.Url == url)
                    .Include(i => i.FoodCategories)
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();
            }
        }

        public List<Food> GetFoodsByCategory(string name, int page, int pageSize)
        {
            using (var context = new DurkayaRecipeContext())
            {
                var foods = context
                    .Foods
                    .Where(i => i.IsApproved)
                    .AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                   foods  = foods
                        .Include(i => i.FoodCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.FoodCategories.Any(a => a.Category.Url == name));
                }
                return foods.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public List<Food> GetHomePageFoods()
        {
            using (var context = new DurkayaRecipeContext())
            {
                return context
                    .Foods
                    .Where(i => i.IsApproved && i.IsHome)
                    .ToList();
            }
        }

        public int GetCountByCategory(string category)
        {
            using (var context = new DurkayaRecipeContext())
            {
                var foods = context
                    .Foods
                    .Where(i => i.IsApproved)
                    .AsQueryable();
                if (!string.IsNullOrEmpty(category))
                {
                    foods = foods
                        .Include(i => i.FoodCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.FoodCategories.Any(a => a.Category.Url == category));
                }
                return foods.Count();
            }
        }

        public void Create(Food entity, int[] categoryIds)
        {
            using (var context = new DurkayaRecipeContext())
            {
                context.Foods.Add(entity);
                context.SaveChanges();
                entity.FoodCategories = categoryIds
                    .Select(catId => new FoodCategory
                    {
                        FoodId = entity.FoodId,
                        CategoryId = catId
                    }).ToList();
                context.SaveChanges();
            }
        }

        public void Update(Food entity, int[] categoryIds)
        {
            using (var context = new DurkayaRecipeContext())
            {
                var food = context
                    .Foods
                    .Include(i => i.FoodCategories)
                    .FirstOrDefault(i => i.FoodId == entity.FoodId);
                food.FoodName = entity.FoodName;
                food.FoodDescription = entity.FoodDescription;
                food.Url = entity.Url;
                food.ImageUrl = entity.ImageUrl;
                food.IsApproved = entity.IsApproved;
                food.IsHome = entity.IsHome;
                food.FoodCategories = categoryIds
                    .Select(catId => new FoodCategory()
                    {
                        FoodId = entity.FoodId,
                        CategoryId = catId
                    }).ToList();
                context.SaveChanges();
            }
        }

        public Food GetByIdWithCategories(int id)
        {
            using (var context = new DurkayaRecipeContext())
            {
                return context
                    .Foods
                    .Where(i => i.FoodId == id)
                    .Include(i => i.FoodCategories)
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();
            }
        }
    }
}
