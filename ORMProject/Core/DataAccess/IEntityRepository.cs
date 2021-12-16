using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, new()
    {
        // Select metoduna expression ekleyeceğim
        List<T> Select();
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);

    }
}
