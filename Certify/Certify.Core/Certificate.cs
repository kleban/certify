using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certify.Core
{
    public class Certificate
    {
        [Key]
        public string  Id { get; set; }

        public Course Course { get; set; }

        public User Student { get; set; }

    }
}
