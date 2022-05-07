using Sales.Models.Abstract;
using Sales.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models.Concrete
{
    public class ProductDAL : BaseRepository<Product>, IProductRepository
    {
        public ProductDAL(SalesDbContext context) : base(context)
        {

        }
        private SalesDbContext Context
        {
            get { return _context as SalesDbContext; }
        }
        public List<Product> GetPopularProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
