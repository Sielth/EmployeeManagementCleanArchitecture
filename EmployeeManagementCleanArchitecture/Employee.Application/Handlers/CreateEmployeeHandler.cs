﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Employee.Application.Commands;
using Employee.Application.Mappers;
using Employee.Application.Responses;
using Employee.Domain.Repositories;
using MediatR;

namespace Employee.Application.Handlers
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, EmployeeResponse>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeEntity = EmployeeMapper.Mapper.Map<Domain.Entities.Employee>(request);

            if (employeeEntity is null) throw new ApplicationException("Issue with mapper");

            var newEmployee = await _employeeRepository.AddAsync(employeeEntity);

            var employeeResponse = EmployeeMapper.Mapper.Map<EmployeeResponse>(newEmployee);

            return employeeResponse;
        }
    }
}
