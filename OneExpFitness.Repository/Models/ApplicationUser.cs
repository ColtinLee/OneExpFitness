using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace OneExpFitness.Repository.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public DateTime JoinDate { get; set; }

        public virtual ICollection<Friend> Friends { get; set; }
        //use prop tab tab for properties
    }
}
