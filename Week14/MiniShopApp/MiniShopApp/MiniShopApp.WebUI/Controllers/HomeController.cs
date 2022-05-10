using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniShopApp.Bussiness.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //burada IProductService Çağrılıyor ve isimlendiriliyor
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            //product servisten çağrılan komutla ilgili viewe listeleme metodu gerçekleşmesi için yzılan komut.
            return View(_productService.GetAll());
        }
    }
}
