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
    public class TurController : Controller
    {
        private readonly KutuphaneSabahContext _context;
        public TurController(KutuphaneSabahContext context)
        {
            _context = context;
            //bu aşamadan sonra yani nesne ilk üretildiği andan itibaren 
            //_context değişkeni benim modelimi temsil ediyor olacak.
            //bir daha yani, KutuphaneSabaContext'i temsil edecek.
        }

        //GET kitap türlerini listele
        public IActionResult Index()
        {
            return View(_context.Turlers.ToList());
        }

        //GET kitap türü detayını göster
        public IActionResult Details(int id)
        {
            var tur = _context.Turlers.Find(id);
            return View(tur);
        }
        //GET düzenlenecek kitabın bilgilerini göster[HttpGet] işlemi yapar
        public IActionResult Edit(int id)
        {
            var tur = _context.Turlers.Find(id);
            return View(tur);
        }

        [HttpPost]
        public IActionResult Edit([Bind("Id,TurAd")] Turler tur)
        {
            if (ModelState.IsValid)
            {
                _context.Update(tur);
                //üst satır sadece contextimizi güncelledi.
                _context.SaveChanges();//veri tabanına değişikliğii yansıtan komut
                return RedirectToAction("Index");
            }
            return View(tur);
        }
        //GET Metod silinecek tür sayfasını göster
        public IActionResult Delete(int id)
        {
            var tur = _context.Turlers.Find(id);
            return View(tur);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var SilinecekKitapTuru = _context.Turlers.Find(id);
            _context.Turlers.Remove(SilinecekKitapTuru);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Turler tur)
        {
            _context.Add(tur);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}