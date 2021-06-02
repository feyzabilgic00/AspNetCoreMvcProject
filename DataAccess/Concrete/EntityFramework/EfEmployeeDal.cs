using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, ProjectContext>, IEmployeeDal
    {
        public List<EmployeeDetailsDto> GetDepartments(Expression<Func<Department, bool>> filter = null)
        {
            using (ProjectContext context = new ProjectContext())
            {
                var result = from e in filter == null ? context.Departments : context.Departments.Where(filter)
                             join d in context.Departments
                             on e.DepartmentId equals d.DepartmentId
                             select new EmployeeDetailsDto
                             {
                                 Department = d.DepartmentName,
                                 DepartmentId=d.DepartmentId
                             };
                return result.ToList();
            }
        }

        public List<EmployeeDetailsDto> GetEmployeeDetails(Expression<Func<Employee, bool>> filter = null)
        {
            using (ProjectContext context = new ProjectContext())
            {
                var result = from e in filter == null ? context.Employees : context.Employees.Where(filter)
                             join d in context.Departments
                             on e.DepartmentId equals d.DepartmentId
                             select new EmployeeDetailsDto
                             {
                                 EmployeeId = e.EmployeeId,
                                 EmployeeNameSurname=e.EmployeeName+" "+e.EmployeeSurname,
                                 City=e.City,
                                 Department=d.DepartmentName
                             };
                return result.ToList();
            }
        }
    }
}
