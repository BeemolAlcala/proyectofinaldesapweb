using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EquiposDeFutbol.Data;
using EquiposDeFutbol.Models;

namespace EquiposDeFutbol.Controllers
{
    public class CompetitionsController : Controller
    {
        private readonly EquiposDeFutbolContext _context;

        public CompetitionsController(EquiposDeFutbolContext context)
        {
            _context = context;
        }

        // GET: Competitions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Competitions.ToListAsync());
        }

        // GET: Competitions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competitions = await _context.Competitions
                .FirstOrDefaultAsync(m => m.CompetitionID == id);
            if (competitions == null)
            {
                return NotFound();
            }

            return View(competitions);
        }

        // GET: Competitions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Competitions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompetitionID,CompetitionName")] Competitions competitions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(competitions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(competitions);
        }

        // GET: Competitions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competitions = await _context.Competitions.FindAsync(id);
            if (competitions == null)
            {
                return NotFound();
            }
            return View(competitions);
        }

        // POST: Competitions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompetitionID,CompetitionName")] Competitions competitions)
        {
            if (id != competitions.CompetitionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(competitions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompetitionsExists(competitions.CompetitionID))
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
            return View(competitions);
        }

        // GET: Competitions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competitions = await _context.Competitions
                .FirstOrDefaultAsync(m => m.CompetitionID == id);
            if (competitions == null)
            {
                return NotFound();
            }

            return View(competitions);
        }

        // POST: Competitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var competitions = await _context.Competitions.FindAsync(id);
            _context.Competitions.Remove(competitions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompetitionsExists(int id)
        {
            return _context.Competitions.Any(e => e.CompetitionID == id);
        }
    }
}
