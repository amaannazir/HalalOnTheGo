using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalalOnTheGo.Shared
{
    public class User //User model to be used for login authentication.
    {
        
        public string StudentEmail{ get; set; } //User UNIVERSITY EMAIL for authentication - in form
        public string Password{ get; set; }//To be used in form 
        public string FirstName { get; set; }//To be used in SIGN UP form 
        public string LastName { get; set; } //To be used in SIGN UP form 
        public string University { get; set; } //To be used in SIGN UP form 
        public string ConfirmPassword { get; set; } //Validating password

    }
}
