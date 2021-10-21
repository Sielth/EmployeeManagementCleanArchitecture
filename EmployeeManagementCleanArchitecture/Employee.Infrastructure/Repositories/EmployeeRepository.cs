using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee.Domain.Repositories;
using Employee.Persistence.Data;
using Employee.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Employee.Persistence.Repositories
{
    public class EmployeeRepository : Repository<Domain.Entities.Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeContext employeeContext) : base(employeeContext) { }

        public async Task<IEnumerable<Domain.Entities.Employee>> GetEmployeeByLastName(string lastname)
        {
            return await _employeeContext.Employees.Where(m => m.LastName == lastname).ToListAsync();
        }
    }
}
