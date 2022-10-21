using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AUT02_04_DiscosNET.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _user;
        public UserController(UserManager<IdentityUser> users)
        {
            _user = users;
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var usuarios = await _user.Users.ToListAsync();
            return View(usuarios);
        }
    }
}
