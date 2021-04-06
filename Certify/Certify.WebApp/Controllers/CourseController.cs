using Certify.Core;
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

        public async Task<IActionResult> Index(string view = "table")
        {
            view = view.Trim().ToLower();

            if(view == "card")
                return View("CardView", await _courseRepository.GetMyCoursesAsync(User.Identity.Name));

            return View(await _courseRepository.GetMyCoursesAsync(User.Identity.Name));
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Course model)
        {
            if(ModelState.IsValid)
            {
                var courseId = await _courseRepository.CreateAsync(model, User.Identity.Name);
                return RedirectToAction("Details", new { id = courseId });
            }

            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await _courseRepository.GetCourseAsync(id, User.Identity.Name));
        }
    }
}
