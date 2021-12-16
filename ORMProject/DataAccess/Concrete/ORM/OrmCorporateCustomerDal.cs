using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using System;
namespace DataAccess.Concrete.ORM
{
    public class CorporateCustomerOrm : EfEntityRepositoryBase<Customer, OrmCustomerDal>
    {
    }
}

