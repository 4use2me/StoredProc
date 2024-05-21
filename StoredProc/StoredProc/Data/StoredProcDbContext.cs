using Microsoft.EntityFrameworkCore;
using StoredProc;


namespace StoredProc.Data
{
    public class StoredProcDbContext : DbContext
    
        public StoredProcDbContex(DbContextOptions<StoredProcDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employees { get; set;  }
    }
}
