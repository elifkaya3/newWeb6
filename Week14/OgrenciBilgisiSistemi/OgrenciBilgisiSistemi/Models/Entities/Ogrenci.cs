using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgisiSistemi.Models.Entities
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public int OgrenciNo { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public DateTime OgrenciDogumTarihi { get; set; }
        public DateTime OgrenciKayitTarihi { get; set; }
        public int Donem { get; set; }
        public Bolum Bolum { get; set; }
        public int BolumId { get; set; }
        public List<OgrenciDers> OgrenciDersler { get; set; }
    }
}
