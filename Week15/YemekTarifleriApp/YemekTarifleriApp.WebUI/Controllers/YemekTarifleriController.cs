using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemekTarifleriApp.Bussiness.Abstract;

namespace YemekTarifleriApp.WebUI.Controllers
{
    public class YemekTarifleriController : Controller
    {
        private IRecipeService _recipeService;
        public YemekTarifleriController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View(_recipeService.GetAll());
        }
    }
}
