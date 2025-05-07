using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SUNRISECMS.Shared.ViewModels;

namespace SUNRISECMS.Infrastructure.Data
{
    public class SunriseCMSDbContext : DbContext
    {
        public SunriseCMSDbContext(DbContextOptions<SunriseCMSDbContext> options)
            : base(options)
        {
        }

        public DbSet<VMClients> Clients { get; set; }
    }
}
