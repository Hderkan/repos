using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sales.Models.Concrete;
using Sales.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new ProductDAL();
            return View(product.GetAll());
            
        }
        public IActionResult Create()
        {
            var category = new CategoryDAL();
            ViewData["Category"] = new SelectList(category.GetAll(), "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product, IFormFile file)
        {
            if (file != null)
            {
                string imageExtension = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid() + imageExtension;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}");
                var stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
                product.ImageURL = $"/images/{imageName}";

            }
            var products = new ProductDAL();
            products.Add(product);
            return RedirectToAction("Index");

        }
        



    }
}
