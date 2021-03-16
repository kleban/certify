using Certify.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certify.Repositories
{
    public class CourseRepository
    {
        private readonly CertifyDbContext _ctx;

        public CourseRepository(CertifyDbContext ctx)
        {
            _ctx = ctx;
        }

        public bool Any()
        {
            return _ctx.Courses.Any();
        }

        public async Task<int> CreateAsync(Course course, string userName)
        {
            course.Owner = _ctx.Users.First(x => x.UserName == userName);
            var newCourse = await _ctx.Courses.AddAsync(course);
            await _ctx.SaveChangesAsync();

            return newCourse.Entity.Id;
        }
    }
}
