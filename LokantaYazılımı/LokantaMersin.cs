using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LokantaYazılımı {
    class LokantaMersin: Lokanta {
        public LokantaMersin()
        {
            base._harc = 3500;
        }

        public override void BelediyeHarcOde()
        {
            Console.WriteLine($"Mersin Harç Ödemesi: {this._harc} tldir.");
        }
    }
}
