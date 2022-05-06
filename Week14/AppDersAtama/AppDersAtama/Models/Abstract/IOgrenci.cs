using AppDersAtama.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDersAtama.Models.Abstract
{
    public interface IOgrenci : IRepository<Ogrenci>
    {
        public void GetWithDepartment();
        public Ogrenci GetByIdWithCourses(int id);
    }
}
