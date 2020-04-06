using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SagTest.Data;
using SagTest.Models;

namespace SagTest.Controllers
{
    public class SagsController : Controller
    {
        private readonly MyDBContext _context;

        public SagsController(MyDBContext context)
        {
            _context = context;
        }

        // GET: Sags
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sag.ToListAsync());
        }

        // GET: Sags/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sag = await _context.Sag
                .FirstOrDefaultAsync(m => m.SubjectId == id);
            if (sag == null)
            {
                return NotFound();
            }

            return View(sag);
        }

        // GET: Sags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sags/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubjectId,Text,Subject,URLImage")] Sag sag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sag);
        }

        // GET: Sags/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sag = await _context.Sag.FindAsync(id);
            if (sag == null)
            {
                return NotFound();
            }
            return View(sag);
        }

        // POST: Sags/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SubjectId,Text,Subject,URLImage")] Sag sag)
        {
            if (id != sag.SubjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SagExists(sag.SubjectId))
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
            return View(sag);
        }

        // GET: Sags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sag = await _context.Sag
                .FirstOrDefaultAsync(m => m.SubjectId == id);
            if (sag == null)
            {
                return NotFound();
            }

            return View(sag);
        }

        // POST: Sags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sag = await _context.Sag.FindAsync(id);
            _context.Sag.Remove(sag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SagExists(int id)
        {
            return _context.Sag.Any(e => e.SubjectId == id);
        }
    }
}
