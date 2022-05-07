using AppDersAtama.Models.Abstract;
using AppDersAtama.Models.Concrete;
using AppDersAtama.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDersAtama.Models.EF
{
    public class EFOgrenciDal : EFCoreEntity<Ogrenci>, IOgrenci
    {
        public Ogrenci GetByIdWithDersler(int id)
        {
            using (var context = new OgrenciDbContext())
            {
                return context.Ogrenciler
                    .Where(x => x.OgrenciId == id)
                    .Include(x => x.OgrenciDersler)
                    .ThenInclude(x => x.Ders)
                    .FirstOrDefault();
            }
        }
        public Ogrenci GetByIdWithDersler()
        {
            throw new NotImplementedException();
        }

        public void GetWithBolum()
        {
            throw new NotImplementedException();
        }
    }
}
