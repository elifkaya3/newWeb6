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
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, DurkayaRecipeContext>, ICategoryRepository
    {
        public void Create(Category entity, int[] categoryIds)
        {
            using (var context = new DurkayaRecipeContext())
            {
                context.Categories.Add(entity);
                context.SaveChanges();
                entity.FoodCategories = categoryIds
                    .Select(catId => new FoodCategory
                    {
                        CategoryId = catId
                    }).ToList();
                context.SaveChanges();
            }
        }

        public Category GetByIdWithCategories(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity, int[] categoryIds)
        {
            using (var context = new DurkayaRecipeContext())
            {
                var category = context
                    .Categories
                    .Include(i => i.FoodCategories)
                    .FirstOrDefault(i => i.CategoryId == entity.CategoryId);
                category.CategoryName = entity.CategoryName;
                category.CategoryDescription = entity.CategoryDescription;
                category.Url = entity.Url;
                category.FoodCategories = categoryIds
                    .Select(catId => new FoodCategory()
                    {
                        CategoryId = catId
                    }).ToList();
                context.SaveChanges();
            }
        }
    }
}
