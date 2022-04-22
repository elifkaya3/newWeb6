using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models.Context;
using EF_CodeFirst.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace EF_CodeFirst.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Library6Context _context;

        public CategoryController(Library6Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }
        public IActionResult Details(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
        //Delete islemi GET 
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
//Delete islemi POST
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var SilinecekKitapTuru = _context.Categories.Find(id);
            _context.Categories.Remove(SilinecekKitapTuru);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //Edit islemi GET
        public IActionResult Edit(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
        //Edit islemi POST
        [HttpPost]
        public IActionResult Edit(Category Category)
        {
            // if (!ModelState.IsValid)
            // {
            //     return View(Category);
            // }
            _context.Update(Category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //Create islemi GET
        public IActionResult Create()
        {
            return View();
        }
        //Create islemi POST
        [HttpPost]
        public IActionResult Create(Category Category)
        {
            _context.Add(Category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}