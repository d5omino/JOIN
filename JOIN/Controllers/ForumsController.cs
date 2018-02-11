using JOIN.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Linq;
using System.Threading.Tasks;

namespace JOIN.Controllers
{
    [Authorize]
    public class ForumsController : Controller
    {
        private readonly ForumsDbContext _context;

        public ForumsController(ForumsDbContext context) => _context = context;

        protected ForumsController()
        {
        }

        // GET: Forums


        [AllowAnonymous]
        public async Task<IActionResult> Index() => View(await _context.Forums.ToListAsync());

        // GET: Forums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var forums = await _context.Forums
                .SingleOrDefaultAsync(m => m.Id == id);
            if (forums == null)
            {
                return NotFound();
            }

            return View(forums);
        }

        // GET: Forums/Create
        public IActionResult Create() => View();

        // POST: Forums/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Url,Topic")] Forums forums)
        {
            if (ModelState.IsValid)
            {
                _context.Add(forums);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(forums);
        }

        // GET: Forums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var forums = await _context.Forums.SingleOrDefaultAsync(m => m.Id == id);
            if (forums == null)
            {
                return NotFound();
            }
            return View(forums);
        }

        // POST: Forums/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Url,Topic")] Forums forums)
        {
            if (id != forums.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(forums);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ForumsExists(forums.Id))
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
            return View(forums);
        }

        // GET: Forums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var forums = await _context.Forums
                .SingleOrDefaultAsync(m => m.Id == id);
            if (forums == null)
            {
                return NotFound();
            }

            return View(forums);
        }

        // POST: Forums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var forums = await _context.Forums.SingleOrDefaultAsync(m => m.Id == id);
            _context.Forums.Remove(forums);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ForumsExists(int id) => _context.Forums.Any(e => e.Id == id);
    }
}
