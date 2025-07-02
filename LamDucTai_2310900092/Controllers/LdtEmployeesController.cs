// Controller: LdtEmployeesController.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LamDucTai_2310900092.Models;

namespace LamDucTai_2310900092.Controllers
{
    public class LdtEmployeesController : Controller
    {
        private readonly LamDucTai2310900092Context _context;

        public LdtEmployeesController(LamDucTai2310900092Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> LdtIndex()
        {
            return View(await _context.LdtEmployees.ToListAsync());
        }

        public async Task<IActionResult> LdtDetails(int? LdtId)
        {
            if (LdtId == null) return NotFound();
            var emp = await _context.LdtEmployees.FirstOrDefaultAsync(m => m.LdtEmpId == LdtId);
            return emp == null ? NotFound() : View(emp);
        }

        public IActionResult LdtCreate() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LdtCreate(LdtEmployee emp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(LdtIndex));
            }
            return View(emp);
        }

        public async Task<IActionResult> LdtEdit(int? LdtId)
        {
            if (LdtId == null) return NotFound();
            var emp = await _context.LdtEmployees.FindAsync(LdtId);
            return emp == null ? NotFound() : View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LdtEdit(int LdtId, LdtEmployee emp)
        {
            if (LdtId != emp.LdtEmpId) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.LdtEmployees.Any(e => e.LdtEmpId == emp.LdtEmpId))
                        return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(LdtIndex));
            }
            return View(emp);
        }

        public async Task<IActionResult> LdtDelete(int? LdtId)
        {
            if (LdtId == null) return NotFound();
            var emp = await _context.LdtEmployees.FirstOrDefaultAsync(m => m.LdtEmpId == LdtId);
            return emp == null ? NotFound() : View(emp);
        }

        [HttpPost, ActionName("LdtDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LdtDeleteConfirmed(int LdtId)
        {
            var emp = await _context.LdtEmployees.FindAsync(LdtId);
            if (emp != null)
            {
                _context.LdtEmployees.Remove(emp);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(LdtIndex));
        }
    }
}