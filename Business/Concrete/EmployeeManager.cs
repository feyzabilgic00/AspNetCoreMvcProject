using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public void Add(Employee employee)
        {
            _employeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public Employee GetById(int employeeId)
        {
            return _employeeDal.Get(e=>e.EmployeeId==employeeId);
        }

        public List<EmployeeDetailsDto> GetDepartments()
        {
            return _employeeDal.GetDepartments();
        }

        public List<EmployeeDetailsDto> GetEmployeeDetails()
        {
            return _employeeDal.GetEmployeeDetails();
        }

        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);
        }
    }
}
