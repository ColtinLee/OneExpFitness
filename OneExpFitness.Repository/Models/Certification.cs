using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OneExpFitness.Repository.Models
{
    public class Certification
    {        
        [Key]
        public int CertificateId { get; set; }
        public string CertificateIssuer { get; set; }
        [ForeignKey("AspNetUsers")]
        public string UserId { get; set; }
        [ForeignKey("CertificationCourse")]
        public int CertificationCourseId { get; set; }

        public virtual CertificationCourse CertificationCourse { get; set; }
    }
}
