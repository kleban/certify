using Certify.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Certify.WebApp.Controllers
{
    [Authorize(Roles = "Admin, Teacher")]
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;
        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _userRepository.GetUsersListAsync());
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Roles = await _userRepository.GetRolesListAsync();
            return View();
        }
    }
}
