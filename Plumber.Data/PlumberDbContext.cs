using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Plumber.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumber.Data
{
    public class PlumberDbContext:IdentityDbContext<AdminUser>
    {
        public PlumberDbContext(DbContextOptions opt):base(opt)
        {
            
        }
        public DbSet<Technician> Technicians  { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
