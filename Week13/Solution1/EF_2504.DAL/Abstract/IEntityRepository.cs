using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF_2504.DAL.Abstract
{
    public interface IEntityRepository<T> where T:class
    {
        //ekleme (C)rud
        void Add(T entity);
        //listeleme (R)ead
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        //güncelle (U)pdate
        void Update(T entity);
        //sil (D)elete
        void Delete(T entity);
    }
}
