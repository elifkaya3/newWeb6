using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemekTarifleriApp.Bussiness.Abstract;
using YemekTarifleriApp.WebUI.Models;

namespace YemekTarifleriApp.WebUI.Controllers
{
    public class RecipeController : Controller
    {
        private IRecipeService _recipeService;
        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }
        public IActionResult Index()
        {
            return View(_recipeService.GetAll());
        }
        //public IActionResult RecipeDetails()
        //{
        //    return View(_recipeService.GetAll());
        //}
        public IActionResult List(string category, int page = 1)
        {
            ViewBag.Message = "Ürün bulunamadı";
            ViewBag.AlertType = "warning";
            //ÖDEV:
            //Bu işi ister model kullanarak şu an olduğu gibi partial yapıyla
            //İsterseniz ise daha farklı bir yol olarak ViewComponent mantığıyla
            //Çözün.

            //***********************************

            const int pageSize = 5;//bu değişken her sayfada kaç item görüneceğini tutacak
            int totalItems = _recipeService.GetCountByCategory(category);
            var productListViewModel = new RecipeListViewModel()
            {
                PageInfo = new PageInfo
                {
                    TotalItems = totalItems,
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    CurrentCategory = category
                },
                Recipes = _recipeService.GetProductsByCategory(category, page, pageSize)
            };
            return View(productListViewModel);
        }
    }
}
