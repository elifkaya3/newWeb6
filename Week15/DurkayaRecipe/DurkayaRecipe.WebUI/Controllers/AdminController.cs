﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DurkayaRecipe.Business.Abstract;
using DurkayaRecipe.Business.Concrete;
using DurkayaRecipe.Entity;
using DurkayaRecipe.WebUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DurkayaRecipe.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IFoodService _foodService;
        private readonly ICategoryService _categoryService;
        public AdminController(IFoodService foodService, ICategoryService categoryService)
        {
            _foodService = foodService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FoodList()
        {
            return View(_foodService.GetAll());
        }
        public IActionResult FoodCreate()
        {
            ViewBag.Categories = _categoryService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult FoodCreate(FoodModel model, int[] categoryIds, IFormFile file)
        {
            if (ModelState.IsValid && categoryIds.Length > 0 && file != null)
            {
                JobManager urlGenerate = new JobManager();
                var url = urlGenerate.MakeUrl(model.FoodName);

                model.ImageUrl = urlGenerate.UploadImage(file, url);

                var food = new Food()
                {
                    FoodName = model.FoodName,
                    Url = model.Url,
                    FoodMaterial = model.FoodMaterial,
                    ImageUrl = model.ImageUrl,
                    FoodDescription = model.FoodDescription,
                    IsApproved = model.IsApproved,
                    IsHome = model.IsHome
                };
                _foodService .Create(food, categoryIds);

                CreateMessage("Ürün başarıyla eklenmiştir", "success");
                return RedirectToAction("FoodList");
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
            if (file == null)
            {
                ViewBag.ImageMessage = "Lütfen resim seçiniz!";
            }
            return View(model);
        }

        public IActionResult FoodEdit(int? id)
        {
            var entity = _foodService.GetByIdWithCategories((int)id);
            var model = new FoodModel()
            {
                FoodId = entity.FoodId,
                FoodName = entity.FoodName,
                FoodMaterial = entity.FoodMaterial,
                Url = entity.Url,
                FoodDescription = entity.FoodDescription,
                ImageUrl = entity.ImageUrl,
                IsApproved = entity.IsApproved,
                IsHome = entity.IsHome,
                SelectedCategories = entity
                    .FoodCategories
                    .Select(i => i.Category)
                    .ToList()
            };
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }

        [HttpPost]
        public IActionResult FoodEdit(FoodModel model, int[] categoryIds, IFormFile file)
        {
            JobManager urlGenerate = new JobManager();
            var url = urlGenerate.MakeUrl(model.FoodName);

            model.ImageUrl = urlGenerate.UploadImage(file, url);
            var entity = _foodService.GetById(model.FoodId);
            entity.FoodName = model.FoodName;
            entity.FoodMaterial = model.FoodMaterial;
            entity.Url = model.Url;
            entity.FoodDescription = model.FoodDescription;
            entity.IsApproved = model.IsApproved;
            entity.IsHome = model.IsHome;
            entity.ImageUrl = model.ImageUrl;
            _foodService.Update(entity, categoryIds);
            return RedirectToAction("FoodList");
        }

        public IActionResult FoodDelete(int foodId)
        {
            var entity = _foodService.GetById(foodId);
            _foodService.Delete(entity);
            return RedirectToAction("FoodList");
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
