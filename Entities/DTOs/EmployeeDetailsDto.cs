using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class EmployeeDetailsDto:IDto
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public string EmployeeNameSurname { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
    }
}
