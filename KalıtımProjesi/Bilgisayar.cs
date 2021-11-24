using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımProjesi {
    class Bilgisayar : Ilan {
        string _marka;
        string _islemci;
        byte _bellek;
        bool _HDD;
        bool _SSD;
        bool _ethernetVarMi;
        bool _wifiVarMi;
        int _HDDKapasitesi;
        int _SSDKapasitesi;

        public Bilgisayar(Kullanici kullanici, int fiyat, string marka, string ıslemci,
            byte bellek, bool hDD, bool sSD, bool ethernetVarMi, bool wifiVarMi) : base(kullanici, fiyat)
        {
            Marka = marka;
            Islemci = ıslemci;
            Bellek = bellek;
            HDD = hDD;
            SSD = sSD;
            EthernetVarMi = ethernetVarMi;
            WifiVarMi = wifiVarMi;
        }

        public string Marka { get => _marka; set => _marka = value; }
        public string Islemci { get => _islemci; set => _islemci = value; }
        public byte Bellek { get => _bellek; set => _bellek = value; }
        public bool HDD { get => _HDD; set => _HDD = value; }
        public bool SSD { get => _SSD; set => _SSD = value; }
        public bool EthernetVarMi { get => _ethernetVarMi; set => _ethernetVarMi = value; }
        public bool WifiVarMi { get => _wifiVarMi; set => _wifiVarMi = value; }
        public int HDDKapasitesi
        {
            get => _HDDKapasitesi; set
            {
                if (HDD == true)
                {
                    _HDDKapasitesi = value;
                }
            }
        }
        public int SSDKapasitesi
        {
            get => _SSDKapasitesi; set
            {
                if (SSD == true)
                {
                    _SSDKapasitesi = value;
                }
            }
        }

    }
}
