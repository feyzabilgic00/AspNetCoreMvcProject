using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAdminDal:IEntityRepository<Admin>
    {
        Admin GetAdmin(Expression<Func<Admin,bool>> filter);
    }
}
