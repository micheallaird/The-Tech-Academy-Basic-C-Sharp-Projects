using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private readonly InsureeContext _context;

        public InsureesController(InsureeContext context)
        {
            _context = context;
        }

        // GET: Insurees
        public async Task<IActionResult> Admin()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        // GET: Insurees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insurees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Admin));
            }
            return View(insuree);
        }

        // GET: Insurees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    insuree.Quote = CalculateQuote(insuree);
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Admin));
            }
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree != null)
            {
                _context.Insurees.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Admin));
        }

        private bool InsureeExists(int id)
        {
            return _context.Insurees.Any(e => e.Id == id);
        }
        // Adds logic to calculate insurance quotes based on these guidelines:
        // - Start with a base monthly rate of $50.
        // - If the user is under 18, add $100 to the monthly total.
        // - If the user is between 18 and 25, add $50 to the monthly total.
        // - If the user is over 25, add $25 to the monthly total.
        // - If the car's year is before 2000, add $25 to the monthly total.
        // - If the car's year is after 2015, add $25 to the monthly total.
        // - If the car's make is a "Porsche", add $25 to the monthly total.
        // - If the car's make is a "Porsche" and the model is a "911 Carrera", add an additional $25 to the monthly total.
        // - Add $10 to the monthly total for every speeding ticket the user has.
        // - If the user has ever had a DUI, increase the total by 25%.
        // - If the user wants full coverage, increase the total by 50%.
        private decimal CalculateQuote(Insuree insuree)
        {
            decimal quote = 50m;
            var today = DateOnly.FromDateTime(DateTime.Today);
            int age = today.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth > today.AddYears(-age)) age--;
            if (age < 18)
            {
                quote += 100m;
            }
            else if (age >= 18 && age <= 25)
            {
                quote += 50m;
            }
            else
            {
                quote += 25m;
            }
            if (insuree.CarYear < 2000)
            {
                quote += 25m;
            }
            else if (insuree.CarYear > 2015)
            {
                quote += 25m;
            }
            if (insuree.CarMake.ToLower() == "porsche")
            {
                quote += 25m;
                if (insuree.CarModel.ToLower() == "911 carrera")
                {
                    quote += 25m;
                }
            }
            quote += insuree.SpeedingTickets * 10m;
            if (insuree.DUI)
            {
                quote *= 1.25m;
            }
            if (!string.IsNullOrEmpty(insuree.CoverageType) && insuree.CoverageType.ToLower() == "full")
            {
                quote *= 1.5m;
            }
            return quote;
        }
    }
}
