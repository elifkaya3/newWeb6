using Microsoft.AspNetCore.Mvc;
using Sales.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var categories = new CategoryDAL();
            return View(categories.GetAll());
        }
    }
}
