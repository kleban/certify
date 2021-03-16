using Certify.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Certify.WebApp.Controllers
{
    [Authorize(Roles = "Teacher")]
    public class CourseController : Controller
    {
        private readonly CourseRepository _courseRepository;

        public CourseController(CourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _courseRepository.GetMyCoursesAsync(User.Identity.Name));
        }
    }
}
