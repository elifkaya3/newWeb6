using Microsoft.EntityFrameworkCore;
using OgrenciBilgisiSistemi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgisiSistemi.Models.Concrete
{
    public class OgrenciDbContext : DbContext
    {
        public OgrenciDbContext()
        {

        }
        public OgrenciDbContext(DbContextOptions<OgrenciDbContext> options) : base(options)
        {

        }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<OgrenciDers> OgrenciDers { get; set; }
        public DbSet<BolumDers> BolumDers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8M7D7GE\\SQLEXPRESS;Database=OgrenciDbSabah; Trusted_Connection=true;");
        }

    }
}
