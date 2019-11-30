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
    public class PlayerFixturesController : Controller
    {
        private readonly EquiposDeFutbolContext _context;

        public PlayerFixturesController(EquiposDeFutbolContext context)
        {
            _context = context;
        }

        // GET: PlayerFixtures
        public async Task<IActionResult> Index()
        {
            var equiposDeFutbolContext = _context.PlayerFixtures.Include(p => p.Fixture).Include(p => p.Player);
            return View(await equiposDeFutbolContext.ToListAsync());
        }

        // GET: PlayerFixtures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerFixtures = await _context.PlayerFixtures
                .Include(p => p.Fixture)
                .Include(p => p.Player)
                .FirstOrDefaultAsync(m => m.FixtureID == id);
            if (playerFixtures == null)
            {
                return NotFound();
            }

            return View(playerFixtures);
        }

        // GET: PlayerFixtures/Create
        public IActionResult Create()
        {
            ViewData["FixtureID"] = new SelectList(_context.Fixtures, "FixtureID", "FixtureID");
            ViewData["PlayerID"] = new SelectList(_context.Players, "PlayerID", "PlayerID");
            return View();
        }

        // POST: PlayerFixtures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FixtureID,PlayerID,GoalsScoredID")] PlayerFixtures playerFixtures)
        {
            if (ModelState.IsValid)
            {
                _context.Add(playerFixtures);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FixtureID"] = new SelectList(_context.Fixtures, "FixtureID", "FixtureID", playerFixtures.FixtureID);
            ViewData["PlayerID"] = new SelectList(_context.Players, "PlayerID", "PlayerID", playerFixtures.PlayerID);
            return View(playerFixtures);
        }

        // GET: PlayerFixtures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerFixtures = await _context.PlayerFixtures.FindAsync(id);
            if (playerFixtures == null)
            {
                return NotFound();
            }
            ViewData["FixtureID"] = new SelectList(_context.Fixtures, "FixtureID", "FixtureID", playerFixtures.FixtureID);
            ViewData["PlayerID"] = new SelectList(_context.Players, "PlayerID", "PlayerID", playerFixtures.PlayerID);
            return View(playerFixtures);
        }

        // POST: PlayerFixtures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FixtureID,PlayerID,GoalsScoredID")] PlayerFixtures playerFixtures)
        {
            if (id != playerFixtures.FixtureID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playerFixtures);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerFixturesExists(playerFixtures.FixtureID))
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
            ViewData["FixtureID"] = new SelectList(_context.Fixtures, "FixtureID", "FixtureID", playerFixtures.FixtureID);
            ViewData["PlayerID"] = new SelectList(_context.Players, "PlayerID", "PlayerID", playerFixtures.PlayerID);
            return View(playerFixtures);
        }

        // GET: PlayerFixtures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerFixtures = await _context.PlayerFixtures
                .Include(p => p.Fixture)
                .Include(p => p.Player)
                .FirstOrDefaultAsync(m => m.FixtureID == id);
            if (playerFixtures == null)
            {
                return NotFound();
            }

            return View(playerFixtures);
        }

        // POST: PlayerFixtures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var playerFixtures = await _context.PlayerFixtures.FindAsync(id);
            _context.PlayerFixtures.Remove(playerFixtures);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerFixturesExists(int id)
        {
            return _context.PlayerFixtures.Any(e => e.FixtureID == id);
        }
    }
}
