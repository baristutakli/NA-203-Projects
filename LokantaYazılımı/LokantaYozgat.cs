using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LokantaYazılımı {
    class LokantaYozgat : Lokanta {

        public LokantaYozgat()
        {
            base._harc = 1500;
        }

        public override void BelediyeHarcOde()
        {
            Console.WriteLine($"Yozgat Harç Ödemesi: {this._harc} tldir.");
        }
    }
}
