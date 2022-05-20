using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemekTarifleriApp.Bussiness.Abstract;

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
    }
}
