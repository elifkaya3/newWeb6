using DurkayaRecipe.Business.Abstract;
using DurkayaRecipe.Entity;
using DurkayaRecipe.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DurkayaRecipe.WebUI.Controllers
{
    public class DurkayaRecipeController : Controller
    {
        private IFoodService _foodService;
        public DurkayaRecipeController(IFoodService foodService)
        {
            _foodService = foodService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string category, int page = 1)
        {
            ViewBag.Message = "Ürün bulunamadı";
            ViewBag.AlertType = "warning";

            const int pageSize = 5;
            int totalItems = _foodService.GetCountByCategory(category);
            var foodListViewModel = new FoodListViewModel()
            {
                PageInfo = new PageInfo
                {
                    TotalItems = totalItems,
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    CurrentCategory = category
                },
                Foods = _foodService.GetFoodsByCategory(category, page, pageSize)
            };
            return View(foodListViewModel);
        }

        public IActionResult Details(string url)
        {
            if (url == null)
            {
                return NotFound();
            }
            Food food = _foodService.GetFoodDetails(url);
            if (food == null)
            {
                return NotFound();
            }
            FoodDetailModel foodDetail = new FoodDetailModel()
            {
                Food = food,
                Categories = food.FoodCategories.Select(i => i.Category).ToList()
            };
            return View(foodDetail);
        }

        public IActionResult Search(string q)
        {
            return View(_foodService.GetSearchResult(q));
        }
    }
}
