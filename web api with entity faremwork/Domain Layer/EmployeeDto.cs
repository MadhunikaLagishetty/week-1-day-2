﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Salary { get; set; }
        public int DepartmentId { get; set; }
    }
}
