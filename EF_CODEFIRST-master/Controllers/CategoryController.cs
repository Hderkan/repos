using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using EF_CodeFirst.Models.Context;
using EF_CodeFirst.Models.Entities;

namespace Controllers
{
    
    public class CategoryController : Controller
    {
        private readonly Library6Context _context;

        

        public CategoryController(Library6Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }
        public IActionResult Details(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
        public IActionResult Edit(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit([Bind(include:"CategoryId,CategoryName,CategoryDescription,IsDeleted")] Category  tur)
        {
            if (ModelState.IsValid)
            {
                _context.Update(tur);//Bu satır sadece contextimizi güncelledi.
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tur);
            

        }
         public IActionResult Delete(int id)
        {
            var tur = _context.Categories.Find(id);
            return View(tur);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekKitapTuru = _context.Categories.Find(id);
            _context.Categories.Remove(silinecekKitapTuru);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
         public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category baka)
        {
            _context.Add(baka);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        

        
    }
}