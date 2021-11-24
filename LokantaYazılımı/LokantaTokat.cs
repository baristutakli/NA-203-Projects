using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LokantaYazılımı {
    class LokantaTokat : Lokanta{
        public LokantaTokat()
        {
            base._harc = 2000;
        }

        public override void BelediyeHarcOde()
        {
            Console.WriteLine($"Tokat Harç Ödemesi: {this._harc} tldir.");
        }
    }
}
