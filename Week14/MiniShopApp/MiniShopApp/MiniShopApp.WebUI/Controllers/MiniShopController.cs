using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Bussiness.Abstract;
using MiniShopApp.Entity;
using MiniShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Controllers
{
    public class MiniShopController : Controller
    {
        private IProductService _productService;
        public MiniShopController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(string category, int page=1)
        {
            ViewBag.Message = "Ürün Bulunamadı";
            ViewBag.AlertType = "warning";

            //Ödevv:: 
            //bu işi ister model mantığıyla kullanarak şu an olduğu gibi yapıyla ViewComponent mantığıyla çözün
            //*************************

            const int pageSize = 3; //bu dğeişken ka sayfada item görüntüleneciğini tutacak
            var productListViewModel = new ProductListViewModel()
            {
                PageInfo = new PageInfo
                {
                    TotalItems = _productService.GetCountByCategory(category);
                }
            };

            return View(_productService.GetProductsByCategory(category));
        }
        
        public IActionResult Details(string url)
        {
            if (url == null) 
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails(url);

            if (product == null)
            {
                return NotFound();
            }
            ProductDetailModel productDetail = new ProductDetailModel()
            {
                Product = product,
                Categories = product.ProductCategories.Select(i => i.Category).ToList()
            };

            return View(productDetail);
        }

        public IActionResult Search(string q)
        {
            //bize arama kriterinin uygun olduğum eşleştiği tüm 
            //ürünleri döndürecel metod lazım
            
            return View(_productService.GetSearchResult(q));
        }

    }}
}
