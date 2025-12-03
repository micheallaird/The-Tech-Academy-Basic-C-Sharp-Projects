using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CarInsurance.Data;
using System.Linq;

namespace CarInsurance.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly InsureeData _context;

        public AdminController(InsureeData context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public IActionResult UserDetails(int id)
        {
            var user = GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
    }

    public class ApplicationDbContext
    {
        public IQueryable<User> Users { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
