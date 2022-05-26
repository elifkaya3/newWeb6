using DurkayaRecipe.Business.Abstract;
using DurkayaRecipe.Entity;
using DurkayaRecipe.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DurkayaRecipe.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IFoodService _foodService;
        private readonly ICategoryService _categoryService;

        public CategoryController(IFoodService foodService, ICategoryService categoryService)
        {
            _foodService = foodService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryList()
        {
            return View(_categoryService.GetAll());
        }
        public IActionResult CategoryCreate()
        {
            ViewBag.Categories = _categoryService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult CategoryCreate(CategoryModel model, int[] categoryIds)
        {
            if (ModelState.IsValid)
            {

                var category = new Category()
                {
                    CategoryName = model.CategoryName,
                    Url = model.Url,
                    CategoryDescription = model.CategoryDescription,
                };
                _categoryService.Create(category, categoryIds);

                CreateMessage("Ürün başarıyla eklenmiştir", "success");
                return RedirectToAction("CategoryList");
            }
            CreateMessage("Ürün kaydedilememiştir. Lütfen ilgili alanları kontrol edip, yeniden deneyiniz.", "warning");
            ViewBag.Categories = _categoryService.GetAll();
            if (categoryIds.Length > 0)
            {
                model.SelectedCategories = categoryIds.Select(catId => new Category()
                {
                    CategoryId = catId
                }).ToList();
            }
            else
            {
                ViewBag.CategoryMessage = "Lütfen bir kategori seçimi yapınız!";
            }
           
            return View(model);
        }

        private void CreateMessage(string message, string alertType)
        {
            var msg = new AlertMessage()
            {
                Message = message,
                AlertType = alertType
            };
            TempData["Message"] = JsonConvert.SerializeObject(msg);
        }
    }
}
