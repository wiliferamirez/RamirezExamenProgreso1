using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RamirezExamenProgreso1.Data;
using RamirezExamenProgreso1.Models;

namespace RamirezExamenProgreso1.Controllers
{
    public class PlanRecompensasController : Controller
    {
        private readonly RamirezExamenProgreso1Context _context;

        public PlanRecompensasController(RamirezExamenProgreso1Context context)
        {
            _context = context;
        }

        // GET: PlanRecompensas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Planrecompensa.ToListAsync());
        }

        // GET: PlanRecompensas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planRecompensas = await _context.Planrecompensa
                .FirstOrDefaultAsync(m => m.RecompensasId == id);
            if (planRecompensas == null)
            {
                return NotFound();
            }

            return View(planRecompensas);
        }

        // GET: PlanRecompensas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlanRecompensas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RecompensasId,NombreRecompensa,PuntosRecompensa")] PlanRecompensas planRecompensas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planRecompensas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planRecompensas);
        }

        // GET: PlanRecompensas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planRecompensas = await _context.Planrecompensa.FindAsync(id);
            if (planRecompensas == null)
            {
                return NotFound();
            }
            return View(planRecompensas);
        }

        // POST: PlanRecompensas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RecompensasId,NombreRecompensa,PuntosRecompensa")] PlanRecompensas planRecompensas)
        {
            if (id != planRecompensas.RecompensasId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planRecompensas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanRecompensasExists(planRecompensas.RecompensasId))
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
            return View(planRecompensas);
        }

        // GET: PlanRecompensas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planRecompensas = await _context.Planrecompensa
                .FirstOrDefaultAsync(m => m.RecompensasId == id);
            if (planRecompensas == null)
            {
                return NotFound();
            }

            return View(planRecompensas);
        }

        // POST: PlanRecompensas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planRecompensas = await _context.Planrecompensa.FindAsync(id);
            if (planRecompensas != null)
            {
                _context.Planrecompensa.Remove(planRecompensas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanRecompensasExists(int id)
        {
            return _context.Planrecompensa.Any(e => e.RecompensasId == id);
        }
    }
}
