using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Models
{
    public class ProductListViewModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Products { get; set; }
    }
    public class PageInfo
    {
        public int TotalItems { get; set; }//toplam item sayısı
        public int ItemPerPage { get; set; }//her sayfada gösterilecek ıtem sayısı
        public int CurrentPage { get; set; }//o sırada geçerli syfa numarası
        public string CurrentCategory { get; set; }//Geçerli Kategori
        public int TotalPages ()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemPerPage);
        }
    }

}
