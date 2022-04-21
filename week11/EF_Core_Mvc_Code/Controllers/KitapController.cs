using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EF_Core_Mvc_Code.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EF_Core_Mvc_Code.Controllers
{
    public class KitapController : Controller
    {
        private readonly KutuphaneSabahContext _context;


        public KitapController(KutuphaneSabahContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Kitaplars.ToList());
        }

        public IActionResult Details(string id)
        {
             var seciliKitap = _context.Kitaplars
            .Include(k=>k.Tur)
            .Include(k=>k.YayinEvi)
            .Include(k=>k.Yazar)
            .First(sk=>sk.Isbn==id);
            return View(seciliKitap);
        }
        public IActionResult Edit(string id)
        {
            var seciliKitap = _context.Kitaplars.Find(id);
            ViewData["Tur"]=new SelectList(_context.Turlers,"Id","TurAd",seciliKitap.TurId);
            ViewData["Yazar"]=new SelectList(_context.Yazarlars,"Id","AdSoyad",seciliKitap.YazarId);
            ViewData["YayinEvi"]=new SelectList(_context.Yayinevleris,"Id","Ad",seciliKitap.YayinEviId);
            return View(seciliKitap);
        }
        //Post işlemi
        [HttpPost]
        public IActionResult Edit(Kitaplar kitap)
        {
            _context.Update(kitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}