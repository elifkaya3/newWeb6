using AppDersAtama.Models;
using AppDersAtama.Models.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDersAtama.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AssignLesson()
        {
            var model = new EFOgrenciDal();
            return View(model.GetAll());
        }

        public IActionResult Assign(int id)
        {
            var model2 = new EFDersDal();
            var context = new EFOgrenciDal();
            var entity = context.GetByIdWithDersler(id);
            var model = new OgrenciModel()
            {
                OgrenciId = entity.OgrenciId,
                OgrenciNo = entity.OgrenciNo,
                OgrenciAd = entity.OgrenciAd,
                OgrenciSoyad = entity.OgrenciSoyad,
                OgrenciDogumTarihi = entity.OgrenciDogumTarihi,
                OgrenciKayitTarihi = entity.OgrenciKayitTarihi,
                Donem = entity.Donem,
                BolumId = entity.BolumId,
                SecilenDersler = entity.OgrenciDersler.Select(x => x.Ders).ToList()
            };
            ViewBag.Dersler = model2.GetAll();
            return View(model);
        }
    }
}
