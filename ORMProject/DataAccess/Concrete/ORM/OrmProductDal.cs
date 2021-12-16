using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using System;
namespace DataAccess.Concrete.ORM
{
    public class OrmProductDal: EfEntityRepositoryBase<Product, OrmProductDal>
    {
    }
}

