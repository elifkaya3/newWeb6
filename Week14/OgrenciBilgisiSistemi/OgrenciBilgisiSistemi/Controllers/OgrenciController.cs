using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OgrenciBilgisiSistemi.Models.Concrete;
using OgrenciBilgisiSistemi.Models.Config;
using OgrenciBilgisiSistemi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgisiSistemi.Controllers
{
    public class OgrenciController : Controller 
    {
        //private readonly EFOgrenciDAL _context;
        //public  OgrenciController(EFOgrenciDAL context)
        //{
        //    _context = context;
        //}
        public IActionResult Index()
        {
            var _context = new EFOgrenciDAL();
            return View(_context.GetAll());
        }






        //public IActionResult Details(int id)
        //{
        //    //var _ogrenciler = _context.Get(id);
        //    //return View(_ogrenciler);
        //    return View();

        //}
        //public IActionResult Create()
        //{
        //    //ViewData["Bolum"] = new SelectList(_context.Bolumler, "BolumId", "BolumAd");
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Ogrenci _ogrenciler)
        //{
        //    //_context.Add(_ogrenciler);
        //    //_context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //public IActionResult Edit(int id)
        //{
        //    //ViewData["Bolum"] = new SelectList(_context.Bolumler, "BolumId", "BolumAd");
        //    //var _ogrenciler = _context.Ogrenciler.Find(id);
        //    //return View(_ogrenciler);
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Edit(Ogrenci _ogrenciler)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(_ogrenciler);
        //    }

        //    //_context.Update(_ogrenciler);
        //    //_context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //public IActionResult Delete(int id)
        //{
        //    //var _ogrenciler = _context.Ogrenciler.Find(id);
        //    //return View(_ogrenciler);
        //    return View();
        //}
        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    //var silinecekOgrenci = _context.Ogrenciler.Find(id);
        //    //_context.Remove(silinecekOgrenci);
        //    //_context.SaveChanges();
        //    return RedirectToAction("Index");
        //}




    }
}
