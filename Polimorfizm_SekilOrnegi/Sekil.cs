using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_SekilOrnegi {
    class Sekil {
        protected string Ad;

        public Sekil()
        {
            this.Ad = "";
        }
        virtual public void AlanHesapla()
        {
            Console.WriteLine($"Şekil: {this.Ad}");
        } 

        virtual public void CevreHesapla()
        {
            Console.WriteLine($"Şekil: {this.Ad}");
        }
    }
}
