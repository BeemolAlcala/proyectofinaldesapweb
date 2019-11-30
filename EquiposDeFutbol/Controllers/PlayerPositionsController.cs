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
    public class PlayerPositionsController : Controller
    {
        private readonly EquiposDeFutbolContext _context;

        public PlayerPositionsController(EquiposDeFutbolContext context)
        {
            _context = context;
        }

        // GET: PlayerPositions
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlayerPositions.ToListAsync());
        }

        // GET: PlayerPositions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerPositions = await _context.PlayerPositions
                .FirstOrDefaultAsync(m => m.PositionID == id);
            if (playerPositions == null)
            {
                return NotFound();
            }

            return View(playerPositions);
        }

        // GET: PlayerPositions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlayerPositions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PositionID,PositionDescription")] PlayerPositions playerPositions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(playerPositions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(playerPositions);
        }

        // GET: PlayerPositions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerPositions = await _context.PlayerPositions.FindAsync(id);
            if (playerPositions == null)
            {
                return NotFound();
            }
            return View(playerPositions);
        }

        // POST: PlayerPositions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PositionID,PositionDescription")] PlayerPositions playerPositions)
        {
            if (id != playerPositions.PositionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playerPositions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerPositionsExists(playerPositions.PositionID))
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
            return View(playerPositions);
        }

        // GET: PlayerPositions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playerPositions = await _context.PlayerPositions
                .FirstOrDefaultAsync(m => m.PositionID == id);
            if (playerPositions == null)
            {
                return NotFound();
            }

            return View(playerPositions);
        }

        // POST: PlayerPositions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var playerPositions = await _context.PlayerPositions.FindAsync(id);
            _context.PlayerPositions.Remove(playerPositions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerPositionsExists(int id)
        {
            return _context.PlayerPositions.Any(e => e.PositionID == id);
        }
    }
}
