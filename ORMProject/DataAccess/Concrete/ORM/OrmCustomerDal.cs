using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using System;
namespace DataAccess.Concrete.ORM
{
    public class OrmCustomerDal: EfEntityRepositoryBase<Customer, OrmCustomerDal>
    {
    }
}

