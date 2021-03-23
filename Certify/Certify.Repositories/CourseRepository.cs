using Certify.Core;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Course> GetFullCourseAsync(int id, string userName)
        {
            if (await _accessAllowed(id, userName))
            {
                return await _ctx.Courses.Include(x=> x.Certifictes).Include(x => x.Owner).FirstAsync(x => x.Id == id);
            }

            throw new NotImplementedException(); // переписати
        }

        public async Task<List<Course>> GetMyCoursesAsync(string userName)
        {
            return await _ctx.Courses.Include(x=> x.Certifictes).Where(x => x.Owner.UserName == userName).ToListAsync();
        }

        public async Task<Course> GetCourseAsync(int courseId, string userName)
        {
            if(await _accessAllowed(courseId, userName))
            {
                return await _ctx.Courses.Include(x => x.Owner).FirstAsync(x => x.Id == courseId);
            }

            throw new NotImplementedException(); // переписати
        }

        public async Task<bool> _accessAllowed(int courseId, string userName)
        {
            return await _ctx.Courses.FirstOrDefaultAsync(x => x.Owner.UserName == userName && x.Id == courseId) != null;
        }
    }
}
