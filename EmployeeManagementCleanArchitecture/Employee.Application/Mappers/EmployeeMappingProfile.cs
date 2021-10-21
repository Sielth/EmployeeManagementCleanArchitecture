using AutoMapper;
using Employee.Application.Commands;
using Employee.Application.Responses;

namespace Employee.Application.Mappers
{
    class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee.Domain.Entities.Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Employee.Domain.Entities.Employee, CreateEmployeeCommand>().ReverseMap();
        }
    }
}
