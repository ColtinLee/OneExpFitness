using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OneExpFitness.Repository.Models
{
    public class GymTrainer
    {
        [Key]
        public int GymTrainerId { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        [ForeignKey("Gym")]
        public int GymId { get; set; }
    }
}
