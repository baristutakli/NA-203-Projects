using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcikArtirmaUygulamasi {
    class Teklif {

        static int count = 0;
        private int Id;

        int _fiyat;
        Kullanici _kullanici;
        Urun _urun;



        public int Fiyat
        {
            get => _fiyat; set
            {
                if (value != 0)
                {
                    _fiyat = value;
                }
            }
        }
        public Kullanici Kullanici { get => _kullanici; }
        public Urun urun { get => _urun; }

        public Teklif(Kullanici kullanici, Urun urun, int fiyat)
        {
            _kullanici = kullanici;
            _urun = urun;
            Fiyat = fiyat;
        }


    }
}
