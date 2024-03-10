using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalalOnTheGo.Shared
{
    public class User //User model to be used for login authentication.
    {
        public int Id { get; set; }
        public string Email{ get; set; } //User UNIVERSITY EMAIL for authentication - in form
        public string Password{ get; set; }//To be used in form 
    }
}
