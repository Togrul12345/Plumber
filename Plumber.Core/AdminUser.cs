using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumber.Core
{
    public class AdminUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
   
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
   
}
