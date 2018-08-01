using System;
using System.Collections.Generic;
using System.Text;

namespace OneExpFitness.ViewModels.Account
{
    public class UserProfileViewModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //make sure old password exists in current user profile table
        public string Password { get; set; }
    }
}
