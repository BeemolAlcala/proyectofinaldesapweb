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
    public class PlayersController : Controller
    {
        private readonly EquiposDeFutbolContext _context;

        public PlayersController(EquiposDeFutbolContext context)
        {
            _context = context;
        }

        // GET: Players
        public async Task<IActionResult> Index()
        {
            var equiposDeFutbolContext = _context.Players.Include(p => p.PlayerPosition).Include(p => p.Team);
            return View(await equiposDeFutbolContext.ToListAsync());
        }

        // GET: Players/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var players = await _context.Players
                .Include(p => p.PlayerPosition)
                .Include(p => p.Team)
                .FirstOrDefaultAsync(m => m.PlayerID == id);
            if (players == null)
            {
                return NotFound();
            }

            return View(players);
        }

        // GET: Players/Create
        public IActionResult Create()
        {
            ViewData["PositionID"] = new SelectList(_context.PlayerPositions, "PositionID", "PositionID");
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamName");
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlayerID,TeamID,PlayerName,PlayerSquadNumber,PositionID")] Players players)
        {
            if (ModelState.IsValid)
            {
                _context.Add(players);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PositionID"] = new SelectList(_context.PlayerPositions, "PositionID", "PositionID", players.PositionID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamName", players.TeamID);
            return View(players);
        }

        // GET: Players/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var players = await _context.Players.FindAsync(id);
            if (players == null)
            {
                return NotFound();
            }
            ViewData["PositionID"] = new SelectList(_context.PlayerPositions, "PositionID", "PositionID", players.PositionID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamName", players.TeamID);
            return View(players);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlayerID,TeamID,PlayerName,PlayerSquadNumber,PositionID")] Players players)
        {
            if (id != players.PlayerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(players);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayersExists(players.PlayerID))
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
            ViewData["PositionID"] = new SelectList(_context.PlayerPositions, "PositionID", "PositionID", players.PositionID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamName", players.TeamID);
            return View(players);
        }

        // GET: Players/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var players = await _context.Players
                .Include(p => p.PlayerPosition)
                .Include(p => p.Team)
                .FirstOrDefaultAsync(m => m.PlayerID == id);
            if (players == null)
            {
                return NotFound();
            }

            return View(players);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var players = await _context.Players.FindAsync(id);
            _context.Players.Remove(players);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayersExists(int id)
        {
            return _context.Players.Any(e => e.PlayerID == id);
        }
    }
}
