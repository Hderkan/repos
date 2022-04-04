using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_mvs_01.Controllers
{
    //eger bir clasn controoler davranısı gösteresi yani gelen bir requestı karsılayabilir bir özell,k kazanmasını istiyorsak
    //o sınıfı controller sınfından turetmeliz

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Action Method: eger bir method bir controller icindeyse
            //buna action method diyoruz
            //cogu kez action sözcugu ile ifade edilebilri. 

            //bu action uygulamamızn ana sayfasına girildiginde tetiklenmis olacak
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
    }
}
