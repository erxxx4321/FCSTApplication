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
    public class CoalDatasController : Controller
    {
        private readonly FCSTApplicationContext _context;

        public CoalDatasController(FCSTApplicationContext context)
        {
            _context = context;
        }

        // GET: CoalDatas
        public async Task<IActionResult> Index()
        {
            return View(await _context.CoalData.ToListAsync());
        }

        // GET: CoalDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coalData = await _context.CoalData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coalData == null)
            {
                return NotFound();
            }

            return View(coalData);
        }

        // GET: CoalDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CoalDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Week,Date,CoalPrice_5800,CoalPrice_5500,CoalPrice_5000,SpotPrice_5500,BohaiInventory,PortChinInventory,DeliveryFee,NewcPrice")] CoalData coalData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coalData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coalData);
        }

        // GET: CoalDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coalData = await _context.CoalData.FindAsync(id);
            if (coalData == null)
            {
                return NotFound();
            }
            return View(coalData);
        }

        // POST: CoalDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Week,Date,CoalPrice_5800,CoalPrice_5500,CoalPrice_5000,SpotPrice_5500,BohaiInventory,PortChinInventory,DeliveryFee,NewcPrice")] CoalData coalData)
        {
            if (id != coalData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coalData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoalDataExists(coalData.Id))
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
            return View(coalData);
        }

        // GET: CoalDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coalData = await _context.CoalData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coalData == null)
            {
                return NotFound();
            }

            return View(coalData);
        }

        // POST: CoalDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coalData = await _context.CoalData.FindAsync(id);
            _context.CoalData.Remove(coalData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoalDataExists(int id)
        {
            return _context.CoalData.Any(e => e.Id == id);
        }
    }
}
