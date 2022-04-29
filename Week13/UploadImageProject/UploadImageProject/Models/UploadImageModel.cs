using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadImageProject.Models
{
    public class UploadImageModel
    {
        public string FullName { get; set; }
        public string FileName { get; set; }
        public long Size { get; set; }

    }
    //public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options)
    //{

    //}
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    if (!optionsBuilder.IsConfigured)
    //    {
    //        optionsBuilder.UseSqlServer("Server=DESKTOP-8M7D7GE\\SQLEXPRESS;Database=UploadImage;Trusted_Connection=true");
    //    }
    //}
}
