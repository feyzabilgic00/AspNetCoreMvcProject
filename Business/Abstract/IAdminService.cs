using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAdminService
    {
        Admin GetAdmin(Admin admin);
        Admin GetById(int id);
    }
}
