using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin GetAdmin(Admin admin)
        {
            return _adminDal.GetAdmin(a=>a.User==admin.User && a.Password==admin.Password);
        }

        public Admin GetById(int id)
        {
            return _adminDal.Get(I=>I.AdminId==id);
        }
    }
}
