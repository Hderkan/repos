using DatabaseImageProject.Models.Concrete;
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
        public IActionResult Index()
        {
            var hakan = new ProductDAL();



            return View(hakan.GetAll());
        }
        public IActionResult Create()
        {

           
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product , IFormFile file)
        {
            if (file != null)
            {
                string imageExtension = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid() + imageExtension;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}");
                var stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
              


            }
            var products = new ProductDAL();
            products.Add(product);
            return RedirectToAction("Index");


        }
    }
}
