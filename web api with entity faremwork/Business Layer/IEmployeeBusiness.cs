﻿using Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public interface IEmployeeBusiness
    {
        public Task<List<EmployeeDto>> GetEmployees();
        public Task<EmployeeDto> GetEmployee(int id);
        public Task InsertEmployee(EmployeeDto employee);
        public Task UpdateEmployee(EmployeeDto employee);
        public Task DeleteEmployee(int id);
    }
}
