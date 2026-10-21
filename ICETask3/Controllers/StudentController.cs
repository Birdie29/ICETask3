using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ICETask3.Models;
using ICETask3.Data;
namespace ICETask3.Controllers
{
    public class StudentController : Controller
    {

        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var student = await _context.Student.ToListAsync();
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}
