﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_mvs_01.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index3()
        {
            return View();
        }
    }
}