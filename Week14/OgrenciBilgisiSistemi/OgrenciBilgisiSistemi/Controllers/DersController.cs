using Microsoft.AspNetCore.Mvc;
using OgrenciBilgisiSistemi.Models.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgisiSistemi.Controllers
{
    public class DersController : Controller
    {
        public IActionResult Index()
        {
            var _dersler = new EFDersDAL();

            return View(_dersler.GetAll());
        }
    }
}
