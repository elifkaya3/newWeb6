using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDersAtama.Models.Entity
{
    public class BolumDers
    {

        public int BolumDersId { get; set; }
        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }
        public int DersId { get; set; }
        public Ders Ders { get; set; }
    }
}
