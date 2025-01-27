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

        public DbSet<SystemSallesWeb.Models.Department> Department { get; set; } = default!;
    }
}
