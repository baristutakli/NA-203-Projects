using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımProjesi {
    class Kullanici {
        static int KullaniciSayisi = 0;
        int _id;
        string _adSoyad;
        string _tel;

        public Kullanici(string adSoyad, string tel)
        {
            KullaniciSayisi += 1;
            _id = KullaniciSayisi;
            AdSoyad = adSoyad;
            Tel = tel;
        }

        public string AdSoyad
        {
            get => _adSoyad; set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _adSoyad = value;
                }
            }
        }
        public string Tel { get => _tel; set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _tel = value;
                }
            }}
    }
}
