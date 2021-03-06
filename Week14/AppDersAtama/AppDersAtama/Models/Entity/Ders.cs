using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDersAtama.Models.Entity
{
    public class Ders
    {
        public int DersId { get; set; }
        public string DersAd { get; set; }
        public string DersHocası { get; set; }
        public sbyte Kredi { get; set; }
        public sbyte Donem { get; set; }
        public List<OgrenciDers> OgrenciDersler { get; set; }
        public List<BolumDers> BolumDersler { get; set; }
    }
}
