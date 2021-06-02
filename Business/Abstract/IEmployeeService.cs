using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        List<EmployeeDetailsDto> GetEmployeeDetails();
        List<EmployeeDetailsDto> GetDepartments();
        Employee GetById(int employeeId);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
    }
}
