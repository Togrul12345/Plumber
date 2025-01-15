using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumber.Bl.Services.Abstraction
{
    public interface IIdentityService
    {
        bool IsIncludeUserName(string userName);
       bool IsIncludeEmail(string email);
    }
}
