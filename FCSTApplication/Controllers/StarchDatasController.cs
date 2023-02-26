using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FCSTApplication.Data;
using FCSTApplication.Models;

namespace FCSTApplication.Controllers
{
    public class StarchDatasController : Controller
    {
        private readonly FCSTApplicationContext _context;

        public StarchDatasController(FCSTApplicationContext context)
        {
            _context = context;
        }

        // GET: StarchDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.StarchData.ToListAsync());
        }

        // GET: StarchDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var starchData = await _context.StarchData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (starchData == null)
            {
                return NotFound();
            }

            return View(starchData);
        }

        // GET: StarchDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StarchDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Week,Date,ChinaShandongPrice,ThaiPrice,CornPrice,WheatPrice")] StarchData starchData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(starchData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(starchData);
        }

        // GET: StarchDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var starchData = await _context.StarchData.FindAsync(id);
            if (starchData == null)
            {
                return NotFound();
            }
            return View(starchData);
        }

        // POST: StarchDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Week,Date,ChinaShandongPrice,ThaiPrice,CornPrice,WheatPrice")] StarchData starchData)
        {
            if (id != starchData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(starchData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StarchDataExists(starchData.Id))
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
            return View(starchData);
        }

        // GET: StarchDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var starchData = await _context.StarchData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (starchData == null)
            {
                return NotFound();
            }

            return View(starchData);
        }

        // POST: StarchDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var starchData = await _context.StarchData.FindAsync(id);
            _context.StarchData.Remove(starchData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StarchDataExists(int id)
        {
            return _context.StarchData.Any(e => e.Id == id);
        }
    }
}
