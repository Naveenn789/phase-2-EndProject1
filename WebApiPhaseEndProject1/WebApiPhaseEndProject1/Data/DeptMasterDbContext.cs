using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiPhaseEndProject1.Model;

namespace WebApiPhaseEndProject1.Data
{
    public class DeptMasterDbContext : DbContext
    {
        public DeptMasterDbContext (DbContextOptions<DeptMasterDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiPhaseEndProject1.Model.DeptMaster> DeptMaster { get; set; } = default!;
    }
}
