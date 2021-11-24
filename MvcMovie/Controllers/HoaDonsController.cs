using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HoaDonsController : Controller
    {
        private readonly MvcMovieContext _context;

        public HoaDonsController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: HoaDons
        public async Task<IActionResult> Index()
        {
            var mvcMovieContext = _context.HoaDon.Include(h => h.KhachHang);
            return View(await mvcMovieContext.ToListAsync());
        }

        // GET: HoaDons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDon
                .Include(h => h.KhachHang)
                .FirstOrDefaultAsync(m => m.HoaDonID == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // GET: HoaDons/Create
        public IActionResult Create()
        {
            ViewData["KhachHangID"] = new SelectList(_context.KhachHang, "KhachHangID", "KhachHangID");
            return View();
        }

        // POST: HoaDons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HoaDonID,KhachHangID,NgayTao")] HoaDon hoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KhachHangID"] = new SelectList(_context.KhachHang, "KhachHangID", "KhachHangID", hoaDon.KhachHangID);
            return View(hoaDon);
        }

        // GET: HoaDons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDon.FindAsync(id);
            if (hoaDon == null)
            {
                return NotFound();
            }
            ViewData["KhachHangID"] = new SelectList(_context.KhachHang, "KhachHangID", "KhachHangID", hoaDon.KhachHangID);
            return View(hoaDon);
        }

        // POST: HoaDons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HoaDonID,KhachHangID,NgayTao")] HoaDon hoaDon)
        {
            if (id != hoaDon.HoaDonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonExists(hoaDon.HoaDonID))
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
            ViewData["KhachHangID"] = new SelectList(_context.KhachHang, "KhachHangID", "KhachHangID", hoaDon.KhachHangID);
            return View(hoaDon);
        }

        // GET: HoaDons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDon
                .Include(h => h.KhachHang)
                .FirstOrDefaultAsync(m => m.HoaDonID == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // POST: HoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hoaDon = await _context.HoaDon.FindAsync(id);
            _context.HoaDon.Remove(hoaDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoaDonExists(int id)
        {
            return _context.HoaDon.Any(e => e.HoaDonID == id);
        }
    }
}
