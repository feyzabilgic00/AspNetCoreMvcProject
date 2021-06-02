using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal:IEntityRepository<Employee>
    {
        List<EmployeeDetailsDto> GetEmployeeDetails(Expression<Func<Employee,bool>> filter=null);
        List<EmployeeDetailsDto> GetDepartments(Expression<Func<Department, bool>> filter = null);
    }
}
