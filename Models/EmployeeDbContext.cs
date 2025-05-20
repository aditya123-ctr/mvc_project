using Microsoft.EntityFrameworkCore;

namespace TechNovaSolutions.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<DepartmentEmployee> Employees { get; set; }
    }
}
