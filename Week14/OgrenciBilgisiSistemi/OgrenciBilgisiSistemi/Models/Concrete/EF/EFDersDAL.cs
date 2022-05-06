using OgrenciBilgisiSistemi.Models.Abstract;
using OgrenciBilgisiSistemi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgisiSistemi.Models.Config
{
    public class EFDersDAL : EFBaseRepository<Ders>, IEntityRepository<Ders>
    {
    }
}
