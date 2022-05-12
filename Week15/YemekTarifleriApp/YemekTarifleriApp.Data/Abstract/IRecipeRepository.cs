using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifleriApp.Entity;

namespace YemekTarifleriApp.Data.Abstract
{
    public interface IRecipeRepository : IRepository<Recipe>
    {
        List<Recipe> GetRecipesByCategory(string name);
    }
}
