using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcKutuphane.Models;

namespace MvcKutuphane.Controllers
{
    public class YazarlarController : Controller
    {
        private readonly KutuphaneSabahContext _context;

        public YazarlarController(KutuphaneSabahContext context)
        {
            _context = context;
        }

        // GET: Yazarlar
        public async Task<IActionResult> Index()
        {
            var kutuphaneSabahContext = _context.Yazarlars.Include(y => y.Tur);
            return View(await kutuphaneSabahContext.ToListAsync());
        }

        // GET: Yazarlar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yazarlar = await _context.Yazarlars
                .Include(y => y.Tur)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yazarlar == null)
            {
                return NotFound();
            }

            return View(yazarlar);
        }

        // GET: Yazarlar/Create
        public IActionResult Create()
        {
            ViewData["TurId"] = new SelectList(_context.Turlers, "Id", "Id");
            return View();
        }

        // POST: Yazarlar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AdSoyad,Cinsiyet,DogumTarihi,Tel,Mail,TurId")] Yazarlar yazarlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yazarlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TurId"] = new SelectList(_context.Turlers, "Id", "Id", yazarlar.TurId);
            return View(yazarlar);
        }

        // GET: Yazarlar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yazarlar = await _context.Yazarlars.FindAsync(id);
            if (yazarlar == null)
            {
                return NotFound();
            }
            ViewData["TurId"] = new SelectList(_context.Turlers, "Id", "Id", yazarlar.TurId);
            return View(yazarlar);
        }

        // POST: Yazarlar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AdSoyad,Cinsiyet,DogumTarihi,Tel,Mail,TurId")] Yazarlar yazarlar)
        {
            if (id != yazarlar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yazarlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YazarlarExists(yazarlar.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["TurId"] = new SelectList(_context.Turlers, "Id", "Id", yazarlar.TurId);
            return View(yazarlar);
        }

        // GET: Yazarlar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yazarlar = await _context.Yazarlars
                .Include(y => y.Tur)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yazarlar == null)
            {
                return NotFound();
            }

            return View(yazarlar);
        }

        // POST: Yazarlar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yazarlar = await _context.Yazarlars.FindAsync(id);
            _context.Yazarlars.Remove(yazarlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YazarlarExists(int id)
        {
            return _context.Yazarlars.Any(e => e.Id == id);
        }
    }
}
