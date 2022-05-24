using DurkayaRecipe.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DurkayaRecipe.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IFoodService _foodService;
        public HomeController(IFoodService foodService)
        {
            _foodService = foodService;
        }
        public IActionResult Index()
        {
            return View(_foodService.GetHomePageFoods());
        }
    }
}
