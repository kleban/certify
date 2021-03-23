using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certify.Core
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Назва курсу")]
        [Required(ErrorMessage = "Це поле обов'язкове")]
        public string Title { get; set; }

        [Display(Name = "Опис курсу")]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public User Owner { get; set; }
        public virtual ICollection<Certificate> Certifictes { get; set; }

        [NotMapped]
        public int CertificatesCount
        {
            get { return (Certifictes??new List<Certificate>()).Count; }
        }
    }
}
