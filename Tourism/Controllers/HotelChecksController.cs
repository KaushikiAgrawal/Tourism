using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tourism.Models;

namespace Tourism.Controllers
{
    public class HotelChecksController : Controller
    {
        private readonly HotelCheckContext _context;

        public HotelChecksController(HotelCheckContext context)
        {
            _context = context;
        }

        // GET: HotelChecks
        public async Task<IActionResult> Index()
        {
            return View(await _context.HotelChecks.ToListAsync());
        }

        // GET: HotelChecks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelCheck = await _context.HotelChecks
                .FirstOrDefaultAsync(m => m.HotelId == id);
            if (hotelCheck == null)
            {
                return NotFound();
            }

            return View(hotelCheck);
        }

        // GET: HotelChecks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HotelChecks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HotelId,HotelName,Star,HotelLocation")] HotelCheck hotelCheck)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hotelCheck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hotelCheck);
        }

        // GET: HotelChecks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelCheck = await _context.HotelChecks.FindAsync(id);
            if (hotelCheck == null)
            {
                return NotFound();
            }
            return View(hotelCheck);
        }

        // POST: HotelChecks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HotelId,HotelName,Star,HotelLocation")] HotelCheck hotelCheck)
        {
            if (id != hotelCheck.HotelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hotelCheck);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelCheckExists(hotelCheck.HotelId))
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
            return View(hotelCheck);
        }

        // GET: HotelChecks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelCheck = await _context.HotelChecks
                .FirstOrDefaultAsync(m => m.HotelId == id);
            if (hotelCheck == null)
            {
                return NotFound();
            }

            return View(hotelCheck);
        }

        // POST: HotelChecks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hotelCheck = await _context.HotelChecks.FindAsync(id);
            _context.HotelChecks.Remove(hotelCheck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HotelCheckExists(int id)
        {
            return _context.HotelChecks.Any(e => e.HotelId == id);
        }
    }
}
