using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Employee.Application.Queries;
using Employee.Domain.Repositories;
using MediatR;


namespace Employee.Application.Handlers
{
    class GetAllEmployeeHandler : IRequestHandler<GetAllEmployeeQuery, List<Employee.Domain.Entities.Employee>>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetAllEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Domain.Entities.Employee>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return (List<Domain.Entities.Employee>)await _employeeRepository.GetAllAsync();
        }
    }
}
