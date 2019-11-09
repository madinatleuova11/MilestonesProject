using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CardListController : Controller
    {
        private readonly StoreContext _context;

        public CardListController(StoreContext context)
        {
            _context = context;
        }

        // GET: CardList
        public async Task<IActionResult> Index()
        {
            return View(await _context.DiscountCard.ToListAsync());
        }

        // GET: CardList/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var discountCard = await _context.DiscountCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (discountCard == null)
            {
                return NotFound();
            }

            return View(discountCard);
        }

        // GET: CardList/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CardList/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,type")] DiscountCard discountCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(discountCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(discountCard);
        }

        // GET: CardList/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var discountCard = await _context.DiscountCard.FindAsync(id);
            if (discountCard == null)
            {
                return NotFound();
            }
            return View(discountCard);
        }

        // POST: CardList/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,type")] DiscountCard discountCard)
        {
            if (id != discountCard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(discountCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiscountCardExists(discountCard.Id))
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
            return View(discountCard);
        }

        // GET: CardList/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var discountCard = await _context.DiscountCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (discountCard == null)
            {
                return NotFound();
            }

            return View(discountCard);
        }

        // POST: CardList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var discountCard = await _context.DiscountCard.FindAsync(id);
            _context.DiscountCard.Remove(discountCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiscountCardExists(int id)
        {
            return _context.DiscountCard.Any(e => e.Id == id);
        }
    }
}
