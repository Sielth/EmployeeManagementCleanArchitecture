using Microsoft.EntityFrameworkCore;

namespace Employee.Persistence.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
        public DbSet<Domain.Entities.Employee> Employees { get; set; }
    }
}
