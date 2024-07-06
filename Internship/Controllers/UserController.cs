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
            return View(_context.users.ToList());
        }

        // Create, Edit, Details, Delete 

    }
}
