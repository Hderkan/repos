



using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _Context;

        public CategoryController(ILogger<CategoryController> Context)
        {
            _Context = Context;
        }

        public IActionResult Index()
        {
            return View();
        }

      
    }
}