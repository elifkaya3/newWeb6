using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgisiSistemi.Models.Entities
{
    public class Bolum
    {
        public int BolumId { get; set; }
        public string BolumAd { get; set; }
        public string BolumBaskanAd { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
        public List<Ders> Dersler { get; set; }
    }
}