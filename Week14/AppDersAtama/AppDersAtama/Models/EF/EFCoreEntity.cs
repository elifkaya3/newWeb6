using AppDersAtama.Models.Abstract;
using AppDersAtama.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDersAtama.Models.EF
{
    public class EFCoreEntity<T> : IRepository<T> where T : class, new()
    {
        public void Add(T entity)
        {
            using (var _context = new OgrenciDbContext())
            {
                _context.Entry(entity).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var _context = new OgrenciDbContext())
            {
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public T Get(int id)
        {

            using (var _context = new OgrenciDbContext())
            {
                return _context.Set<T>().Find(id);
            }
        }

        public List<T> GetAll()
        {
            using (var _context = new OgrenciDbContext())
            {
                return _context.Set<T>().ToList();
            }
        }

        public void Update(T entity)
        {
            using (var _context = new OgrenciDbContext())
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
