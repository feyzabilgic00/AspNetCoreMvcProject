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
    public class EfDepartmentDal : EfEntityRepositoryBase<Department, ProjectContext>, IDepartmentDal
    {
        public List<EmployeeDetailsDto> GetEmployeeDetails(Expression<Func<Department, bool>> filter = null)
        {
            using (ProjectContext context=new ProjectContext())
            {
                var result = from d in filter == null ? context.Departments.ToList() : context.Departments.Where(filter).ToList()
                             join e in context.Employees
                             on d.DepartmentId equals e.DepartmentId
                             select new EmployeeDetailsDto
                             {
                                 EmployeeId = e.EmployeeId,
                                 DepartmentId = d.DepartmentId,
                                 EmployeeNameSurname = e.EmployeeName + " " + e.EmployeeSurname,
                                 City = e.City,
                                 Department = d.DepartmentName
                             };
                return result.ToList();
            }
        }
    }
}
