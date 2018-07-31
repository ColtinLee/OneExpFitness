using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OneExpFitness.Repository.Models
{
    public class Friend
    {
        [Key]
        public int FriendId { get; set; }
        //grabs the user's id from the AspNetUsers table
        [ForeignKey("AspNetUsers")]
        public string UserId { get; set; }        
        public string FriendUserId { get; set; }
    }
}
