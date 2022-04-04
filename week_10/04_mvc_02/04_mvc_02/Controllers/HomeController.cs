using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_mvc_02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Anasayfa()
        {
            return View("Anasayfa");
        }
    }
}
