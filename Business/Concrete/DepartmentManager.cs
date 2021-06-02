using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;
        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }
        public void Add(Department department)
        {
            _departmentDal.Add(department);
        }

        public void Delete(Department department)
        {
            _departmentDal.Delete(department);
        }

        public List<Department> GetAll()
        {
            return _departmentDal.GetAll();
        }

        public Department GetById(int departmentId)
        {
            return _departmentDal.Get(d=>d.DepartmentId==departmentId);
        }

        public List<EmployeeDetailsDto> GetDepartmentsDetails(int id)
        {
            return _departmentDal.GetEmployeeDetails(I=>I.DepartmentId==id);
        }

        public void Update(Department department)
        {
            _departmentDal.Update(department);
        }
    }
}
