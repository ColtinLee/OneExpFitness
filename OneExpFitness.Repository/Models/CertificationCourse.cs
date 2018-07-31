using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OneExpFitness.Repository.Models
{
    public class CertificationCourse
    {
        [Key]
        public int CertificationCourseId { get; set; }
        public decimal CertificationCost { get; set; }
        public short CourseLength { get; set; }
        public string CertificationLink { get; set; }
        [ForeignKey("CertificationCompany")]
        public int CompanyId { get; set; }

        public virtual CertificationCompany CertificationCompany { get; set; }
    }
}
