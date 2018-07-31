using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OneExpFitness.Repository.Models
{
    public class GroupActivity
    {
        [Key]
        public int GroupActivityId { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public string MuscleGroup { get; set; }
        public DateTime WorkoutTime { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public virtual Group Group { get; set; }
    }
}
