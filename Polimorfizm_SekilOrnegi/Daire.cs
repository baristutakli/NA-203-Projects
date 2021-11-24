using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_SekilOrnegi {
    class Daire:Sekil {
        int _r;

        public Daire(int r)
        {
            base.Ad = "Daire";
            R = r;
        }

        public int R { get => _r; set => _r = value; }

        public override void AlanHesapla()
        {
            Console.WriteLine($"Şekil: {this.Ad} Alan: {Convert.ToInt32(this.R*this.R*Math.PI)}");

        }


        public override void CevreHesapla()
        {
            Console.WriteLine($"Şekil: {this.Ad} ve Çevresi :{Convert.ToInt32(2 * (this.R * Math.PI))}");

        }
    }
}
