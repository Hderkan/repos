using EF_2504.DAL.Concrete.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_2504.MVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var _categories = new EFCategoryDAL();
            
            return View(_categories.GetAll());

        }
    }
}
