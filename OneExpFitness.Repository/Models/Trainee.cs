using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OneExpFitness.Repository.Models
{
    public class Trainee
    {
        [Key]
        public int TraineeId { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        [ForeignKey("AspNetUser")]
        public string UserId { get; set; }

        public virtual Trainer Trainer { get; set;}
    }
}
