using Internship.Models;
using Microsoft.AspNetCore.Mvc;

namespace Internship.Controllers
{
    public class UserController : Controller
    {
        private readonly InternshipDbContext _context;

        public UserController(InternshipDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // Create, Edit, Details, Delete actions can be added here.
    }
}
