using DatabaseImageProject.Models.Concrete;
using DatabaseImageProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseImageProject.Models.Abstract
{
    public class ProductDAL : BaseRepository<Product>
    {
        private readonly ProductDbContext _context;
        public ProductDAL(ProductDbContext context)
        {
            _context = context;
        }
    }
}
