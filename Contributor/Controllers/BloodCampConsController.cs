using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Contributor.Data;
using Contributor.Models;

namespace Contributor.Controllers
{
    public class BloodCampConsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BloodCampConsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BloodCampCons
        public async Task<IActionResult> Index()
        {
              return _context.BloodCampCon != null ? 
                          View(await _context.BloodCampCon.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.BloodCampCon'  is null.");
        }

        // GET: BloodCampCons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BloodCampCon == null)
            {
                return NotFound();
            }

            var bloodCampCon = await _context.BloodCampCon
                .FirstOrDefaultAsync(m => m.Camp_ID == id);
            if (bloodCampCon == null)
            {
                return NotFound();
            }

            return View(bloodCampCon);
        }

        // GET: BloodCampCons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BloodCampCons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Camp_ID,Date,StartTime,EndTime,Location,Coordinator,Organization")] BloodCampCon bloodCampCon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bloodCampCon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bloodCampCon);
        }

        // GET: BloodCampCons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BloodCampCon == null)
            {
                return NotFound();
            }

            var bloodCampCon = await _context.BloodCampCon.FindAsync(id);
            if (bloodCampCon == null)
            {
                return NotFound();
            }
            return View(bloodCampCon);
        }

        // POST: BloodCampCons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Camp_ID,Date,StartTime,EndTime,Location,Coordinator,Organization")] BloodCampCon bloodCampCon)
        {
            if (id != bloodCampCon.Camp_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bloodCampCon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BloodCampConExists(bloodCampCon.Camp_ID))
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
            return View(bloodCampCon);
        }

        // GET: BloodCampCons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BloodCampCon == null)
            {
                return NotFound();
            }

            var bloodCampCon = await _context.BloodCampCon
                .FirstOrDefaultAsync(m => m.Camp_ID == id);
            if (bloodCampCon == null)
            {
                return NotFound();
            }

            return View(bloodCampCon);
        }

        // POST: BloodCampCons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BloodCampCon == null)
            {
                return Problem("Entity set 'ApplicationDbContext.BloodCampCon'  is null.");
            }
            var bloodCampCon = await _context.BloodCampCon.FindAsync(id);
            if (bloodCampCon != null)
            {
                _context.BloodCampCon.Remove(bloodCampCon);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BloodCampConExists(int id)
        {
          return (_context.BloodCampCon?.Any(e => e.Camp_ID == id)).GetValueOrDefault();
        }
    }
}
