using Microsoft.AspNetCore.Identity;
using Plumber.Bl.Services.Abstraction;
using Plumber.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumber.Bl.Services.Implementation
{
    public  class IdentityService : IIdentityService
    {
        private readonly UserManager<AdminUser> _userManager;

        public IdentityService(UserManager<AdminUser> userManager)
        {
            _userManager = userManager;
        }

        public  bool IsIncludeUserName(string userName)
        {
            if (_userManager.Users.Where(a => a.UserName == userName) != null)
            {
                return false;
            };
            return true;
        }

        public  bool IsIncludeEmail(string email)
        {
            if (_userManager.Users.Where(a => a.Email == email) != null)
            {
                return false;
            }
            return true;
        }

       
    }
}
