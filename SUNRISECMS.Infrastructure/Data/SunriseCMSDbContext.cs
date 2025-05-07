using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SUNRISECMS.Shared.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SUNRISECMS.Infrastructure.Data
{
    public class SunriseCMSDbContext : IdentityDbContext
    {
        public SunriseCMSDbContext(DbContextOptions<SunriseCMSDbContext> options)
            : base(options)
        {
        }

        public DbSet<VMClients> Clients { get; set; }
    }
}
