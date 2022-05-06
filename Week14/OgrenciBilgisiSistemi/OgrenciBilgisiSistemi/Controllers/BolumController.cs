using Microsoft.AspNetCore.Mvc;
using OgrenciBilgisiSistemi.Models.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgisiSistemi.Controllers
{
    public class BolumController : Controller
    {
        public IActionResult Index()
        {
            var _bolumler = new EFBolumDAL();

            return View(_bolumler.GetAll());
        }
    }
}
