using OyunYönetimSistemiAbstraction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunYönetimSistemiAbstraction.Business {
    interface IUserService<T>:IService<T> where T: User {
    }
}
