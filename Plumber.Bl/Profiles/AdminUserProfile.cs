using AutoMapper;
using Plumber.Bl.Dtos;
using Plumber.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumber.Bl.Profiles
{
    public class AdminUserProfile:Profile
    {
        public AdminUserProfile()
        {
            CreateMap<CreateAdminUserDto, AdminUser>();
        }
    }
}
