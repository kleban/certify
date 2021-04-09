using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certify.Core
{
    public class Certificate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public Course Course { get; set; }
        public User Student { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }

        [NotMapped]
        public bool HasAccount
        {
            get
            {
                return Student != null;
            }
        }
        public string ImagePath { get; set; }

    }
}
