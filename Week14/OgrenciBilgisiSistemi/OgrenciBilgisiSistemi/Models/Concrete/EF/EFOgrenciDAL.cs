using Microsoft.EntityFrameworkCore;
using OgrenciBilgisiSistemi.Models.Abstract;
using OgrenciBilgisiSistemi.Models.Concrete;
using OgrenciBilgisiSistemi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgisiSistemi.Models.Config
{
    public class EFOgrenciDAL : EFBaseRepository<Ogrenci>, IEntityRepository<Ogrenci>
    {
        //public Ogrenci GetByIdWithDers(int id)
        //{
        //    using (var _context= new OgrenciDbContext())
        //    {
        //        return _context.Ogrenciler
        //            .Where(x => x.OgrenciId == id)
        //            .Include(x => x.OgrenciDersler)
        //            .ThenInclude(x => x.Ders)
        //            .

        //    }
        //}
    }
}
