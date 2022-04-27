using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_2504.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_2504.DAL.Concrete.EF.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);
            builder.Property(b => b.BookName).IsRequired();
            builder.Property(b => b.BookPrice).HasDefaultValue(0);
            builder.Property(b => b.BookCreateDate).HasDefaultValue(DateTime.Now);

            builder.HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Book { BookId = 1, BookName = "Yönetim Bilişim Sistemleri", BookImageUrl = 
                "https://m.media-amazon.com/images/I/41GKz4PqkNL._AC_SY1000_.jpg", CategoryId = 1 },
                new Book { BookId = 2, BookName = "A'dan Z'ye React", BookImageUrl =
                "https://www.tdk.com.tr/images_buyuk/f14/A-dan-Z-ye-PHP_8614_1.jpg", CategoryId = 2 },
                new Book { BookId = 3, BookName = "Sefiller" , BookImageUrl=
                "https://img.kitapyurdu.com/v1/getImage/fn:9950059/wh:true/wi:800", CategoryId=3}
                );

        }
    }
}