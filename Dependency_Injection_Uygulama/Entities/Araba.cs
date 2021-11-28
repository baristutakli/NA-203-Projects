using Dependency_Injection_Uygulama.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Uygulama.Entities {
    class Araba : ITasit {
        public void FrenYap()
        {
            Console.WriteLine("Araba fren yaptı");
        }

        public void GazVer()
        {
            //
        }

        public void SagaSinyal()
        {
            //
        }

        public void SolaSinyal()
        {
            //
        }
    }
}
