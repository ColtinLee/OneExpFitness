using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OneExpFitness.Repository.Models
{
    public class Gym
    {
        [Key]
        public int GymId { get; set; }
        public string GymName { get; set; }
        public decimal GymPrice { get; set; }
        public string GymAddress1 { get; set; }
        public string GymAddress2 { get; set; }
        public string GymUrl { get; set; }

        public virtual ICollection<GymTrainer> GymTrainers { get; set; }
    }
}
