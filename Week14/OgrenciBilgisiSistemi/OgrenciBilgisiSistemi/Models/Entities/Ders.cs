using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgisiSistemi.Models.Entities
{
    public class Ders
    {
        public int DersId { get; set; }
        public string DersAd { get; set; }
        public string DersHocası { get; set; }
        public decimal Kredi { get; set; }
        public int Donem { get; set; }
        public List<OgrenciDers> OgrenciDersler { get; set; }

    }
}
