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
    public class FixturesController : Controller
    {
        private readonly EquiposDeFutbolContext _context;

        public FixturesController(EquiposDeFutbolContext context)
        {
            _context = context;
        }

        // GET: Fixtures
        public async Task<IActionResult> Index()
        {
            var equiposDeFutbolContext = _context.Fixtures.Include(f => f.Competition);
            return View(await equiposDeFutbolContext.ToListAsync());
        }

        // GET: Fixtures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fixtures = await _context.Fixtures
                .Include(f => f.Competition)
                .FirstOrDefaultAsync(m => m.FixtureID == id);
            if (fixtures == null)
            {
                return NotFound();
            }

            return View(fixtures);
        }

        // GET: Fixtures/Create
        public IActionResult Create()
        {
            ViewData["CompetitionID"] = new SelectList(_context.Competitions, "CompetitionID", "CompetitionName");
            return View();
        }

        // POST: Fixtures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FixtureID,FixtureDate,FixtureTime,HomeTeamID,AwayTeamID,CompetitionID")] Fixtures fixtures)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fixtures);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompetitionID"] = new SelectList(_context.Competitions, "CompetitionID", "CompetitionName", fixtures.CompetitionID);
            return View(fixtures);
        }

        // GET: Fixtures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fixtures = await _context.Fixtures.FindAsync(id);
            if (fixtures == null)
            {
                return NotFound();
            }
            ViewData["CompetitionID"] = new SelectList(_context.Competitions, "CompetitionID", "CompetitionName", fixtures.CompetitionID);
            return View(fixtures);
        }

        // POST: Fixtures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FixtureID,FixtureDate,FixtureTime,HomeTeamID,AwayTeamID,CompetitionID")] Fixtures fixtures)
        {
            if (id != fixtures.FixtureID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fixtures);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FixturesExists(fixtures.FixtureID))
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
            ViewData["CompetitionID"] = new SelectList(_context.Competitions, "CompetitionID", "CompetitionName", fixtures.CompetitionID);
            return View(fixtures);
        }

        // GET: Fixtures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fixtures = await _context.Fixtures
                .Include(f => f.Competition)
                .FirstOrDefaultAsync(m => m.FixtureID == id);
            if (fixtures == null)
            {
                return NotFound();
            }

            return View(fixtures);
        }

        // POST: Fixtures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fixtures = await _context.Fixtures.FindAsync(id);
            _context.Fixtures.Remove(fixtures);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FixturesExists(int id)
        {
            return _context.Fixtures.Any(e => e.FixtureID == id);
        }
    }
}
