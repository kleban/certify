using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certify.Core
{
    public class User : IdentityUser
    {
        public ICollection<Course> CoursesCreated { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
    }
}
