using DatabaseImageProject.Models.Abstract;
using DatabaseImageProject.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseImageProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDAL _context;
        public ProductController(ProductDAL context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //var products = new ProductDAL();
            return View(_context.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product, IFormFile file)
        {
            string filePath = ImageUpload(file);
            if (filePath != null)
            {
                product.ProductImage = filePath;
                _context.Add(product);
                return RedirectToAction("Index", _context.GetAll());
            }
            return View();
        }
        public string ImageUpload(IFormFile file)
        {
            if (file != null && (file.ContentType == "image/png" || file.ContentType == "image/png"))
            {
                string imageExtension = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid() + imageExtension;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/products/{imageName}");

                var stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
                return $"wwwroot/images/products/{imageName}";
            }
            return null;
        }
    }
}
