using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IDepartmentDal : IEntityRepository<Department>
    {
        List<EmployeeDetailsDto> GetEmployeeDetails(Expression<Func<Department,bool>> filter=null);
    }
}
