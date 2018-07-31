using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OneExpFitness.Repository.Models
{
    public class Trainer
    {
        [Key]
        public int TrainerId { get; set; }
        [ForeignKey("AspNetUsers")]
        public string UserId { get; set; }
        public bool IsFreelance { get; set; }
        [ForeignKey("Certification")]
        public int? CertificationId { get; set; }

        public virtual Certification Certification { get; set; }

        public virtual ICollection<GymTrainer> GymTrainers { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}
