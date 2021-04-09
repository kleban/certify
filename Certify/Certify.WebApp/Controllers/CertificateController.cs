using Certify.Core;
using Certify.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Certify.WebApp.Controllers
{
    public class CertificateController : Controller
    {
        private readonly CertificateRepository _certificateRepository;
        private readonly CourseRepository _courseRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CertificateController(
            CertificateRepository certificateRepository,
            CourseRepository courseRepository,
             IWebHostEnvironment webHostEnvironment)
        {
            _certificateRepository = certificateRepository;
            _courseRepository = courseRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index(int id)
        {
            var course = await _courseRepository.GetFullCourseAsync(id, User.Identity.Name);
            return View(course);
        }

        public async Task<IActionResult> Add()
        {
            ViewBag.Courses = await _courseRepository.GetMyCoursesAsync(User.Identity.Name);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Certificate model, int courseId)
        {
            if(ModelState.IsValid)
            {
                await _certificateRepository.CreateAsync(model, courseId);
            }
            return RedirectToAction("Details", "Course", new { id = courseId });
        }

        [HttpGet]
        public async Task<IActionResult> Image(string id)
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            var imagePath = Path.Combine(webRootPath, "certificates", (await _certificateRepository.GetAsync(id)).ImagePath);

            var provider = new FileExtensionContentTypeProvider();
            string contentType;
            if (!provider.TryGetContentType(imagePath, out contentType))
            {
                contentType = "application/octet-stream";
            }            

            return File(await System.IO.File.ReadAllBytesAsync(imagePath), contentType);
        }
    }
}
