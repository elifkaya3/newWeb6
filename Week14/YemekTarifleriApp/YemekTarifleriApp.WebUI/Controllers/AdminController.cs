using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemekTarifleriApp.Bussiness.Abstract;
using YemekTarifleriApp.Bussiness.Concrete;
using YemekTarifleriApp.Entity;
using YemekTarifleriApp.WebUI.Models;

namespace YemekTarifleriApp.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRecipeService _recipeService;
        private readonly ICategoryService _categoryService;
        private readonly IMemberService _memberService;
        public AdminController(IRecipeService recipeService, ICategoryService categoryService, IMemberService memberService)
        {
            _recipeService = recipeService;
            _categoryService = categoryService;
            _memberService = memberService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RecipeList()
        {
            return View(_recipeService.GetAll());
        }
        public IActionResult RecipeCreate()
        {
            ViewBag.Categories = _categoryService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult RecipeCreate(RecipeModel model, int[] categoryIds, IFormFile file)
        {
            if (ModelState.IsValid && categoryIds.Length > 0 && file != null)
            {
                JobManager urlGenerate = new JobManager();
                var url = urlGenerate.MakeUrl(model.RecipeName);

                model.ImageUrl = urlGenerate.UploadImage(file, url);

                var recipe = new Recipe()
                {
                    RecipeName = model.RecipeName,
                    Url = model.Url,
                    RecipeMaterial = model.RecipeMaterial,
                    ImageUrl = model.ImageUrl,
                    RecipeDescription = model.RecipeDescription,
                    IsApproved = model.IsApproved,
                    IsHome = model.IsHome
                };
                _recipeService.Create(recipe, categoryIds);

                //CreateMessage("Tarifiniz başarıyla eklenmiştir", "success");
                return RedirectToAction("RecipeList");
            }

            //CreateMessage("Tarifiniz kaydedililirken bir sorun oluştu. Lütfen formu kontrol edip, yeniden deneyiniz.", "warning");
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
                ViewBag.CategoryMessage = "Lütfen tarifiniz için bir kategori seçimi yapınız!";
            }
            if (file == null)
            {
                ViewBag.ImageMessage = "Lütfen tarifiniz için resim seçiniz!";
            }
            return View(model);
        }

        public IActionResult RecipeEdit(int? id)
        {
            var entity = _recipeService.GetByIdWithCategories((int)id);
            var model = new RecipeModel()
            {
                RecipeId = entity.RecipeId,
                RecipeName = entity.RecipeName,
                RecipeMaterial = entity.RecipeMaterial,
                Url = entity.Url,
                RecipeDescription = entity.RecipeDescription,
                ImageUrl = entity.ImageUrl,
                IsApproved = entity.IsApproved,
                IsHome = entity.IsHome,
                SelectedCategories = entity
                    .RecipeCategories
                    .Select(i => i.Category)
                    .ToList()
            };
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }

        [HttpPost]
        public IActionResult RecipeEdit(RecipeModel model, int[] categoryIds, IFormFile file)
        {
            JobManager urlGenerate = new JobManager();
            var url = urlGenerate.MakeUrl(model.RecipeName);

            model.ImageUrl = urlGenerate.UploadImage(file, url);
            var entity = _recipeService.GetById(model.RecipeId);
            entity.RecipeName = model.RecipeName;
            entity.RecipeMaterial = model.RecipeMaterial; 
            entity.RecipeDescription = model.RecipeDescription;
            entity.Url = model.Url;
            entity.IsApproved = model.IsApproved;
            entity.IsHome = model.IsHome;
            entity.ImageUrl = model.ImageUrl;

            _recipeService.Update(entity, categoryIds);
            return RedirectToAction("RecipeList");
        }

        public IActionResult RecipeDelete(int recipeId)
        {
            var entity = _recipeService.GetById(recipeId);
            _recipeService.Delete(entity);
            return RedirectToAction("RecipeList");
        }

       
    }
}
