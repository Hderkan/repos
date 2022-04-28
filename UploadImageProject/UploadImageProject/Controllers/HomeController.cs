using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UploadImageProject.Models;

namespace UploadImageProject.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UploadImage()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/");

            var imageList = Directory.GetFiles(path);

            List<UploadImageModel> uploadImages = new List<UploadImageModel>();

            foreach (var Image in imageList)

            {
                FileInfo fileInfo = new FileInfo(Image);
                UploadImageModel model = new UploadImageModel();
                model.FullName = Image.Substring(Image.IndexOf("wwwroot")).Replace("wwwroot/", string.Empty);

                model.FullFile = fileInfo.Name;
                model.Size = fileInfo.Length / 1024;

                uploadImages.Add(model);


            }



            return View(uploadImages);

        }
        [HttpPost]
        public IActionResult UploadImage(IFormFile file)
        {
            if (file != null)
            {
                string imageExtension = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid() + imageExtension;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}");

                var stream = new FileStream(path,FileMode.Create);
                file.CopyTo(stream);
            }
            return RedirectToAction("UploadImage");
        }



    }
}
