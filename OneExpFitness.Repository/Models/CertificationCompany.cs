using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace OneExpFitness.Repository.Models
{
    public class CertificationCompany
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyUrl { get; set; }

        public virtual ICollection<CertificationCourse> CertificationCourses { get; set; }
    }
}
