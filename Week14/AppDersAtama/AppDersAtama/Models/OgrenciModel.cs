using AppDersAtama.Models.Entity;
using System;
using System.Collections.Generic;

namespace AppDersAtama.Models
{
    public class OgrenciModel
    {
        public int OgrenciId { get; set; }
        public int OgrenciNo { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public DateTime OgrenciDogumTarihi { get; set; }
        public DateTime OgrenciKayitTarihi { get; set; }
        public sbyte Donem { get; set; }
        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }
        public List<Ders> SecilenDersler { get; set; }
    }
}