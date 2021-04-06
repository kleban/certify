using Certify.Core;
using Certify.Repositories;
using Certify.Repositories.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Certify.WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class InitController : Controller
    {
        private readonly CourseRepository _courseRepository;
        private readonly CertificateRepository _certificateRepository;
        public InitController(CourseRepository courseRepository, CertificateRepository certificateRepository)
        {
            _courseRepository = courseRepository;
            _certificateRepository = certificateRepository;
        }

        public async Task<IActionResult> Do()
        {
          //  if (!_courseRepository.Any())
          //  {
                var courseId = await _courseRepository.CreateAsync(
                    new Course { 
                        Title = "Тестовий курс №1",
                        Description = "Тестовий курс для демонстрації",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(-42)                        
                    },
                    User.Identity.Name);

                await _certificateRepository.CreateAsync(
                    new Certificate
                    {
                        Id = CertificateDefaultIdGenerator.Generate(await _courseRepository.GetCourseAsync(courseId, User.Identity.Name), 0),
                        StudentFirstName = "Іван",
                        StudentLastName = "Іванов",
                        ImagePath = "wwwroot/certificates/initial.png",                        
                    }, courseId);

                await _certificateRepository.CreateAsync(
                  new Certificate
                  {
                      Id = CertificateDefaultIdGenerator.Generate(await _courseRepository.GetCourseAsync(courseId, User.Identity.Name), 1),
                      StudentFirstName = "Іван",
                      StudentLastName = "Іванов2",
                      ImagePath = "wwwroot/certificates/initial.png",
                  }, courseId);

           // }
            return Ok();
        }
    }
}
