using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        List<Department> GetAll();
        List<EmployeeDetailsDto> GetDepartmentsDetails(int id);
        Department GetById(int departmentId);
        void Add(Department department);
        void Update(Department department);
        void Delete(Department department);
    }
}
