﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcKutuphane.Models;

namespace MvcKutuphane.Controllers
{
    public class TurlerController : Controller
    {
        private readonly KutuphaneSabahContext _context;

        public TurlerController(KutuphaneSabahContext context)
        {
            _context = context;
        }

        // GET: Turler
        public async Task<IActionResult> Index()
        {
            return View(await _context.Turlers.ToListAsync());
        }

        // GET: Turler/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turler = await _context.Turlers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (turler == null)
            {
                return NotFound();
            }

            return View(turler);
        }

        // GET: Turler/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Turler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TurAd")] Turler turler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(turler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(turler);
        }

        // GET: Turler/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turler = await _context.Turlers.FindAsync(id);
            if (turler == null)
            {
                return NotFound();
            }
            return View(turler);
        }

        // POST: Turler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TurAd")] Turler turler)
        {
            if (id != turler.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(turler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TurlerExists(turler.Id))
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
            return View(turler);
        }

        // GET: Turler/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turler = await _context.Turlers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (turler == null)
            {
                return NotFound();
            }

            return View(turler);
        }

        // POST: Turler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var turler = await _context.Turlers.FindAsync(id);
            _context.Turlers.Remove(turler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TurlerExists(int id)
        {
            return _context.Turlers.Any(e => e.Id == id);
        }
    }
}
