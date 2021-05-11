using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebGameNetCore.Models
{
    public class ApDbContext : DbContext
    {
        public DbSet<Unit> Units { get; set; }

        public ApDbContext(DbContextOptions<ApDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
