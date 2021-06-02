using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAdminDal : EfEntityRepositoryBase<Admin, ProjectContext>, IAdminDal
    {
        public Admin GetAdmin(Expression<Func<Admin, bool>> filter)
        {
            using (ProjectContext context=new ProjectContext())
            {
                return context.Admins.SingleOrDefault(filter);
            } 
        }
    }
}
