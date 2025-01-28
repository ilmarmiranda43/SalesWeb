using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SystemSallesWeb.Models;

namespace SystemSallesWeb.Data
{
    public class SystemSallesWebContext : DbContext
    {
        public SystemSallesWebContext (DbContextOptions<SystemSallesWebContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
