using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunYönetimSistemiAbstraction.Business {
    interface IService<T> {
        void Create();
        void Update();
        void Delete();

        void Find();
    
    }
}
