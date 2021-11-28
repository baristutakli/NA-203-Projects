using Dependency_Injection_Uygulama.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Uygulama.Entities {
    class Otobus : ITasit {
        public void FrenYap()
        {
            Console.WriteLine( "Otubus fren yaptı");
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
