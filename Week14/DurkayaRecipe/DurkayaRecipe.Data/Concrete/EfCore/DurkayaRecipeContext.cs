using DurkayaRecipe.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurkayaRecipe.Data.Concrete.EfCore
{
    public class DurkayaRecipeContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = RecipeDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodCategory>()
                .HasKey(fc => new { fc.FoodId, fc.CategoryId });
        }
    }
}
