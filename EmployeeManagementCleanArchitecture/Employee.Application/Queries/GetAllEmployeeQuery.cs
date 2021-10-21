using System.Collections.Generic;
using MediatR;

namespace Employee.Application.Queries
{
    public class GetAllEmployeeQuery : IRequest<List<Employee.Domain.Entities.Employee>>
    {
    }
}
