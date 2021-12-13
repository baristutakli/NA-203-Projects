using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    
    public interface IORM<T>where T:class,new() // referanslanabilir bir nesne olmalı ve new lenebilir olmalı 
    {
        List<T> Select();
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);

        /**
         *Categories category = new Categories();
         *insert(c);
         */

    }
}
