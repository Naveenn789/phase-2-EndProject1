using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiPhaseEndProject1.Model;

namespace WebApiPhaseEndProject1.Data
{
    public class EmpProfileDbContext : DbContext
    {
        public EmpProfileDbContext (DbContextOptions<EmpProfileDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiPhaseEndProject1.Model.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
