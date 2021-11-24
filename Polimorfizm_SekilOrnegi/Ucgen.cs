using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_SekilOrnegi {
    class Ucgen : Sekil {
        int _yükseklik;
        int _taban;
        int _kenar2;
        int _kenar3;

        public Ucgen(int yükseklik, int taban, int kenar2, int kenar3)
        {
            base.Ad = "Uçgen";
            Yükseklik = yükseklik;
            Taban = taban;
            Kenar2 = kenar2;
            Kenar3 = kenar3;
        }

        public int Yükseklik { get => _yükseklik; set => _yükseklik = value; }
        public int Taban { get => _taban; set => _taban = value; }
        public int Kenar2 { get => _kenar2; set => _kenar2 = value; }
        public int Kenar3 { get => _kenar3; set => _kenar3 = value; }

         public override void AlanHesapla()
        {
            Console.WriteLine($"Şekil: {this.Ad} Alan: {(this.Taban*this.Yükseklik)/2}");

        }


        public override void CevreHesapla()
        {
            Console.WriteLine($"Şekil: {this.Ad} ve Çevresi :{this.Taban+ this.Kenar2+this.Kenar3}");

        }


    }
}
