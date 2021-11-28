using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunYönetimSistemiAbstraction.Entities {
    class Campaign {
        public Game Game { get; set; }

        public byte DurationOfWeeks { get; set; }

        public int Discount { get; set; }

    }
}
