using AUT02_04_DiscosNET.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AUT02_04_DiscosNET.Controllers
{
    public class UserController : Controller
    {
        private readonly ChinookContext _context;
        public UserController(ChinookContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var usuarios = await _context.Users.ToListAsync();
            return View(usuarios);
        }
    }
}
