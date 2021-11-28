using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunYönetimSistemiAbstraction.Entities {
    class MemberShip {
        public MemberShip(string level)
        {
            Level = level;
        }

        public string Level { get; set; }
    }
}
