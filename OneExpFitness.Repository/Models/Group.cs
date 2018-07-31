using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneExpFitness.Repository.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        [ForeignKey("Gym")]
        public int GymId { get; set; }
        [ForeignKey("AspNetUser")]
        public int UserId { get; set; }
        public string GroupTitle { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<GroupActivity> GroupActivities { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
