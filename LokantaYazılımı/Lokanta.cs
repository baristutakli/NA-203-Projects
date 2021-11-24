using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LokantaYazılımı {
    class Lokanta {

        protected short _harc;
        public Lokanta()
        {
            this._harc = 3000;
        }
        virtual public void BelediyeHarcOde()
        {
            Console.WriteLine($"Genel Harç Ödemesi: {this._harc} tldir.");
        }
    }


}
