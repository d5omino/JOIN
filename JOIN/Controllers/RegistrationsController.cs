
using JOIN.Data;
using JOIN.Models;

using Microsoft.AspNetCore.Mvc;

namespace JOIN.Controllers
{
    public class RegistrationsController : Controller
    {
        public JoinDbContext _context;
        public string SaveSuccess { get; } = "Saved Successfully";


        public RegistrationsController(JoinDbContext context)
        {
            _context = context;
        }

        //Helper/Action methods

        [HttpPost]
        public IActionResult Index(string validemail)
        {

            Registration ValidRegistration = new Registration(validemail);




            return View(ValidRegistration);
        }

        public IActionResult Error()
        {

            return View();
        }



        public IActionResult Register(Registration ValidRegistration)
        {


            if (ModelState.IsValid)
            {
                _context.Add(ValidRegistration);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return Redirect("http://cucklist.com");
            }


        }



        ////Properties
        //private readonly JoinDbContext _context;
        ////Constructors
        //public RegistrationsController(JoinDbContext context)
        //{
        //    _context = context;
        //}

        //// GET List
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Registrations.ToListAsync());
        //}

        //// GET Detail
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var registration = await _context.Registrations
        //        .SingleOrDefaultAsync(m => m.Id == id);
        //    if (registration == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(registration);
        //}

        //// GET Create View
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST Create

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Owner")] Registration registration)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(registration);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(registration);
        //}

        //// GET Edit
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var registration = await _context.Registrations.SingleOrDefaultAsync(m => m.Id == id);
        //    if (registration == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(registration);
        //}

        //// POST Edit

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Owner")] Registration registration)
        //{
        //    if (id != registration.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(registration);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!RegistrationExists(registration.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(registration);
        //}

        //// GET Delete
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var registration = await _context.Registrations
        //        .SingleOrDefaultAsync(m => m.Id == id);
        //    if (registration == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(registration);
        //}

        //// POST Delete
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var registration = await _context.Registrations.SingleOrDefaultAsync(m => m.Id == id);
        //    _context.Registrations.Remove(registration);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool RegistrationExists(int id)
        //{
        //    return _context.Registrations.Any(e => e.Id == id);
        //}
    }


}
