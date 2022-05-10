using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        //ekstra kullanmka istedğim metodları ekleyebilirim  eklmek zorunda değiliz

        List<Category> GetProductsByCategory(string name);

    }
}
