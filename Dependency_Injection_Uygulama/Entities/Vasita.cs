using Dependency_Injection_Uygulama.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Uygulama.Entities {
    class Vasita {
        ITasit _tasit;

        public Vasita(ITasit tasit)
        {
            _tasit = tasit;
        }
        public void Kullan()
        {
            _tasit.GazVer();
            _tasit.SagaSinyal();
            _tasit.FrenYap();
            _tasit.SolaSinyal();
        }
    }
}
