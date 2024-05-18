using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rexpresso_2.Models;
using Rexpresso_2.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Rexpresso_2.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult UsersList()
        {
            var users = _userManager.Users.ToList();
            var viewModel = new UserListViewModel
            {
                Users = users
            };
            return View(viewModel);
        }
    }
}
