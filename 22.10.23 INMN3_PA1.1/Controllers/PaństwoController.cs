using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _22._10._23_INMN3_PA1._1.Data;
using _22._10._23_INMN3_PA1._1.Models;

namespace _22._10._23_INMN3_PA1._1.Controllers
{
    public class PaństwoController : Controller
    {
        private readonly _22_10_23_INMN3_PA1_1Context _context;

        public PaństwoController(_22_10_23_INMN3_PA1_1Context context)
        {
            _context = context;
        }

        // GET: Państwo
        public async Task<IActionResult> Index()
        {
              return View(await _context.Państwa.ToListAsync());
        }

        // GET: Państwo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Państwa == null)
            {
                return NotFound();
            }

            var państwo = await _context.Państwa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (państwo == null)
            {
                return NotFound();
            }

            return View(państwo);
        }

        // GET: Państwo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Państwo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Id,Nazwa,Populacja,Powierzchnia,DataZałożenia,Stolica")]
            Państwo państwo
            )
        {
            if (ModelState.IsValid)
            {
                _context.Add(państwo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(państwo);
        }

        // GET: Państwo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Państwa == null)
            {
                return NotFound();
            }

            var państwo = await _context.Państwa.FindAsync(id);
            if (państwo == null)
            {
                return NotFound();
            }
            return View(państwo);
        }

        // POST: Państwo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            int id,
            [Bind("Id,Nazwa,Populacja,Powierzchnia,DataZałożenia,Stolica")]
            Państwo państwo
            )
        {
            if (id != państwo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(państwo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaństwoExists(państwo.Id))
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
            return View(państwo);
        }

        // GET: Państwo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Państwa == null)
            {
                return NotFound();
            }

            var państwo = await _context.Państwa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (państwo == null)
            {
                return NotFound();
            }

            return View(państwo);
        }

        // POST: Państwo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Państwa == null)
            {
                return Problem("Entity set '_22_10_23_INMN3_PA1_1Context.Państwo'  is null.");
            }
            var państwo = await _context.Państwa.FindAsync(id);
            if (państwo != null)
            {
                _context.Państwa.Remove(państwo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaństwoExists(int id)
        {
          return _context.Państwa.Any(e => e.Id == id);
        }
    }
}
