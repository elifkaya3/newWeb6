using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_Core_Mvc_Code.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_Core_Mvc_Code.Controllers
{
    public class YayinEviController : Controller
    {
        private readonly KutuphaneSabahContext _context;
        public YayinEviController(KutuphaneSabahContext context)
        {
            _context = context;
        }
        //GET List
        public IActionResult Index()
        {
            return View(_context.Yayinevleris.ToList());
        }

        //GET Details
        public IActionResult Details(int id)
        {
            var yayinEv = _context.Yayinevleris.Find(id);
            return View(yayinEv);
        }
        //GET Edit
        public IActionResult Edit(int id)
        {
            var yayinEv = _context.Yayinevleris.Find(id);
            return View(yayinEv);
        }

        //POST Details
        [HttpPost]
        public IActionResult Edit([Bind("Id,Ad,Adres,Tel")] Yayinevleri yayinEv)
        {
            if (ModelState.IsValid)
            {
                _context.Update(yayinEv);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yayinEv);
            //GET Metod silinecek tür sayfasını göster
        }
        public IActionResult Delete(int id)
        {
            var yayinEv = _context.Yayinevleris.Find(id);
            return View(yayinEv);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var SilinecekYayinEvi = _context.Yayinevleris.Find(id);
            _context.Yayinevleris.Remove(SilinecekYayinEvi);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Yayinevleri yayinEv)
        {
            _context.Add(yayinEv);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
