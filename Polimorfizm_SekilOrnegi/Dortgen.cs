using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_SekilOrnegi {
    class Dortgen:Sekil {
        // en boy
        int _en;
        int _boy;

        public Dortgen(int en, int boy)
        {
            base.Ad = "Dortgen";
            En = en;
            Boy = boy;
        }

        public int En { get => _en; set => _en = value; }
        public int Boy { get => _boy; set => _boy = value; }
        public override void AlanHesapla()
        {
            Console.WriteLine($"Şekil: {this.Ad} Alan: {this.En * this.Boy}");

        }


        public override void CevreHesapla()
        {
            Console.WriteLine($"Şekil: {this.Ad} ve Çevresi :{2*(this.En+this.Boy)}");

        }
    }
}
