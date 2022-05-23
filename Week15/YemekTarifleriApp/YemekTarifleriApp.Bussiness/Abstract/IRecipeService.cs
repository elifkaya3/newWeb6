using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleriApp.Entity;

namespace YemekTarifleriApp.Bussiness.Abstract
{
    public interface IRecipeService
    {
        Recipe GetById(int id);
        List<Recipe> GetAll();
        void Create(Recipe entity);
        void Update(Recipe entity);
        void Delete(Recipe entity);
        List<Recipe> GetRecipesByCategory(string name, int page, int pageSize);
        int GetCountByCategory(string category);


        //Recipe GetRecipeDetails(string url);

    }
}
