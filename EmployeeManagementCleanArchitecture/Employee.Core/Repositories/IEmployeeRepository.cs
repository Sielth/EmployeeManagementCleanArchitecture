using System.Collections.Generic;
using System.Threading.Tasks;
using Employee.Domain.Repositories.Base;

namespace Employee.Domain.Repositories
{
    public interface IEmployeeRepository : IRepository<Entities.Employee>
    {
        Task<IEnumerable<Entities.Employee>> GetEmployeeByLastName(string lastname);
    }
}
